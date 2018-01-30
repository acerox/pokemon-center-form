using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_center
{
    public class Database
    {
        //variable que maneja la conexion
        private MySqlConnection connection;

        // Ultimo comando usado
        private MySqlCommand lastSqlCommand;

        //guarda el resultado de la consulta
        private MySqlDataReader result;


        //pone el resultado de la bbdd en esta variable
        private DataTable datos = new DataTable();

        public Database(MySqlConnection connection)
        {
            this.connection = connection;
        }

        public void createNewNurse(string username, int centerId, string password)
        {
            executeQuery(
                "INSERT INTO nurse(id_center, username, password) VALUES(" + centerId + ", '" + username + "', '" + password + "')"
                );
        }

        public Boolean existUser(string username, string password)
        {
            openConnection();

            lastSqlCommand = new MySqlCommand("SELECT nurse.username, nurse.password FROM nurse WHERE username ='" + username + "' AND password ='" + password + "'", connection);

            DataTable data = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(lastSqlCommand);
            dataAdapter.Fill(data);

            closeConnection();

            return data.Rows.Count == 1;
        }

        public void limpiaDataGrid(DataGridView menuPrincipal)
        {
            //menuPrincipal.Rows.Clear();
            //menuPrincipal.Refresh();
            //datos.Clear();
            datos.Reset();
        }

        //selecciona los entrenadores
        public DataTable getTrainerDataTable()
        {
            lastSqlCommand = new MySqlCommand("SELECT * FROM trainer", connection);
            connection.Open();
            result = lastSqlCommand.ExecuteReader();
            datos.Load(result);
            connection.Close();
            return datos;
        }
        // selecciona los pokemon
        public DataTable getPokemonDatatable()
        {
            lastSqlCommand = new MySqlCommand("SELECT * FROM pokemon", connection);
            connection.Open();
            result = lastSqlCommand.ExecuteReader();
            datos.Load(result);
            connection.Close();
            return datos;
        }

        private void openConnection()
        {
            connection.Open();
        }

        private void closeConnection()
        {
            connection.Close();
        }

        private void executeQuery(string sql)
        {
            openConnection();

            lastSqlCommand = new MySqlCommand(sql, connection);
            lastSqlCommand.ExecuteNonQuery();

            closeConnection();
        }
    }
}
