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
    public partial class RegisterPokemonForm : Form
    {
        // variable local de bbdd con la que nos enlazamos a la real
        private Database database;

        public RegisterPokemonForm(Database database)
        {
            InitializeComponent();
            //igualamos la bbdd local con la real (que pasamos arriba en el constructor)
            this.database = database;
        }


        private void botonRegistroPokemon_Click(object sender, EventArgs e)
        {
            if (checkTextBoxes())
            {
                database.createNewPokemon
                (textoNombre.Text,
                textoGenero.Text,
                textoTipo.Text,
                textoRaza.Text,
               Convert.ToInt32(textoChip.Text));
                MessageBox.Show("Pokemon registrado con éxito");
            }
        }

        private Boolean checkTextBoxes()
        {
            if (textoNombre.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo nombre");
                return false;
            }
            else if (textoGenero.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo género");
                return false;
            }
            else if (textoTipo.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo tipo");
                return false;
            }
            else if (textoRaza.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo raza");
                return false;
            }else if (textoChip.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, rellena correctamente el campo chip");
                return false;
            }

            return true;
        }
    }
}
