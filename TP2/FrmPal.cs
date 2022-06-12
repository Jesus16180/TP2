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
            string data = Emp.ExactData();
            char delim = ',';
            string[] vallues = data.Split(delim);

            int n = dGVDatos.Rows.Add();
 
            dGVDatos.Rows[n].Cells[0].Value = vallues[0];
            dGVDatos.Rows[n].Cells[1].Value = vallues[1];
            dGVDatos.Rows[n].Cells[2].Value = vallues[2];
            dGVDatos.Rows[n].Cells[3].Value = vallues[3];
            dGVDatos.Rows[n].Cells[4].Value = vallues[4];
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            dGVDatos.DataSource = Empleado.Buscar();
            dGVDatos.DataSource = Jefe.Buscar();
        }

        private void bVD_Click(object sender, EventArgs e)
        {
            
        }
    }
}
