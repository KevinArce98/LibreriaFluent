namespace EjemploLibreriaFluent
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
            this.btnLibro = new System.Windows.Forms.Button();
            this.btnEditorial = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLibro
            // 
            this.btnLibro.Location = new System.Drawing.Point(51, 31);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(75, 23);
            this.btnLibro.TabIndex = 0;
            this.btnLibro.Text = "Libro";
            this.btnLibro.UseVisualStyleBackColor = true;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // btnEditorial
            // 
            this.btnEditorial.Location = new System.Drawing.Point(51, 80);
            this.btnEditorial.Name = "btnEditorial";
            this.btnEditorial.Size = new System.Drawing.Size(75, 23);
            this.btnEditorial.TabIndex = 1;
            this.btnEditorial.Text = "Editorial";
            this.btnEditorial.UseVisualStyleBackColor = true;
            this.btnEditorial.Click += new System.EventHandler(this.btnEditorial_Click);
            // 
            // btnAutor
            // 
            this.btnAutor.Location = new System.Drawing.Point(51, 132);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(75, 23);
            this.btnAutor.TabIndex = 2;
            this.btnAutor.Text = "Autor";
            this.btnAutor.UseVisualStyleBackColor = true;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 178);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.btnEditorial);
            this.Controls.Add(this.btnLibro);
            this.Name = "Form1";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.Button btnEditorial;
        private System.Windows.Forms.Button btnAutor;
    }
}

