namespace Screens
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.UploadTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SaveLocalScreenshotCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveLogCheckBox = new System.Windows.Forms.CheckBox();
            this.OpenBrowserCheckBox = new System.Windows.Forms.CheckBox();
            this.ShortenUrlCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WaterMarkEdit = new System.Windows.Forms.TextBox();
            this.UseHKCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveLocalPathLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SaveLogLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CopyInClipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(236, 317);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton1
            // 
            this.CancelButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton1.Location = new System.Drawing.Point(317, 317);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(75, 23);
            this.CancelButton1.TabIndex = 1;
            this.CancelButton1.Text = "Отмена";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click);
            // 
            // UploadTypeComboBox
            // 
            this.UploadTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UploadTypeComboBox.FormattingEnabled = true;
            this.UploadTypeComboBox.Location = new System.Drawing.Point(20, 25);
            this.UploadTypeComboBox.Name = "UploadTypeComboBox";
            this.UploadTypeComboBox.Size = new System.Drawing.Size(340, 21);
            this.UploadTypeComboBox.TabIndex = 3;
            // 
            // SaveLocalScreenshotCheckBox
            // 
            this.SaveLocalScreenshotCheckBox.AutoSize = true;
            this.SaveLocalScreenshotCheckBox.Location = new System.Drawing.Point(20, 167);
            this.SaveLocalScreenshotCheckBox.Name = "SaveLocalScreenshotCheckBox";
            this.SaveLocalScreenshotCheckBox.Size = new System.Drawing.Size(188, 17);
            this.SaveLocalScreenshotCheckBox.TabIndex = 11;
            this.SaveLocalScreenshotCheckBox.Text = "Сохранять последний скриншот";
            this.SaveLocalScreenshotCheckBox.UseVisualStyleBackColor = true;
            this.SaveLocalScreenshotCheckBox.CheckedChanged += new System.EventHandler(this.SaveLocalScreenshotCheckBox_CheckedChanged);
            // 
            // SaveLogCheckBox
            // 
            this.SaveLogCheckBox.AutoSize = true;
            this.SaveLogCheckBox.Location = new System.Drawing.Point(20, 144);
            this.SaveLogCheckBox.Name = "SaveLogCheckBox";
            this.SaveLogCheckBox.Size = new System.Drawing.Size(76, 17);
            this.SaveLogCheckBox.TabIndex = 10;
            this.SaveLogCheckBox.Text = "Вести лог";
            this.SaveLogCheckBox.UseVisualStyleBackColor = true;
            this.SaveLogCheckBox.CheckedChanged += new System.EventHandler(this.SaveLogCheckBox_CheckedChanged);
            // 
            // OpenBrowserCheckBox
            // 
            this.OpenBrowserCheckBox.AutoSize = true;
            this.OpenBrowserCheckBox.Location = new System.Drawing.Point(20, 121);
            this.OpenBrowserCheckBox.Name = "OpenBrowserCheckBox";
            this.OpenBrowserCheckBox.Size = new System.Drawing.Size(190, 17);
            this.OpenBrowserCheckBox.TabIndex = 9;
            this.OpenBrowserCheckBox.Text = "Открывать картинку в браузере";
            this.OpenBrowserCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShortenUrlCheckBox
            // 
            this.ShortenUrlCheckBox.AutoSize = true;
            this.ShortenUrlCheckBox.Location = new System.Drawing.Point(20, 75);
            this.ShortenUrlCheckBox.Name = "ShortenUrlCheckBox";
            this.ShortenUrlCheckBox.Size = new System.Drawing.Size(172, 17);
            this.ShortenUrlCheckBox.TabIndex = 8;
            this.ShortenUrlCheckBox.Text = "Сокращать адреса картинок";
            this.ShortenUrlCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.UploadTypeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 66);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сервис картинок";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.WaterMarkEdit);
            this.groupBox2.Controls.Add(this.UseHKCheckBox);
            this.groupBox2.Controls.Add(this.AutoStartCheckBox);
            this.groupBox2.Controls.Add(this.SaveLocalPathLinkLabel);
            this.groupBox2.Controls.Add(this.SaveLogLinkLabel);
            this.groupBox2.Controls.Add(this.ShortenUrlCheckBox);
            this.groupBox2.Controls.Add(this.CopyInClipboardCheckBox);
            this.groupBox2.Controls.Add(this.OpenBrowserCheckBox);
            this.groupBox2.Controls.Add(this.SaveLocalScreenshotCheckBox);
            this.groupBox2.Controls.Add(this.SaveLogCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 225);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Водный знак";
            // 
            // WaterMarkEdit
            // 
            this.WaterMarkEdit.Location = new System.Drawing.Point(96, 190);
            this.WaterMarkEdit.Name = "WaterMarkEdit";
            this.WaterMarkEdit.Size = new System.Drawing.Size(264, 20);
            this.WaterMarkEdit.TabIndex = 16;
            this.WaterMarkEdit.Text = "http://scrns.ru";
            // 
            // UseHKCheckBox
            // 
            this.UseHKCheckBox.AutoSize = true;
            this.UseHKCheckBox.Location = new System.Drawing.Point(20, 52);
            this.UseHKCheckBox.Name = "UseHKCheckBox";
            this.UseHKCheckBox.Size = new System.Drawing.Size(189, 17);
            this.UseHKCheckBox.TabIndex = 15;
            this.UseHKCheckBox.Text = "Использовать PrntScrn клавишу";
            this.UseHKCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoStartCheckBox
            // 
            this.AutoStartCheckBox.AutoSize = true;
            this.AutoStartCheckBox.Location = new System.Drawing.Point(20, 29);
            this.AutoStartCheckBox.Name = "AutoStartCheckBox";
            this.AutoStartCheckBox.Size = new System.Drawing.Size(180, 17);
            this.AutoStartCheckBox.TabIndex = 14;
            this.AutoStartCheckBox.Text = "Запускать вместе с системой";
            this.AutoStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveLocalPathLinkLabel
            // 
            this.SaveLocalPathLinkLabel.AutoSize = true;
            this.SaveLocalPathLinkLabel.Location = new System.Drawing.Point(205, 168);
            this.SaveLocalPathLinkLabel.Name = "SaveLocalPathLinkLabel";
            this.SaveLocalPathLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.SaveLocalPathLinkLabel.TabIndex = 13;
            this.SaveLocalPathLinkLabel.TabStop = true;
            this.SaveLocalPathLinkLabel.Text = "в файл...";
            this.SaveLocalPathLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaveLocalPathLinkLabel_LinkClicked);
            // 
            // SaveLogLinkLabel
            // 
            this.SaveLogLinkLabel.AutoSize = true;
            this.SaveLogLinkLabel.Location = new System.Drawing.Point(91, 145);
            this.SaveLogLinkLabel.Name = "SaveLogLinkLabel";
            this.SaveLogLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.SaveLogLinkLabel.TabIndex = 12;
            this.SaveLogLinkLabel.TabStop = true;
            this.SaveLogLinkLabel.Text = "в файл...";
            this.SaveLogLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaveLogLinkLabel_LinkClicked);
            // 
            // CopyInClipboardCheckBox
            // 
            this.CopyInClipboardCheckBox.AutoSize = true;
            this.CopyInClipboardCheckBox.Location = new System.Drawing.Point(20, 98);
            this.CopyInClipboardCheckBox.Name = "CopyInClipboardCheckBox";
            this.CopyInClipboardCheckBox.Size = new System.Drawing.Size(169, 17);
            this.CopyInClipboardCheckBox.TabIndex = 9;
            this.CopyInClipboardCheckBox.Text = "Копировать адрес картинки";
            this.CopyInClipboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton1;
            this.ClientSize = new System.Drawing.Size(404, 352);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.ComboBox UploadTypeComboBox;
        private System.Windows.Forms.CheckBox SaveLocalScreenshotCheckBox;
        private System.Windows.Forms.CheckBox SaveLogCheckBox;
        private System.Windows.Forms.CheckBox OpenBrowserCheckBox;
        private System.Windows.Forms.CheckBox ShortenUrlCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel SaveLocalPathLinkLabel;
        private System.Windows.Forms.LinkLabel SaveLogLinkLabel;
        private System.Windows.Forms.CheckBox AutoStartCheckBox;
        private System.Windows.Forms.CheckBox UseHKCheckBox;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.CheckBox CopyInClipboardCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WaterMarkEdit;
    }
}