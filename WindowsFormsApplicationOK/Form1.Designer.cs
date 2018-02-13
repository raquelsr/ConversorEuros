namespace WindowsFormsApplicationOK
{
    partial class Form1
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
            this.botonEuros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.texto = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonEuros
            // 
            this.botonEuros.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonEuros.Location = new System.Drawing.Point(99, 158);
            this.botonEuros.Name = "botonEuros";
            this.botonEuros.Size = new System.Drawing.Size(96, 68);
            this.botonEuros.TabIndex = 0;
            this.botonEuros.Text = "Pasar a euros";
            this.botonEuros.UseVisualStyleBackColor = false;
            this.botonEuros.Click += new System.EventHandler(this.botonEurosClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conversor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(99, 88);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(100, 20);
            this.texto.TabIndex = 3;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(237, 198);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 242);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonEuros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonEuros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.Label resultado;
    }
}

