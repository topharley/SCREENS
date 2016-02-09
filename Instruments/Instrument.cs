﻿using System.Drawing;
using System.Windows.Forms;

namespace Screens.Instruments
{
    public abstract class Instrument
    {
        protected bool _mouseDown;
        protected PictureBox _picture;
        protected Image _sourceImage;
        protected Color _color;
        protected Point _prevPoint { get; set; }
        protected Point _newPoint { get; set; }

        public InstrumentType Type { get; protected set; }
        public virtual Image SourceImage
        {
            get { return (Image)_sourceImage.Clone(); }
        }

        public virtual void Init(PictureBox picture, Color color)
        {
            _picture = picture;
            _color = color;
            _sourceImage = (Image)picture.Image.Clone();
        }

        public abstract Image Draw(Image image);

        public virtual void MouseDown(Point location)
        {
            _mouseDown = true;
            _prevPoint = location;
        }

        public virtual void MouseUp(Image image)
        {
            _mouseDown = false;
            _sourceImage = (Image)image.Clone();
        }

        public virtual void MouseMove(Point location)
        {
            if (_mouseDown)
            {
                _newPoint = location;
                _picture.Image = Draw((Image)_sourceImage.Clone());
            }
        }
    }
}