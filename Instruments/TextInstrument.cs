using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Screens.Instruments
{
    class TextInstrument : Instrument
    {
        private String _text;
        private Font _font = new Font(FontFamily.GenericSansSerif, 12f);

        public TextInstrument()
        {
            Type = InstrumentType.Text;
        }

        public override Image SourceImage
        {
            get { return _sourceImage; } //not clone
        }

        public override void Init(PictureBox picture, Color color)
        {
            base.Init(picture, color);
            if (_text == null)
            {
                if (!InputQuery.Input("Text", "Input text", ref _text))
                    _text = "";
                _mouseDown = true;
            }
        }

        public override Image Draw(Image image)
        {
            using (Graphics graphics = Graphics.FromImage(image))
            {
                var startPos = new Point(_newPoint.X, _newPoint.Y - 20);
                var size = graphics.MeasureString(_text, _font).ToSize();
                var rect = new Rectangle(startPos, size);
                graphics.DrawRectangle(new Pen(_color) { DashStyle = DashStyle.Dash }, rect);
                graphics.DrawString(_text, _font, new SolidBrush(_color), startPos);
                return image;
            }
        }
    }
}
