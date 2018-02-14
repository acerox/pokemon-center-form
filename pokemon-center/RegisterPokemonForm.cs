using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_center
{
    public partial class RegisterPokemonForm : Form
    {
        // variable local de bbdd con la que nos enlazamos a la real
        private Database database;
        private Movement movement;
         
        public RegisterPokemonForm(Database database)
               
        {
            InitializeComponent();
            //igualamos la bbdd local con la real (que pasamos arriba en el constructor)
            this.database = database;
            movement = new Movement(this);
        }

        private Boolean checkTextBoxes()
        {
            if (textoNombre.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo nombre");
                return false;
            }
            else if (textoGenero.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo género");
                return false;
            }
            else if (textoTipo.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo tipo");
                return false;
            }
            else if (textoRaza.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo raza");
                return false;
            }else if (textoChip.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo chip");
                return false;
            }

            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (checkTextBoxes())
            {
                database.createNewPokemon
                (textoNombre.Text,
                textoGenero.Text,
                textoTipo.Text,
                textoRaza.Text,
               Convert.ToInt32(textoChip.Text));
                MessageBox.Show("Pokemon registrado con éxito");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textoNombre.Text = "";
            textoGenero.Text = "";
            textoTipo.Text = "";
            textoRaza.Text = "";
            textoChip.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            movement.setMouseMovement(e.X, e.Y, true);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            movement.changeWindowPosition();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            movement.setWindowState(false);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Load(Application.StartupPath + "/images/login/button-hover.png");
            label5.ForeColor = Color.White;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Load(Application.StartupPath + "/images/login/button.png");
            label5.ForeColor = Color.Black;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1_MouseEnter(sender, e);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1_MouseLeave(sender, e);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Load(Application.StartupPath + "/images/login/button-hover.png");
            label6.ForeColor = Color.White;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Load(Application.StartupPath + "/images/login/button.png");
            label6.ForeColor = Color.Black;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2_MouseEnter(sender, e);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2_MouseLeave(sender, e);
        }

        private void exitPictureBox_MouseEnter(object sender, EventArgs e)
        {
            exitPictureBox.Load(Application.StartupPath + "/images/exit-hover.png");
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Load(Application.StartupPath + "/images/exit.png");
        }

        private void minimizePictureBox_MouseEnter(object sender, EventArgs e)
        {
            minimizePictureBox.Load(Application.StartupPath + "/images/minimize-hover.png");
        }

        private void minimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            minimizePictureBox.Load(Application.StartupPath + "/images/minimize.png");
        }
    }
}
