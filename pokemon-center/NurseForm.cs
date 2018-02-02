﻿using MySql.Data.MySqlClient;
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
        
        public NurseForm(Database database, TextBox usernameBox)
        {
            InitializeComponent();
            this.database = database;
            database.lector(usernameBox.Text);
        }

        private void trainerButton_Click(object sender, EventArgs e)
        {
            database.limpiaDataGrid();
            menuPrincipal.DataSource = database.getTrainerDataTable();
            backgroundImg.Image = Image.FromFile(Application.StartupPath + "/images/imgTrainer.jpg");
            
        }

        private void pokemonsButton_Click(object sender, EventArgs e)
        {
            database.limpiaDataGrid();
            menuPrincipal.DataSource = database.getPokemonDatatable();
            backgroundImg.Image = Image.FromFile(Application.StartupPath + "/images/imgPokemon1.png");
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            database.limpiaDataGrid();
            menuPrincipal.DataSource = database.getShopDatatable();
            backgroundImg.Image = Image.FromFile(Application.StartupPath + "/images/imgShop1.jpg");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            // ver como cerrar las demas ventanas si están abiertas
        }

        private void NurseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
