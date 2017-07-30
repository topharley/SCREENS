using Screens.Instruments;

namespace Screens
{
    partial class EditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.OKButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClipboardBbutton = new System.Windows.Forms.Button();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.UndoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ArrowToolStripButton = new Screens.InstrumentToolStripButton();
            this.PenToolStripButton = new Screens.InstrumentToolStripButton();
            this.RectToolStripButton = new Screens.InstrumentToolStripButton();
            this.LineToolStripButton = new Screens.InstrumentToolStripButton();
            this.EraserToolStripButton = new Screens.InstrumentToolStripButton();
            this.HightlightToolStripButton = new Screens.InstrumentToolStripButton();
            this.BlurToolStripButton = new Screens.InstrumentToolStripButton();
            this.LineWidthToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this._3pxToolStripMenuItem = new Screens.Controls.LineWidthToolStripMenuItem();
            this._5pxToolStripMenuItem = new Screens.Controls.LineWidthToolStripMenuItem();
            this._7pxToolStripMenuItem = new Screens.Controls.LineWidthToolStripMenuItem();
            this._10pxToolStripMenuItem = new Screens.Controls.LineWidthToolStripMenuItem();
            this._12pxToolStripMenuItem = new Screens.Controls.LineWidthToolStripMenuItem();
            this.TextToolStripButton = new Screens.InstrumentToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RedToolStripButton = new Screens.ColorToolStripButton();
            this.WhiteToolStripButton = new Screens.ColorToolStripButton();
            this.OrangeToolStripButton = new Screens.ColorToolStripButton();
            this.GreenToolStripButton = new Screens.ColorToolStripButton();
            this.BlueToolStripButton = new Screens.ColorToolStripButton();
            this.BlackToolStripButton = new Screens.ColorToolStripButton();
            this.CenterPanel = new Screens.SelectablePictureBox();
            this.Box = new System.Windows.Forms.PictureBox();
            this.BottomPanel.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CenterPanel)).BeginInit();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Image = ((System.Drawing.Image)(resources.GetObject("OKButton.Image")));
            this.OKButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKButton.Location = new System.Drawing.Point(452, 6);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 40);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "Загрузить";
            this.OKButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorForm_KeyDown);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.SettingsButton);
            this.BottomPanel.Controls.Add(this.SaveButton);
            this.BottomPanel.Controls.Add(this.ClipboardBbutton);
            this.BottomPanel.Controls.Add(this.OKButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 262);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(564, 58);
            this.BottomPanel.TabIndex = 2;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(208, 6);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(46, 40);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(113, 6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(89, 40);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "В файл ";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClipboardBbutton
            // 
            this.ClipboardBbutton.Image = ((System.Drawing.Image)(resources.GetObject("ClipboardBbutton.Image")));
            this.ClipboardBbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClipboardBbutton.Location = new System.Drawing.Point(12, 6);
            this.ClipboardBbutton.Name = "ClipboardBbutton";
            this.ClipboardBbutton.Size = new System.Drawing.Size(95, 40);
            this.ClipboardBbutton.TabIndex = 1;
            this.ClipboardBbutton.Text = "В буфер ";
            this.ClipboardBbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClipboardBbutton.UseVisualStyleBackColor = true;
            this.ClipboardBbutton.Click += new System.EventHandler(this.ClipboardBbutton_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripButton,
            this.toolStripSeparator2,
            this.ArrowToolStripButton,
            this.PenToolStripButton,
            this.RectToolStripButton,
            this.LineToolStripButton,
            this.EraserToolStripButton,
            this.HightlightToolStripButton,
            this.BlurToolStripButton,
            this.LineWidthToolStripButton,
            this.TextToolStripButton,
            this.toolStripSeparator1,
            this.RedToolStripButton,
            this.WhiteToolStripButton,
            this.OrangeToolStripButton,
            this.GreenToolStripButton,
            this.BlueToolStripButton,
            this.BlackToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(564, 25);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // UndoToolStripButton
            // 
            this.UndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoToolStripButton.Enabled = false;
            this.UndoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoToolStripButton.Image")));
            this.UndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoToolStripButton.Name = "UndoToolStripButton";
            this.UndoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.UndoToolStripButton.Text = "Отмена";
            this.UndoToolStripButton.Click += new System.EventHandler(this.UndoToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ArrowToolStripButton
            // 
            this.ArrowToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ArrowToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ArrowToolStripButton.Image")));
            this.ArrowToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ArrowToolStripButton.InstrumentType = Screens.Instruments.InstrumentType.Arrow;
            this.ArrowToolStripButton.Name = "ArrowToolStripButton";
            this.ArrowToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ArrowToolStripButton.Text = "Стрелка";
            this.ArrowToolStripButton.Click += new System.EventHandler(this.InstrumentToolStripButton_Click);
            // 
            // PenToolStripButton
            // 
            this.PenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PenToolStripButton.Image")));
            this.PenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenToolStripButton.InstrumentType = Screens.Instruments.InstrumentType.Pen;
            this.PenToolStripButton.Name = "PenToolStripButton";
            this.PenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PenToolStripButton.Text = "Карандаш";
            this.PenToolStripButton.Click += new System.EventHandler(this.InstrumentToolStripButton_Click);
            // 
            // RectToolStripButton
            // 
            this.RectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RectToolStripButton.Image")));
            this.RectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectToolStripButton.InstrumentType = Screens.Instruments.InstrumentType.Rect;
            this.RectToolStripButton.Name = "RectToolStripButton";
            this.RectToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RectToolStripButton.Text = "Прямоугольник";
            this.RectToolStripButton.Click += new System.EventHandler(this.InstrumentToolStripButton_Click);
            // 
            // LineToolStripButton
            // 
            this.LineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LineToolStripButton.Image")));
            this.LineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineToolStripButton.InstrumentType = Screens.Instruments.InstrumentType.Line;
            this.LineToolStripButton.Name = "LineToolStripButton";
            this.LineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.LineToolStripButton.Text = "Линия";
            this.LineToolStripButton.Click += new System.EventHandler(this.InstrumentToolStripButton_Click);
            // 
            // EraserToolStripButton
            // 
            this.EraserToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EraserToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EraserToolStripButton.Image")));
            this.EraserToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EraserToolStripButton.InstrumentType = Screens.Instruments.InstrumentType.Eraser;
            this.EraserToolStripButton.Name = "EraserToolStripButton";
            this.EraserToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.EraserToolStripButton.Text = "Стерка";
            this.EraserToolStripButton.Click += new System.EventHandler(this.InstrumentToolStripButton_Click);
            // 
            // HightlightToolStripButton
            // 
            this.HightlightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HightlightToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HightlightToolStripButton.Image")));
            this.HightlightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HightlightToolStripButton.InstrumentType = Screens.Instruments.InstrumentType.Hightlight;
            this.HightlightToolStripButton.Name = "HightlightToolStripButton";
            this.HightlightToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.HightlightToolStripButton.Text = "Маркер";
            this.HightlightToolStripButton.Click += new System.EventHandler(this.InstrumentToolStripButton_Click);
            // 
            // BlurToolStripButton
            // 
            this.BlurToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BlurToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BlurToolStripButton.Image")));
            this.BlurToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlurToolStripButton.InstrumentType = Screens.Instruments.InstrumentType.Blur;
            this.BlurToolStripButton.Name = "BlurToolStripButton";
            this.BlurToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BlurToolStripButton.Text = "Размытие";
            this.BlurToolStripButton.Click += new System.EventHandler(this.InstrumentToolStripButton_Click);
            // 
            // LineWidthToolStripButton
            // 
            this.LineWidthToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineWidthToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._3pxToolStripMenuItem,
            this._5pxToolStripMenuItem,
            this._7pxToolStripMenuItem,
            this._10pxToolStripMenuItem,
            this._12pxToolStripMenuItem});
            this.LineWidthToolStripButton.Image = global::Screens.Properties.Resources._3px;
            this.LineWidthToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineWidthToolStripButton.Name = "LineWidthToolStripButton";
            this.LineWidthToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.LineWidthToolStripButton.Text = "toolStripDropDownButton1";
            // 
            // _3pxToolStripMenuItem
            // 
            this._3pxToolStripMenuItem.Image = global::Screens.Properties.Resources._3px;
            this._3pxToolStripMenuItem.LineWidth = ((uint)(3u));
            this._3pxToolStripMenuItem.Name = "_3pxToolStripMenuItem";
            this._3pxToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this._3pxToolStripMenuItem.Text = "3px";
            this._3pxToolStripMenuItem.Click += new System.EventHandler(this.WidthToolMenuItem_Click);
            // 
            // _5pxToolStripMenuItem
            // 
            this._5pxToolStripMenuItem.Image = global::Screens.Properties.Resources._5px;
            this._5pxToolStripMenuItem.LineWidth = ((uint)(5u));
            this._5pxToolStripMenuItem.Name = "_5pxToolStripMenuItem";
            this._5pxToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this._5pxToolStripMenuItem.Text = "5px";
            this._5pxToolStripMenuItem.Click += new System.EventHandler(this.WidthToolMenuItem_Click);
            // 
            // _7pxToolStripMenuItem
            // 
            this._7pxToolStripMenuItem.Image = global::Screens.Properties.Resources._7px;
            this._7pxToolStripMenuItem.LineWidth = ((uint)(7u));
            this._7pxToolStripMenuItem.Name = "_7pxToolStripMenuItem";
            this._7pxToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this._7pxToolStripMenuItem.Text = "7px";
            this._7pxToolStripMenuItem.Click += new System.EventHandler(this.WidthToolMenuItem_Click);
            // 
            // _10pxToolStripMenuItem
            // 
            this._10pxToolStripMenuItem.Image = global::Screens.Properties.Resources._10px;
            this._10pxToolStripMenuItem.LineWidth = ((uint)(10u));
            this._10pxToolStripMenuItem.Name = "_10pxToolStripMenuItem";
            this._10pxToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this._10pxToolStripMenuItem.Text = "10px";
            this._10pxToolStripMenuItem.Click += new System.EventHandler(this.WidthToolMenuItem_Click);
            // 
            // _12pxToolStripMenuItem
            // 
            this._12pxToolStripMenuItem.Image = global::Screens.Properties.Resources._12px;
            this._12pxToolStripMenuItem.LineWidth = ((uint)(12u));
            this._12pxToolStripMenuItem.Name = "_12pxToolStripMenuItem";
            this._12pxToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this._12pxToolStripMenuItem.Text = "12px";
            this._12pxToolStripMenuItem.Click += new System.EventHandler(this.WidthToolMenuItem_Click);
            // 
            // TextToolStripButton
            // 
            this.TextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TextToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("TextToolStripButton.Image")));
            this.TextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TextToolStripButton.InstrumentType = Screens.Instruments.InstrumentType.Text;
            this.TextToolStripButton.Name = "TextToolStripButton";
            this.TextToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.TextToolStripButton.Text = "Текст";
            this.TextToolStripButton.Click += new System.EventHandler(this.TextToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RedToolStripButton
            // 
            this.RedToolStripButton.Color = System.Drawing.Color.Crimson;
            this.RedToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RedToolStripButton.Image")));
            this.RedToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedToolStripButton.Name = "RedToolStripButton";
            this.RedToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RedToolStripButton.Tag = "";
            this.RedToolStripButton.Click += new System.EventHandler(this.ColoredButtonToolStripButton_Click);
            // 
            // WhiteToolStripButton
            // 
            this.WhiteToolStripButton.Color = System.Drawing.Color.White;
            this.WhiteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.WhiteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("WhiteToolStripButton.Image")));
            this.WhiteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WhiteToolStripButton.Name = "WhiteToolStripButton";
            this.WhiteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.WhiteToolStripButton.Tag = "";
            this.WhiteToolStripButton.Click += new System.EventHandler(this.ColoredButtonToolStripButton_Click);
            // 
            // OrangeToolStripButton
            // 
            this.OrangeToolStripButton.Color = System.Drawing.Color.Orange;
            this.OrangeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrangeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OrangeToolStripButton.Image")));
            this.OrangeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrangeToolStripButton.Name = "OrangeToolStripButton";
            this.OrangeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OrangeToolStripButton.Tag = "";
            this.OrangeToolStripButton.Click += new System.EventHandler(this.ColoredButtonToolStripButton_Click);
            // 
            // GreenToolStripButton
            // 
            this.GreenToolStripButton.Color = System.Drawing.Color.Green;
            this.GreenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GreenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GreenToolStripButton.Image")));
            this.GreenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GreenToolStripButton.Name = "GreenToolStripButton";
            this.GreenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.GreenToolStripButton.Tag = "";
            this.GreenToolStripButton.Click += new System.EventHandler(this.ColoredButtonToolStripButton_Click);
            // 
            // BlueToolStripButton
            // 
            this.BlueToolStripButton.Color = System.Drawing.Color.Blue;
            this.BlueToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BlueToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BlueToolStripButton.Image")));
            this.BlueToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlueToolStripButton.Name = "BlueToolStripButton";
            this.BlueToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BlueToolStripButton.Tag = "";
            this.BlueToolStripButton.Click += new System.EventHandler(this.ColoredButtonToolStripButton_Click);
            // 
            // BlackToolStripButton
            // 
            this.BlackToolStripButton.Color = System.Drawing.Color.Black;
            this.BlackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BlackToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BlackToolStripButton.Image")));
            this.BlackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlackToolStripButton.Name = "BlackToolStripButton";
            this.BlackToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BlackToolStripButton.Tag = "";
            this.BlackToolStripButton.Click += new System.EventHandler(this.ColoredButtonToolStripButton_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CenterPanel.BackgroundImage")));
            this.CenterPanel.Controls.Add(this.Box);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 25);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(564, 237);
            this.CenterPanel.TabIndex = 0;
            this.CenterPanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorForm_KeyDown);
            // 
            // Box
            // 
            this.Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Box.BackColor = System.Drawing.Color.White;
            this.Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box.Location = new System.Drawing.Point(104, 88);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(333, 98);
            this.Box.TabIndex = 5;
            this.Box.TabStop = false;
            this.Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDown);
            this.Box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Box_MouseMove);
            this.Box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Box_MouseUp);
            // 
            // EditorForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 320);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.BottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 300);
            this.Name = "EditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorForm_KeyDown);
            this.BottomPanel.ResumeLayout(false);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CenterPanel)).EndInit();
            this.CenterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private InstrumentToolStripButton PenToolStripButton;
        private InstrumentToolStripButton ArrowToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private InstrumentToolStripButton TextToolStripButton;
        private InstrumentToolStripButton LineToolStripButton;
        private InstrumentToolStripButton EraserToolStripButton;
        private System.Windows.Forms.ToolStripButton UndoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private InstrumentToolStripButton HightlightToolStripButton;
        private ColorToolStripButton RedToolStripButton;
        private ColorToolStripButton WhiteToolStripButton;
        private ColorToolStripButton OrangeToolStripButton;
        private ColorToolStripButton GreenToolStripButton;
        private ColorToolStripButton BlueToolStripButton;
        private ColorToolStripButton BlackToolStripButton;
        private Screens.InstrumentToolStripButton RectToolStripButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClipboardBbutton;
        private SelectablePictureBox CenterPanel;
        private System.Windows.Forms.PictureBox Box;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.ToolStripDropDownButton LineWidthToolStripButton;
        private Controls.LineWidthToolStripMenuItem _3pxToolStripMenuItem;
        private Controls.LineWidthToolStripMenuItem _5pxToolStripMenuItem;
        private Controls.LineWidthToolStripMenuItem _7pxToolStripMenuItem;
        private Controls.LineWidthToolStripMenuItem _10pxToolStripMenuItem;
        private Controls.LineWidthToolStripMenuItem _12pxToolStripMenuItem;
        private Screens.InstrumentToolStripButton BlurToolStripButton;
    }
}