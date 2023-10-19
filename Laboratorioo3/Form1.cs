using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorioo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int numFormsToCreate = (int)numericUpDown1.Value;

            for (int i = 0; i < numFormsToCreate; i++)
            {
                Form form = new Form();
                form.Text = "Formulario " + (i + 1);

                // Agrega los controles necesarios a este formulario.
                // Puedes personalizar este formulario según tus necesidades.

                form.Show();
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
