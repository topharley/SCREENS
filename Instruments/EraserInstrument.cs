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
        }

        protected override  void DrawRect(Graphics graphics, Rectangle rect)
        {
            graphics.FillRectangle(new SolidBrush(Color.White), rect);
            if (_mouseDown) graphics.DrawRectangle(new Pen(_color, 1), rect);
        }

        public override void MouseUp(Image image)
        {
            _mouseDown = false;
            _picture.Image = Draw(_sourceImage);
            base.MouseUp(_sourceImage);
        }
    }
}
