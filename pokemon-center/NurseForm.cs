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
using System.Speech.Recognition;

namespace pokemon_center
{
    public partial class NurseForm : Form
    {
        private Database database;
        
        public NurseForm(Database database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void trainerButton_Click(object sender, EventArgs e)
        {
            database.limpiaDataGrid();
            menuPrincipal.DataSource = database.getTrainerDataTable();
        }

        private void pokemonsButton_Click(object sender, EventArgs e)
        {
            database.limpiaDataGrid();
            menuPrincipal.DataSource = database.getPokemonDatatable();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            
        }

        private void addTrainerLogLabel_Click(object sender, EventArgs e)
        {
          String registro = database.seleccionaParaRegistrar();
            if (registro.Equals("entrenador"))
            {
                new RegisterTrainerForm(database).Show();
            }
            else if (registro.Equals("pokemon"))
            {
                new RegisterPokemonForm(database).Show();
            }
            
        }

        private void botonEscucha_Click(object sender, EventArgs e)
        {
            database.escuchador();
        }
    }
}
