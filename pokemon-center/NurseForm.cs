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
        private Movement movement;
        
        public NurseForm(Database database, TextBox usernameBox)
        {
            InitializeComponent();
            this.database = database;
            database.lector(usernameBox.Text);
            movement = new Movement(this);
            menuPrincipal.DataSource = database.getTrainerDataTable();
        }

        private void textoBuscar_TextChanged(object sender, EventArgs e)
        {
            database.limpiaDataGrid();
            menuPrincipal.DataSource = database.buscarRegistro(textoBuscar.Text);
        }

        private void textoBuscar_Click(object sender, EventArgs e)
        {
            if (textoBuscar.Text.Equals("Buscar"))
            {
                textoBuscar.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            database.escuchador();
            MessageBox.Show("Escuchando...");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            database.limpiaDataGrid();
            menuPrincipal.DataSource = database.getTrainerDataTable();
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "/images/dashboard/background-trainers.png");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            database.limpiaDataGrid();
            menuPrincipal.DataSource = database.getPokemonDatatable();
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "/images/dashboard/background-pokemons.png");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            database.limpiaDataGrid();
            menuPrincipal.DataSource = database.getShopDatatable();
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "/images/dashboard/background-shop.png");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            // ver como cerrar las demas ventanas si están abiertas
        }

        private void addLabel_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void trainersLabel_Click(object sender, EventArgs e)
        {
            pictureBox3_Click(sender, e);
        }

        private void pokemonsLabel_Click(object sender, EventArgs e)
        {
            pictureBox4_Click(sender, e);
        }

        private void shopLabel_Click(object sender, EventArgs e)
        {
            pictureBox5_Click(sender, e);
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            pictureBox6_Click(sender, e);
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
