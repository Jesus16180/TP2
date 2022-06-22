﻿using System;
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
    public partial class FrmProy : Form
    {
        string charers = "1234567890qwertyuiopasdfghjklñzxcvbnm";
        int id = 0;
        string idprint;
        Proyecto proy;

        public FrmProy()
        {
            InitializeComponent();
        }

        private void bSubDatCliente_Click(object sender, EventArgs e)
        {
            if ((tBProj.Text.Intersect(charers).Count() > 0)|| (tBCost.Text.Intersect(charers).Count() > 0) ||
                (cBJef.Text.Intersect(charers).Count() > 0) || (tBNom.Text.Intersect(charers).Count() > 0) ||
                (tbAp.Text.Intersect(charers).Count() > 0) || (tBTel.Text.Intersect(charers).Count() > 0))
            {
                proy = new Proyecto(lbIDProy.Text, tBProj.Text, Convert.ToDecimal(tBCost.Text), cBJef.Text, Convert.ToInt32(nUDDE.Value), tBNom.Text, tbAp.Text, tBTel.Text);
                proy.Guardar();
                lbIDUpdate();
            }
            else
            {
                MessageBox.Show("Uno o más campos vacíos. Ingrese los datos correspondientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            lbIDUpdate();
        }

        private void bVolverCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void lbIDUpdate()
        {
            id = id + 1;
            idprint = id.ToString("D4");
            idprint = Convert.ToString(id);
            idprint = id.ToString("D4");
            lbIDProy.Text = idprint;
        }
    }
}