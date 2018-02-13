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
    }
}
