using System.Drawing;
using System.Drawing.Drawing2D;

namespace Screens.Instruments
{
    class HightlightInstrument : PenInstrument
    {
        public HightlightInstrument()
        {
            Type = InstrumentType.Hightlight;
        }

        public override Image Draw(Image image)
        {
            using (Graphics graphics = Graphics.FromImage(image))
            {
                Color color = Color.FromArgb(60, _color.R, _color.G, _color.B);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawLine(new Pen(color, 12), _prevPoint, _newPoint);
                return image;
            }
        }
    }
}
