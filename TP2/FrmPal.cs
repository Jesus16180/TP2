using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace TP2
{
    public partial class Frmpal : Form
    {
        FrmEmp FEmp = new FrmEmp();
        FrmJefe FJf = new FrmJefe();
        FrmArTra FAT = new FrmArTra();
        FrmProy FClint = new FrmProy();

        Empleado Emp = new Empleado();


        public Frmpal()
        {
            InitializeComponent();
        }

        private void bAgEm_Click(object sender, EventArgs e)
        {
            FEmp.ShowDialog();
        }

        private void bAgAr_Click(object sender, EventArgs e)
        {
            FAT.ShowDialog();
        }

        private void bAgJef_Click(object sender, EventArgs e)
        {
            FJf.ShowDialog();
        }

        private void Frmpal_Load(object sender, EventArgs e)
        {
            dGVDatos.DataSource = null;
            

        }

        private void bVD_Click(object sender, EventArgs e)
        {
            
        }

        private void bBuscar_Click_1(object sender, EventArgs e)
        {
            dGVDatos.DataSource = Empleado.Buscar();
            dGVDatos.DataSource = Jefe.Buscar();
        }

        private void btAgClint_Click(object sender, EventArgs e)
        {
            FClint.ShowDialog();
        }
    }
}
