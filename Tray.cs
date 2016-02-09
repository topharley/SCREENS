using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Screens
{
    class Tray
    {
        private static Form _trayForm;
        private static NotifyIcon _icon;
        private static ContextMenu _contextMenu;
        private static string _lastUrl;
        private static MenuItem _lastUrlMenuItem;

        public static IntPtr TrayHandle
        {
            get
            {
                if (_trayForm == null) throw new InvalidOperationException();
                return _trayForm.Handle;
            }
        }

        public static void Run()
        {
            _trayForm = new Form();

            InitContextMenu();

            InitTrayIcon();

            Settings.Current.Apply();
        }

        private static void InitTrayIcon()
        {
            _icon = new NotifyIcon();
            _icon.Icon = Properties.Resources.icon;
            _icon.Text = "Screens - нажмите PrntScrn";
            _icon.Visible = true;
            _icon.ContextMenu = _contextMenu;
            _icon.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left) 
                    Clipper.TakeSnapshot();
            };
        }

        private static void InitContextMenu()
        {
            _contextMenu = new ContextMenu();
            _contextMenu.MenuItems.Add(new MenuItem("Сделать скриншот", (s, e) => { Clipper.TakeSnapshot(); }));
            _contextMenu.MenuItems.Add(_lastUrlMenuItem = new MenuItem("Открыть последний скриншот", (s, e) => { Process.Start(_lastUrl); }));
            _lastUrlMenuItem.Enabled = false;
            _contextMenu.MenuItems.Add(new MenuItem("Настройки...", (s, e) => { new SettingsDialog().ShowDialog(); }));
            _contextMenu.MenuItems.Add("-");
            _contextMenu.MenuItems.Add(new MenuItem("Выход", (s, e) => { _icon.Visible = false; Clipper.Terminate(); }));
        }

        public static void ProcessReponse(string result)
        {
            if (!String.IsNullOrEmpty(result) && !result.Contains(Processor.SCREENS_FAILED))
            {
                _icon.ShowBalloonTip(1000, "Screens", "Скриншот готов!", ToolTipIcon.Info);
                _lastUrlMenuItem.Enabled = true;
                _lastUrl = result;
            }
        }
    }
}
