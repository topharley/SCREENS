using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Screens.Controls
{
    public class LineWidthToolStripMenuItem : ToolStripMenuItem
    {
        private uint _lineWidth;

        public uint LineWidth
        {
            get { return _lineWidth; }
            set
            {
                _lineWidth = value;
                this.Text = _lineWidth + "px";
            }
        }
    }
}
