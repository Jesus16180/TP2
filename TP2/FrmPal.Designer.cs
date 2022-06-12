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
            this.bBuscar = new System.Windows.Forms.Button();
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
            this.iconButton0 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // bAgEm
            // 
            this.bAgEm.BackColor = System.Drawing.SystemColors.Control;
            this.bAgEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgEm.Location = new System.Drawing.Point(80, 28);
            this.bAgEm.Name = "bAgEm";
            this.bAgEm.Size = new System.Drawing.Size(160, 38);
            this.bAgEm.TabIndex = 0;
            this.bAgEm.Text = "Agregar empleado";
            this.bAgEm.UseVisualStyleBackColor = false;
            this.bAgEm.Click += new System.EventHandler(this.bAgEm_Click);
            // 
            // bAgJef
            // 
            this.bAgJef.BackColor = System.Drawing.SystemColors.Control;
            this.bAgJef.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgJef.Location = new System.Drawing.Point(549, 28);
            this.bAgJef.Name = "bAgJef";
            this.bAgJef.Size = new System.Drawing.Size(120, 38);
            this.bAgJef.TabIndex = 1;
            this.bAgJef.Text = "Agregar jefe";
            this.bAgJef.UseVisualStyleBackColor = false;
            this.bAgJef.Click += new System.EventHandler(this.bAgJef_Click);
            // 
            // bAgAr
            // 
            this.bAgAr.BackColor = System.Drawing.SystemColors.Control;
            this.bAgAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgAr.Location = new System.Drawing.Point(334, 28);
            this.bAgAr.Name = "bAgAr";
            this.bAgAr.Size = new System.Drawing.Size(120, 38);
            this.bAgAr.TabIndex = 2;
            this.bAgAr.Text = "Agregar área";
            this.bAgAr.UseVisualStyleBackColor = false;
            this.bAgAr.Click += new System.EventHandler(this.bAgAr_Click);
            // 
            // bVD
            // 
            this.bVD.BackColor = System.Drawing.SystemColors.Control;
            this.bVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVD.Location = new System.Drawing.Point(549, 100);
            this.bVD.Name = "bVD";
            this.bVD.Size = new System.Drawing.Size(120, 38);
            this.bVD.TabIndex = 3;
            this.bVD.Text = "Ver datos";
            this.bVD.UseVisualStyleBackColor = false;
            this.bVD.Click += new System.EventHandler(this.bVD_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.bBuscar.BackgroundImage = global::TP2.Properties.Resources.search16;
            this.bBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Location = new System.Drawing.Point(394, 100);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(40, 38);
            this.bBuscar.TabIndex = 4;
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
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
            this.dGVDatos.Location = new System.Drawing.Point(21, 161);
            this.dGVDatos.Name = "dGVDatos";
            this.dGVDatos.RowTemplate.Height = 24;
            this.dGVDatos.Size = new System.Drawing.Size(1235, 281);
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
            this.tBBuscar.Location = new System.Drawing.Point(80, 109);
            this.tBBuscar.Name = "tBBuscar";
            this.tBBuscar.Size = new System.Drawing.Size(300, 19);
            this.tBBuscar.TabIndex = 6;
            // 
            // btAgClint
            // 
            this.btAgClint.BackColor = System.Drawing.SystemColors.Control;
            this.btAgClint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgClint.Location = new System.Drawing.Point(757, 28);
            this.btAgClint.Name = "btAgClint";
            this.btAgClint.Size = new System.Drawing.Size(120, 38);
            this.btAgClint.TabIndex = 7;
            this.btAgClint.Text = "Agregar cliente";
            this.btAgClint.UseVisualStyleBackColor = false;
            // 
            // iconButton0
            // 
            this.iconButton0.IconChar = FontAwesome.Sharp.IconChar.Glasses;
            this.iconButton0.IconColor = System.Drawing.Color.Black;
            this.iconButton0.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton0.Location = new System.Drawing.Point(414, 94);
            this.iconButton0.Name = "iconButton0";
            this.iconButton0.Size = new System.Drawing.Size(75, 48);
            this.iconButton0.TabIndex = 8;
            this.iconButton0.UseVisualStyleBackColor = true;
            // 
            // Frmpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1268, 464);
            this.Controls.Add(this.iconButton0);
            this.Controls.Add(this.btAgClint);
            this.Controls.Add(this.tBBuscar);
            this.Controls.Add(this.dGVDatos);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bVD);
            this.Controls.Add(this.bAgAr);
            this.Controls.Add(this.bAgJef);
            this.Controls.Add(this.bAgEm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button bBuscar;
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
        private FontAwesome.Sharp.IconButton iconButton0;
    }
}

