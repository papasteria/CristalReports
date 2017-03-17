using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CristalReport.controlador;

namespace CristalReport
{
    public partial class Form1 : Form
    {
        private void cargarDeptos()
        {
            this.cmbDepto.DataSource = productosManager.ListarDeptos();
            this.cmbDepto.SelectedItem = this.cmbDepto.Items.Count - 1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cargarDeptos();
        }
    }
}
