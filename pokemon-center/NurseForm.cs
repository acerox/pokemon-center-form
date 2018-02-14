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

        private void exitPictureBox_MouseEnter(object sender, EventArgs e)
        {
            exitPictureBox.Load(Application.StartupPath + "/images/exit-hover.png");
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Load(Application.StartupPath + "/images/exit.png");
        }

        private void minimizePictureBox_MouseEnter(object sender, EventArgs e)
        {
            minimizePictureBox.Load(Application.StartupPath + "/images/minimize-hover.png");
        }

        private void minimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            minimizePictureBox.Load(Application.StartupPath + "/images/minimize.png");
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Load(Application.StartupPath + "/images/login/button-hover.png");
            logoutLabel.ForeColor = Color.White;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Load(Application.StartupPath + "/images/login/button.png");
            logoutLabel.ForeColor = Color.Black;
        }

        private void logoutLabel_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6_MouseEnter(sender, e);
        }

        private void logoutLabel_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6_MouseLeave(sender, e);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Load(Application.StartupPath + "/images/dashboard/listen-button-hover.png");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Load(Application.StartupPath + "/images/blank.png");
        }
    }
}
