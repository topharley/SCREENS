using System;
using System.Drawing;

namespace Screens.Instruments
{
    class BlurInstrument : RectInstrument
    {
        public BlurInstrument()
        {
            Type = InstrumentType.Blur;
        }

        protected override void DrawRect(Graphics graphics, Rectangle rect)
        {
            if (_mouseDown) graphics.DrawRectangle(new Pen(_color, 1), rect);
        }

        public override void MouseUp(Image image)
        {
            _mouseDown = false;
            _picture.Image = Blur(_sourceImage);
            base.MouseUp(_sourceImage);
        }

        private Image Blur(Image image)
        {
            _prevPoint = new Point(Math.Max(Math.Min(_prevPoint.X, image.Width), 0), Math.Max(Math.Min(_prevPoint.Y, image.Height), 0));
            _newPoint = new Point(Math.Max(Math.Min(_newPoint.X, image.Width), 0), Math.Max(Math.Min(_newPoint.Y, image.Height), 0));

            var rectangle = new Rectangle(
                    Math.Min(_prevPoint.X, _newPoint.X),
                    Math.Min(_prevPoint.Y, _newPoint.Y),
                    Math.Abs(_newPoint.X - _prevPoint.X),
                    Math.Abs(_newPoint.Y - _prevPoint.Y));

            const int blurSize = 5;
            LockBitmap original = new LockBitmap((Bitmap)image.Clone());
            LockBitmap blurred = new LockBitmap((Bitmap)image);

            for (int xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (int yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    int avgR = 0, avgG = 0, avgB = 0;
                    int blurPixelCount = 0;
                    for (int x = xx; x < xx + blurSize && x < image.Width; x++)
                    {
                        for (int y = yy; y < yy + blurSize && y < image.Height; y++)
                        {
                            Color pixel = original.GetPixel(x, y);

                            avgR += pixel.R;
                            avgG += pixel.G;
                            avgB += pixel.B;

                            blurPixelCount++;
                        }
                    }

                    if (blurPixelCount == 0) continue;

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    for (int x = xx; x < xx + blurSize && x < image.Width; x++) // && x < rectangle.Width
                        for (int y = yy; y < yy + blurSize && y < image.Height; y++) // && y < rectangle.Height
                            blurred.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            blurred.UnlockBits();

            return image;
        }
    }
}
