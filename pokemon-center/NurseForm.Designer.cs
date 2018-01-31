namespace pokemon_center
{
    partial class NurseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseForm));
            this.addTrainerLogLabel = new System.Windows.Forms.Button();
            this.textoBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuPrincipal = new System.Windows.Forms.DataGridView();
            this.botonEscucha = new System.Windows.Forms.Button();
            this.backgroundImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.menuPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImg)).BeginInit();
            this.SuspendLayout();
            // 
            // addTrainerLogLabel
            // 
            this.addTrainerLogLabel.Location = new System.Drawing.Point(557, 45);
            this.addTrainerLogLabel.Margin = new System.Windows.Forms.Padding(10);
            this.addTrainerLogLabel.Name = "addTrainerLogLabel";
            this.addTrainerLogLabel.Size = new System.Drawing.Size(83, 28);
            this.addTrainerLogLabel.TabIndex = 2;
            this.addTrainerLogLabel.Text = "Añadir registro";
            this.addTrainerLogLabel.UseVisualStyleBackColor = true;
            this.addTrainerLogLabel.Click += new System.EventHandler(this.addTrainerLogLabel_Click);
            // 
            // textoBuscar
            // 
            this.textoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textoBuscar.Location = new System.Drawing.Point(22, 48);
            this.textoBuscar.Margin = new System.Windows.Forms.Padding(10);
            this.textoBuscar.Multiline = true;
            this.textoBuscar.Name = "textoBuscar";
            this.textoBuscar.Size = new System.Drawing.Size(236, 28);
            this.textoBuscar.TabIndex = 0;
            this.textoBuscar.Text = "Buscar";
            this.textoBuscar.Click += new System.EventHandler(this.textoBuscar_Click);
            this.textoBuscar.TextChanged += new System.EventHandler(this.textoBuscar_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Entrenadores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.trainerButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Pokemons";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.pokemonsButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(190, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Tienda";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuPrincipal.Location = new System.Drawing.Point(18, 110);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(622, 332);
            this.menuPrincipal.TabIndex = 5;
            // 
            // botonEscucha
            // 
            this.botonEscucha.Location = new System.Drawing.Point(459, 48);
            this.botonEscucha.Name = "botonEscucha";
            this.botonEscucha.Size = new System.Drawing.Size(75, 23);
            this.botonEscucha.TabIndex = 6;
            this.botonEscucha.Text = "Escucha";
            this.botonEscucha.UseVisualStyleBackColor = true;
            this.botonEscucha.Click += new System.EventHandler(this.botonEscucha_Click);
            // 
            // backgroundImg
            // 
            this.backgroundImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backgroundImg.Image = ((System.Drawing.Image)(resources.GetObject("backgroundImg.Image")));
            this.backgroundImg.Location = new System.Drawing.Point(-1, -1);
            this.backgroundImg.Name = "backgroundImg";
            this.backgroundImg.Size = new System.Drawing.Size(845, 495);
            this.backgroundImg.TabIndex = 7;
            this.backgroundImg.TabStop = false;
            // 
            // NurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 491);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.botonEscucha);
            this.Controls.Add(this.addTrainerLogLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textoBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backgroundImg);
            this.Name = "NurseForm";
            this.Text = "Panel de control";
            this.Load += new System.EventHandler(this.NurseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addTrainerLogLabel;
        private System.Windows.Forms.TextBox textoBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView menuPrincipal;
        private System.Windows.Forms.Button botonEscucha;
        public System.Windows.Forms.PictureBox backgroundImg;
    }
}