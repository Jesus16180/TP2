namespace TP2
{
    partial class FrmEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmp));
            this.lbID = new System.Windows.Forms.Label();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.cBArTra = new System.Windows.Forms.ComboBox();
            this.lbIDEmp = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbApe = new System.Windows.Forms.Label();
            this.lbCUIL = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbArTra = new System.Windows.Forms.Label();
            this.tBTel = new System.Windows.Forms.TextBox();
            this.tBAp = new System.Windows.Forms.TextBox();
            this.tBCUIL = new System.Windows.Forms.TextBox();
            this.lbIDJ = new System.Windows.Forms.Label();
            this.cBIDJef = new System.Windows.Forms.ComboBox();
            this.bSubDatEmple = new FontAwesome.Sharp.IconButton();
            this.bVolverEmple = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(79, 31);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(19, 12);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID:";
            // 
            // tBNom
            // 
            this.tBNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNom.Location = new System.Drawing.Point(206, 72);
            this.tBNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(198, 19);
            this.tBNom.TabIndex = 1;
            // 
            // cBArTra
            // 
            this.cBArTra.BackColor = System.Drawing.SystemColors.Window;
            this.cBArTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBArTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBArTra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cBArTra.FormattingEnabled = true;
            this.cBArTra.Location = new System.Drawing.Point(206, 235);
            this.cBArTra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBArTra.Name = "cBArTra";
            this.cBArTra.Size = new System.Drawing.Size(198, 21);
            this.cBArTra.TabIndex = 3;
            // 
            // lbIDEmp
            // 
            this.lbIDEmp.AutoSize = true;
            this.lbIDEmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDEmp.Location = new System.Drawing.Point(249, 31);
            this.lbIDEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDEmp.Name = "lbIDEmp";
            this.lbIDEmp.Size = new System.Drawing.Size(106, 12);
            this.lbIDEmp.TabIndex = 4;
            this.lbIDEmp.Text = "//auto_incremento";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(52, 75);
            this.lbNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(52, 12);
            this.lbNom.TabIndex = 5;
            this.lbNom.Text = "Nombre:";
            // 
            // lbApe
            // 
            this.lbApe.AutoSize = true;
            this.lbApe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApe.Location = new System.Drawing.Point(54, 116);
            this.lbApe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbApe.Name = "lbApe";
            this.lbApe.Size = new System.Drawing.Size(53, 12);
            this.lbApe.TabIndex = 6;
            this.lbApe.Text = "Apellido:";
            // 
            // lbCUIL
            // 
            this.lbCUIL.AutoSize = true;
            this.lbCUIL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCUIL.Location = new System.Drawing.Point(64, 156);
            this.lbCUIL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCUIL.Name = "lbCUIL";
            this.lbCUIL.Size = new System.Drawing.Size(34, 12);
            this.lbCUIL.TabIndex = 7;
            this.lbCUIL.Text = "CUIL:";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.Location = new System.Drawing.Point(52, 195);
            this.lbTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(57, 12);
            this.lbTel.TabIndex = 8;
            this.lbTel.Text = "Teléfono:";
            // 
            // lbArTra
            // 
            this.lbArTra.AutoSize = true;
            this.lbArTra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArTra.Location = new System.Drawing.Point(31, 237);
            this.lbArTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbArTra.Name = "lbArTra";
            this.lbArTra.Size = new System.Drawing.Size(95, 12);
            this.lbArTra.TabIndex = 9;
            this.lbArTra.Text = "Área de trabajo:";
            // 
            // tBTel
            // 
            this.tBTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTel.Location = new System.Drawing.Point(206, 192);
            this.tBTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBTel.Name = "tBTel";
            this.tBTel.Size = new System.Drawing.Size(198, 19);
            this.tBTel.TabIndex = 10;
            // 
            // tBAp
            // 
            this.tBAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAp.Location = new System.Drawing.Point(206, 114);
            this.tBAp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBAp.Name = "tBAp";
            this.tBAp.Size = new System.Drawing.Size(198, 19);
            this.tBAp.TabIndex = 10;
            // 
            // tBCUIL
            // 
            this.tBCUIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCUIL.Location = new System.Drawing.Point(206, 153);
            this.tBCUIL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBCUIL.Name = "tBCUIL";
            this.tBCUIL.Size = new System.Drawing.Size(198, 19);
            this.tBCUIL.TabIndex = 11;
            // 
            // lbIDJ
            // 
            this.lbIDJ.AutoSize = true;
            this.lbIDJ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDJ.Location = new System.Drawing.Point(45, 283);
            this.lbIDJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDJ.Name = "lbIDJ";
            this.lbIDJ.Size = new System.Drawing.Size(60, 12);
            this.lbIDJ.TabIndex = 12;
            this.lbIDJ.Text = "ID de jefe:";
            // 
            // cBIDJef
            // 
            this.cBIDJef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBIDJef.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBIDJef.FormattingEnabled = true;
            this.cBIDJef.Location = new System.Drawing.Point(206, 280);
            this.cBIDJef.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBIDJef.Name = "cBIDJef";
            this.cBIDJef.Size = new System.Drawing.Size(198, 21);
            this.cBIDJef.TabIndex = 13;
            // 
            // bSubDatEmple
            // 
            this.bSubDatEmple.BackColor = System.Drawing.SystemColors.Control;
            this.bSubDatEmple.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.bSubDatEmple.IconColor = System.Drawing.Color.Black;
            this.bSubDatEmple.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bSubDatEmple.IconSize = 32;
            this.bSubDatEmple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSubDatEmple.Location = new System.Drawing.Point(251, 336);
            this.bSubDatEmple.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSubDatEmple.Name = "bSubDatEmple";
            this.bSubDatEmple.Size = new System.Drawing.Size(153, 41);
            this.bSubDatEmple.TabIndex = 31;
            this.bSubDatEmple.Text = "Cargar empleado";
            this.bSubDatEmple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSubDatEmple.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSubDatEmple.UseVisualStyleBackColor = false;
            this.bSubDatEmple.Click += new System.EventHandler(this.bSubDatEmple_Click);
            // 
            // bVolverEmple
            // 
            this.bVolverEmple.BackColor = System.Drawing.SystemColors.Control;
            this.bVolverEmple.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bVolverEmple.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.bVolverEmple.IconColor = System.Drawing.Color.Black;
            this.bVolverEmple.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVolverEmple.IconSize = 32;
            this.bVolverEmple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolverEmple.Location = new System.Drawing.Point(47, 336);
            this.bVolverEmple.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolverEmple.Name = "bVolverEmple";
            this.bVolverEmple.Size = new System.Drawing.Size(100, 40);
            this.bVolverEmple.TabIndex = 32;
            this.bVolverEmple.Text = "Volver";
            this.bVolverEmple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolverEmple.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bVolverEmple.UseVisualStyleBackColor = false;
            this.bVolverEmple.Click += new System.EventHandler(this.bVolverEmple_Click);
            // 
            // FrmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(447, 400);
            this.Controls.Add(this.bVolverEmple);
            this.Controls.Add(this.bSubDatEmple);
            this.Controls.Add(this.cBIDJef);
            this.Controls.Add(this.lbIDJ);
            this.Controls.Add(this.tBCUIL);
            this.Controls.Add(this.tBAp);
            this.Controls.Add(this.tBTel);
            this.Controls.Add(this.lbArTra);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.lbCUIL);
            this.Controls.Add(this.lbApe);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbIDEmp);
            this.Controls.Add(this.cBArTra);
            this.Controls.Add(this.tBNom);
            this.Controls.Add(this.lbID);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmEmp";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FormEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.ComboBox cBArTra;
        private System.Windows.Forms.Label lbIDEmp;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbApe;
        private System.Windows.Forms.Label lbCUIL;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbArTra;
        private System.Windows.Forms.TextBox tBTel;
        private System.Windows.Forms.TextBox tBAp;
        private System.Windows.Forms.TextBox tBCUIL;
        private System.Windows.Forms.Label lbIDJ;
        private System.Windows.Forms.ComboBox cBIDJef;
        private FontAwesome.Sharp.IconButton bSubDatEmple;
        private FontAwesome.Sharp.IconButton bVolverEmple;
    }
}