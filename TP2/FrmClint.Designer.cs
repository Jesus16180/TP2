namespace TP2
{
    partial class FrmClint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClint));
            this.butV = new System.Windows.Forms.Button();
            this.butSD = new System.Windows.Forms.Button();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.tbAp = new System.Windows.Forms.TextBox();
            this.tBProj = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbAp = new System.Windows.Forms.Label();
            this.lbProj = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.tBCost = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbJef = new System.Windows.Forms.Label();
            this.lbEstDate = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // butV
            // 
            this.butV.BackColor = System.Drawing.SystemColors.Control;
            this.butV.Location = new System.Drawing.Point(47, 222);
            this.butV.Name = "butV";
            this.butV.Size = new System.Drawing.Size(70, 28);
            this.butV.TabIndex = 0;
            this.butV.Text = "Volver";
            this.butV.UseVisualStyleBackColor = false;
            this.butV.Click += new System.EventHandler(this.butV_Click);
            // 
            // butSD
            // 
            this.butSD.BackColor = System.Drawing.SystemColors.Control;
            this.butSD.Location = new System.Drawing.Point(449, 222);
            this.butSD.Name = "butSD";
            this.butSD.Size = new System.Drawing.Size(120, 28);
            this.butSD.TabIndex = 1;
            this.butSD.Text = "Subir datos";
            this.butSD.UseVisualStyleBackColor = false;
            // 
            // tBNom
            // 
            this.tBNom.Location = new System.Drawing.Point(128, 28);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(150, 20);
            this.tBNom.TabIndex = 2;
            // 
            // tbAp
            // 
            this.tbAp.Location = new System.Drawing.Point(128, 70);
            this.tbAp.Name = "tbAp";
            this.tbAp.Size = new System.Drawing.Size(150, 20);
            this.tbAp.TabIndex = 3;
            // 
            // tBProj
            // 
            this.tBProj.Location = new System.Drawing.Point(419, 28);
            this.tBProj.Name = "tBProj";
            this.tBProj.Size = new System.Drawing.Size(150, 20);
            this.tBProj.TabIndex = 5;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(45, 30);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(47, 13);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "Nombre:";
            // 
            // lbAp
            // 
            this.lbAp.AutoSize = true;
            this.lbAp.Location = new System.Drawing.Point(45, 77);
            this.lbAp.Name = "lbAp";
            this.lbAp.Size = new System.Drawing.Size(47, 13);
            this.lbAp.TabIndex = 7;
            this.lbAp.Text = "Apellido:";
            // 
            // lbProj
            // 
            this.lbProj.AutoSize = true;
            this.lbProj.Location = new System.Drawing.Point(336, 31);
            this.lbProj.Name = "lbProj";
            this.lbProj.Size = new System.Drawing.Size(52, 13);
            this.lbProj.TabIndex = 8;
            this.lbProj.Text = "Proyecto:";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Location = new System.Drawing.Point(336, 76);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(37, 13);
            this.lbCost.TabIndex = 9;
            this.lbCost.Text = "Costo:";
            // 
            // tBCost
            // 
            this.tBCost.Location = new System.Drawing.Point(419, 73);
            this.tBCost.Name = "tBCost";
            this.tBCost.Size = new System.Drawing.Size(150, 20);
            this.tBCost.TabIndex = 11;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(42, 120);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(52, 13);
            this.lbTel.TabIndex = 12;
            this.lbTel.Text = "Teléfono:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(419, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // lbJef
            // 
            this.lbJef.AutoSize = true;
            this.lbJef.Location = new System.Drawing.Point(336, 128);
            this.lbJef.Name = "lbJef";
            this.lbJef.Size = new System.Drawing.Size(30, 13);
            this.lbJef.TabIndex = 15;
            this.lbJef.Text = "Jefe:";
            // 
            // lbEstDate
            // 
            this.lbEstDate.AutoSize = true;
            this.lbEstDate.Location = new System.Drawing.Point(302, 171);
            this.lbEstDate.Name = "lbEstDate";
            this.lbEstDate.Size = new System.Drawing.Size(83, 13);
            this.lbEstDate.TabIndex = 16;
            this.lbEstDate.Text = "Días estimados:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(419, 169);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 20);
            this.numericUpDown1.TabIndex = 17;
            // 
            // iconButton7
            // 
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 32;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(345, 206);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(98, 44);
            this.iconButton7.TabIndex = 32;
            this.iconButton7.Text = "Cargar cliente";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // iconButton8
            // 
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 32;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(60, 184);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(98, 44);
            this.iconButton8.TabIndex = 33;
            this.iconButton8.Text = "Volver";
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // FrmClint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(608, 281);
            this.Controls.Add(this.iconButton8);
            this.Controls.Add(this.iconButton7);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbEstDate);
            this.Controls.Add(this.lbJef);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.tBCost);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.lbProj);
            this.Controls.Add(this.lbAp);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.tBProj);
            this.Controls.Add(this.tbAp);
            this.Controls.Add(this.tBNom);
            this.Controls.Add(this.butSD);
            this.Controls.Add(this.butV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClint";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butV;
        private System.Windows.Forms.Button butSD;
        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.TextBox tbAp;
        private System.Windows.Forms.TextBox tBProj;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbAp;
        private System.Windows.Forms.Label lbProj;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.TextBox tBCost;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbJef;
        private System.Windows.Forms.Label lbEstDate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton8;
    }
}