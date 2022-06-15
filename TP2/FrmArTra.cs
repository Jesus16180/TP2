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
    public partial class FrmArTra : Form
    {
        FrmEmp Emp = new FrmEmp();
        FrmJefe Jef = new FrmJefe();

        Area_trabajo ArTra;

        public string charers = "1234567890qwertyuiopasdfghjklñzxcvbnm";
        public string Areadetra;

        public FrmArTra()
        {
            InitializeComponent();
        }

        private void bV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSD_Click(object sender, EventArgs e)
        {
            if (tBArTra.Text.Intersect(charers).Count() > 0)
            {
                ArTra = new Area_trabajo(tBArTra.Text);
                ArTra.Guardar();
            }
            else
            {
                MessageBox.Show("Uno o más campos vacíos. Ingrese los datos correspondientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSubDatArTra_Click(object sender, EventArgs e)
        {
            if (tBArTra.Text.Intersect(charers).Count() > 0)
            {
                ArTra = new Area_trabajo(tBArTra.Text);
                ArTra.Guardar();
            }
            else
            {
                MessageBox.Show("Uno o más campos vacíos. Ingrese los datos correspondientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bVolverArTra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}