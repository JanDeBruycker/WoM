namespace WorldOfMagic
{
    partial class ItemShop
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
            this.btnItem1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnItem2 = new System.Windows.Forms.Button();
            this.pcbItem1 = new System.Windows.Forms.PictureBox();
            this.pcbItem2 = new System.Windows.Forms.PictureBox();
            this.pcbItem3 = new System.Windows.Forms.PictureBox();
            this.btnItem3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItem1
            // 
            this.btnItem1.Location = new System.Drawing.Point(12, 101);
            this.btnItem1.Name = "btnItem1";
            this.btnItem1.Size = new System.Drawing.Size(95, 50);
            this.btnItem1.TabIndex = 0;
            this.btnItem1.Text = "Item\r\n(Price)";
            this.btnItem1.UseVisualStyleBackColor = true;
            this.btnItem1.Click += new System.EventHandler(this.btnItem1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(297, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Leave";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnItem2
            // 
            this.btnItem2.Location = new System.Drawing.Point(113, 101);
            this.btnItem2.Name = "btnItem2";
            this.btnItem2.Size = new System.Drawing.Size(95, 50);
            this.btnItem2.TabIndex = 4;
            this.btnItem2.Text = "Item\r\n(Price)";
            this.btnItem2.UseVisualStyleBackColor = true;
            this.btnItem2.Click += new System.EventHandler(this.btnItem2_Click);
            // 
            // pcbItem1
            // 
            this.pcbItem1.Location = new System.Drawing.Point(12, 12);
            this.pcbItem1.Name = "pcbItem1";
            this.pcbItem1.Size = new System.Drawing.Size(95, 83);
            this.pcbItem1.TabIndex = 5;
            this.pcbItem1.TabStop = false;
            // 
            // pcbItem2
            // 
            this.pcbItem2.Location = new System.Drawing.Point(113, 12);
            this.pcbItem2.Name = "pcbItem2";
            this.pcbItem2.Size = new System.Drawing.Size(95, 83);
            this.pcbItem2.TabIndex = 6;
            this.pcbItem2.TabStop = false;
            // 
            // pcbItem3
            // 
            this.pcbItem3.Location = new System.Drawing.Point(214, 12);
            this.pcbItem3.Name = "pcbItem3";
            this.pcbItem3.Size = new System.Drawing.Size(95, 83);
            this.pcbItem3.TabIndex = 7;
            this.pcbItem3.TabStop = false;
            // 
            // btnItem3
            // 
            this.btnItem3.Location = new System.Drawing.Point(214, 101);
            this.btnItem3.Name = "btnItem3";
            this.btnItem3.Size = new System.Drawing.Size(95, 50);
            this.btnItem3.TabIndex = 8;
            this.btnItem3.Text = "Item\r\n(Price)";
            this.btnItem3.UseVisualStyleBackColor = true;
            this.btnItem3.Click += new System.EventHandler(this.btnItem3_Click);
            // 
            // ItemShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 272);
            this.ControlBox = false;
            this.Controls.Add(this.btnItem3);
            this.Controls.Add(this.pcbItem3);
            this.Controls.Add(this.pcbItem2);
            this.Controls.Add(this.pcbItem1);
            this.Controls.Add(this.btnItem2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnItem1);
            this.MaximumSize = new System.Drawing.Size(339, 319);
            this.MinimumSize = new System.Drawing.Size(339, 319);
            this.Name = "ItemShop";
            this.Text = "ItemShop";
            this.Load += new System.EventHandler(this.ItemShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItem1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnItem2;
        private System.Windows.Forms.PictureBox pcbItem1;
        private System.Windows.Forms.PictureBox pcbItem2;
        private System.Windows.Forms.PictureBox pcbItem3;
        private System.Windows.Forms.Button btnItem3;
    }
}