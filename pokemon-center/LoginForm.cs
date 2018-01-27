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
        private string connStr;

        //variable que maneja la conexion
        private MySqlConnection conexion;

        //variable para almacenar la consulta a la bbdd
        private String sentenciaSQL;

        //variable que sirve para crear la conexion
        private static MySqlCommand comando;

        //guarda el resultado de la consulta
        private MySqlDataReader resultado;

        //pone el resultado de la bbdd en esta variable
        private DataTable datos = new DataTable();

        private int contadorFila = 0;
        private int numeroFilas = 0;

        public LoginForm()
        {
            InitializeComponent();

            conexion = new MySqlConnection("Server = 127.0.0.1; Database = pokemon_center; Uid = root; Pwd =; Port = 3306");
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base de datos: Los datos de inicio de sesión son incorrectos");
            }
        }

        private void connectButtonClick(object sender, EventArgs e)
        {
            //  PARA EL NOMBRE DE USUARIO
            comando = new MySqlCommand("SELECT nurse.username, nurse.password FROM nurse WHERE username ='" + usernameBox.Text + "' AND password ='" + passwordBox.Text + "'", conexion);

            MySqlDataAdapter adaptaDatos = new MySqlDataAdapter(comando);
            adaptaDatos.Fill(datos);

            if (datos.Rows.Count == 1)
            {
                this.Hide();
                new NurseForm().Show();
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        }

        private void RegisterLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterNurseForm().Show();
        }
    }
}
