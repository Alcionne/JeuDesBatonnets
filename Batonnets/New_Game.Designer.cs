namespace Batonnets
{
    partial class New_Game
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.radioJ2 = new System.Windows.Forms.RadioButton();
            this.radioJ1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValider);
            this.groupBox1.Controls.Add(this.radioJ2);
            this.groupBox1.Controls.Add(this.radioJ1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qui commence ?";
            // 
            // btnValider
            // 
            this.btnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnValider.Location = new System.Drawing.Point(101, 80);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(106, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // radioJ2
            // 
            this.radioJ2.AutoSize = true;
            this.radioJ2.Location = new System.Drawing.Point(193, 41);
            this.radioJ2.Name = "radioJ2";
            this.radioJ2.Size = new System.Drawing.Size(66, 17);
            this.radioJ2.TabIndex = 1;
            this.radioJ2.TabStop = true;
            this.radioJ2.Text = "Joueur 2";
            this.radioJ2.UseVisualStyleBackColor = true;
            this.radioJ2.CheckedChanged += new System.EventHandler(this.radioJ2_CheckedChanged);
            // 
            // radioJ1
            // 
            this.radioJ1.AutoSize = true;
            this.radioJ1.Location = new System.Drawing.Point(45, 41);
            this.radioJ1.Name = "radioJ1";
            this.radioJ1.Size = new System.Drawing.Size(66, 17);
            this.radioJ1.TabIndex = 0;
            this.radioJ1.TabStop = true;
            this.radioJ1.Text = "Joueur 1";
            this.radioJ1.UseVisualStyleBackColor = true;
            this.radioJ1.CheckedChanged += new System.EventHandler(this.radioJ1_CheckedChanged);
            // 
            // New_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 146);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "New_Game";
            this.Text = "Nouvelle partie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioJ2;
        private System.Windows.Forms.RadioButton radioJ1;
        private System.Windows.Forms.Button btnValider;
    }
}