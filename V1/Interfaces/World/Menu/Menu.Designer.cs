namespace WorldOfMagic
{
    partial class Menu
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnShowStats = new System.Windows.Forms.Button();
            this.btnShowItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 291);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(308, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Return to Game";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 124);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(308, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 170);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(308, 40);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Last Save";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 216);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(308, 40);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnShowStats
            // 
            this.btnShowStats.Location = new System.Drawing.Point(12, 12);
            this.btnShowStats.Name = "btnShowStats";
            this.btnShowStats.Size = new System.Drawing.Size(308, 40);
            this.btnShowStats.TabIndex = 1;
            this.btnShowStats.Text = "Stats";
            this.btnShowStats.UseVisualStyleBackColor = true;
            this.btnShowStats.Click += new System.EventHandler(this.btnShowStats_Click);
            // 
            // btnShowItems
            // 
            this.btnShowItems.Location = new System.Drawing.Point(12, 58);
            this.btnShowItems.Name = "btnShowItems";
            this.btnShowItems.Size = new System.Drawing.Size(308, 40);
            this.btnShowItems.TabIndex = 2;
            this.btnShowItems.Text = "Items";
            this.btnShowItems.UseVisualStyleBackColor = true;
            this.btnShowItems.Click += new System.EventHandler(this.btnShowItems_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 333);
            this.ControlBox = false;
            this.Controls.Add(this.btnShowItems);
            this.Controls.Add(this.btnShowStats);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.MaximumSize = new System.Drawing.Size(350, 380);
            this.MinimumSize = new System.Drawing.Size(350, 380);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnShowStats;
        private System.Windows.Forms.Button btnShowItems;
    }
}