using System.Drawing;
using System.Drawing.Drawing2D;

namespace Screens.Instruments
{
    class HightlightInstrument : Instrument
    {
        public HightlightInstrument()
        {
            Type = InstrumentType.Hightlight;
            _lineWidth = 12;
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

        public override Image Draw(Image image)
        {
            DrawLine(image, Color.FromArgb(5, _color.R, _color.G, _color.B));
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

                    pen.EndCap = LineCap.Square;
                    pen.StartCap = LineCap.Square;
                    graphics.DrawLine(pen, a, b);
                    graphics.FillRectangle(pen.Brush, a.X - pen.Width / 2.0f, a.Y - pen.Width / 2.0f, pen.Width, pen.Width);
                }
            }
        }

        internal override void SetWidth(uint lineWidth) { }
    }
}
