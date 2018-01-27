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
        private MySqlConnection conexion;
        private MySqlCommand comando;

        public RegisterNurseForm()
        {
            InitializeComponent();
            connectDatabase();
        }

        private void connectDatabase()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = pokemon_center; Uid = root; Pwd =; Port = 3306");

            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base de datos: Error al conectar con la base de datos");
            }
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
            try
            {
                if (passwordBox.Text.Equals(passwordConfirmBox.Text))
                {
                    try
                    {
                        comando = new MySqlCommand(
                            "INSERT INTO nurse(id_center, username, password) VALUES(" + getPokemonCenterId() + ", '" + usernameBox.Text + "', '" + passwordBox.Text + "')", 
                            conexion
                        );

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Usuario registrado");

                        this.Hide();
                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Base de datos: No ha sido posible registrar al usuario, error en la conexión" + ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Formulario: Las contraseñas no coinciden");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Base de datos: No se pudo conectar a la bbdd" + ex.ToString() + ex.HResult); //+ ex.ToString() + ex.HResult
            }
            conexion.Close();
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
