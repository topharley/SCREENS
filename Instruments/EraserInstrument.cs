using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Screens.Instruments
{
    class EraserInstrument : RectInstrument
    {
        public EraserInstrument()
        {
            Type = InstrumentType.Eraser;
            _cursor = Resources.Cursors.EraserToolCursor;
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
                graphics.FillRectangle(new SolidBrush(Color.White), rect);
                if(_mouseDown) graphics.DrawRectangle(new Pen(_color, 1), rect);
            }
            return image;
        }

        public override void MouseUp(Image image)
        {
            _mouseDown = false;
            _picture.Image = Draw(_sourceImage);
            base.MouseUp(_sourceImage);
        }
    }
}
