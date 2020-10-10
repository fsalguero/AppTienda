namespace AppTienda
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelNombreTienda = new System.Windows.Forms.Label();
            this.labelDireccionTienda = new System.Windows.Forms.Label();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.buttonHistorial = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radioButtonCamisa = new System.Windows.Forms.RadioButton();
            this.checkBoxMangaCorta = new System.Windows.Forms.CheckBox();
            this.checkBoxCuelloMao = new System.Windows.Forms.CheckBox();
            this.checkBoxChupin = new System.Windows.Forms.CheckBox();
            this.labelDisponibles = new System.Windows.Forms.Label();
            this.textBoxDisponibles = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonSantard = new System.Windows.Forms.RadioButton();
            this.radioButtonPremium = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.buttonCotizar = new System.Windows.Forms.Button();
            this.textBoxCotizacion = new System.Windows.Forms.TextBox();
            this.radioButtonPantalon = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDireccionTienda);
            this.groupBox1.Controls.Add(this.labelNombreTienda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonHistorial);
            this.groupBox2.Controls.Add(this.labelVendedor);
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.textBoxDisponibles);
            this.groupBox3.Controls.Add(this.labelDisponibles);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(12, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 278);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxCotizacion);
            this.groupBox4.Controls.Add(this.buttonCotizar);
            this.groupBox4.Location = new System.Drawing.Point(12, 400);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(559, 62);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // labelNombreTienda
            // 
            this.labelNombreTienda.AutoSize = true;
            this.labelNombreTienda.Location = new System.Drawing.Point(17, 17);
            this.labelNombreTienda.Name = "labelNombreTienda";
            this.labelNombreTienda.Size = new System.Drawing.Size(80, 13);
            this.labelNombreTienda.TabIndex = 0;
            this.labelNombreTienda.Text = "Nombre Tienda";
            // 
            // labelDireccionTienda
            // 
            this.labelDireccionTienda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDireccionTienda.AutoSize = true;
            this.labelDireccionTienda.Location = new System.Drawing.Point(460, 17);
            this.labelDireccionTienda.Name = "labelDireccionTienda";
            this.labelDireccionTienda.Size = new System.Drawing.Size(84, 13);
            this.labelDireccionTienda.TabIndex = 1;
            this.labelDireccionTienda.Text = "Dirección tienda";
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Location = new System.Drawing.Point(17, 17);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(216, 13);
            this.labelVendedor.TabIndex = 0;
            this.labelVendedor.Text = "Nombre y apellido vendedor - codigo vendor";
            // 
            // buttonHistorial
            // 
            this.buttonHistorial.Location = new System.Drawing.Point(398, 12);
            this.buttonHistorial.Name = "buttonHistorial";
            this.buttonHistorial.Size = new System.Drawing.Size(142, 26);
            this.buttonHistorial.TabIndex = 1;
            this.buttonHistorial.Text = "Historial de cotizaciones";
            this.buttonHistorial.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.splitContainer1);
            this.groupBox5.Location = new System.Drawing.Point(18, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(524, 123);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prenda";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxCuelloMao);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxMangaCorta);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonCamisa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.radioButtonPantalon);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxChupin);
            this.splitContainer1.Size = new System.Drawing.Size(518, 104);
            this.splitContainer1.TabIndex = 0;
            // 
            // radioButtonCamisa
            // 
            this.radioButtonCamisa.AutoSize = true;
            this.radioButtonCamisa.Location = new System.Drawing.Point(15, 16);
            this.radioButtonCamisa.Name = "radioButtonCamisa";
            this.radioButtonCamisa.Size = new System.Drawing.Size(59, 17);
            this.radioButtonCamisa.TabIndex = 0;
            this.radioButtonCamisa.TabStop = true;
            this.radioButtonCamisa.Text = "Camisa";
            this.radioButtonCamisa.UseVisualStyleBackColor = true;
            // 
            // checkBoxMangaCorta
            // 
            this.checkBoxMangaCorta.AutoSize = true;
            this.checkBoxMangaCorta.Location = new System.Drawing.Point(259, 16);
            this.checkBoxMangaCorta.Name = "checkBoxMangaCorta";
            this.checkBoxMangaCorta.Size = new System.Drawing.Size(86, 17);
            this.checkBoxMangaCorta.TabIndex = 1;
            this.checkBoxMangaCorta.Text = "Manga corta";
            this.checkBoxMangaCorta.UseVisualStyleBackColor = true;
            // 
            // checkBoxCuelloMao
            // 
            this.checkBoxCuelloMao.AutoSize = true;
            this.checkBoxCuelloMao.Location = new System.Drawing.Point(381, 16);
            this.checkBoxCuelloMao.Name = "checkBoxCuelloMao";
            this.checkBoxCuelloMao.Size = new System.Drawing.Size(78, 17);
            this.checkBoxCuelloMao.TabIndex = 2;
            this.checkBoxCuelloMao.Text = "Cuello mao";
            this.checkBoxCuelloMao.UseVisualStyleBackColor = true;
            // 
            // checkBoxChupin
            // 
            this.checkBoxChupin.AutoSize = true;
            this.checkBoxChupin.Location = new System.Drawing.Point(259, 16);
            this.checkBoxChupin.Name = "checkBoxChupin";
            this.checkBoxChupin.Size = new System.Drawing.Size(61, 17);
            this.checkBoxChupin.TabIndex = 2;
            this.checkBoxChupin.Text = "Chupín";
            this.checkBoxChupin.UseVisualStyleBackColor = true;
            // 
            // labelDisponibles
            // 
            this.labelDisponibles.AutoSize = true;
            this.labelDisponibles.Location = new System.Drawing.Point(20, 165);
            this.labelDisponibles.Name = "labelDisponibles";
            this.labelDisponibles.Size = new System.Drawing.Size(157, 13);
            this.labelDisponibles.TabIndex = 1;
            this.labelDisponibles.Text = "Unidades de stock disponibles: ";
            // 
            // textBoxDisponibles
            // 
            this.textBoxDisponibles.Location = new System.Drawing.Point(188, 162);
            this.textBoxDisponibles.Name = "textBoxDisponibles";
            this.textBoxDisponibles.Size = new System.Drawing.Size(131, 20);
            this.textBoxDisponibles.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButtonPremium);
            this.groupBox6.Controls.Add(this.radioButtonSantard);
            this.groupBox6.Location = new System.Drawing.Point(20, 202);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(353, 52);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Calidad de la prenda";
            // 
            // radioButtonSantard
            // 
            this.radioButtonSantard.AutoSize = true;
            this.radioButtonSantard.Location = new System.Drawing.Point(36, 18);
            this.radioButtonSantard.Name = "radioButtonSantard";
            this.radioButtonSantard.Size = new System.Drawing.Size(68, 17);
            this.radioButtonSantard.TabIndex = 0;
            this.radioButtonSantard.TabStop = true;
            this.radioButtonSantard.Text = "Standard";
            this.radioButtonSantard.UseVisualStyleBackColor = true;
            // 
            // radioButtonPremium
            // 
            this.radioButtonPremium.AutoSize = true;
            this.radioButtonPremium.Location = new System.Drawing.Point(211, 18);
            this.radioButtonPremium.Name = "radioButtonPremium";
            this.radioButtonPremium.Size = new System.Drawing.Size(65, 17);
            this.radioButtonPremium.TabIndex = 1;
            this.radioButtonPremium.TabStop = true;
            this.radioButtonPremium.Text = "Premium";
            this.radioButtonPremium.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxPrecio);
            this.groupBox7.Location = new System.Drawing.Point(379, 202);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 52);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(16, 16);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(132, 20);
            this.textBoxPrecio.TabIndex = 0;
            // 
            // buttonCotizar
            // 
            this.buttonCotizar.Location = new System.Drawing.Point(27, 20);
            this.buttonCotizar.Name = "buttonCotizar";
            this.buttonCotizar.Size = new System.Drawing.Size(138, 23);
            this.buttonCotizar.TabIndex = 0;
            this.buttonCotizar.Text = "Cotizar";
            this.buttonCotizar.UseVisualStyleBackColor = true;
            // 
            // textBoxCotizacion
            // 
            this.textBoxCotizacion.Location = new System.Drawing.Point(218, 23);
            this.textBoxCotizacion.Name = "textBoxCotizacion";
            this.textBoxCotizacion.Size = new System.Drawing.Size(313, 20);
            this.textBoxCotizacion.TabIndex = 1;
            // 
            // radioButtonPantalon
            // 
            this.radioButtonPantalon.AutoSize = true;
            this.radioButtonPantalon.Location = new System.Drawing.Point(16, 15);
            this.radioButtonPantalon.Name = "radioButtonPantalon";
            this.radioButtonPantalon.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPantalon.TabIndex = 3;
            this.radioButtonPantalon.TabStop = true;
            this.radioButtonPantalon.Text = "Pantalon";
            this.radioButtonPantalon.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 474);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.Text = "Cotizador Express";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDireccionTienda;
        private System.Windows.Forms.Label labelNombreTienda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonHistorial;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButtonPremium;
        private System.Windows.Forms.RadioButton radioButtonSantard;
        private System.Windows.Forms.TextBox textBoxDisponibles;
        private System.Windows.Forms.Label labelDisponibles;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox checkBoxCuelloMao;
        private System.Windows.Forms.CheckBox checkBoxMangaCorta;
        private System.Windows.Forms.RadioButton radioButtonCamisa;
        private System.Windows.Forms.CheckBox checkBoxChupin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCotizacion;
        private System.Windows.Forms.Button buttonCotizar;
        private System.Windows.Forms.RadioButton radioButtonPantalon;
    }
}

