
namespace proyecto_video_club.Formularios.Socios
{
    partial class Consultar_Socios
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
            this.cmb_consulta_socio = new System.Windows.Forms.ComboBox();
            this.DGV_consulta_socios = new System.Windows.Forms.DataGridView();
            this.btn_bucar_socio_x_nombre = new System.Windows.Forms.Button();
            this.btn_consultar_todos_socios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_consulta_socios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Socios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Socio";
            // 
            // cmb_consulta_socio
            // 
            this.cmb_consulta_socio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_consulta_socio.FormattingEnabled = true;
            this.cmb_consulta_socio.Location = new System.Drawing.Point(153, 88);
            this.cmb_consulta_socio.Name = "cmb_consulta_socio";
            this.cmb_consulta_socio.Size = new System.Drawing.Size(133, 24);
            this.cmb_consulta_socio.TabIndex = 2;
            // 
            // DGV_consulta_socios
            // 
            this.DGV_consulta_socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_consulta_socios.Location = new System.Drawing.Point(35, 204);
            this.DGV_consulta_socios.Name = "DGV_consulta_socios";
            this.DGV_consulta_socios.Size = new System.Drawing.Size(605, 193);
            this.DGV_consulta_socios.TabIndex = 3;
            // 
            // btn_bucar_socio_x_nombre
            // 
            this.btn_bucar_socio_x_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bucar_socio_x_nombre.Location = new System.Drawing.Point(310, 82);
            this.btn_bucar_socio_x_nombre.Name = "btn_bucar_socio_x_nombre";
            this.btn_bucar_socio_x_nombre.Size = new System.Drawing.Size(92, 34);
            this.btn_bucar_socio_x_nombre.TabIndex = 4;
            this.btn_bucar_socio_x_nombre.Text = "Buscar";
            this.btn_bucar_socio_x_nombre.UseVisualStyleBackColor = true;
            this.btn_bucar_socio_x_nombre.Click += new System.EventHandler(this.btn_bucar_socio_x_nombre_Click);
            // 
            // btn_consultar_todos_socios
            // 
            this.btn_consultar_todos_socios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar_todos_socios.Location = new System.Drawing.Point(35, 164);
            this.btn_consultar_todos_socios.Name = "btn_consultar_todos_socios";
            this.btn_consultar_todos_socios.Size = new System.Drawing.Size(267, 34);
            this.btn_consultar_todos_socios.TabIndex = 5;
            this.btn_consultar_todos_socios.Text = "Consultar todos los socios";
            this.btn_consultar_todos_socios.UseVisualStyleBackColor = true;
            this.btn_consultar_todos_socios.Click += new System.EventHandler(this.btn_consultar_todos_socios_Click);
            // 
            // Consultar_Socios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.btn_consultar_todos_socios);
            this.Controls.Add(this.btn_bucar_socio_x_nombre);
            this.Controls.Add(this.DGV_consulta_socios);
            this.Controls.Add(this.cmb_consulta_socio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Consultar_Socios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar_Socios";
            this.Load += new System.EventHandler(this.Consultar_Socios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_consulta_socios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_consulta_socio;
        private System.Windows.Forms.DataGridView DGV_consulta_socios;
        private System.Windows.Forms.Button btn_bucar_socio_x_nombre;
        private System.Windows.Forms.Button btn_consultar_todos_socios;
    }
}