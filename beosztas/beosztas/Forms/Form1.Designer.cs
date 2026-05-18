namespace beosztas
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
            this.lblalapadatok = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmbTanarok = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.osztályfőnökökToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osztályRészletelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblalapadatok
            // 
            this.lblalapadatok.AutoSize = true;
            this.lblalapadatok.Location = new System.Drawing.Point(33, 33);
            this.lblalapadatok.Name = "lblalapadatok";
            this.lblalapadatok.Size = new System.Drawing.Size(35, 13);
            this.lblalapadatok.TabIndex = 0;
            this.lblalapadatok.Text = "label1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(344, 89);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "label1";
            // 
            // cmbTanarok
            // 
            this.cmbTanarok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTanarok.FormattingEnabled = true;
            this.cmbTanarok.Location = new System.Drawing.Point(347, 40);
            this.cmbTanarok.Name = "cmbTanarok";
            this.cmbTanarok.Size = new System.Drawing.Size(121, 21);
            this.cmbTanarok.TabIndex = 4;
            this.cmbTanarok.SelectedIndexChanged += new System.EventHandler(this.cmbTanarok_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osztályfőnökökToolStripMenuItem,
            this.osztályRészletelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // osztályfőnökökToolStripMenuItem
            // 
            this.osztályfőnökökToolStripMenuItem.Name = "osztályfőnökökToolStripMenuItem";
            this.osztályfőnökökToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.osztályfőnökökToolStripMenuItem.Text = "Osztályfőnökök";
            this.osztályfőnökökToolStripMenuItem.Click += new System.EventHandler(this.osztályfőnökökToolStripMenuItem_Click);
            // 
            // osztályRészletelToolStripMenuItem
            // 
            this.osztályRészletelToolStripMenuItem.Name = "osztályRészletelToolStripMenuItem";
            this.osztályRészletelToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.osztályRészletelToolStripMenuItem.Text = "Osztály részletel";
            this.osztályRészletelToolStripMenuItem.Click += new System.EventHandler(this.osztályRészletelToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTanarok);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblalapadatok);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblalapadatok;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbTanarok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem osztályfőnökökToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osztályRészletelToolStripMenuItem;
    }
}

