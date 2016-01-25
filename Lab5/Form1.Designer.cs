namespace Lab5
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PenWidthLabel = new System.Windows.Forms.Label();
            this.FillColorLabel = new System.Windows.Forms.Label();
            this.PenColorLabel = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.FillColor = new System.Windows.Forms.ListBox();
            this.PenWidth = new System.Windows.Forms.ListBox();
            this.PenColor = new System.Windows.Forms.ListBox();
            this.outline_chkbox = new System.Windows.Forms.CheckBox();
            this.fill_chkbox = new System.Windows.Forms.CheckBox();
            this.textRadio = new System.Windows.Forms.RadioButton();
            this.ellipseRadio = new System.Windows.Forms.RadioButton();
            this.rectRadio = new System.Windows.Forms.RadioButton();
            this.lineRadio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SettingsPanel.Controls.Add(this.textBox1);
            this.SettingsPanel.Controls.Add(this.PenWidthLabel);
            this.SettingsPanel.Controls.Add(this.FillColorLabel);
            this.SettingsPanel.Controls.Add(this.PenColorLabel);
            this.SettingsPanel.Controls.Add(this.Draw);
            this.SettingsPanel.Controls.Add(this.FillColor);
            this.SettingsPanel.Controls.Add(this.PenWidth);
            this.SettingsPanel.Controls.Add(this.PenColor);
            this.SettingsPanel.Controls.Add(this.outline_chkbox);
            this.SettingsPanel.Controls.Add(this.fill_chkbox);
            this.SettingsPanel.Controls.Add(this.textRadio);
            this.SettingsPanel.Controls.Add(this.ellipseRadio);
            this.SettingsPanel.Controls.Add(this.rectRadio);
            this.SettingsPanel.Controls.Add(this.lineRadio);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 24);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(603, 211);
            this.SettingsPanel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PenWidthLabel
            // 
            this.PenWidthLabel.AutoSize = true;
            this.PenWidthLabel.Location = new System.Drawing.Point(437, 22);
            this.PenWidthLabel.Name = "PenWidthLabel";
            this.PenWidthLabel.Size = new System.Drawing.Size(57, 13);
            this.PenWidthLabel.TabIndex = 11;
            this.PenWidthLabel.Text = "Pen Width";
            // 
            // FillColorLabel
            // 
            this.FillColorLabel.AutoSize = true;
            this.FillColorLabel.Location = new System.Drawing.Point(293, 22);
            this.FillColorLabel.Name = "FillColorLabel";
            this.FillColorLabel.Size = new System.Drawing.Size(46, 13);
            this.FillColorLabel.TabIndex = 10;
            this.FillColorLabel.Text = "Fill Color";
            // 
            // PenColorLabel
            // 
            this.PenColorLabel.AutoSize = true;
            this.PenColorLabel.Location = new System.Drawing.Point(185, 22);
            this.PenColorLabel.Name = "PenColorLabel";
            this.PenColorLabel.Size = new System.Drawing.Size(53, 13);
            this.PenColorLabel.TabIndex = 9;
            this.PenColorLabel.Text = "Pen Color";
            // 
            // Draw
            // 
            this.Draw.AutoSize = true;
            this.Draw.Location = new System.Drawing.Point(47, 22);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(32, 13);
            this.Draw.TabIndex = 8;
            this.Draw.Text = "Draw";
            // 
            // FillColor
            // 
            this.FillColor.FormattingEnabled = true;
            this.FillColor.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.FillColor.Location = new System.Drawing.Point(296, 42);
            this.FillColor.Name = "FillColor";
            this.FillColor.Size = new System.Drawing.Size(88, 82);
            this.FillColor.TabIndex = 7;
            this.FillColor.SelectedIndexChanged += new System.EventHandler(this.FillColor_SelectedIndexChanged);
            // 
            // PenWidth
            // 
            this.PenWidth.FormattingEnabled = true;
            this.PenWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.PenWidth.Location = new System.Drawing.Point(440, 42);
            this.PenWidth.Name = "PenWidth";
            this.PenWidth.Size = new System.Drawing.Size(141, 134);
            this.PenWidth.TabIndex = 6;
            this.PenWidth.SelectedIndexChanged += new System.EventHandler(this.PenWidth_SelectedIndexChanged);
            // 
            // PenColor
            // 
            this.PenColor.FormattingEnabled = true;
            this.PenColor.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.PenColor.Location = new System.Drawing.Point(188, 42);
            this.PenColor.Name = "PenColor";
            this.PenColor.Size = new System.Drawing.Size(86, 82);
            this.PenColor.TabIndex = 4;
            this.PenColor.SelectedIndexChanged += new System.EventHandler(this.PenColor_SelectedIndexChanged);
            // 
            // outline_chkbox
            // 
            this.outline_chkbox.AutoSize = true;
            this.outline_chkbox.Location = new System.Drawing.Point(236, 167);
            this.outline_chkbox.Name = "outline_chkbox";
            this.outline_chkbox.Size = new System.Drawing.Size(59, 17);
            this.outline_chkbox.TabIndex = 5;
            this.outline_chkbox.Text = "Outline";
            this.outline_chkbox.UseVisualStyleBackColor = true;
            // 
            // fill_chkbox
            // 
            this.fill_chkbox.AutoSize = true;
            this.fill_chkbox.Location = new System.Drawing.Point(236, 144);
            this.fill_chkbox.Name = "fill_chkbox";
            this.fill_chkbox.Size = new System.Drawing.Size(38, 17);
            this.fill_chkbox.TabIndex = 4;
            this.fill_chkbox.Text = "Fill";
            this.fill_chkbox.UseVisualStyleBackColor = true;
            // 
            // textRadio
            // 
            this.textRadio.AutoSize = true;
            this.textRadio.Location = new System.Drawing.Point(50, 107);
            this.textRadio.Name = "textRadio";
            this.textRadio.Size = new System.Drawing.Size(46, 17);
            this.textRadio.TabIndex = 3;
            this.textRadio.TabStop = true;
            this.textRadio.Text = "Text";
            this.textRadio.UseVisualStyleBackColor = true;
            // 
            // ellipseRadio
            // 
            this.ellipseRadio.AutoSize = true;
            this.ellipseRadio.Location = new System.Drawing.Point(50, 84);
            this.ellipseRadio.Name = "ellipseRadio";
            this.ellipseRadio.Size = new System.Drawing.Size(55, 17);
            this.ellipseRadio.TabIndex = 2;
            this.ellipseRadio.TabStop = true;
            this.ellipseRadio.Text = "Ellipse";
            this.ellipseRadio.UseVisualStyleBackColor = true;
            // 
            // rectRadio
            // 
            this.rectRadio.AutoSize = true;
            this.rectRadio.Location = new System.Drawing.Point(50, 61);
            this.rectRadio.Name = "rectRadio";
            this.rectRadio.Size = new System.Drawing.Size(74, 17);
            this.rectRadio.TabIndex = 1;
            this.rectRadio.TabStop = true;
            this.rectRadio.Text = "Rectangle";
            this.rectRadio.UseVisualStyleBackColor = true;
            // 
            // lineRadio
            // 
            this.lineRadio.AutoSize = true;
            this.lineRadio.Location = new System.Drawing.Point(50, 38);
            this.lineRadio.Name = "lineRadio";
            this.lineRadio.Size = new System.Drawing.Size(45, 17);
            this.lineRadio.TabIndex = 0;
            this.lineRadio.TabStop = true;
            this.lineRadio.Text = "Line";
            this.lineRadio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 2;
            // 
            // DrawPanel
            // 
            this.DrawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawPanel.Location = new System.Drawing.Point(0, 235);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(603, 311);
            this.DrawPanel.TabIndex = 3;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 546);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.RadioButton lineRadio;
        private System.Windows.Forms.RadioButton textRadio;
        private System.Windows.Forms.RadioButton ellipseRadio;
        private System.Windows.Forms.RadioButton rectRadio;
        private System.Windows.Forms.CheckBox outline_chkbox;
        private System.Windows.Forms.CheckBox fill_chkbox;
        private System.Windows.Forms.ListBox PenColor;
        private System.Windows.Forms.ListBox FillColor;
        private System.Windows.Forms.ListBox PenWidth;
        private System.Windows.Forms.Label PenWidthLabel;
        private System.Windows.Forms.Label FillColorLabel;
        private System.Windows.Forms.Label PenColorLabel;
        private System.Windows.Forms.Label Draw;
        private System.Windows.Forms.TextBox textBox1;
    }
}

