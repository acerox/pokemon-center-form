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

namespace pokemon_center
{
    public partial class LoginForm : Form
    {   
        // Base de datos
        private Database database;

        private Movement movement;

        public LoginForm(Database database)
        {
            InitializeComponent();
            this.database = database;
            movement = new Movement(this);
        }

        private void RegisterLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterNurseForm(database).Show();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void exitPictureBox_MouseHover(object sender, EventArgs e)
        {
            exitPictureBox.Load(Application.StartupPath + "/images/exit-hover.png");
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Load(Application.StartupPath + "/images/exit.png");
        }

        private void minimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            minimizePictureBox.Load(Application.StartupPath + "/images/minimize.png");
        }

        private void minimizePictureBox_MouseHover(object sender, EventArgs e)
        {
            minimizePictureBox.Load(Application.StartupPath + "/images/minimize-hover.png");
        }

        private void connectPictureBox_Click(object sender, EventArgs e)
        {
            if (database.existUser(usernameBox.Text, passwordBox.Text))
            {
                this.Hide();
                new NurseForm(database, usernameBox).Show();
            }
            else
            {
                MessageBox.Show("El usuario y/o la contraseña son incorrectos o no existen en el servidor");
            }
        }

        private void registerPictureBox_Click(object sender, EventArgs e)
        {
            new RegisterNurseForm(database).Show();
        }

        private void connectPictureBox_MouseLeave(object sender, EventArgs e)
        {
            connectPictureBox.Load(Application.StartupPath + "/images/login/button.png");
            connectLabel.ForeColor = Color.Black;
            Cursor.Current = Cursors.Arrow;
        }

        private void connectLabel_MouseLeave(object sender, EventArgs e)
        {
            connectPictureBox_MouseLeave(sender, e);
        }

        private void registerPictureBox_MouseLeave(object sender, EventArgs e)
        {
            registerPictureBox.Load(Application.StartupPath + "/images/login/button.png");
            registerLabel.ForeColor = Color.Black;
        }

        private void connectLabel_Click(object sender, EventArgs e)
        {
            connectPictureBox_Click(sender, e);
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            registerPictureBox_Click(sender, e);
        }

        private void registerLabel_MouseLeave(object sender, EventArgs e)
        {
            registerPictureBox_MouseLeave(sender, e);
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                connectPictureBox_Click(sender, e);
            }
        }

        private void usernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            passwordBox_KeyPress(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veterinario pokemon creado por:\n\n - Marc Fernandez\n - Sergio Freire\n - Agustín Cisneros\n\nContacto: dudas@dam.com");
        }

        private void connectLabel_MouseEnter(object sender, EventArgs e)
        {
            connectPictureBox_MouseEnter(sender, e);
        }

        private void connectPictureBox_MouseEnter(object sender, EventArgs e)
        {
            connectPictureBox.Load(Application.StartupPath + "/images/login/button-hover.png");
            connectLabel.ForeColor = Color.White;
        }

        private void exitPictureBox_MouseEnter(object sender, EventArgs e)
        {
            exitPictureBox_MouseHover(sender, e);
        }

        private void minimizePictureBox_MouseEnter(object sender, EventArgs e)
        {
            minimizePictureBox_MouseHover(sender, e);
        }

        private void registerPictureBox_MouseEnter(object sender, EventArgs e)
        {
            registerPictureBox.Load(Application.StartupPath + "/images/login/button-hover.png");
            registerLabel.ForeColor = Color.White;
        }

        private void registerLabel_MouseEnter(object sender, EventArgs e)
        {
            registerPictureBox_MouseEnter(sender, e);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }
    }
}
