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

        // para saber que registrar cuando se pulse el boton de registro
        string registro = "entrenador";

        public Database(MySqlConnection connection)
        {
            this.connection = connection;
        }

        /**
         * Registra un nuevo entrenador en la ventana NurseForm
         */
        public void createNewTrainer(string name, string surname, int dni, string phone)
        {
            executeQuery("INSERT INTO trainer(name, surname, dni, phone) VALUES('" + name + "', '" + surname + "', " + dni + ", '" + phone + "')");
        }
        // registra un nuevo medico
        public void createNewNurse(string username, int centerId, string password)
        {
            executeQuery(
                "INSERT INTO nurse(id_center, username, password) VALUES(" + centerId + ", '" + username + "', '" + password + "')"
                );
        }

        public void createNewPokemon(string name, string gender, string type, string race, int chip  )
        {
            executeQuery(
                "INSERT INTO pokemon (name, gender, type, race, chip) VALUES ('"+name+ "','"+gender+ "','"+type+"','"+race+"',"+chip+")"
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

        //actualiza el datagridview (para que no se superpongan las consultas)
        public void limpiaDataGrid()
        {
            //menuPrincipal.Rows.Clear();
            //menuPrincipal.Refresh();
            //datos.Clear();
            //datos.Reset();
            datos = new DataTable();
        }

        //selecciona los entrenadores
        public DataTable getTrainerDataTable()
        {
            registro = "entrenador";
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
            registro = "pokemon";
            lastSqlCommand = new MySqlCommand("SELECT * FROM pokemon", connection);
            connection.Open();
            result = lastSqlCommand.ExecuteReader();
            datos.Load(result);
            connection.Close();
            return datos;
        }

        public string seleccionaParaRegistrar()
        {
            return registro;
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
