using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Screens.Instruments
{
    class ArrowInstrument : Instrument
    {
        private Image _arrow;

        public ArrowInstrument()
        {
            Type = InstrumentType.Arrow;
        }

        public override void Init(PictureBox picture, Color color)
        {
            base.Init(picture, color);
            _arrow = GetColoredArrow();
        }

        public override Image Draw(Image image)
        {
            using (Graphics graphics = Graphics.FromImage(image))
            {
                int xDistance = _newPoint.X - _prevPoint.X;
                int yDistance = _newPoint.Y - _prevPoint.Y;
                if (xDistance == 0 || yDistance == 0) return image;
                double diag = Math.Sqrt(yDistance * yDistance + xDistance * xDistance);
                double scale = diag / _arrow.Width;
                double angle = xDistance / diag;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.TranslateTransform(_prevPoint.X, _prevPoint.Y);
                graphics.RotateTransform(((_newPoint.Y < _prevPoint.Y) ? -1 : 1)
                    * Convert.ToInt32(Math.Acos(angle) * 180.0 / Math.PI));
                graphics.ScaleTransform((float)scale, (float)scale);
                Rectangle rect = new Rectangle(0, -(_arrow.Height / 2), _arrow.Width, _arrow.Height);
                graphics.DrawImage(_arrow, rect);
                return image;
            }
        }

        private Image GetColoredArrow()
        {
            Bitmap bitmap = (Bitmap)Properties.Resources.arrow.Clone();
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color pixel = bitmap.GetPixel(j, i);
                    if (pixel.A != 0)
                    {
                        bitmap.SetPixel(j, i, Color.FromArgb((int)pixel.A, _color));
                    }
                }
            }
            return bitmap;
        }
    }
}
