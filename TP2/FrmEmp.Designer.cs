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
            this.bSubD = new System.Windows.Forms.Button();
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
            this.bV = new System.Windows.Forms.Button();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(88, 31);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID:";
            // 
            // tBNom
            // 
            this.tBNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNom.Location = new System.Drawing.Point(197, 76);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(170, 19);
            this.tBNom.TabIndex = 1;
            // 
            // bSubD
            // 
            this.bSubD.BackColor = System.Drawing.SystemColors.Control;
            this.bSubD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubD.Location = new System.Drawing.Point(227, 368);
            this.bSubD.Name = "bSubD";
            this.bSubD.Size = new System.Drawing.Size(120, 28);
            this.bSubD.TabIndex = 2;
            this.bSubD.Text = "Subir datos";
            this.bSubD.UseVisualStyleBackColor = false;
            this.bSubD.Click += new System.EventHandler(this.bSubD_Click);
            // 
            // cBArTra
            // 
            this.cBArTra.BackColor = System.Drawing.SystemColors.Window;
            this.cBArTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBArTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBArTra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cBArTra.FormattingEnabled = true;
            this.cBArTra.Location = new System.Drawing.Point(197, 252);
            this.cBArTra.Name = "cBArTra";
            this.cBArTra.Size = new System.Drawing.Size(170, 21);
            this.cBArTra.TabIndex = 3;
            // 
            // lbIDEmp
            // 
            this.lbIDEmp.AutoSize = true;
            this.lbIDEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDEmp.Location = new System.Drawing.Point(224, 31);
            this.lbIDEmp.Name = "lbIDEmp";
            this.lbIDEmp.Size = new System.Drawing.Size(96, 13);
            this.lbIDEmp.TabIndex = 4;
            this.lbIDEmp.Text = "//auto_incremento";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(65, 79);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(47, 13);
            this.lbNom.TabIndex = 5;
            this.lbNom.Text = "Nombre:";
            // 
            // lbApe
            // 
            this.lbApe.AutoSize = true;
            this.lbApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApe.Location = new System.Drawing.Point(67, 124);
            this.lbApe.Name = "lbApe";
            this.lbApe.Size = new System.Drawing.Size(47, 13);
            this.lbApe.TabIndex = 6;
            this.lbApe.Text = "Apellido:";
            // 
            // lbCUIL
            // 
            this.lbCUIL.AutoSize = true;
            this.lbCUIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCUIL.Location = new System.Drawing.Point(75, 167);
            this.lbCUIL.Name = "lbCUIL";
            this.lbCUIL.Size = new System.Drawing.Size(34, 13);
            this.lbCUIL.TabIndex = 7;
            this.lbCUIL.Text = "CUIL:";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.Location = new System.Drawing.Point(65, 209);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(52, 13);
            this.lbTel.TabIndex = 8;
            this.lbTel.Text = "Teléfono:";
            // 
            // lbArTra
            // 
            this.lbArTra.AutoSize = true;
            this.lbArTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArTra.Location = new System.Drawing.Point(47, 255);
            this.lbArTra.Name = "lbArTra";
            this.lbArTra.Size = new System.Drawing.Size(82, 13);
            this.lbArTra.TabIndex = 9;
            this.lbArTra.Text = "Área de trabajo:";
            // 
            // tBTel
            // 
            this.tBTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTel.Location = new System.Drawing.Point(197, 206);
            this.tBTel.Name = "tBTel";
            this.tBTel.Size = new System.Drawing.Size(170, 19);
            this.tBTel.TabIndex = 10;
            // 
            // tBAp
            // 
            this.tBAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAp.Location = new System.Drawing.Point(197, 121);
            this.tBAp.Name = "tBAp";
            this.tBAp.Size = new System.Drawing.Size(170, 19);
            this.tBAp.TabIndex = 10;
            // 
            // tBCUIL
            // 
            this.tBCUIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCUIL.Location = new System.Drawing.Point(197, 164);
            this.tBCUIL.Name = "tBCUIL";
            this.tBCUIL.Size = new System.Drawing.Size(170, 19);
            this.tBCUIL.TabIndex = 11;
            // 
            // lbIDJ
            // 
            this.lbIDJ.AutoSize = true;
            this.lbIDJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDJ.Location = new System.Drawing.Point(59, 304);
            this.lbIDJ.Name = "lbIDJ";
            this.lbIDJ.Size = new System.Drawing.Size(56, 13);
            this.lbIDJ.TabIndex = 12;
            this.lbIDJ.Text = "ID de jefe:";
            // 
            // cBIDJef
            // 
            this.cBIDJef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBIDJef.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBIDJef.FormattingEnabled = true;
            this.cBIDJef.Location = new System.Drawing.Point(197, 301);
            this.cBIDJef.Name = "cBIDJef";
            this.cBIDJef.Size = new System.Drawing.Size(170, 21);
            this.cBIDJef.TabIndex = 13;
            // 
            // bV
            // 
            this.bV.BackColor = System.Drawing.SystemColors.Control;
            this.bV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bV.Location = new System.Drawing.Point(64, 368);
            this.bV.Name = "bV";
            this.bV.Size = new System.Drawing.Size(70, 28);
            this.bV.TabIndex = 14;
            this.bV.Text = "Volver";
            this.bV.UseVisualStyleBackColor = false;
            this.bV.Click += new System.EventHandler(this.bV_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(236, 318);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(98, 44);
            this.iconButton3.TabIndex = 31;
            this.iconButton3.Text = "Cargar empleado";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(50, 320);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(98, 44);
            this.iconButton4.TabIndex = 32;
            this.iconButton4.Text = "Volver";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // FrmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(419, 429);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.bV);
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
            this.Controls.Add(this.bSubD);
            this.Controls.Add(this.tBNom);
            this.Controls.Add(this.lbID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmp";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FormEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.Button bSubD;
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
        private System.Windows.Forms.Button bV;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}