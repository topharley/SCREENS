using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Screens.Instruments
{
    class PenInstrument : Instrument
    {
        public PenInstrument()
        {
            Type = InstrumentType.Pen;
            _cursor = Resources.Cursors.PencilToolCursor;
        }

        public override Image Draw(Image image)
        {
            DrawLine(image, _color);
            return image;
        }

        protected void DrawLine(Image image, Color color)
        {
            Point a = _prevPoint;
            Point b = _newPoint;
            using (Graphics graphics = Graphics.FromImage(image))
            {
                using (Pen pen = new Pen(color, _lineWidth))
                {
                    graphics.SmoothingMode = SmoothingMode.None;

                    graphics.CompositingMode = CompositingMode.SourceOver;
                    graphics.PixelOffsetMode = pen.Width > 1 ? PixelOffsetMode.Half : PixelOffsetMode.None;

                    pen.EndCap = LineCap.Round;
                    pen.StartCap = LineCap.Round;
                    graphics.DrawLine(pen, a, b);
                    graphics.FillEllipse(pen.Brush, a.X - pen.Width / 2.0f, a.Y - pen.Width / 2.0f, pen.Width, pen.Width);
                }
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
