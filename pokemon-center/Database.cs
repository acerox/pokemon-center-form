using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// el programa lee tu voz
using System.Speech.Recognition;
// el programa retransmite la voz
using System.Speech.Synthesis;

namespace pokemon_center
{
    public class Database
    {
        private Database database;
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

        public DataTable buscarRegistro(string condicion)
        {

            if (registro.Equals("entrenador"))
            {
                lastSqlCommand = new MySqlCommand("SELECT * FROM trainer where " +
                                "id LIKE '%"+condicion + //int
                                "%' or name LIKE '%" + condicion +
                                "%' or surname LIKE '%" + condicion +
                                "%' or dni LIKE '%" + condicion + //int
                                "%' or phone LIKE '%" + condicion + "%'", connection);//int
            }  
            else if(registro.Equals("pokemon")) 
            {
                lastSqlCommand = new MySqlCommand("SELECT * FROM pokemon where " +
                                "id LIKE '%" + condicion + //int
                                "%' or name LIKE '%" + condicion +
                                "%' or gender LIKE '%" + condicion +
                                "%' or type LIKE '%" + condicion +
                                "%' or chip LIKE '%" + condicion + //int
                                "%' or race LIKE '%" + condicion + "%'", connection);
            }
            else//tienda
            {

            }


            connection.Open();
            result = lastSqlCommand.ExecuteReader();
            datos.Load(result);
            connection.Close();
            return datos;
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

        //variable que retransmitira sonido(2)
        SpeechSynthesizer sintetizador = new SpeechSynthesizer();
        //lista que el ordenador retransmitira mediante sonido
        List<VoiceInfo> listaAReproducir = new List<VoiceInfo>();
        public void lector(string userName)
        {
            foreach (InstalledVoice voz in sintetizador.GetInstalledVoices())
            {
                listaAReproducir.Add(voz.VoiceInfo);
                sintetizador.SelectVoice("Microsoft Helena Desktop");
                if (userName.Equals("Jorge"))
                {
                    sintetizador.Speak("Qué pasa Jorge tronco, rulate unos dieces");
                }
                else
                {
                    sintetizador.Speak("Buen dia" + userName);
                }
                
            }
        }
        // variable que escucha lo que decimos(1)
        SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();
        public void escuchador()
        {
            try
            {
                //permite al programa detectar lo que digamos por el micro 
                escucha.SetInputToDefaultAudioDevice();
                // diccionario para enlazar las palabras que decimos
                escucha.LoadGrammar(new DictationGrammar());
                // lo que escuche el programa lo envia al método reconocedor
                escucha.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(reconocerdor);
                // permite al programa reconocer mas de una palabra
                escucha.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch(InvalidOperationException) 
            {
                MessageBox.Show("El microfono ya esta conectado y escuchando");
            }
        }

        private void reconocerdor(object sender, SpeechRecognizedEventArgs e)
        {
            string resultado = "";
            foreach (RecognizedWordUnit palabra in e.Result.Words)
            {
                resultado += palabra.Text + " ";

                if (resultado.Contains("escolta"))
                {

                    new RegisterPokemonForm(database).Show();
                    resultado = "";
                }
                else if (resultado.Contains("cliente"))
                {
                    new RegisterTrainerForm(database).Show();
          
                }
                else if (resultado.Contains("sesion"))
                {

                }
                else
                {
                    MessageBox.Show(resultado);
                    resultado = "";
                }

            }
            
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
