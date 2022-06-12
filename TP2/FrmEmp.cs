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
    public partial class FrmEmp : Form
    {
        Empleado Emp = new Empleado();
        Area_trabajo ArTra = new Area_trabajo();

        string charers = "1234567890qwertyuiopasdfghjklñzxcvbnm";
        int id = 0;
        string idprint;

        public FrmEmp()
        {
            InitializeComponent();
        }

        private void FormEmp_Load(object sender, EventArgs e)
        {
            lbIDUpdate();
        }

        private void bV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSubD_Click(object sender, EventArgs e)
        {
            if ((tBNom.Text.Intersect(charers).Count() > 0) || (tBAp.Text.Intersect(charers).Count() > 0) 
                || (tBCUIL.Text.Intersect(charers).Count() > 0) || (tBTel.Text.Intersect(charers).Count() > 0)||
                (cBArTra.Text.Intersect(charers).Count() > 0) || (cBIDJef.Text.Intersect(charers).Count() > 0))
            {;
                Emp = new Empleado(lbIDEmp.Text, tBNom.Text, tBAp.Text, tBCUIL.Text, tBTel.Text, cBArTra.Text, cBIDJef.Text);
                Emp.Guardar();
                lbIDUpdate();
            }
            else
            {
                MessageBox.Show("Uno o más campos vacíos. Ingrese los datos correspondientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void lbIDUpdate()
        {
            id = id + 1;
            idprint = id.ToString("D8");
            idprint = Convert.ToString(id);
            idprint = id.ToString("D8");
            lbIDEmp.Text = idprint;
        }
        }
    }
