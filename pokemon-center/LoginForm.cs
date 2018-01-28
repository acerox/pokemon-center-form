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
        // Movimientos de la ventana
        private int ex;

        public bool windowMovement = false;

        private int ey;

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
            this.ex = e.X;
            this.ey = e.Y;
            this.windowMovement = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (windowMovement)
            {
                this.Location =
                    this.PointToScreen(new Point(
                        Cursor.Position.X - this.Location.X - ex, 
                        Cursor.Position.Y - this.Location.Y - ey
                    ));
            }

            // If arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            windowMovement = false;
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

        private void label3_Click(object sender, EventArgs e)
        {
            connectPictureBox_Click(sender, e);
        }

        private void registerPictureBox_Click(object sender, EventArgs e)
        {
            new RegisterNurseForm().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            registerPictureBox_Click(sender, e);
        }
    }
}
