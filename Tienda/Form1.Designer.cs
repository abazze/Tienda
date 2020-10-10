namespace Tienda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.linkHistorial = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCamisa = new System.Windows.Forms.RadioButton();
            this.rdbPantalon = new System.Windows.Forms.RadioButton();
            this.chkManga = new System.Windows.Forms.CheckBox();
            this.chkCuello = new System.Windows.Forms.CheckBox();
            this.chkChupin = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbStandard = new System.Windows.Forms.RadioButton();
            this.rdbPremium = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizador Express";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDireccionTienda);
            this.panel2.Controls.Add(this.lblNombreTienda);
            this.panel2.Location = new System.Drawing.Point(1, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 34);
            this.panel2.TabIndex = 1;
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblNombreTienda.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNombreTienda.Location = new System.Drawing.Point(35, 8);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(102, 15);
            this.lblNombreTienda.TabIndex = 0;
            this.lblNombreTienda.Text = "NombreTienda";
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.AutoSize = true;
            this.lblDireccionTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDireccionTienda.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDireccionTienda.Location = new System.Drawing.Point(479, 8);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(112, 15);
            this.lblDireccionTienda.TabIndex = 1;
            this.lblDireccionTienda.Text = "DireccionTienda";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.linkHistorial);
            this.panel3.Controls.Add(this.lblVendedor);
            this.panel3.Location = new System.Drawing.Point(1, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 34);
            this.panel3.TabIndex = 2;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblVendedor.Location = new System.Drawing.Point(35, 9);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(267, 15);
            this.lblVendedor.TabIndex = 0;
            this.lblVendedor.Text = "Nombre y Apellido Vendedor | Código Vendedor";
            // 
            // linkHistorial
            // 
            this.linkHistorial.AutoSize = true;
            this.linkHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.linkHistorial.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkHistorial.Location = new System.Drawing.Point(466, 9);
            this.linkHistorial.Name = "linkHistorial";
            this.linkHistorial.Size = new System.Drawing.Size(125, 15);
            this.linkHistorial.TabIndex = 1;
            this.linkHistorial.TabStop = true;
            this.linkHistorial.Text = "Historial Cotizaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkChupin);
            this.groupBox1.Controls.Add(this.chkCuello);
            this.groupBox1.Controls.Add(this.chkManga);
            this.groupBox1.Controls.Add(this.rdbPantalon);
            this.groupBox1.Controls.Add(this.rdbCamisa);
            this.groupBox1.Location = new System.Drawing.Point(52, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            // 
            // rdbCamisa
            // 
            this.rdbCamisa.AutoSize = true;
            this.rdbCamisa.Checked = true;
            this.rdbCamisa.Location = new System.Drawing.Point(61, 28);
            this.rdbCamisa.Name = "rdbCamisa";
            this.rdbCamisa.Size = new System.Drawing.Size(59, 17);
            this.rdbCamisa.TabIndex = 0;
            this.rdbCamisa.TabStop = true;
            this.rdbCamisa.Text = "Camisa";
            this.rdbCamisa.UseVisualStyleBackColor = true;
            // 
            // rdbPantalon
            // 
            this.rdbPantalon.AutoSize = true;
            this.rdbPantalon.Location = new System.Drawing.Point(61, 64);
            this.rdbPantalon.Name = "rdbPantalon";
            this.rdbPantalon.Size = new System.Drawing.Size(67, 17);
            this.rdbPantalon.TabIndex = 1;
            this.rdbPantalon.Text = "Pantalón";
            this.rdbPantalon.UseVisualStyleBackColor = true;
            // 
            // chkManga
            // 
            this.chkManga.AutoSize = true;
            this.chkManga.Location = new System.Drawing.Point(219, 28);
            this.chkManga.Name = "chkManga";
            this.chkManga.Size = new System.Drawing.Size(86, 17);
            this.chkManga.TabIndex = 2;
            this.chkManga.Text = "Manga corta";
            this.chkManga.UseVisualStyleBackColor = true;
            // 
            // chkCuello
            // 
            this.chkCuello.AutoSize = true;
            this.chkCuello.Location = new System.Drawing.Point(360, 29);
            this.chkCuello.Name = "chkCuello";
            this.chkCuello.Size = new System.Drawing.Size(79, 17);
            this.chkCuello.TabIndex = 3;
            this.chkCuello.Text = "Cuello Mao";
            this.chkCuello.UseVisualStyleBackColor = true;
            // 
            // chkChupin
            // 
            this.chkChupin.AutoSize = true;
            this.chkChupin.Location = new System.Drawing.Point(219, 65);
            this.chkChupin.Name = "chkChupin";
            this.chkChupin.Size = new System.Drawing.Size(59, 17);
            this.chkChupin.TabIndex = 4;
            this.chkChupin.Text = "Chupin";
            this.chkChupin.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblUnidades);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(52, 262);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(523, 34);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unidades de stock disponibles:";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(218, 10);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(35, 13);
            this.lblUnidades.TabIndex = 1;
            this.lblUnidades.Text = "label3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbPremium);
            this.groupBox2.Controls.Add(this.rdbStandard);
            this.groupBox2.Location = new System.Drawing.Point(52, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de Prenda";
            // 
            // rdbStandard
            // 
            this.rdbStandard.AutoSize = true;
            this.rdbStandard.Checked = true;
            this.rdbStandard.Location = new System.Drawing.Point(63, 21);
            this.rdbStandard.Name = "rdbStandard";
            this.rdbStandard.Size = new System.Drawing.Size(68, 17);
            this.rdbStandard.TabIndex = 0;
            this.rdbStandard.TabStop = true;
            this.rdbStandard.Text = "Standard";
            this.rdbStandard.UseVisualStyleBackColor = true;
            // 
            // rdbPremium
            // 
            this.rdbPremium.AutoSize = true;
            this.rdbPremium.Location = new System.Drawing.Point(178, 21);
            this.rdbPremium.Name = "rdbPremium";
            this.rdbPremium.Size = new System.Drawing.Size(65, 17);
            this.rdbPremium.TabIndex = 1;
            this.rdbPremium.TabStop = true;
            this.rdbPremium.Text = "Premium";
            this.rdbPremium.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(375, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 50);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "$";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(70, 18);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblPrecioFinal);
            this.panel5.Controls.Add(this.btnCotizar);
            this.panel5.Location = new System.Drawing.Point(1, 390);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(628, 59);
            this.panel5.TabIndex = 7;
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.Color.White;
            this.btnCotizar.Location = new System.Drawing.Point(169, 12);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(124, 36);
            this.btnCotizar.TabIndex = 0;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = false;
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPrecioFinal.Location = new System.Drawing.Point(369, 19);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(18, 20);
            this.lblPrecioFinal.TabIndex = 1;
            this.lblPrecioFinal.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 451);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDireccionTienda;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkHistorial;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPantalon;
        private System.Windows.Forms.RadioButton rdbCamisa;
        private System.Windows.Forms.CheckBox chkChupin;
        private System.Windows.Forms.CheckBox chkCuello;
        private System.Windows.Forms.CheckBox chkManga;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbPremium;
        private System.Windows.Forms.RadioButton rdbStandard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Button btnCotizar;
    }
}

