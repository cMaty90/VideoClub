
namespace proyecto_video_club.Formularios.Categorias
{
    partial class Frm_Alta_Categoria
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
            this.btn_guardar_categoria = new System.Windows.Forms.Button();
            this.btn_limpiar_categoria = new System.Windows.Forms.Button();
            this.txt_id_categoria = new System.Windows.Forms.TextBox();
            this.txt_nombre_categoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // btn_guardar_categoria
            // 
            this.btn_guardar_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_categoria.Location = new System.Drawing.Point(51, 186);
            this.btn_guardar_categoria.Name = "btn_guardar_categoria";
            this.btn_guardar_categoria.Size = new System.Drawing.Size(89, 38);
            this.btn_guardar_categoria.TabIndex = 3;
            this.btn_guardar_categoria.Text = "Guardar";
            this.btn_guardar_categoria.UseVisualStyleBackColor = true;
            this.btn_guardar_categoria.Click += new System.EventHandler(this.btn_guardar_categoria_Click);
            // 
            // btn_limpiar_categoria
            // 
            this.btn_limpiar_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar_categoria.Location = new System.Drawing.Point(163, 186);
            this.btn_limpiar_categoria.Name = "btn_limpiar_categoria";
            this.btn_limpiar_categoria.Size = new System.Drawing.Size(89, 38);
            this.btn_limpiar_categoria.TabIndex = 4;
            this.btn_limpiar_categoria.Text = "Limpiar";
            this.btn_limpiar_categoria.UseVisualStyleBackColor = true;
            this.btn_limpiar_categoria.Click += new System.EventHandler(this.btn_limpiar_categoria_Click);
            // 
            // txt_id_categoria
            // 
            this.txt_id_categoria.Location = new System.Drawing.Point(163, 97);
            this.txt_id_categoria.Name = "txt_id_categoria";
            this.txt_id_categoria.Size = new System.Drawing.Size(115, 20);
            this.txt_id_categoria.TabIndex = 5;
            // 
            // txt_nombre_categoria
            // 
            this.txt_nombre_categoria.Location = new System.Drawing.Point(163, 137);
            this.txt_nombre_categoria.Name = "txt_nombre_categoria";
            this.txt_nombre_categoria.Size = new System.Drawing.Size(115, 20);
            this.txt_nombre_categoria.TabIndex = 6;
            // 
            // Frm_Alta_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 301);
            this.Controls.Add(this.txt_nombre_categoria);
            this.Controls.Add(this.txt_id_categoria);
            this.Controls.Add(this.btn_limpiar_categoria);
            this.Controls.Add(this.btn_guardar_categoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Alta_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Alta_Categoria";
            this.Load += new System.EventHandler(this.Frm_Alta_Categoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_guardar_categoria;
        private System.Windows.Forms.Button btn_limpiar_categoria;
        private System.Windows.Forms.TextBox txt_id_categoria;
        private System.Windows.Forms.TextBox txt_nombre_categoria;
    }
}