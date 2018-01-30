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

        public RegisterTrainerForm(Database database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void registerButton_Click(object sender, EventArgs e)
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
    }
}
