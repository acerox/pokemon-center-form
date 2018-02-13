namespace pokemon_center
{
    partial class RegisterPokemonForm
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
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.textoGenero = new System.Windows.Forms.TextBox();
            this.textoTipo = new System.Windows.Forms.TextBox();
            this.textoRaza = new System.Windows.Forms.TextBox();
            this.textoChip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.botonRegistroPokemon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(38, 61);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(150, 20);
            this.textoNombre.TabIndex = 0;
            // 
            // textoGenero
            // 
            this.textoGenero.Location = new System.Drawing.Point(38, 100);
            this.textoGenero.Name = "textoGenero";
            this.textoGenero.Size = new System.Drawing.Size(150, 20);
            this.textoGenero.TabIndex = 1;
            // 
            // textoTipo
            // 
            this.textoTipo.Location = new System.Drawing.Point(38, 139);
            this.textoTipo.Name = "textoTipo";
            this.textoTipo.Size = new System.Drawing.Size(150, 20);
            this.textoTipo.TabIndex = 2;
            // 
            // textoRaza
            // 
            this.textoRaza.Location = new System.Drawing.Point(38, 178);
            this.textoRaza.Name = "textoRaza";
            this.textoRaza.Size = new System.Drawing.Size(150, 20);
            this.textoRaza.TabIndex = 3;
            // 
            // textoChip
            // 
            this.textoChip.Location = new System.Drawing.Point(38, 217);
            this.textoChip.Name = "textoChip";
            this.textoChip.Size = new System.Drawing.Size(150, 20);
            this.textoChip.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Raza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chip";
            // 
            // botonRegistroPokemon
            // 
            this.botonRegistroPokemon.Location = new System.Drawing.Point(113, 243);
            this.botonRegistroPokemon.Name = "botonRegistroPokemon";
            this.botonRegistroPokemon.Size = new System.Drawing.Size(75, 23);
            this.botonRegistroPokemon.TabIndex = 10;
            this.botonRegistroPokemon.Text = "Registrar";
            this.botonRegistroPokemon.UseVisualStyleBackColor = true;
            this.botonRegistroPokemon.Click += new System.EventHandler(this.botonRegistroPokemon_Click);
            // 
            // RegisterPokemonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.botonRegistroPokemon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoChip);
            this.Controls.Add(this.textoRaza);
            this.Controls.Add(this.textoTipo);
            this.Controls.Add(this.textoGenero);
            this.Controls.Add(this.textoNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterPokemonForm";
            this.Text = "Nuevo pokemon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.TextBox textoGenero;
        private System.Windows.Forms.TextBox textoTipo;
        private System.Windows.Forms.TextBox textoRaza;
        private System.Windows.Forms.TextBox textoChip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonRegistroPokemon;
    }
}