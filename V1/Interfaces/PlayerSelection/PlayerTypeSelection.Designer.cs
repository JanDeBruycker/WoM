namespace WorldOfMagic.Interfaces.PlayerSelection
{
    partial class PlayerTypeSelection
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
            this.gpbPlayerType = new System.Windows.Forms.GroupBox();
            this.rdbNoType = new System.Windows.Forms.RadioButton();
            this.rdbArcane = new System.Windows.Forms.RadioButton();
            this.rdbFrost = new System.Windows.Forms.RadioButton();
            this.rdbFire = new System.Windows.Forms.RadioButton();
            this.btnSelectType = new System.Windows.Forms.Button();
            this.gpbPlayerType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPlayerType
            // 
            this.gpbPlayerType.Controls.Add(this.rdbFire);
            this.gpbPlayerType.Controls.Add(this.rdbFrost);
            this.gpbPlayerType.Controls.Add(this.rdbArcane);
            this.gpbPlayerType.Controls.Add(this.rdbNoType);
            this.gpbPlayerType.Location = new System.Drawing.Point(12, 12);
            this.gpbPlayerType.Name = "gpbPlayerType";
            this.gpbPlayerType.Size = new System.Drawing.Size(298, 98);
            this.gpbPlayerType.TabIndex = 0;
            this.gpbPlayerType.TabStop = false;
            this.gpbPlayerType.Text = "Type Selection";
            // 
            // rdbNoType
            // 
            this.rdbNoType.AutoSize = true;
            this.rdbNoType.Location = new System.Drawing.Point(15, 30);
            this.rdbNoType.Name = "rdbNoType";
            this.rdbNoType.Size = new System.Drawing.Size(95, 21);
            this.rdbNoType.TabIndex = 0;
            this.rdbNoType.TabStop = true;
            this.rdbNoType.Text = "TypeNone";
            this.rdbNoType.UseVisualStyleBackColor = true;
            // 
            // rdbArcane
            // 
            this.rdbArcane.AutoSize = true;
            this.rdbArcane.Location = new System.Drawing.Point(164, 30);
            this.rdbArcane.Name = "rdbArcane";
            this.rdbArcane.Size = new System.Drawing.Size(106, 21);
            this.rdbArcane.TabIndex = 1;
            this.rdbArcane.TabStop = true;
            this.rdbArcane.Text = "TypeArcane";
            this.rdbArcane.UseVisualStyleBackColor = true;
            // 
            // rdbFrost
            // 
            this.rdbFrost.AutoSize = true;
            this.rdbFrost.Location = new System.Drawing.Point(15, 60);
            this.rdbFrost.Name = "rdbFrost";
            this.rdbFrost.Size = new System.Drawing.Size(93, 21);
            this.rdbFrost.TabIndex = 2;
            this.rdbFrost.TabStop = true;
            this.rdbFrost.Text = "TypeFrost";
            this.rdbFrost.UseVisualStyleBackColor = true;
            // 
            // rdbFire
            // 
            this.rdbFire.AutoSize = true;
            this.rdbFire.Location = new System.Drawing.Point(164, 60);
            this.rdbFire.Name = "rdbFire";
            this.rdbFire.Size = new System.Drawing.Size(85, 21);
            this.rdbFire.TabIndex = 3;
            this.rdbFire.TabStop = true;
            this.rdbFire.Text = "TypeFire";
            this.rdbFire.UseVisualStyleBackColor = true;
            // 
            // btnSelectType
            // 
            this.btnSelectType.Location = new System.Drawing.Point(12, 116);
            this.btnSelectType.Name = "btnSelectType";
            this.btnSelectType.Size = new System.Drawing.Size(298, 35);
            this.btnSelectType.TabIndex = 1;
            this.btnSelectType.Text = "Select Player Type";
            this.btnSelectType.UseVisualStyleBackColor = true;
            this.btnSelectType.Click += new System.EventHandler(this.btnSelectType_Click);
            // 
            // PlayerTypeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 163);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelectType);
            this.Controls.Add(this.gpbPlayerType);
            this.Name = "PlayerTypeSelection";
            this.Text = "Type Selection";
            this.Load += new System.EventHandler(this.PlayerTypeSelection_Load);
            this.gpbPlayerType.ResumeLayout(false);
            this.gpbPlayerType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPlayerType;
        private System.Windows.Forms.RadioButton rdbFire;
        private System.Windows.Forms.RadioButton rdbFrost;
        private System.Windows.Forms.RadioButton rdbArcane;
        private System.Windows.Forms.RadioButton rdbNoType;
        private System.Windows.Forms.Button btnSelectType;
    }
}