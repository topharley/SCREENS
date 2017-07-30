using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Screens.Instruments;
using Screens.Uploaders;

namespace Screens
{
    public class Processor
    {
        public static readonly string SCREENS_FAILED = "SCREENS_FAILED";

        private Uploader _uploader;

        public Processor()
        {
            _uploader = UploaderFactory.Create(Settings.Current.UploaderType);
            Settings.Current.Apply();
        }

        public void Process(Bitmap bitmap)
        {
            SaveLastScreenshot(bitmap);

            bitmap = EditScreenshot(bitmap);

            if (!String.IsNullOrEmpty(Settings.Current.WaterMark))
                bitmap = (Bitmap)TextInstrument.DrawWaterMark(bitmap);

            string url = UploadScreenshot(bitmap);

            if (Settings.Current.ShortenUrl) url = ShortenUrl(url);

            var success = url != null && url.StartsWith("http");

            if (success)
            {
                SetClipboard(url);

                OpenBrowser(url);

                LogScreenshotUrl(url);
            }

            SetSuccessToEnvironment(success, url);

            if (!success)
                MessageBox.Show("Failed to upload, try again later.");

            Clipper.Terminate();
        }

        private void SetSuccessToEnvironment(bool success, string url)
        {
            Console.Write(success ? url : SCREENS_FAILED);
        }

        private static void OpenBrowser(string url)
        {
            if (Settings.Current.OpenInBrowser)
                System.Diagnostics.Process.Start(url);
        }

        private static void SetClipboard(string url)
        {
            if (Settings.Current.CopyInClipboard)
            {
                try
                {
                    Clipboard.SetText(url);
                }
                catch
                {
                    Nop();
                }
            }
        }

        private static void Nop()
        {
        }

        private string ShortenUrl(string url)
        {
            try
            {
                return Shortener.Shorten(url);
            }
            catch
            {
                return url;
            }
        }

        private static Bitmap EditScreenshot(Bitmap bitmap)
        {
            EditorForm editorForm = new EditorForm(bitmap);
            if (editorForm.ShowDialog() != DialogResult.OK) Clipper.Terminate();
            return editorForm.Bitmap;
        }

        private static void SaveLastScreenshot(Bitmap bitmap)
        {
            if (Settings.Current.SaveLastScreenshot && Settings.Current.SaveLastScreenshotFile != null)
            {
                try
                {
                    File.WriteAllBytes(Settings.Current.SaveLastScreenshotFile, Clipper.GetPng(bitmap));
                }
                catch
                {
                    Nop();
                }
            }
        }

        private static void LogScreenshotUrl(string url)
        {
            if (Settings.Current.SaveLog && Settings.Current.SaveLogFile != null)
            {
                try
                {
                    File.AppendAllText(Settings.Current.SaveLogFile, DateTime.Now + ": " + url + Environment.NewLine);
                }
                catch
                {
                    Nop();
                }
            }
        }

        private string UploadScreenshot(Bitmap bitmap)
        {
            try
            {
                return _uploader.Upload(bitmap);
            }
            catch
            {
                return null;
            }
        }
    }
}
