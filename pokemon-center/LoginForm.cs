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
    public partial class LoginForm : Form
    {
        // Movimientos de la ventana
        private int mousePositionX;
        private int mousePositionY;
        public bool windowMovement = false;
        
        // Base de datos
        private Database database;

        public LoginForm(Database database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void RegisterLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterNurseForm(database).Show();
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
            this.mousePositionX = e.X;
            this.mousePositionY = e.Y;
            this.windowMovement = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (windowMovement)
            {
                this.Location =
                    this.PointToScreen(new Point(
                        Cursor.Position.X - this.Location.X - mousePositionX, 
                        Cursor.Position.Y - this.Location.Y - mousePositionY
                    ));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            windowMovement = false;
        }

        private void exitPictureBox_MouseHover(object sender, EventArgs e)
        {
            exitPictureBox.Load(Application.StartupPath + "/images/exit-hover.png");
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Load(Application.StartupPath + "/images/exit.png");
        }

        private void minimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            minimizePictureBox.Load(Application.StartupPath + "/images/minimize.png");
        }

        private void minimizePictureBox_MouseHover(object sender, EventArgs e)
        {
            minimizePictureBox.Load(Application.StartupPath + "/images/minimize-hover.png");
        }

        private void connectPictureBox_Click(object sender, EventArgs e)
        {
            if (database.existUser(usernameBox.Text, passwordBox.Text))
            {
                this.Hide();
                new NurseForm(database).Show();
            }
            else
            {
                MessageBox.Show("El usuario y/o la contraseña son incorrectos o no existen en el servidor");
            }
        }

        private void registerPictureBox_Click(object sender, EventArgs e)
        {
            new RegisterNurseForm(database).Show();
        }

        private void connectPictureBox_MouseHover(object sender, EventArgs e)
        {
            connectPictureBox.Load(Application.StartupPath + "/images/login/button-hover.png");
            connectLabel.ForeColor = Color.White;
        }

        private void connectPictureBox_MouseLeave(object sender, EventArgs e)
        {
            connectPictureBox.Load(Application.StartupPath + "/images/login/button.png");
            connectLabel.ForeColor = Color.Black;
        }

        private void connectLabel_MouseHover(object sender, EventArgs e)
        {
            connectPictureBox_MouseHover(sender, e);
        }

        private void connectLabel_MouseLeave(object sender, EventArgs e)
        {
            connectPictureBox_MouseLeave(sender, e);
        }

        private void registerPictureBox_MouseHover(object sender, EventArgs e)
        {
            registerPictureBox.Load(Application.StartupPath + "/images/login/button-hover.png");
            registerLabel.ForeColor = Color.White;
        }

        private void registerPictureBox_MouseLeave(object sender, EventArgs e)
        {
            registerPictureBox.Load(Application.StartupPath + "/images/login/button.png");
            registerLabel.ForeColor = Color.Black;
        }

        private void connectLabel_Click(object sender, EventArgs e)
        {
            connectPictureBox_Click(sender, e);
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            registerPictureBox_Click(sender, e);
        }

        private void registerLabel_MouseHover(object sender, EventArgs e)
        {
            registerPictureBox_MouseHover(sender, e);
        }

        private void registerLabel_MouseLeave(object sender, EventArgs e)
        {
            registerPictureBox_MouseLeave(sender, e);
        }
    }
}
