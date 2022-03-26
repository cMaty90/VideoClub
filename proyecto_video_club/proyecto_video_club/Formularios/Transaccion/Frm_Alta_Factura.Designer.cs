
namespace proyecto_video_club.Formularios.Transaccion
{
    partial class Frm_Alta_Factura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tipo_factura = new System.Windows.Forms.TextBox();
            this.txt_nroSocio_factura = new System.Windows.Forms.TextBox();
            this.txt_fecha_actual = new System.Windows.Forms.TextBox();
            this.txt_nro_factura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_codPeli_factura = new System.Windows.Forms.ComboBox();
            this.txt_fecha_real_dev = new System.Windows.Forms.TextBox();
            this.txt_fecha_prevista_dev = new System.Windows.Forms.TextBox();
            this.btn_agregar_pelicula = new System.Windows.Forms.Button();
            this.btn_reg_alquiler = new System.Windows.Forms.Button();
            this.btn_limpiar_datos = new System.Windows.Forms.Button();
            this.txt_precioPeli_factura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grid_detalle_pelicula = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_traer_fecha = new System.Windows.Forms.Button();
            this.txt_total_facturacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detalle_pelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nro Socio";
            // 
            // txt_tipo_factura
            // 
            this.txt_tipo_factura.Location = new System.Drawing.Point(123, 108);
            this.txt_tipo_factura.Name = "txt_tipo_factura";
            this.txt_tipo_factura.Size = new System.Drawing.Size(100, 20);
            this.txt_tipo_factura.TabIndex = 5;
            // 
            // txt_nroSocio_factura
            // 
            this.txt_nroSocio_factura.Location = new System.Drawing.Point(123, 224);
            this.txt_nroSocio_factura.Name = "txt_nroSocio_factura";
            this.txt_nroSocio_factura.Size = new System.Drawing.Size(100, 20);
            this.txt_nroSocio_factura.TabIndex = 7;
            // 
            // txt_fecha_actual
            // 
            this.txt_fecha_actual.Location = new System.Drawing.Point(123, 188);
            this.txt_fecha_actual.Name = "txt_fecha_actual";
            this.txt_fecha_actual.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_actual.TabIndex = 8;
            // 
            // txt_nro_factura
            // 
            this.txt_nro_factura.Location = new System.Drawing.Point(123, 147);
            this.txt_nro_factura.Name = "txt_nro_factura";
            this.txt_nro_factura.Size = new System.Drawing.Size(100, 20);
            this.txt_nro_factura.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha Real Devolucion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha Prevista Devolucion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(361, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Codigo de Pelicula";
            // 
            // cmb_codPeli_factura
            // 
            this.cmb_codPeli_factura.FormattingEnabled = true;
            this.cmb_codPeli_factura.Location = new System.Drawing.Point(507, 111);
            this.cmb_codPeli_factura.Name = "cmb_codPeli_factura";
            this.cmb_codPeli_factura.Size = new System.Drawing.Size(121, 21);
            this.cmb_codPeli_factura.TabIndex = 13;
            this.cmb_codPeli_factura.SelectionChangeCommitted += new System.EventHandler(this.cmb_codPeli_factura_SelectionChangeCommitted);
            // 
            // txt_fecha_real_dev
            // 
            this.txt_fecha_real_dev.Location = new System.Drawing.Point(507, 190);
            this.txt_fecha_real_dev.Name = "txt_fecha_real_dev";
            this.txt_fecha_real_dev.Size = new System.Drawing.Size(121, 20);
            this.txt_fecha_real_dev.TabIndex = 14;
            // 
            // txt_fecha_prevista_dev
            // 
            this.txt_fecha_prevista_dev.Location = new System.Drawing.Point(507, 229);
            this.txt_fecha_prevista_dev.Name = "txt_fecha_prevista_dev";
            this.txt_fecha_prevista_dev.Size = new System.Drawing.Size(121, 20);
            this.txt_fecha_prevista_dev.TabIndex = 15;
            // 
            // btn_agregar_pelicula
            // 
            this.btn_agregar_pelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_pelicula.Location = new System.Drawing.Point(660, 217);
            this.btn_agregar_pelicula.Name = "btn_agregar_pelicula";
            this.btn_agregar_pelicula.Size = new System.Drawing.Size(143, 32);
            this.btn_agregar_pelicula.TabIndex = 16;
            this.btn_agregar_pelicula.Text = "Agregar Pelicula";
            this.btn_agregar_pelicula.UseVisualStyleBackColor = true;
            this.btn_agregar_pelicula.Click += new System.EventHandler(this.btn_agregar_pelicula_Click);
            // 
            // btn_reg_alquiler
            // 
            this.btn_reg_alquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg_alquiler.Location = new System.Drawing.Point(34, 375);
            this.btn_reg_alquiler.Name = "btn_reg_alquiler";
            this.btn_reg_alquiler.Size = new System.Drawing.Size(143, 32);
            this.btn_reg_alquiler.TabIndex = 17;
            this.btn_reg_alquiler.Text = "Guardar";
            this.btn_reg_alquiler.UseVisualStyleBackColor = true;
            this.btn_reg_alquiler.Click += new System.EventHandler(this.btn_reg_alquiler_Click);
            // 
            // btn_limpiar_datos
            // 
            this.btn_limpiar_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar_datos.Location = new System.Drawing.Point(34, 424);
            this.btn_limpiar_datos.Name = "btn_limpiar_datos";
            this.btn_limpiar_datos.Size = new System.Drawing.Size(143, 32);
            this.btn_limpiar_datos.TabIndex = 18;
            this.btn_limpiar_datos.Text = "Limpiar Casillas";
            this.btn_limpiar_datos.UseVisualStyleBackColor = true;
            this.btn_limpiar_datos.Click += new System.EventHandler(this.btn_limpiar_datos_Click);
            // 
            // txt_precioPeli_factura
            // 
            this.txt_precioPeli_factura.Location = new System.Drawing.Point(508, 153);
            this.txt_precioPeli_factura.Name = "txt_precioPeli_factura";
            this.txt_precioPeli_factura.Size = new System.Drawing.Size(121, 20);
            this.txt_precioPeli_factura.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Precio";
            // 
            // grid_detalle_pelicula
            // 
            this.grid_detalle_pelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_detalle_pelicula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grid_detalle_pelicula.Location = new System.Drawing.Point(264, 265);
            this.grid_detalle_pelicula.Name = "grid_detalle_pelicula";
            this.grid_detalle_pelicula.Size = new System.Drawing.Size(595, 191);
            this.grid_detalle_pelicula.TabIndex = 21;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tipo Factura";
            this.Column5.Name = "Column5";
            this.Column5.Width = 108;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero Factura";
            this.Column1.Name = "Column1";
            this.Column1.Width = 108;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo Pelicula";
            this.Column2.Name = "Column2";
            this.Column2.Width = 108;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha Real Devolucion";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total";
            // 
            // btn_traer_fecha
            // 
            this.btn_traer_fecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_traer_fecha.Location = new System.Drawing.Point(229, 188);
            this.btn_traer_fecha.Name = "btn_traer_fecha";
            this.btn_traer_fecha.Size = new System.Drawing.Size(30, 22);
            this.btn_traer_fecha.TabIndex = 24;
            this.btn_traer_fecha.UseVisualStyleBackColor = false;
            this.btn_traer_fecha.Click += new System.EventHandler(this.btn_traer_fecha_Click);
            // 
            // txt_total_facturacion
            // 
            this.txt_total_facturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_facturacion.Location = new System.Drawing.Point(82, 321);
            this.txt_total_facturacion.Name = "txt_total_facturacion";
            this.txt_total_facturacion.Size = new System.Drawing.Size(100, 23);
            this.txt_total_facturacion.TabIndex = 25;
            this.txt_total_facturacion.TextChanged += new System.EventHandler(this.txt_total_facturacion_TextChanged);
            // 
            // Frm_Alta_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 499);
            this.Controls.Add(this.txt_total_facturacion);
            this.Controls.Add(this.btn_traer_fecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grid_detalle_pelicula);
            this.Controls.Add(this.txt_precioPeli_factura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_limpiar_datos);
            this.Controls.Add(this.btn_reg_alquiler);
            this.Controls.Add(this.btn_agregar_pelicula);
            this.Controls.Add(this.txt_fecha_prevista_dev);
            this.Controls.Add(this.txt_fecha_real_dev);
            this.Controls.Add(this.cmb_codPeli_factura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nro_factura);
            this.Controls.Add(this.txt_fecha_actual);
            this.Controls.Add(this.txt_nroSocio_factura);
            this.Controls.Add(this.txt_tipo_factura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Alta_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Alta_Factura";
            this.Load += new System.EventHandler(this.Frm_Alta_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_detalle_pelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tipo_factura;
        private System.Windows.Forms.TextBox txt_nroSocio_factura;
        private System.Windows.Forms.TextBox txt_fecha_actual;
        private System.Windows.Forms.TextBox txt_nro_factura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_codPeli_factura;
        private System.Windows.Forms.TextBox txt_fecha_real_dev;
        private System.Windows.Forms.TextBox txt_fecha_prevista_dev;
        private System.Windows.Forms.Button btn_agregar_pelicula;
        private System.Windows.Forms.Button btn_reg_alquiler;
        private System.Windows.Forms.Button btn_limpiar_datos;
        private System.Windows.Forms.TextBox txt_precioPeli_factura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grid_detalle_pelicula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_traer_fecha;
        private System.Windows.Forms.TextBox txt_total_facturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}