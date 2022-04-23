
namespace proyecto_video_club.Formularios.Categorias
{
    partial class Consulta_Categoria
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
            this.cmb_consultar_categoria = new System.Windows.Forms.ComboBox();
            this.DGV_consultar_categoria = new System.Windows.Forms.DataGridView();
            this.btn_consultar_categoria = new System.Windows.Forms.Button();
            this.btn_buscar_todas_las_categorias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_consultar_categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // cmb_consultar_categoria
            // 
            this.cmb_consultar_categoria.FormattingEnabled = true;
            this.cmb_consultar_categoria.Location = new System.Drawing.Point(126, 96);
            this.cmb_consultar_categoria.Name = "cmb_consultar_categoria";
            this.cmb_consultar_categoria.Size = new System.Drawing.Size(136, 21);
            this.cmb_consultar_categoria.TabIndex = 2;
            // 
            // DGV_consultar_categoria
            // 
            this.DGV_consultar_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_consultar_categoria.Location = new System.Drawing.Point(55, 201);
            this.DGV_consultar_categoria.Name = "DGV_consultar_categoria";
            this.DGV_consultar_categoria.Size = new System.Drawing.Size(259, 165);
            this.DGV_consultar_categoria.TabIndex = 3;
            // 
            // btn_consultar_categoria
            // 
            this.btn_consultar_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar_categoria.Location = new System.Drawing.Point(298, 87);
            this.btn_consultar_categoria.Name = "btn_consultar_categoria";
            this.btn_consultar_categoria.Size = new System.Drawing.Size(74, 37);
            this.btn_consultar_categoria.TabIndex = 4;
            this.btn_consultar_categoria.Text = "Buscar";
            this.btn_consultar_categoria.UseVisualStyleBackColor = true;
            this.btn_consultar_categoria.Click += new System.EventHandler(this.btn_consultar_categoria_Click);
            // 
            // btn_buscar_todas_las_categorias
            // 
            this.btn_buscar_todas_las_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_todas_las_categorias.Location = new System.Drawing.Point(55, 153);
            this.btn_buscar_todas_las_categorias.Name = "btn_buscar_todas_las_categorias";
            this.btn_buscar_todas_las_categorias.Size = new System.Drawing.Size(259, 31);
            this.btn_buscar_todas_las_categorias.TabIndex = 5;
            this.btn_buscar_todas_las_categorias.Text = "Buscar todas las categorias";
            this.btn_buscar_todas_las_categorias.UseVisualStyleBackColor = true;
            this.btn_buscar_todas_las_categorias.Click += new System.EventHandler(this.btn_buscar_todas_las_categorias_Click);
            // 
            // Consulta_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 396);
            this.Controls.Add(this.btn_buscar_todas_las_categorias);
            this.Controls.Add(this.btn_consultar_categoria);
            this.Controls.Add(this.DGV_consultar_categoria);
            this.Controls.Add(this.cmb_consultar_categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Consulta_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_Categoria";
            this.Load += new System.EventHandler(this.Consulta_Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_consultar_categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_consultar_categoria;
        private System.Windows.Forms.DataGridView DGV_consultar_categoria;
        private System.Windows.Forms.Button btn_consultar_categoria;
        private System.Windows.Forms.Button btn_buscar_todas_las_categorias;
    }
}