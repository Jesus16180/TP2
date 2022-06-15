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
    public partial class FrmJefe : Form
    {
        Jefe Jef;
        Area_trabajo ArTra;

        Area_trabajo AT = new Area_trabajo();

        string charers = "1234567890qwertyuiopasdfghjklñzxcvbnm";
        int id = 0;
        string idprint;
        
        public FrmJefe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSubD_Click(object sender, EventArgs e)
        {
            if ((tBNom.Text.Intersect(charers).Count() > 0) || (tBAp.Text.Intersect(charers).Count() > 0)
                || (tBCUIL.Text.Intersect(charers).Count() > 0) || (tBTel.Text.Intersect(charers).Count() > 0) ||
                (cBArTra.Text.Intersect(charers).Count() > 0))
            {
                Jef = new Jefe(lbIDJef.Text, tBNom.Text, tBAp.Text, tBCUIL.Text, tBTel.Text, new Area_trabajo(cBArTra.Text));
                Jef.Guardar();
                lbIDUpdate();
            }
            else
            {
                MessageBox.Show("Uno o más campos vacíos. Ingrese los datos correspondientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmJefe_Load(object sender, EventArgs e)
        {
            lbIDUpdate();
            cBArTra.Items.Add(ArTra.ToString());
        }

        public void lbIDUpdate()
        {
            id = id + 1;
            idprint = id.ToString("D4");
            idprint = Convert.ToString(id);
            idprint = id.ToString("D4");
            lbIDJef.Text = idprint;
        }

        private void bSubDatJefe_Click(object sender, EventArgs e)
        {
            if ((tBNom.Text.Intersect(charers).Count() > 0) || (tBAp.Text.Intersect(charers).Count() > 0)
                || (tBCUIL.Text.Intersect(charers).Count() > 0) || (tBTel.Text.Intersect(charers).Count() > 0) ||
                (cBArTra.Text.Intersect(charers).Count() > 0))
            {
                Jef = new Jefe(lbIDJef.Text, tBNom.Text, tBAp.Text, tBCUIL.Text, tBTel.Text, new Area_trabajo(cBArTra.Text));
                Jef.Guardar();
                lbIDUpdate();
            }
            else
            {
                MessageBox.Show("Uno o más campos vacíos. Ingrese los datos correspondientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bVolverJefe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}