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
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
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
            // iconButton5
            // 
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(216, 58);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(108, 44);
            this.iconButton5.TabIndex = 31;
            this.iconButton5.Text = "Cargar area de trabajo";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 32;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(70, 52);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(98, 44);
            this.iconButton6.TabIndex = 32;
            this.iconButton6.Text = "Volver";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // FrmArTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(407, 157);
            this.Controls.Add(this.iconButton6);
            this.Controls.Add(this.iconButton5);
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
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
    }
}