using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Screens.Instruments
{
    class RectInstrument : Instrument
    {
        public RectInstrument()
        {
            Type = InstrumentType.Rect;
        }

        public override Image Draw(Image image)
        {
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                var rect = new Rectangle(
                    Math.Min(_prevPoint.X, _newPoint.X),
                    Math.Min(_prevPoint.Y, _newPoint.Y), 
                    Math.Abs(_newPoint.X - _prevPoint.X), 
                    Math.Abs(_newPoint.Y - _prevPoint.Y));
                DrawRect(graphics, rect);
            }
            return image;
        }

        protected virtual void DrawRect(Graphics graphics, Rectangle rect)
        {
            graphics.DrawRectangle(new Pen(_color, _lineWidth), rect);
        }
    }
}
