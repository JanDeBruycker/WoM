namespace WorldOfMagic.Interfaces.World
{
    partial class Items
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblItem3 = new System.Windows.Forms.Label();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 131);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(333, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 20);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // lblItem3
            // 
            this.lblItem3.AutoSize = true;
            this.lblItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem3.Location = new System.Drawing.Point(26, 80);
            this.lblItem3.Name = "lblItem3";
            this.lblItem3.Size = new System.Drawing.Size(42, 17);
            this.lblItem3.TabIndex = 16;
            this.lblItem3.Text = "Item3";
            // 
            // lblItem2
            // 
            this.lblItem2.AutoSize = true;
            this.lblItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem2.Location = new System.Drawing.Point(26, 63);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Size = new System.Drawing.Size(42, 17);
            this.lblItem2.TabIndex = 15;
            this.lblItem2.Text = "Item2";
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem1.Location = new System.Drawing.Point(26, 46);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(42, 17);
            this.lblItem1.TabIndex = 14;
            this.lblItem1.Text = "Item1";
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 173);
            this.Controls.Add(this.lblItem3);
            this.Controls.Add(this.lblItem2);
            this.Controls.Add(this.lblItem1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.MaximumSize = new System.Drawing.Size(375, 220);
            this.MinimumSize = new System.Drawing.Size(375, 220);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblItem3;
        private System.Windows.Forms.Label lblItem2;
        private System.Windows.Forms.Label lblItem1;
    }
}