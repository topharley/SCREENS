using System.Drawing;
using System.Drawing.Drawing2D;

namespace Screens.Instruments
{
    class LineInstrument : Instrument
    {
        public LineInstrument()
        {
            Type = InstrumentType.Line;
        }

        public override Image Draw(Image image)
        {
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawLine(new Pen(_color, _lineWidth), _prevPoint, _newPoint);
                return image;
            }
        }
    }
}
