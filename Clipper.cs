using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Screens
{
    public class Clipper
    {
        private static Point _startPoint;
        private static bool _selectingArea;

        public static void Clip(Processor processor)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            var screenForm = new Form
            {
                WindowState = FormWindowState.Maximized,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.01,
                Cursor = Cursors.Cross,
                ShowInTaskbar = false,
                TopMost = true
            };
            PictureBox screenImage;
            screenForm.Controls.Add(screenImage = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = GetScreenshot()
            });
            screenForm.Show();
            screenForm.Focus();
            new Thread(() =>
            {
                Thread.Sleep(50);
                screenForm.Opacity = 1.0;
            }).Start();

            var clipForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.Black,
                Opacity = 0.25,
                ShowInTaskbar = false,
                TopMost = true
            };

            Label sizeLabel;
            clipForm.Controls.Add(sizeLabel = new Label
            {
                AutoSize = false,
                Size = new Size(90, 13),
                Left = clipForm.Width - 75,
                Top = clipForm.Height - 55,
                Anchor = (AnchorStyles.Bottom | AnchorStyles.Right),
                ForeColor = Color.White
            });

            screenImage.MouseDown += (s, e) =>
            {
                var cursorColor = GetColor(screenImage, e.Location);
                clipForm.BackColor = cursorColor.ToArgb() > Color.Black.ToArgb() / 2 ? Color.Black : Color.White;
                sizeLabel.ForeColor = cursorColor.ToArgb() > Color.Black.ToArgb() / 2 ? Color.White : Color.Black;
            };

            screenImage.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    _selectingArea = true;
                    _startPoint = screenImage.PointToScreen(e.Location);
                    clipForm.Location = _startPoint;
                    clipForm.Size = new Size(1, 1);
                    clipForm.Show();
                }
            };

            screenImage.MouseMove += (s, e) =>
            {
                if (_selectingArea)
                {
                    var newPoint = screenImage.PointToScreen(e.Location);
                    var point = new Point(Math.Min(newPoint.X, _startPoint.X), Math.Min(newPoint.Y, _startPoint.Y));
                    var size = new Size(Math.Max(newPoint.X, _startPoint.X) - point.X, Math.Max(newPoint.Y, _startPoint.Y) - point.Y);
                    if (clipForm.Location != point) clipForm.Location = point;
                    clipForm.Size = size;
                    sizeLabel.Text = size.Width + " x " + size.Height;
                }
            };

            screenImage.MouseUp += (s, e) =>
            {
                _selectingArea = false;
                clipForm.Close();
                screenForm.Close();
                var bitmap = GetClip(screenImage.Image, new Rectangle(clipForm.Location, clipForm.Size));
                if (bitmap.Size.Width < 15 || bitmap.Size.Height < 15) Terminate(); //too small to see
                processor.Process(bitmap);
            };

            clipForm.KeyDown += (s, e) => Escape(e);
            screenForm.KeyDown += (s, e) => Escape(e);
            screenImage.KeyDown += (s, e) => Escape(e);
        }

        private static void Escape(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Terminate();
        }

        public static Color GetColor(Control ctl, Point location)
        {
            using (Bitmap bmp = new Bitmap(1, 1))
            {
                Graphics g = Graphics.FromImage(bmp);
                Point screenP = ctl.PointToScreen(location);
                g.CopyFromScreen(screenP.X, screenP.Y, 0, 0, new Size(1, 1));
                return bmp.GetPixel(0, 0);
            }
        }

        private static Bitmap GetScreenshot()
        {
            var rect = Screen.GetBounds(Point.Empty);
            var bitmap = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppRgb);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(Point.Empty, Point.Empty, bitmap.Size);
            }
            return bitmap;
        }

        private static Bitmap GetClip(Image image, Rectangle rect)
        {
            var bitmap = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppRgb);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(image, new Rectangle(Point.Empty, rect.Size), rect, GraphicsUnit.Pixel);
            }
            return bitmap;
        }

        public static void TakeSnapshot()
        {
            var psi = new System.Diagnostics.ProcessStartInfo(Application.ExecutablePath)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false
            };
            var p = System.Diagnostics.Process.Start(psi);
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            var resultsBuilder = new StringBuilder();
            while (!p.HasExited) resultsBuilder.Append(p.StandardOutput.ReadToEnd());
            Tray.ProcessReponse(resultsBuilder.ToString());
        }

        public static byte[] GetPng(Bitmap bitmap)
        {
            byte[] image;
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Png);
                image = stream.ToArray();
            }
            return image;
        }

        public static void Terminate()
        {
            Environment.Exit(0);
        }
    }
}
