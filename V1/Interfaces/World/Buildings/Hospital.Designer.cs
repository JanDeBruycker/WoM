namespace WorldOfMagic
{
    partial class Hospital
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
            this.btnRestoreHP = new System.Windows.Forms.Button();
            this.btnRestoreMoves = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestoreHP
            // 
            this.btnRestoreHP.Location = new System.Drawing.Point(12, 12);
            this.btnRestoreHP.Name = "btnRestoreHP";
            this.btnRestoreHP.Size = new System.Drawing.Size(150, 70);
            this.btnRestoreHP.TabIndex = 0;
            this.btnRestoreHP.Text = "Restore Hitpoints\r\n(Free)";
            this.btnRestoreHP.UseVisualStyleBackColor = true;
            this.btnRestoreHP.Click += new System.EventHandler(this.btnRestoreHP_Click);
            // 
            // btnRestoreMoves
            // 
            this.btnRestoreMoves.Location = new System.Drawing.Point(170, 12);
            this.btnRestoreMoves.Name = "btnRestoreMoves";
            this.btnRestoreMoves.Size = new System.Drawing.Size(150, 70);
            this.btnRestoreMoves.TabIndex = 1;
            this.btnRestoreMoves.Text = "Restore Moves\r\n(Free)";
            this.btnRestoreMoves.UseVisualStyleBackColor = true;
            this.btnRestoreMoves.Click += new System.EventHandler(this.btnRestoreMoves_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 111);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(308, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Leave";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 153);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRestoreMoves);
            this.Controls.Add(this.btnRestoreHP);
            this.MaximumSize = new System.Drawing.Size(350, 200);
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "Hospital";
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Hospital_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestoreHP;
        private System.Windows.Forms.Button btnRestoreMoves;
        private System.Windows.Forms.Button btnClose;
    }
}