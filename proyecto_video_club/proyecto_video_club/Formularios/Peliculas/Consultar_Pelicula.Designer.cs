
namespace proyecto_video_club.Formularios.Peliculas
{
    partial class Consultar_Pelicula
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
            this.cmb_nombre_peli_consulta = new System.Windows.Forms.ComboBox();
            this.DGV_consulta_peliculas = new System.Windows.Forms.DataGridView();
            this.btn_buscar_x_nombre = new System.Windows.Forms.Button();
            this.btn_consultar_todas_peliculas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_consulta_peliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Pelicula";
            // 
            // cmb_nombre_peli_consulta
            // 
            this.cmb_nombre_peli_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_nombre_peli_consulta.FormattingEnabled = true;
            this.cmb_nombre_peli_consulta.Location = new System.Drawing.Point(162, 98);
            this.cmb_nombre_peli_consulta.Name = "cmb_nombre_peli_consulta";
            this.cmb_nombre_peli_consulta.Size = new System.Drawing.Size(149, 24);
            this.cmb_nombre_peli_consulta.TabIndex = 2;
            // 
            // DGV_consulta_peliculas
            // 
            this.DGV_consulta_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_consulta_peliculas.Location = new System.Drawing.Point(35, 216);
            this.DGV_consulta_peliculas.Name = "DGV_consulta_peliculas";
            this.DGV_consulta_peliculas.Size = new System.Drawing.Size(423, 150);
            this.DGV_consulta_peliculas.TabIndex = 3;
            // 
            // btn_buscar_x_nombre
            // 
            this.btn_buscar_x_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_x_nombre.Location = new System.Drawing.Point(331, 92);
            this.btn_buscar_x_nombre.Name = "btn_buscar_x_nombre";
            this.btn_buscar_x_nombre.Size = new System.Drawing.Size(87, 34);
            this.btn_buscar_x_nombre.TabIndex = 4;
            this.btn_buscar_x_nombre.Text = "Buscar";
            this.btn_buscar_x_nombre.UseVisualStyleBackColor = true;
            this.btn_buscar_x_nombre.Click += new System.EventHandler(this.btn_buscar_x_nombre_Click);
            // 
            // btn_consultar_todas_peliculas
            // 
            this.btn_consultar_todas_peliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar_todas_peliculas.Location = new System.Drawing.Point(35, 171);
            this.btn_consultar_todas_peliculas.Name = "btn_consultar_todas_peliculas";
            this.btn_consultar_todas_peliculas.Size = new System.Drawing.Size(276, 39);
            this.btn_consultar_todas_peliculas.TabIndex = 5;
            this.btn_consultar_todas_peliculas.Text = "Consultar todas las peliculas";
            this.btn_consultar_todas_peliculas.UseVisualStyleBackColor = true;
            this.btn_consultar_todas_peliculas.Click += new System.EventHandler(this.btn_consultar_todas_peliculas_Click);
            // 
            // Consultar_Pelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 430);
            this.Controls.Add(this.btn_consultar_todas_peliculas);
            this.Controls.Add(this.btn_buscar_x_nombre);
            this.Controls.Add(this.DGV_consulta_peliculas);
            this.Controls.Add(this.cmb_nombre_peli_consulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Consultar_Pelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar_Pelicula";
            this.Load += new System.EventHandler(this.Consultar_Pelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_consulta_peliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_nombre_peli_consulta;
        private System.Windows.Forms.DataGridView DGV_consulta_peliculas;
        private System.Windows.Forms.Button btn_buscar_x_nombre;
        private System.Windows.Forms.Button btn_consultar_todas_peliculas;
    }
}