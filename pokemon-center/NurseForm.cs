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
    public partial class NurseForm : Form
    {
        private MySqlConnection conexion = new MySqlConnection("Server = 127.0.0.1; Database = pokemon_center; Uid = root; Pwd =; Port = 3306");
        private MySqlCommand comando;
        private DataTable datos = new DataTable();
        private MySqlDataReader resultado;

        public NurseForm()
        {
            InitializeComponent();
        }

        private void trainerButton_Click(object sender, EventArgs e)
        {
            conexion.Open();

            comando = new MySqlCommand("SELECT * FROM trainer", conexion);
            resultado = comando.ExecuteReader();

            datos.Load(resultado);
            conexion.Close();
            dataGridView1.DataSource = datos;

        }

        private void pokemonsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
