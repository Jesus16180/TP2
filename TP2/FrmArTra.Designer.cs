namespace TP2
{
    partial class FrmArTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArTra));
            this.lbArTra = new System.Windows.Forms.Label();
            this.bV = new System.Windows.Forms.Button();
            this.bSD = new System.Windows.Forms.Button();
            this.tBArTra = new System.Windows.Forms.TextBox();
            this.bSubDatArTra = new FontAwesome.Sharp.IconButton();
            this.bVolverArTra = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lbArTra
            // 
            this.lbArTra.AutoSize = true;
            this.lbArTra.Location = new System.Drawing.Point(35, 36);
            this.lbArTra.Name = "lbArTra";
            this.lbArTra.Size = new System.Drawing.Size(82, 13);
            this.lbArTra.TabIndex = 0;
            this.lbArTra.Text = "Área de trabajo:";
            // 
            // bV
            // 
            this.bV.BackColor = System.Drawing.SystemColors.Control;
            this.bV.Location = new System.Drawing.Point(70, 97);
            this.bV.Name = "bV";
            this.bV.Size = new System.Drawing.Size(70, 28);
            this.bV.TabIndex = 5;
            this.bV.Text = "Volver";
            this.bV.UseVisualStyleBackColor = false;
            this.bV.Click += new System.EventHandler(this.bV_Click);
            // 
            // bSD
            // 
            this.bSD.BackColor = System.Drawing.SystemColors.Control;
            this.bSD.Location = new System.Drawing.Point(204, 95);
            this.bSD.Name = "bSD";
            this.bSD.Size = new System.Drawing.Size(120, 30);
            this.bSD.TabIndex = 6;
            this.bSD.Text = "Subir datos";
            this.bSD.UseVisualStyleBackColor = false;
            this.bSD.Click += new System.EventHandler(this.bSD_Click);
            // 
            // tBArTra
            // 
            this.tBArTra.Location = new System.Drawing.Point(173, 33);
            this.tBArTra.Name = "tBArTra";
            this.tBArTra.Size = new System.Drawing.Size(187, 19);
            this.tBArTra.TabIndex = 7;
            // 
            // bSubDatArTra
            // 
            this.bSubDatArTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.bSubDatArTra.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.bSubDatArTra.IconColor = System.Drawing.Color.Black;
            this.bSubDatArTra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bSubDatArTra.IconSize = 32;
            this.bSubDatArTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSubDatArTra.Location = new System.Drawing.Point(216, 58);
            this.bSubDatArTra.Name = "bSubDatArTra";
            this.bSubDatArTra.Size = new System.Drawing.Size(108, 44);
            this.bSubDatArTra.TabIndex = 31;
            this.bSubDatArTra.Text = "Cargar area de trabajo";
            this.bSubDatArTra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSubDatArTra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSubDatArTra.UseVisualStyleBackColor = true;
            this.bSubDatArTra.Click += new System.EventHandler(this.bSubDatArTra_Click);
            // 
            // bVolverArTra
            // 
            this.bVolverArTra.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.bVolverArTra.IconColor = System.Drawing.Color.Black;
            this.bVolverArTra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVolverArTra.IconSize = 32;
            this.bVolverArTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolverArTra.Location = new System.Drawing.Point(70, 52);
            this.bVolverArTra.Name = "bVolverArTra";
            this.bVolverArTra.Size = new System.Drawing.Size(98, 44);
            this.bVolverArTra.TabIndex = 32;
            this.bVolverArTra.Text = "Volver";
            this.bVolverArTra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolverArTra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bVolverArTra.UseVisualStyleBackColor = true;
            this.bVolverArTra.Click += new System.EventHandler(this.bVolverArTra_Click);
            // 
            // FrmArTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(407, 157);
            this.Controls.Add(this.bVolverArTra);
            this.Controls.Add(this.bSubDatArTra);
            this.Controls.Add(this.tBArTra);
            this.Controls.Add(this.bSD);
            this.Controls.Add(this.bV);
            this.Controls.Add(this.lbArTra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmArTra";
            this.Text = "Área de trabajo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbArTra;
        private System.Windows.Forms.Button bV;
        private System.Windows.Forms.Button bSD;
        private System.Windows.Forms.TextBox tBArTra;
        private FontAwesome.Sharp.IconButton bSubDatArTra;
        private FontAwesome.Sharp.IconButton bVolverArTra;
    }
}