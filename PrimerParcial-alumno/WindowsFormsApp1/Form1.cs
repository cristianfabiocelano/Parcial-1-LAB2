using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblContenido_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(rbAgua.Checked == true)
            {
                Agua a1 = new Agua(txtMarca.Text, (int)numberCapacidad.Value, (int)numberContenido.Value);
                barra1.AgregarBotella(a1);
            }
            else
            {
                Cerveza c1 = new Cerveza(txtMarca.Text, (int)numberCapacidad.Value, (int)numberContenido.Value);
                barra1.AgregarBotella(c1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cbTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }
    }
}
