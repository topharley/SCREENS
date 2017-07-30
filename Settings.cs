using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Win32;
using Screens.Uploaders;

namespace Screens
{
    public class Settings
    {
        public UploaderType UploaderType { get; set; }
        public Boolean AutoStart { get; set; }
        public Boolean UseHK { get; set; }
        public Boolean ShortenUrl { get; set; }
        public Boolean OpenInBrowser { get; set; }
        public Boolean CopyInClipboard { get; set; }
        public Boolean SaveLog { get; set; }
        public String SaveLogFile { get; set; }
        public Boolean SaveLastScreenshot { get; set; }
        public String SaveLastScreenshotFile { get; set; }
        public String WaterMark { get; set; }
        public String Proxy { get; set; }
        public Boolean UseProxy { get; set; }

        private static readonly string _settingsFile = Path.Combine(Application.StartupPath, "settings.xml");
        private static readonly XmlSerializer _serializer = new XmlSerializer(typeof(Settings));
        private static HotkeyBinder _hotKeyBinder;

        private static Settings _current;
        public static Settings Current
        {
            get { return _current ?? (_current = Load()); }
        }

        public Settings()
        {
            //defaults
            CopyInClipboard = true;
            OpenInBrowser = true;
        }

        public static void Save()
        {
            try
            {
                using (var writer = XmlWriter.Create(_settingsFile))
                    _serializer.Serialize(writer, _current);
            }
            catch
            {
                MessageBox.Show("Failed to save settings.");
            }
        }

        private static Settings Load()
        {
            try
            {
                using (var stream = new FileStream(_settingsFile, FileMode.Open))
                    return _serializer.Deserialize(stream) as Settings;
            }
            catch
            {
                return new Settings();
            }
        }

        public void Apply()
        {
            EnsureAutoStart();
            BindHotKey();
        }

        private void BindHotKey()
        {
            if (Program.StartMode == StartMode.Tray)
            {
                if (UseHK)
                {
                    if (_hotKeyBinder == null)
                    {
                        _hotKeyBinder = new HotkeyBinder();
                        _hotKeyBinder.Keys = Keys.PrintScreen;
                        _hotKeyBinder.ModKey = 0;
                        _hotKeyBinder.WindowHandle = Tray.TrayHandle;
                        _hotKeyBinder.HotKey += Clipper.TakeSnapshot;
                        _hotKeyBinder.Bind();
                    }
                }
                else
                {
                    if (_hotKeyBinder != null)
                    {
                        _hotKeyBinder.Unbind();
                        _hotKeyBinder = null;
                    }
                }
            }
        }

        private void EnsureAutoStart()
        {
#if DEBUG
            //if (Process.GetProcessesByName("Screens.vshost").Length > 0) 
              //  return;
#endif
            if (Program.StartMode == StartMode.Capture)
            {
                try
                {
                    RegistryKey runKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                    if (AutoStart)
                    {
                        runKey.SetValue("Screens", "\"" + Application.ExecutablePath + "\" /tray");
                        var procs = Process.GetProcessesByName("Screens");
                        if (procs.Length == 1 && !procs[0].StartInfo.Arguments.Contains("/tray"))
                            Process.Start(Application.ExecutablePath, "/tray");
                    }
                    else
                    {
                        runKey.DeleteValue("Screens", false);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            }
        }
    }
}