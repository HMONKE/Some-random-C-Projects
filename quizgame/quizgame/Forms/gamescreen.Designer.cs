namespace quizgame.Forms
{
    partial class gamescreen
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
            this.lblnumbers = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnValasz = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblquestion = new System.Windows.Forms.Label();
            this.btnlngGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumbers
            // 
            this.lblnumbers.AutoSize = true;
            this.lblnumbers.Location = new System.Drawing.Point(103, 68);
            this.lblnumbers.Name = "lblnumbers";
            this.lblnumbers.Size = new System.Drawing.Size(35, 13);
            this.lblnumbers.TabIndex = 0;
            this.lblnumbers.Text = "label1";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(522, 232);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Válassz Témakört";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(522, 279);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(121, 20);
            this.txtAnswer.TabIndex = 3;
            // 
            // btnValasz
            // 
            this.btnValasz.Location = new System.Drawing.Point(513, 320);
            this.btnValasz.Name = "btnValasz";
            this.btnValasz.Size = new System.Drawing.Size(130, 25);
            this.btnValasz.TabIndex = 4;
            this.btnValasz.Text = "Ellenőrzés";
            this.btnValasz.UseVisualStyleBackColor = true;
            this.btnValasz.Click += new System.EventHandler(this.btnValasz_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(519, 379);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(35, 13);
            this.lblCheck.TabIndex = 5;
            this.lblCheck.Text = "label2";
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Location = new System.Drawing.Point(318, 263);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(83, 13);
            this.lblquestion.TabIndex = 6;
            this.lblquestion.Text = "Ide jön a kérdés";
            // 
            // btnlngGame
            // 
            this.btnlngGame.Location = new System.Drawing.Point(469, 34);
            this.btnlngGame.Name = "btnlngGame";
            this.btnlngGame.Size = new System.Drawing.Size(173, 98);
            this.btnlngGame.TabIndex = 7;
            this.btnlngGame.Text = "Több kérdéses játék indítása";
            this.btnlngGame.UseVisualStyleBackColor = true;
            this.btnlngGame.Click += new System.EventHandler(this.btnlngGame_Click);
            // 
            // gamescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlngGame);
            this.Controls.Add(this.lblquestion);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.btnValasz);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblnumbers);
            this.Name = "gamescreen";
            this.Text = "gamescreen";
            this.Load += new System.EventHandler(this.gamescreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumbers;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnValasz;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.Button btnlngGame;
    }
}