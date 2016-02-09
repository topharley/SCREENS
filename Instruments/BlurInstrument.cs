using System.Drawing;
using System.Drawing.Drawing2D;

namespace Screens.Instruments
{
    class BlurInstrument : PenInstrument
    {
        public BlurInstrument()
        {
            Type = InstrumentType.Blur;
        }

        public override Image Draw(Image image)
        {
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Color color;
                try
                {
                    color = ((Bitmap)image).GetPixel(_newPoint.X, _newPoint.Y);
                    color = Color.FromArgb(color.ToArgb() ^ 0x777777);
                }
                catch { color = Color.Gray; }
                graphics.DrawLine(new Pen(color, 12), _prevPoint, _newPoint);
                return image;
            }
        }
    }
}
