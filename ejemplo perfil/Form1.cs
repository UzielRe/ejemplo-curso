using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_perfil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string elem = txtelemento.Text;
            lwelementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("rojo");
            comboBox1.Items.Add("verde");
            comboBox1.Items.Add("amarillo");
        }

        private void btnperfil_Click(object sender, EventArgs e)
        {
            string nombre = txtelemento.Text;
            DateTime fecha = dateTimePicker1.Value;
            string chocolate = chocolate1.Checked == true ? "si le gusta el chocolate" : "no le gusta el chocolate";
            string tipo;

            if (rbtmuggle.Checked)
                tipo = "muggle";
            else if (rbtwizard.Checked)
                tipo = "wizard";
            else tipo = "squibs";

            string colorfavo = comboBox1.SelectedItem.ToString();
            string numerofavo = numerofavorito.Value.ToString();


            string mensaje = chocolate + " , es " + tipo + " , " + " color : " + colorfavo + "," + "su numero es : " + numerofavorito;
            MessageBox.Show(" nombre :" + nombre + " fecha : " + fecha + " ," + mensaje);



        }
    }
}
