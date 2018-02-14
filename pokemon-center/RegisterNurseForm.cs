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

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Load(Application.StartupPath + "/images/login/button-hover.png");
            pictureBox2.ForeColor = Color.White;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Load(Application.StartupPath + "/images/login/button.png");
            pictureBox2.ForeColor = Color.Black;
        }

        private void registerLabel_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2_MouseEnter(sender, e);
        }

        private void registerLabel_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2_MouseLeave(sender, e);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Load(Application.StartupPath + "/images/login/button-hover.png");
            pictureBox1.ForeColor = Color.White;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Load(Application.StartupPath + "/images/login/button.png");
            pictureBox1.ForeColor = Color.Black;
        }

        private void cleanLabel_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1_MouseEnter(sender, e);
        }

        private void cleanLabel_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2_MouseLeave(sender, e);
        }
    }
}
