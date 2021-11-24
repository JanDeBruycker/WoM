namespace WorldOfMagic
{
    partial class PlayerSelection
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
            this.gpbPlayer = new System.Windows.Forms.GroupBox();
            this.txtPlayerExperience = new System.Windows.Forms.TextBox();
            this.txtPlayerLevel = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pcbAd = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.gpbPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAd)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPlayer
            // 
            this.gpbPlayer.Controls.Add(this.txtPlayerExperience);
            this.gpbPlayer.Controls.Add(this.txtPlayerLevel);
            this.gpbPlayer.Controls.Add(this.txtPlayerName);
            this.gpbPlayer.Location = new System.Drawing.Point(13, 14);
            this.gpbPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbPlayer.Name = "gpbPlayer";
            this.gpbPlayer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbPlayer.Size = new System.Drawing.Size(173, 81);
            this.gpbPlayer.TabIndex = 3;
            this.gpbPlayer.TabStop = false;
            this.gpbPlayer.Text = "Current Game";
            // 
            // txtPlayerExperience
            // 
            this.txtPlayerExperience.Location = new System.Drawing.Point(52, 49);
            this.txtPlayerExperience.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayerExperience.Name = "txtPlayerExperience";
            this.txtPlayerExperience.ReadOnly = true;
            this.txtPlayerExperience.Size = new System.Drawing.Size(113, 22);
            this.txtPlayerExperience.TabIndex = 6;
            // 
            // txtPlayerLevel
            // 
            this.txtPlayerLevel.Location = new System.Drawing.Point(6, 49);
            this.txtPlayerLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayerLevel.Name = "txtPlayerLevel";
            this.txtPlayerLevel.ReadOnly = true;
            this.txtPlayerLevel.Size = new System.Drawing.Size(40, 22);
            this.txtPlayerLevel.TabIndex = 5;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(5, 21);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(160, 22);
            this.txtPlayerName.TabIndex = 4;
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(12, 99);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(174, 35);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 157);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(174, 35);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pcbAd
            // 
            this.pcbAd.BackColor = System.Drawing.Color.Black;
            this.pcbAd.Location = new System.Drawing.Point(200, 12);
            this.pcbAd.Name = "pcbAd";
            this.pcbAd.Size = new System.Drawing.Size(270, 219);
            this.pcbAd.TabIndex = 4;
            this.pcbAd.TabStop = false;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 196);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(174, 35);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // PlayerSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 243);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.pcbAd);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.gpbPlayer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(500, 290);
            this.MinimumSize = new System.Drawing.Size(500, 290);
            this.Name = "PlayerSelection";
            this.Text = "World Of Magic";
            this.Load += new System.EventHandler(this.PlayerSelection_Load);
            this.gpbPlayer.ResumeLayout(false);
            this.gpbPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPlayer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtPlayerExperience;
        private System.Windows.Forms.TextBox txtPlayerLevel;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox pcbAd;
        private System.Windows.Forms.Button btnInfo;
    }
}

