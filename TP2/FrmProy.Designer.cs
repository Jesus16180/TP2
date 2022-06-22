namespace TP2
{
    partial class FrmProy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProy));
            this.tBNom = new System.Windows.Forms.TextBox();
            this.tbAp = new System.Windows.Forms.TextBox();
            this.tBProj = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbAp = new System.Windows.Forms.Label();
            this.lbProj = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.tBCost = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.tBTel = new System.Windows.Forms.TextBox();
            this.cBJef = new System.Windows.Forms.ComboBox();
            this.lbJef = new System.Windows.Forms.Label();
            this.lbEstDate = new System.Windows.Forms.Label();
            this.nUDDE = new System.Windows.Forms.NumericUpDown();
            this.bVolverProy = new FontAwesome.Sharp.IconButton();
            this.bSubDatProy = new FontAwesome.Sharp.IconButton();
            this.lbID = new System.Windows.Forms.Label();
            this.lbIDProy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDE)).BeginInit();
            this.SuspendLayout();
            // 
            // tBNom
            // 
            this.tBNom.Location = new System.Drawing.Point(472, 67);
            this.tBNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(174, 20);
            this.tBNom.TabIndex = 2;
            // 
            // tbAp
            // 
            this.tbAp.Location = new System.Drawing.Point(472, 106);
            this.tbAp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAp.Name = "tbAp";
            this.tbAp.Size = new System.Drawing.Size(174, 20);
            this.tbAp.TabIndex = 3;
            // 
            // tBProj
            // 
            this.tBProj.Location = new System.Drawing.Point(121, 64);
            this.tBProj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBProj.Name = "tBProj";
            this.tBProj.Size = new System.Drawing.Size(174, 20);
            this.tBProj.TabIndex = 5;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(345, 73);
            this.lbNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(98, 13);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "Nombre del cliente:";
            // 
            // lbAp
            // 
            this.lbAp.AutoSize = true;
            this.lbAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAp.Location = new System.Drawing.Point(367, 115);
            this.lbAp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAp.Name = "lbAp";
            this.lbAp.Size = new System.Drawing.Size(47, 13);
            this.lbAp.TabIndex = 7;
            this.lbAp.Text = "Apellido:";
            // 
            // lbProj
            // 
            this.lbProj.AutoSize = true;
            this.lbProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProj.Location = new System.Drawing.Point(24, 67);
            this.lbProj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProj.Name = "lbProj";
            this.lbProj.Size = new System.Drawing.Size(52, 13);
            this.lbProj.TabIndex = 8;
            this.lbProj.Text = "Proyecto:";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(32, 109);
            this.lbCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(37, 13);
            this.lbCost.TabIndex = 9;
            this.lbCost.Text = "Costo:";
            // 
            // tBCost
            // 
            this.tBCost.Location = new System.Drawing.Point(121, 105);
            this.tBCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBCost.Name = "tBCost";
            this.tBCost.Size = new System.Drawing.Size(174, 20);
            this.tBCost.TabIndex = 11;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.Location = new System.Drawing.Point(367, 155);
            this.lbTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(52, 13);
            this.lbTel.TabIndex = 12;
            this.lbTel.Text = "Teléfono:";
            // 
            // tBTel
            // 
            this.tBTel.Location = new System.Drawing.Point(472, 152);
            this.tBTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBTel.Name = "tBTel";
            this.tBTel.Size = new System.Drawing.Size(174, 20);
            this.tBTel.TabIndex = 13;
            // 
            // cBJef
            // 
            this.cBJef.FormattingEnabled = true;
            this.cBJef.Location = new System.Drawing.Point(121, 149);
            this.cBJef.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBJef.Name = "cBJef";
            this.cBJef.Size = new System.Drawing.Size(174, 21);
            this.cBJef.TabIndex = 14;
            // 
            // lbJef
            // 
            this.lbJef.AutoSize = true;
            this.lbJef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJef.Location = new System.Drawing.Point(32, 152);
            this.lbJef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJef.Name = "lbJef";
            this.lbJef.Size = new System.Drawing.Size(30, 13);
            this.lbJef.TabIndex = 15;
            this.lbJef.Text = "Jefe:";
            // 
            // lbEstDate
            // 
            this.lbEstDate.AutoSize = true;
            this.lbEstDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstDate.Location = new System.Drawing.Point(351, 28);
            this.lbEstDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstDate.Name = "lbEstDate";
            this.lbEstDate.Size = new System.Drawing.Size(83, 13);
            this.lbEstDate.TabIndex = 16;
            this.lbEstDate.Text = "Días estimados:";
            // 
            // nUDDE
            // 
            this.nUDDE.Location = new System.Drawing.Point(472, 26);
            this.nUDDE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nUDDE.Name = "nUDDE";
            this.nUDDE.Size = new System.Drawing.Size(175, 20);
            this.nUDDE.TabIndex = 17;
            // 
            // bVolverProy
            // 
            this.bVolverProy.BackColor = System.Drawing.SystemColors.Control;
            this.bVolverProy.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.bVolverProy.IconColor = System.Drawing.Color.Black;
            this.bVolverProy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVolverProy.IconSize = 32;
            this.bVolverProy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolverProy.Location = new System.Drawing.Point(19, 196);
            this.bVolverProy.Margin = new System.Windows.Forms.Padding(0);
            this.bVolverProy.Name = "bVolverProy";
            this.bVolverProy.Size = new System.Drawing.Size(100, 40);
            this.bVolverProy.TabIndex = 33;
            this.bVolverProy.Text = "Volver";
            this.bVolverProy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bVolverProy.UseVisualStyleBackColor = false;
            this.bVolverProy.Click += new System.EventHandler(this.bVolverCliente_Click);
            // 
            // bSubDatProy
            // 
            this.bSubDatProy.BackColor = System.Drawing.SystemColors.Control;
            this.bSubDatProy.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.bSubDatProy.IconColor = System.Drawing.Color.Black;
            this.bSubDatProy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bSubDatProy.IconSize = 32;
            this.bSubDatProy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSubDatProy.Location = new System.Drawing.Point(512, 196);
            this.bSubDatProy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSubDatProy.Name = "bSubDatProy";
            this.bSubDatProy.Size = new System.Drawing.Size(135, 41);
            this.bSubDatProy.TabIndex = 32;
            this.bSubDatProy.Text = "Cargar proyecto";
            this.bSubDatProy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSubDatProy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSubDatProy.UseVisualStyleBackColor = false;
            this.bSubDatProy.Click += new System.EventHandler(this.bSubDatCliente_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(45, 28);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 34;
            this.lbID.Text = "ID:";
            // 
            // lbIDProy
            // 
            this.lbIDProy.AutoSize = true;
            this.lbIDProy.Location = new System.Drawing.Point(144, 28);
            this.lbIDProy.Name = "lbIDProy";
            this.lbIDProy.Size = new System.Drawing.Size(96, 13);
            this.lbIDProy.TabIndex = 35;
            this.lbIDProy.Text = "//auto_incremento";
            // 
            // FrmProy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(669, 259);
            this.Controls.Add(this.lbIDProy);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.bVolverProy);
            this.Controls.Add(this.bSubDatProy);
            this.Controls.Add(this.nUDDE);
            this.Controls.Add(this.lbEstDate);
            this.Controls.Add(this.lbJef);
            this.Controls.Add(this.cBJef);
            this.Controls.Add(this.tBTel);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.tBCost);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.lbProj);
            this.Controls.Add(this.lbAp);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.tBProj);
            this.Controls.Add(this.tbAp);
            this.Controls.Add(this.tBNom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmProy";
            this.Text = "Proyecto";
            ((System.ComponentModel.ISupportInitialize)(this.nUDDE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.TextBox tbAp;
        private System.Windows.Forms.TextBox tBProj;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbAp;
        private System.Windows.Forms.Label lbProj;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.TextBox tBCost;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox tBTel;
        private System.Windows.Forms.ComboBox cBJef;
        private System.Windows.Forms.Label lbJef;
        private System.Windows.Forms.Label lbEstDate;
        private System.Windows.Forms.NumericUpDown nUDDE;
        private FontAwesome.Sharp.IconButton bSubDatProy;
        private FontAwesome.Sharp.IconButton bVolverProy;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbIDProy;
    }
}