namespace WindowsFormsApplicationOK
{
    partial class Producto
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
            this.tituloProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloProducto
            // 
            this.tituloProducto.AutoSize = true;
            this.tituloProducto.Location = new System.Drawing.Point(99, 106);
            this.tituloProducto.Name = "tituloProducto";
            this.tituloProducto.Size = new System.Drawing.Size(88, 13);
            this.tituloProducto.TabIndex = 0;
            this.tituloProducto.Text = "ES PRODUCTO!";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tituloProducto);
            this.Name = "Producto";
            this.Text = "Producto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cierra);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloProducto;
    }
}