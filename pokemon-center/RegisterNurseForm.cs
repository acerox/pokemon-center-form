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

        public RegisterNurseForm(Database database)
        {
            InitializeComponent();
            this.database = database;
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ha sido posible registrar al nuevo usuario" + ex.ToString());
            }
            
            MessageBox.Show("Nuevo usuario registrado");
            this.Close();
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
    }
}
