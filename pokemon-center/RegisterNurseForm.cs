using MySql.Data.MySqlClient;
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
    public partial class RegisterNurseForm : Form
    {
        private Database database;
        private Movement movement;

        public RegisterNurseForm(Database database)
        {
            InitializeComponent();
            this.database = database;
            movement = new Movement(this);
        }

        private Int32 getPokemonCenterId()
        {
            switch(centerComboBox.Text)
            {
                case "Ciudad Verde":
                    return 1;
                case "Pueblo Paleta":
                    return 2;
            }

            return 0;
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
            if (!checkTextboxs())
            {
                registNewUser();
            }
        }

        private void registNewUser()
        {
            try
            {
                database.createNewNurse(usernameBox.Text, getPokemonCenterId(), passwordBox.Text);
                MessageBox.Show("Nuevo usuario registrado");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ha sido posible registrar al nuevo usuario" + ex.ToString());

            }   
        }

        private Boolean checkTextboxs()
        {
            Boolean errorTextBox = false;

            if (usernameBox.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena el campo usuario");
                errorTextBox = true;

            }
            else if (centerComboBox.Text.Equals(""))
            {
                MessageBox.Show("Debes escoger un centro en el que te encuentras");
                errorTextBox = true;
            }
            else if (!passwordBox.Text.Equals(passwordConfirmBox.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                errorTextBox = true;
            }

            return errorTextBox;
        }

        private void cleanButtonClick(object sender, EventArgs e)
        {
            usernameBox.Text        = "";
            centerComboBox.Text     = "";
            passwordBox.Text        = "";
            passwordConfirmBox.Text = "";
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            usernameBox.Text = "";
            centerComboBox.Text = "";
            passwordBox.Text = "";
            passwordConfirmBox.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!checkTextboxs())
            {
                registNewUser();
            }
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }

        private void cleanLabel_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }
    }
}
