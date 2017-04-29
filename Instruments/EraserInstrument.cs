using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Screens.Instruments
{
    class EraserInstrument : PenInstrument
    {
        private readonly Color TRANSPARENT = Color.FromArgb(255, 0, 0, 0);
        private Color _eraserColor;
        private bool _transparentEraser;

        public EraserInstrument()
        {
            Type = InstrumentType.Eraser;
            _cursor = Resources.Cursors.EraserToolCursor;
        }

        public override void MouseDown(MouseEventArgs e)
        {
            base.MouseDown(e);
            _transparentEraser = (e.Button != MouseButtons.Left);
            _eraserColor = _transparentEraser ? TRANSPARENT : _color;
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
            if (_transparentEraser)
            {
                Bitmap bmp = (image as Bitmap) ?? new Bitmap(image);
                Rectangle rect = PointsToRectangle(_prevPoint, _newPoint);
                rect.Inflate((int)Math.Ceiling(5f), (int)Math.Ceiling(5f));

                bmp = InvertColor(bmp, rect);
                DrawLine(bmp, _eraserColor);
                return (Image)InvertColor(bmp, rect);
            }
            else
            {
                DrawLine(image, _eraserColor);
                return image;
            }
        }

        private static Bitmap InvertColor(Bitmap bmp, Rectangle rect)
        {
            for (int y = rect.Y; (y <= rect.Bottom); y++)
            {
                if (y < 0 || y > bmp.Height -1) continue;
                for (int x = rect.X; (x <= rect.Right); x++)
                {
                    if (x < 0 || x > bmp.Width - 1) continue;
                    Color inv = bmp.GetPixel(x, y);
                    inv = Color.FromArgb(255 - inv.A, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    bmp.SetPixel(x, y, inv);
                }
            }

            return bmp;
        }
    }
}
