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
    public partial class frmprinipal : Form
    {
        public frmprinipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))    
                    return;
            }

            Form1 form2 = new Form1();
            form2.MdiParent = this;
            form2.Show();
        }
    }
}
