using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Screens
{
    //http://stackoverflow.com/questions/1191479/how-do-i-capture-the-print-screen-key
    public class HotkeyBinder
    {
        private bool _bind;
        private IntPtr _windowHandle = IntPtr.Zero;
        private MODKEY _modKey = MODKEY.MOD_CONTROL;
        private Keys _keys = Keys.A;
        private int _WParam = 10000;
        private HotKeyWndProc _hotKeyWnd = new HotKeyWndProc();

        public IntPtr WindowHandle
        {
            get { return _windowHandle; }
            set { if (_bind) return; _windowHandle = value; }
        }

        public MODKEY ModKey
        {
            get { return _modKey; }
            set { if (_bind) return; _modKey = value; }
        }

        public Keys Keys
        {
            get { return _keys; }
            set { if (_bind) return; _keys = value; }
        }

        public int WParam
        {
            get { return _WParam; }
            set { if (_bind) return; _WParam = value; }
        }

        public void Bind()
        {
            if (_windowHandle != IntPtr.Zero)
            {
                if (!RegisterHotKey(_windowHandle, _WParam, _modKey, _keys))
                {
                    MessageBox.Show("Failed to bind hotkey!");
                }
                try
                {
                    _hotKeyWnd.m_HotKeyPass = new HotKeyPass(KeyPass);
                    _hotKeyWnd.m_WParam = _WParam;
                    _hotKeyWnd.AssignHandle(_windowHandle);
                    _bind = true;
                }
                catch
                {
                    Unbind();
                }
            }
        }

        private void KeyPass()
        {
            if (HotKey != null) HotKey();
        }

        public void Unbind()
        {
            if (_bind)
            {
                if (!UnregisterHotKey(_windowHandle, _WParam))
                {
                    throw new Exception("");
                }
                _bind = false;
                _hotKeyWnd.ReleaseHandle();
            }
        }

        public delegate void HotKeyPass();
        public event HotKeyPass HotKey;

        private class HotKeyWndProc : NativeWindow
        {
            public int m_WParam = 10000;
            public HotKeyPass m_HotKeyPass;
            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x0312 && m.WParam.ToInt32() == m_WParam)
                {
                    if (m_HotKeyPass != null) m_HotKeyPass.Invoke();
                }

                base.WndProc(ref m);
            }
        }

        public enum MODKEY
        {
            MOD_ALT = 0x0001,
            MOD_CONTROL = 0x0002,
            MOD_SHIFT = 0x0004,
            MOD_WIN = 0x0008,
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr wnd, int id, MODKEY mode, Keys vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr wnd, int id);
    }
}
