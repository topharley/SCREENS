using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Screens.Instruments;

namespace Screens
{
    public partial class EditorForm : Form
    {
        public Bitmap Bitmap { get { return (Bitmap)Box.Image; } }

        private Instrument _instrument;
        private uint _lineWidth = 3;
        private Color _color = Color.Transparent;
        private Stack<Image> _undoStack;

        public EditorForm(Bitmap bitmap)
        {
            InitializeComponent();
            Box.Image = bitmap;
            var preferredSize = SetPreferredSize(bitmap);
            Load += (x, y) => InsurePreferredSize(preferredSize);
            _undoStack = new Stack<Image>();
            ArrowToolStripButton.PerformClick();
            RedToolStripButton.PerformClick();
        }

        private void InsurePreferredSize(Size preferredSize)
        {
            if (ClientSize.Width > preferredSize.Width || ClientSize.Height > preferredSize.Height)
            {
                Box.Left = (ClientSize.Width - preferredSize.Width) / 2;
                Box.Top = (ClientSize.Height - preferredSize.Height) / 2;
            }
        }

        private Size SetPreferredSize(Bitmap bitmap)
        {
            Box.ClientSize = bitmap.Size;
            var preferredSize = new Size(
                bitmap.Width + SystemInformation.BorderSize.Width * 2,
                bitmap.Height + MainToolStrip.Height + BottomPanel.Height + SystemInformation.BorderSize.Height * 2);
            ClientSize = preferredSize;
            Box.Location = new Point(0, 0);
            return preferredSize;
        }

        private void UndoToolStripButton_Click(object sender, System.EventArgs e)
        {
            Box.Image = _undoStack.Pop();
            _instrument.Init(Box, _color);
            UndoToolStripButton.Enabled = _undoStack.Count > 0;
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            _undoStack.Push(_instrument.SourceImage);
            UndoToolStripButton.Enabled = _undoStack.Count > 0;
            _instrument.MouseDown(e);
        }

        private void Box_MouseUp(object sender, MouseEventArgs e)
        {
            _instrument.MouseUp(Box.Image);
        }

        private void Box_MouseMove(object sender, MouseEventArgs e)
        {
            _instrument.MouseMove(e.Location);
        }

        private void EditorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Clipper.Terminate();
            if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control && UndoToolStripButton.Enabled)
                UndoToolStripButton.PerformClick();
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
                ClipboardBbutton.PerformClick();
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
                SaveButton.PerformClick();
        }

        private void ColoredButtonToolStripButton_Click(object sender, System.EventArgs e)
        {
            var clickedBtn = (ColorToolStripButton)sender;
            if (!clickedBtn.Checked)
            {
                _color = clickedBtn.Color;
                _instrument.Init(Box, _color);
                foreach (var btn in MainToolStrip.Items)
                {
                    var button = btn as ColorToolStripButton;
                    if (button != null)
                        button.Checked = false;
                }
                clickedBtn.Checked = true;
            }
        }

        private void InstrumentToolStripButton_Click(object sender, System.EventArgs e)
        {
            var clickedBtn = (InstrumentToolStripButton)sender;
            if (!clickedBtn.Checked)
            {
                _instrument = InstrumentFactory.Create(clickedBtn.InstrumentType);
                _instrument.Init(Box, _color);
                _instrument.SetWidth(_lineWidth);
                foreach (var btn in MainToolStrip.Items)
                {
                    var button = btn as InstrumentToolStripButton;
                    if (button != null)
                        button.Checked = false;
                }
                clickedBtn.Checked = true;
            }
        }

        private void TextToolStripButton_Click(object sender, System.EventArgs e)
        {
            if (TextToolStripButton.Checked) TextToolStripButton.Checked = false;
            InstrumentToolStripButton_Click(sender, e);
        }

        private void WidthToolMenuItem_Click(object sender, System.EventArgs e)
        {
            var itm = sender as Controls.LineWidthToolStripMenuItem;
            if (itm == null) return;
            _lineWidth = itm.LineWidth;
            _instrument.SetWidth(itm.LineWidth);

            itm.OwnerItem.Image = itm.Image;
        }

        private void ClipboardBbutton_Click(object sender, System.EventArgs e)
        {
            var bitmap = Box.Image;
            if (Settings.Current.DrawWaterMark)
                bitmap = TextInstrument.DrawWaterMark(bitmap);
            Clipboard.SetImage(bitmap);
            Close();
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog { Filter = "PNG|*.png" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var bitmap = Box.Image;
                if (Settings.Current.DrawWaterMark)
                    bitmap = TextInstrument.DrawWaterMark(bitmap);
                var pngBuffer = Clipper.GetPng((Bitmap)bitmap);
                System.IO.File.WriteAllBytes(dlg.FileName, pngBuffer);
                Clipboard.SetText(dlg.FileName);
                Close();
            }
        }

        private void SettingsButton_Click(object sender, System.EventArgs e)
        {
            new SettingsDialog().ShowDialog();
        }
    }
}
