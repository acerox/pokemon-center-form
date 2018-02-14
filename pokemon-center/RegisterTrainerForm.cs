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
    public partial class RegisterTrainerForm : Form
    {
        // coge la base de datos
        private Database database;
        private Movement movement;

        public RegisterTrainerForm(Database database)
        {
            InitializeComponent();
            this.database = database;
            movement = new Movement(this);
        }
        
        private Boolean checkTextBoxes()
        {
            if (nameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo de nombre");
                return false;
            }
            else if (surnameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo de apellido");
                return false;
            }
            else if (dniTextBox.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo de dni");
                return false;
            }
            else if (phoneTextBox.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo teléfono");
                return false;
            }

            return true;
        }

        private void registerPictureBox_Click(object sender, EventArgs e)
        {
            if (checkTextBoxes())
            {
                database.createNewTrainer(
                    nameTextBox.Text,
                    surnameTextBox.Text,
                    Convert.ToInt32(dniTextBox.Text),
                    phoneTextBox.Text
                    );
                MessageBox.Show("Nuevo entrenador registrado correctamente");
                this.Close();
            }
        }

        private void cleanPictureBox_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            dniTextBox.Text = "";
            phoneTextBox.Text = "";
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            registerPictureBox_Click(sender, e);
        }

        private void cleanLabel_Click(object sender, EventArgs e)
        {
            cleanPictureBox_Click(sender, e);
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

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitPictureBox_MouseHover(object sender, EventArgs e)
        {
            exitPictureBox.Load(Application.StartupPath + "/images/exit-hover.png");
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Load(Application.StartupPath + "/images/exit.png");
        }

        private void minimizePictureBox_MouseHover(object sender, EventArgs e)
        {
            minimizePictureBox.Load(Application.StartupPath + "/images/minimize-hover.png");
        }

        private void minimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            minimizePictureBox.Load(Application.StartupPath + "/images/minimize.png");
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

        private void registerLabel_MouseHover(object sender, EventArgs e)
        {
            registerPictureBox_MouseHover(sender, e);
        }

        private void registerLabel_MouseLeave(object sender, EventArgs e)
        {
            registerPictureBox_MouseLeave(sender, e);
        }

        private void cleanPictureBox_MouseHover(object sender, EventArgs e)
        {
            cleanPictureBox.Load(Application.StartupPath + "/images/login/button-hover.png");
            cleanLabel.ForeColor = Color.White;
        }

        private void cleanPictureBox_MouseLeave(object sender, EventArgs e)
        {
            cleanPictureBox.Load(Application.StartupPath + "/images/login/button.png");
            cleanLabel.ForeColor = Color.Black;
        }

        private void cleanLabel_MouseHover(object sender, EventArgs e)
        {
            cleanPictureBox_MouseHover(sender, e);
        }

        private void cleanLabel_MouseLeave(object sender, EventArgs e)
        {
            cleanPictureBox_MouseLeave(sender, e);
        }

        private void registerPictureBox_MouseEnter(object sender, EventArgs e)
        {
            registerPictureBox_MouseHover(sender, e);
        }

        private void registerLabel_MouseEnter(object sender, EventArgs e)
        {
            registerPictureBox_MouseHover(sender, e);
        }

        private void cleanPictureBox_MouseEnter(object sender, EventArgs e)
        {
            cleanPictureBox_MouseHover(sender, e);
        }

        private void cleanLabel_MouseEnter(object sender, EventArgs e)
        {
            cleanPictureBox_MouseHover(sender, e);
        }

        private void minimizePictureBox_MouseEnter(object sender, EventArgs e)
        {
            minimizePictureBox_MouseHover(sender, e);
        }

        private void exitPictureBox_MouseEnter(object sender, EventArgs e)
        {
            exitPictureBox_MouseHover(sender, e);
        }
    }
}
