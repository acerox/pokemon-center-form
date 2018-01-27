namespace pokemon_center
{
    partial class RegisterNurseForm
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
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.centerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordConfirmBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pokemonCenterIdLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(43, 57);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(150, 20);
            this.usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(43, 156);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(150, 20);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // centerComboBox
            // 
            this.centerComboBox.DropDownWidth = 150;
            this.centerComboBox.FormattingEnabled = true;
            this.centerComboBox.Items.AddRange(new object[] {
            "Ciudad Verde",
            "Pueblo Paleta"});
            this.centerComboBox.Location = new System.Drawing.Point(43, 106);
            this.centerComboBox.Name = "centerComboBox";
            this.centerComboBox.Size = new System.Drawing.Size(150, 21);
            this.centerComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de usuario";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(40, 140);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Contraseña";
            // 
            // passwordConfirmBox
            // 
            this.passwordConfirmBox.Location = new System.Drawing.Point(43, 205);
            this.passwordConfirmBox.Name = "passwordConfirmBox";
            this.passwordConfirmBox.Size = new System.Drawing.Size(150, 20);
            this.passwordConfirmBox.TabIndex = 5;
            this.passwordConfirmBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirma la contraseña";
            // 
            // pokemonCenterIdLabel
            // 
            this.pokemonCenterIdLabel.AutoSize = true;
            this.pokemonCenterIdLabel.Location = new System.Drawing.Point(40, 90);
            this.pokemonCenterIdLabel.Name = "pokemonCenterIdLabel";
            this.pokemonCenterIdLabel.Size = new System.Drawing.Size(85, 13);
            this.pokemonCenterIdLabel.TabIndex = 7;
            this.pokemonCenterIdLabel.Text = "Centro pokemon";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(130, 241);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(63, 23);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Registrar";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButtonClick);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(61, 241);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(63, 23);
            this.cleanButton.TabIndex = 9;
            this.cleanButton.Text = "Limpiar";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButtonClick);
            // 
            // RegisterNurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 307);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.pokemonCenterIdLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordConfirmBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.centerComboBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RegisterNurseForm";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.ComboBox centerComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordConfirmBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pokemonCenterIdLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cleanButton;
    }
}