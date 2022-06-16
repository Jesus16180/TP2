namespace TP2
{
    partial class Frmpal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmpal));
            this.bAgEm = new System.Windows.Forms.Button();
            this.bAgJef = new System.Windows.Forms.Button();
            this.bAgAr = new System.Windows.Forms.Button();
            this.bVD = new System.Windows.Forms.Button();
            this.dGVDatos = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBBuscar = new System.Windows.Forms.TextBox();
            this.btAgClint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // bAgEm
            // 
            this.bAgEm.BackColor = System.Drawing.SystemColors.Control;
            this.bAgEm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgEm.Location = new System.Drawing.Point(101, 26);
            this.bAgEm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAgEm.Name = "bAgEm";
            this.bAgEm.Size = new System.Drawing.Size(187, 35);
            this.bAgEm.TabIndex = 0;
            this.bAgEm.Text = "Agregar empleado";
            this.bAgEm.UseVisualStyleBackColor = false;
            this.bAgEm.Click += new System.EventHandler(this.bAgEm_Click);
            // 
            // bAgJef
            // 
            this.bAgJef.BackColor = System.Drawing.SystemColors.Control;
            this.bAgJef.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgJef.Location = new System.Drawing.Point(648, 26);
            this.bAgJef.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAgJef.Name = "bAgJef";
            this.bAgJef.Size = new System.Drawing.Size(140, 35);
            this.bAgJef.TabIndex = 1;
            this.bAgJef.Text = "Agregar jefe";
            this.bAgJef.UseVisualStyleBackColor = false;
            this.bAgJef.Click += new System.EventHandler(this.bAgJef_Click);
            // 
            // bAgAr
            // 
            this.bAgAr.BackColor = System.Drawing.SystemColors.Control;
            this.bAgAr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgAr.Location = new System.Drawing.Point(398, 26);
            this.bAgAr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAgAr.Name = "bAgAr";
            this.bAgAr.Size = new System.Drawing.Size(140, 35);
            this.bAgAr.TabIndex = 2;
            this.bAgAr.Text = "Agregar área";
            this.bAgAr.UseVisualStyleBackColor = false;
            this.bAgAr.Click += new System.EventHandler(this.bAgAr_Click);
            // 
            // bVD
            // 
            this.bVD.BackColor = System.Drawing.SystemColors.Control;
            this.bVD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVD.Location = new System.Drawing.Point(648, 100);
            this.bVD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVD.Name = "bVD";
            this.bVD.Size = new System.Drawing.Size(140, 35);
            this.bVD.TabIndex = 3;
            this.bVD.Text = "Ver datos";
            this.bVD.UseVisualStyleBackColor = false;
            this.bVD.Click += new System.EventHandler(this.bVD_Click);
            // 
            // dGVDatos
            // 
            this.dGVDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnAp,
            this.ColumnNom,
            this.ColumnPst,
            this.ColumnArTra,
            this.ColumnClint,
            this.ColumnProj});
            this.dGVDatos.Location = new System.Drawing.Point(13, 162);
            this.dGVDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dGVDatos.Name = "dGVDatos";
            this.dGVDatos.RowTemplate.Height = 24;
            this.dGVDatos.Size = new System.Drawing.Size(1233, 283);
            this.dGVDatos.TabIndex = 5;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 120;
            // 
            // ColumnAp
            // 
            this.ColumnAp.HeaderText = "Apellido";
            this.ColumnAp.Name = "ColumnAp";
            this.ColumnAp.Width = 150;
            // 
            // ColumnNom
            // 
            this.ColumnNom.HeaderText = "Nombre";
            this.ColumnNom.Name = "ColumnNom";
            this.ColumnNom.Width = 150;
            // 
            // ColumnPst
            // 
            this.ColumnPst.HeaderText = "Puesto";
            this.ColumnPst.Name = "ColumnPst";
            this.ColumnPst.Width = 150;
            // 
            // ColumnArTra
            // 
            this.ColumnArTra.HeaderText = "Área de trabajo";
            this.ColumnArTra.Name = "ColumnArTra";
            this.ColumnArTra.Width = 220;
            // 
            // ColumnClint
            // 
            this.ColumnClint.HeaderText = "Clientes";
            this.ColumnClint.Name = "ColumnClint";
            this.ColumnClint.Width = 200;
            // 
            // ColumnProj
            // 
            this.ColumnProj.HeaderText = "Proyecto";
            this.ColumnProj.Name = "ColumnProj";
            this.ColumnProj.Width = 200;
            // 
            // tBBuscar
            // 
            this.tBBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tBBuscar.Location = new System.Drawing.Point(101, 108);
            this.tBBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBBuscar.Name = "tBBuscar";
            this.tBBuscar.Size = new System.Drawing.Size(349, 20);
            this.tBBuscar.TabIndex = 6;
            // 
            // btAgClint
            // 
            this.btAgClint.BackColor = System.Drawing.SystemColors.Control;
            this.btAgClint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgClint.Location = new System.Drawing.Point(891, 26);
            this.btAgClint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAgClint.Name = "btAgClint";
            this.btAgClint.Size = new System.Drawing.Size(140, 35);
            this.btAgClint.TabIndex = 7;
            this.btAgClint.Text = "Agregar cliente";
            this.btAgClint.UseVisualStyleBackColor = false;
            this.btAgClint.Click += new System.EventHandler(this.btAgClint_Click);
            // 
            // button1
            // 
            this.button1.Image = global::TP2.Properties.Resources.ythtfh;
            this.button1.Location = new System.Drawing.Point(457, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 27);
            this.button1.TabIndex = 8;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frmpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1259, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAgClint);
            this.Controls.Add(this.tBBuscar);
            this.Controls.Add(this.dGVDatos);
            this.Controls.Add(this.bVD);
            this.Controls.Add(this.bAgAr);
            this.Controls.Add(this.bAgJef);
            this.Controls.Add(this.bAgEm);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frmpal";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.Frmpal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAgEm;
        private System.Windows.Forms.Button bAgJef;
        private System.Windows.Forms.Button bAgAr;
        private System.Windows.Forms.Button bVD;
        private System.Windows.Forms.DataGridView dGVDatos;
        private System.Windows.Forms.TextBox tBBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProj;
        private System.Windows.Forms.Button btAgClint;
        private System.Windows.Forms.Button button1;
    }
}

