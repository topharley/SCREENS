using System.Drawing;
using System.Drawing.Drawing2D;

namespace Screens.Instruments
{
    class PenInstrument : Instrument
    {
        public PenInstrument()
        {
            Type = InstrumentType.Pen;
        }

        public override Image Draw(Image image)
        {
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawLine(new Pen(_color, 3), _prevPoint, _newPoint);
                return image;
            }
        }

        public override void MouseMove(Point location)
        {
            if (_mouseDown)
            {
                _newPoint = location;
                _picture.Image = Draw(_sourceImage);
                _prevPoint = location;
            }
        }
    }
}
