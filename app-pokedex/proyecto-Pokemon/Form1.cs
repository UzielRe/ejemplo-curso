using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace proyecto_Pokemon
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listapokemons;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listapokemons = negocio.listar();
            dgv.DataSource = listapokemons;
            dgv.Columns["UrlImagen"].Visible = false;
            cargarimagen(listapokemons[0].urlimagen);
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgv.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado.urlimagen);

           
        }
        private void cargarimagen(string imagen)
        {
            try
            {
                pictureBox.Load(imagen);

            }
            catch ( Exception )
            {

                pictureBox.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9cSGzVkaZvJD5722MU5A-JJt_T5JMZzotcw&s");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon altaPokemon = new frmAltaPokemon();
            altaPokemon.ShowDialog();
        }
    }
}
