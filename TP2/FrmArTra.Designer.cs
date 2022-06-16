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
            this.tBArTra = new System.Windows.Forms.TextBox();
            this.bSubDatArTra = new FontAwesome.Sharp.IconButton();
            this.bVolverArTra = new FontAwesome.Sharp.IconButton();
            this.lBArTras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbArTra
            // 
            this.lbArTra.AutoSize = true;
            this.lbArTra.Location = new System.Drawing.Point(19, 37);
            this.lbArTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbArTra.Name = "lbArTra";
            this.lbArTra.Size = new System.Drawing.Size(95, 12);
            this.lbArTra.TabIndex = 0;
            this.lbArTra.Text = "Área de trabajo:";
            // 
            // tBArTra
            // 
            this.tBArTra.Location = new System.Drawing.Point(122, 34);
            this.tBArTra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBArTra.Name = "tBArTra";
            this.tBArTra.Size = new System.Drawing.Size(238, 20);
            this.tBArTra.TabIndex = 7;
            // 
            // bSubDatArTra
            // 
            this.bSubDatArTra.BackColor = System.Drawing.SystemColors.Control;
            this.bSubDatArTra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubDatArTra.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.bSubDatArTra.IconColor = System.Drawing.Color.Black;
            this.bSubDatArTra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bSubDatArTra.IconSize = 32;
            this.bSubDatArTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSubDatArTra.Location = new System.Drawing.Point(164, 122);
            this.bSubDatArTra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSubDatArTra.Name = "bSubDatArTra";
            this.bSubDatArTra.Size = new System.Drawing.Size(196, 41);
            this.bSubDatArTra.TabIndex = 31;
            this.bSubDatArTra.Text = "Cargar area de trabajo";
            this.bSubDatArTra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSubDatArTra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSubDatArTra.UseVisualStyleBackColor = false;
            this.bSubDatArTra.Click += new System.EventHandler(this.bSubDatArTra_Click);
            // 
            // bVolverArTra
            // 
            this.bVolverArTra.BackColor = System.Drawing.SystemColors.Control;
            this.bVolverArTra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolverArTra.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.bVolverArTra.IconColor = System.Drawing.Color.Black;
            this.bVolverArTra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVolverArTra.IconSize = 32;
            this.bVolverArTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolverArTra.Location = new System.Drawing.Point(21, 122);
            this.bVolverArTra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolverArTra.Name = "bVolverArTra";
            this.bVolverArTra.Size = new System.Drawing.Size(100, 40);
            this.bVolverArTra.TabIndex = 32;
            this.bVolverArTra.Text = "Volver";
            this.bVolverArTra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolverArTra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bVolverArTra.UseVisualStyleBackColor = false;
            this.bVolverArTra.Click += new System.EventHandler(this.bVolverArTra_Click);
            // 
            // lBArTras
            // 
            this.lBArTras.FormattingEnabled = true;
            this.lBArTras.ItemHeight = 12;
            this.lBArTras.Location = new System.Drawing.Point(390, 34);
            this.lBArTras.Name = "lBArTras";
            this.lBArTras.Size = new System.Drawing.Size(230, 148);
            this.lBArTras.TabIndex = 33;
            // 
            // FrmArTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(626, 197);
            this.Controls.Add(this.lBArTras);
            this.Controls.Add(this.bVolverArTra);
            this.Controls.Add(this.bSubDatArTra);
            this.Controls.Add(this.tBArTra);
            this.Controls.Add(this.lbArTra);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmArTra";
            this.Text = "Área de trabajo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbArTra;
        private System.Windows.Forms.TextBox tBArTra;
        private FontAwesome.Sharp.IconButton bSubDatArTra;
        private FontAwesome.Sharp.IconButton bVolverArTra;
        private System.Windows.Forms.ListBox lBArTras;
    }
}