namespace WorldOfMagic
{
    partial class MagicShopAbilitySelector
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
            this.rbtnAbility1 = new System.Windows.Forms.RadioButton();
            this.rbtnAbility2 = new System.Windows.Forms.RadioButton();
            this.rbtnAbility4 = new System.Windows.Forms.RadioButton();
            this.rbtnAbility3 = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gpbAbilites = new System.Windows.Forms.GroupBox();
            this.gpbAbilites.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnAbility1
            // 
            this.rbtnAbility1.AutoSize = true;
            this.rbtnAbility1.Location = new System.Drawing.Point(6, 21);
            this.rbtnAbility1.Name = "rbtnAbility1";
            this.rbtnAbility1.Size = new System.Drawing.Size(111, 21);
            this.rbtnAbility1.TabIndex = 0;
            this.rbtnAbility1.TabStop = true;
            this.rbtnAbility1.Text = "Ability1Name";
            this.rbtnAbility1.UseVisualStyleBackColor = true;
            // 
            // rbtnAbility2
            // 
            this.rbtnAbility2.AutoSize = true;
            this.rbtnAbility2.Location = new System.Drawing.Point(181, 21);
            this.rbtnAbility2.Name = "rbtnAbility2";
            this.rbtnAbility2.Size = new System.Drawing.Size(111, 21);
            this.rbtnAbility2.TabIndex = 1;
            this.rbtnAbility2.TabStop = true;
            this.rbtnAbility2.Text = "Ability2Name";
            this.rbtnAbility2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnAbility2.UseVisualStyleBackColor = true;
            // 
            // rbtnAbility4
            // 
            this.rbtnAbility4.AutoSize = true;
            this.rbtnAbility4.Location = new System.Drawing.Point(181, 48);
            this.rbtnAbility4.Name = "rbtnAbility4";
            this.rbtnAbility4.Size = new System.Drawing.Size(111, 21);
            this.rbtnAbility4.TabIndex = 2;
            this.rbtnAbility4.TabStop = true;
            this.rbtnAbility4.Text = "Ability4Name";
            this.rbtnAbility4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnAbility4.UseVisualStyleBackColor = true;
            // 
            // rbtnAbility3
            // 
            this.rbtnAbility3.AutoSize = true;
            this.rbtnAbility3.Location = new System.Drawing.Point(6, 48);
            this.rbtnAbility3.Name = "rbtnAbility3";
            this.rbtnAbility3.Size = new System.Drawing.Size(111, 21);
            this.rbtnAbility3.TabIndex = 3;
            this.rbtnAbility3.TabStop = true;
            this.rbtnAbility3.Text = "Ability3Name";
            this.rbtnAbility3.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 96);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(298, 30);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gpbAbilites
            // 
            this.gpbAbilites.Controls.Add(this.rbtnAbility1);
            this.gpbAbilites.Controls.Add(this.rbtnAbility2);
            this.gpbAbilites.Controls.Add(this.rbtnAbility4);
            this.gpbAbilites.Controls.Add(this.rbtnAbility3);
            this.gpbAbilites.Location = new System.Drawing.Point(12, 12);
            this.gpbAbilites.Name = "gpbAbilites";
            this.gpbAbilites.Size = new System.Drawing.Size(298, 80);
            this.gpbAbilites.TabIndex = 5;
            this.gpbAbilites.TabStop = false;
            this.gpbAbilites.Text = "Abilities";
            // 
            // MagicShopAbilitySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 138);
            this.ControlBox = false;
            this.Controls.Add(this.gpbAbilites);
            this.Controls.Add(this.btnSelect);
            this.MaximumSize = new System.Drawing.Size(345, 185);
            this.MinimumSize = new System.Drawing.Size(345, 185);
            this.Name = "MagicShopAbilitySelector";
            this.Text = "MagicShopAbilitySelector";
            this.Load += new System.EventHandler(this.MagicShopAbilitySelector_Load);
            this.gpbAbilites.ResumeLayout(false);
            this.gpbAbilites.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnAbility1;
        private System.Windows.Forms.RadioButton rbtnAbility2;
        private System.Windows.Forms.RadioButton rbtnAbility4;
        private System.Windows.Forms.RadioButton rbtnAbility3;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox gpbAbilites;
    }
}