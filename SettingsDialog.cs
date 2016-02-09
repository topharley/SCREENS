using System;
using System.Windows.Forms;

namespace Screens
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
            FillForm();
        }

        private void FillForm()
        {
            UploadTypeComboBox.DataSource = Enum.GetValues(typeof(Uploaders.UploaderType));
            UploadTypeComboBox.SelectedIndex = 0;
            UploadTypeComboBox.Text = Settings.Current.UploaderType.ToString();
            
            AutoStartCheckBox.Checked = Settings.Current.AutoStart;
            UseHKCheckBox.Checked = Settings.Current.UseHK;
            ShortenUrlCheckBox.Checked = Settings.Current.ShortenUrl;
            OpenBrowserCheckBox.Checked = Settings.Current.OpenInBrowser;
            CopyInClipboardCheckBox.Checked = Settings.Current.CopyInClipboard;
            
            SetPathInTag(SaveLogLinkLabel, Settings.Current.SaveLogFile);
            SaveLogCheckBox.Checked = Settings.Current.SaveLog;
            
            SetPathInTag(SaveLocalPathLinkLabel, Settings.Current.SaveLastScreenshotFile);
            SaveLocalScreenshotCheckBox.Checked = Settings.Current.SaveLastScreenshot;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            FillSettings();
            Settings.Save();
            Settings.Current.Apply();
            Close();
        }

        private void FillSettings()
        {
            Settings.Current.UploaderType = (Uploaders.UploaderType)Enum.Parse(typeof(Uploaders.UploaderType), UploadTypeComboBox.Text);
            Settings.Current.AutoStart = AutoStartCheckBox.Checked;
            Settings.Current.UseHK = UseHKCheckBox.Checked;
            Settings.Current.ShortenUrl = ShortenUrlCheckBox.Checked;
            Settings.Current.OpenInBrowser = OpenBrowserCheckBox.Checked;
            Settings.Current.CopyInClipboard = CopyInClipboardCheckBox.Checked;
            Settings.Current.SaveLog = SaveLogCheckBox.Checked;
            Settings.Current.SaveLogFile = SaveLogLinkLabel.Tag as string;
            Settings.Current.SaveLastScreenshot = SaveLocalScreenshotCheckBox.Checked;
            Settings.Current.SaveLastScreenshotFile = SaveLocalPathLinkLabel.Tag as string;
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetPathInTag(LinkLabel control, string file)
        {
            control.Tag = file;
            MainToolTip.SetToolTip(control, file);
        }

        private void SaveLogLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog { Filter = "*.txt|*.txt" };
            dlg.OverwritePrompt = false;
            string file = SaveLogLinkLabel.Tag as string;
            if (!String.IsNullOrEmpty(file)) dlg.FileName = file;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SetPathInTag(SaveLogLinkLabel, dlg.FileName);
            }
        }

        private void SaveLocalPathLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog { Filter = "*.txt|*.txt" };
            dlg.OverwritePrompt = false;
            string file = SaveLocalPathLinkLabel.Tag as string;
            if (!String.IsNullOrEmpty(file)) dlg.FileName = file;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SetPathInTag(SaveLocalPathLinkLabel, dlg.FileName);
            }
        }

        private void SaveLogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveLogCheckBox.Checked && SaveLogLinkLabel.Tag == null)
                SaveLogLinkLabel_LinkClicked(null, null);
        }

        private void SaveLocalScreenshotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveLocalScreenshotCheckBox.Checked && SaveLocalPathLinkLabel.Tag == null)
                SaveLocalPathLinkLabel_LinkClicked(null, null);
        }
    }
}
