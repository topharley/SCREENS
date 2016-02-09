using System;
using System.Windows.Forms;

namespace Screens
{
    public partial class InputQuery : Form
    {
        public InputQuery()
        {
            InitializeComponent();
        }

        public static Boolean Input(String title, String description, ref String value)
        {
            InputQuery dlg = new InputQuery();
            dlg.Text = title;
            dlg.labelDescription.Text = description;
            dlg.TextBoxInput.Text = value;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                value = dlg.TextBoxInput.Text;
                return true;
            }
            return false;
        }

        public static Boolean MultiInput(String title, String description, ref String value)
        {
            InputQuery dlg = new InputQuery();
            dlg.Text = title;
            dlg.labelDescription.Text = description;
            dlg.TextBoxInput.Text = value;
            dlg.TextBoxInput.Multiline = true;
            dlg.MaximumSize = new System.Drawing.Size(2000, 420);
            dlg.Size = new System.Drawing.Size(dlg.Size.Width, 200);
            dlg.TextBoxInput.AcceptsReturn = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                value = dlg.TextBoxInput.Text;
                return true;
            }
            return false;
        }
    }
}
