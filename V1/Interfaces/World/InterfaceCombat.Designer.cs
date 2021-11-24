namespace WorldOfMagic
{
    partial class InterfaceCombat
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
            this.components = new System.ComponentModel.Container();
            this.pcbPlayerImg = new System.Windows.Forms.PictureBox();
            this.pcbOppImg = new System.Windows.Forms.PictureBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.btnAbility1 = new System.Windows.Forms.Button();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.lblCPUHP = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblCPUName = new System.Windows.Forms.Label();
            this.btnAbility2 = new System.Windows.Forms.Button();
            this.btnAbility3 = new System.Windows.Forms.Button();
            this.btnAbility4 = new System.Windows.Forms.Button();
            this.btnCPUAttack = new System.Windows.Forms.Button();
            this.btnEscape = new System.Windows.Forms.Button();
            this.pcbItem1 = new System.Windows.Forms.PictureBox();
            this.pcbItem2 = new System.Windows.Forms.PictureBox();
            this.pcbItem3 = new System.Windows.Forms.PictureBox();
            this.lblPlayerLevel = new System.Windows.Forms.Label();
            this.lblCPULevel = new System.Windows.Forms.Label();
            this.tmrPlayerAnimation = new System.Windows.Forms.Timer(this.components);
            this.pcbAnimation = new System.Windows.Forms.PictureBox();
            this.tmrOpponentAnimation = new System.Windows.Forms.Timer(this.components);
            this.tmrSpeech = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOppImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPlayerImg
            // 
            this.pcbPlayerImg.Location = new System.Drawing.Point(12, 164);
            this.pcbPlayerImg.Name = "pcbPlayerImg";
            this.pcbPlayerImg.Size = new System.Drawing.Size(107, 118);
            this.pcbPlayerImg.TabIndex = 0;
            this.pcbPlayerImg.TabStop = false;
            // 
            // pcbOppImg
            // 
            this.pcbOppImg.Location = new System.Drawing.Point(204, 12);
            this.pcbOppImg.Name = "pcbOppImg";
            this.pcbOppImg.Size = new System.Drawing.Size(107, 118);
            this.pcbOppImg.TabIndex = 1;
            this.pcbOppImg.TabStop = false;
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(12, 136);
            this.txtAction.Name = "txtAction";
            this.txtAction.ReadOnly = true;
            this.txtAction.Size = new System.Drawing.Size(299, 22);
            this.txtAction.TabIndex = 2;
            this.txtAction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAbility1
            // 
            this.btnAbility1.BackColor = System.Drawing.Color.White;
            this.btnAbility1.ForeColor = System.Drawing.Color.Black;
            this.btnAbility1.Location = new System.Drawing.Point(125, 210);
            this.btnAbility1.Name = "btnAbility1";
            this.btnAbility1.Size = new System.Drawing.Size(95, 50);
            this.btnAbility1.TabIndex = 3;
            this.btnAbility1.Text = "Ability 1";
            this.btnAbility1.UseVisualStyleBackColor = false;
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHP.Location = new System.Drawing.Point(122, 182);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(109, 25);
            this.lblPlayerHP.TabIndex = 4;
            this.lblPlayerHP.Text = "HP: ??/??";
            // 
            // lblCPUHP
            // 
            this.lblCPUHP.AutoSize = true;
            this.lblCPUHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUHP.Location = new System.Drawing.Point(86, 105);
            this.lblCPUHP.Name = "lblCPUHP";
            this.lblCPUHP.Size = new System.Drawing.Size(109, 25);
            this.lblCPUHP.TabIndex = 5;
            this.lblCPUHP.Text = "HP: ??/??";
            this.lblCPUHP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(125, 164);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(99, 18);
            this.lblPlayerName.TabIndex = 6;
            this.lblPlayerName.Text = "PlayerName";
            // 
            // lblCPUName
            // 
            this.lblCPUName.AutoSize = true;
            this.lblCPUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUName.Location = new System.Drawing.Point(12, 87);
            this.lblCPUName.Name = "lblCPUName";
            this.lblCPUName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCPUName.Size = new System.Drawing.Size(35, 18);
            this.lblCPUName.TabIndex = 7;
            this.lblCPUName.Text = "???";
            this.lblCPUName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAbility2
            // 
            this.btnAbility2.BackColor = System.Drawing.Color.White;
            this.btnAbility2.Location = new System.Drawing.Point(225, 210);
            this.btnAbility2.Name = "btnAbility2";
            this.btnAbility2.Size = new System.Drawing.Size(95, 50);
            this.btnAbility2.TabIndex = 8;
            this.btnAbility2.Text = "Ability 2";
            this.btnAbility2.UseVisualStyleBackColor = false;
            // 
            // btnAbility3
            // 
            this.btnAbility3.BackColor = System.Drawing.Color.White;
            this.btnAbility3.Location = new System.Drawing.Point(125, 264);
            this.btnAbility3.Name = "btnAbility3";
            this.btnAbility3.Size = new System.Drawing.Size(95, 50);
            this.btnAbility3.TabIndex = 9;
            this.btnAbility3.Text = "Ability 3";
            this.btnAbility3.UseVisualStyleBackColor = false;
            // 
            // btnAbility4
            // 
            this.btnAbility4.BackColor = System.Drawing.Color.White;
            this.btnAbility4.Location = new System.Drawing.Point(225, 264);
            this.btnAbility4.Name = "btnAbility4";
            this.btnAbility4.Size = new System.Drawing.Size(95, 50);
            this.btnAbility4.TabIndex = 10;
            this.btnAbility4.Text = "Ability 4";
            this.btnAbility4.UseVisualStyleBackColor = false;
            // 
            // btnCPUAttack
            // 
            this.btnCPUAttack.BackColor = System.Drawing.Color.White;
            this.btnCPUAttack.Location = new System.Drawing.Point(12, 12);
            this.btnCPUAttack.Name = "btnCPUAttack";
            this.btnCPUAttack.Size = new System.Drawing.Size(186, 66);
            this.btnCPUAttack.TabIndex = 11;
            this.btnCPUAttack.Text = "Attack";
            this.btnCPUAttack.UseVisualStyleBackColor = false;
            // 
            // btnEscape
            // 
            this.btnEscape.BackColor = System.Drawing.Color.White;
            this.btnEscape.Location = new System.Drawing.Point(170, 320);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(150, 30);
            this.btnEscape.TabIndex = 15;
            this.btnEscape.Text = "Escape";
            this.btnEscape.UseVisualStyleBackColor = false;
            // 
            // pcbItem1
            // 
            this.pcbItem1.BackColor = System.Drawing.Color.White;
            this.pcbItem1.Location = new System.Drawing.Point(12, 288);
            this.pcbItem1.Name = "pcbItem1";
            this.pcbItem1.Size = new System.Drawing.Size(30, 30);
            this.pcbItem1.TabIndex = 16;
            this.pcbItem1.TabStop = false;
            // 
            // pcbItem2
            // 
            this.pcbItem2.BackColor = System.Drawing.Color.White;
            this.pcbItem2.Location = new System.Drawing.Point(48, 288);
            this.pcbItem2.Name = "pcbItem2";
            this.pcbItem2.Size = new System.Drawing.Size(30, 30);
            this.pcbItem2.TabIndex = 17;
            this.pcbItem2.TabStop = false;
            // 
            // pcbItem3
            // 
            this.pcbItem3.BackColor = System.Drawing.Color.White;
            this.pcbItem3.Location = new System.Drawing.Point(84, 288);
            this.pcbItem3.Name = "pcbItem3";
            this.pcbItem3.Size = new System.Drawing.Size(30, 30);
            this.pcbItem3.TabIndex = 18;
            this.pcbItem3.TabStop = false;
            // 
            // lblPlayerLevel
            // 
            this.lblPlayerLevel.AutoSize = true;
            this.lblPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerLevel.Location = new System.Drawing.Point(262, 187);
            this.lblPlayerLevel.Name = "lblPlayerLevel";
            this.lblPlayerLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPlayerLevel.Size = new System.Drawing.Size(52, 18);
            this.lblPlayerLevel.TabIndex = 19;
            this.lblPlayerLevel.Text = "Lvl 01";
            this.lblPlayerLevel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCPULevel
            // 
            this.lblCPULevel.AutoSize = true;
            this.lblCPULevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPULevel.Location = new System.Drawing.Point(12, 110);
            this.lblCPULevel.Name = "lblCPULevel";
            this.lblCPULevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCPULevel.Size = new System.Drawing.Size(52, 18);
            this.lblCPULevel.TabIndex = 20;
            this.lblCPULevel.Text = "Lvl 00";
            // 
            // tmrPlayerAnimation
            // 
            this.tmrPlayerAnimation.Interval = 20;
            this.tmrPlayerAnimation.Tick += new System.EventHandler(this.tmrPlayerAnimation_Tick);
            // 
            // pcbAnimation
            // 
            this.pcbAnimation.Location = new System.Drawing.Point(2, 326);
            this.pcbAnimation.Name = "pcbAnimation";
            this.pcbAnimation.Size = new System.Drawing.Size(25, 25);
            this.pcbAnimation.TabIndex = 21;
            this.pcbAnimation.TabStop = false;
            // 
            // tmrOpponentAnimation
            // 
            this.tmrOpponentAnimation.Interval = 20;
            this.tmrOpponentAnimation.Tick += new System.EventHandler(this.tmrOpponentAnimation_Tick);
            // 
            // tmrSpeech
            // 
            this.tmrSpeech.Interval = 90;
            this.tmrSpeech.Tick += new System.EventHandler(this.tmrSpeech_Tick);
            // 
            // InterfaceCombat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 353);
            this.ControlBox = false;
            this.Controls.Add(this.pcbAnimation);
            this.Controls.Add(this.lblCPULevel);
            this.Controls.Add(this.lblPlayerLevel);
            this.Controls.Add(this.pcbItem3);
            this.Controls.Add(this.pcbItem2);
            this.Controls.Add(this.pcbItem1);
            this.Controls.Add(this.btnEscape);
            this.Controls.Add(this.btnCPUAttack);
            this.Controls.Add(this.btnAbility4);
            this.Controls.Add(this.btnAbility3);
            this.Controls.Add(this.btnAbility2);
            this.Controls.Add(this.lblCPUName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblCPUHP);
            this.Controls.Add(this.lblPlayerHP);
            this.Controls.Add(this.btnAbility1);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.pcbOppImg);
            this.Controls.Add(this.pcbPlayerImg);
            this.Location = new System.Drawing.Point(341, 378);
            this.MaximumSize = new System.Drawing.Size(341, 400);
            this.MinimumSize = new System.Drawing.Size(341, 378);
            this.Name = "InterfaceCombat";
            this.Text = "InterfaceCombat";
            this.Load += new System.EventHandler(this.InterfaceCombat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InterfaceCombat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayerImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOppImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPlayerImg;
        private System.Windows.Forms.PictureBox pcbOppImg;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.Button btnAbility1;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label lblCPUHP;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblCPUName;
        private System.Windows.Forms.Button btnAbility2;
        private System.Windows.Forms.Button btnAbility3;
        private System.Windows.Forms.Button btnAbility4;
        private System.Windows.Forms.Button btnCPUAttack;
        private System.Windows.Forms.Button btnEscape;
        private System.Windows.Forms.PictureBox pcbItem1;
        private System.Windows.Forms.PictureBox pcbItem2;
        private System.Windows.Forms.PictureBox pcbItem3;
        private System.Windows.Forms.Label lblPlayerLevel;
        private System.Windows.Forms.Label lblCPULevel;
        private System.Windows.Forms.Timer tmrPlayerAnimation;
        private System.Windows.Forms.PictureBox pcbAnimation;
        private System.Windows.Forms.Timer tmrOpponentAnimation;
        private System.Windows.Forms.Timer tmrSpeech;
    }
}