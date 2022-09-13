namespace Ejercicio03_Colecciones_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cuadroTexto = new System.Windows.Forms.RichTextBox();
            this.boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cuadroTexto
            // 
            this.cuadroTexto.Location = new System.Drawing.Point(31, 34);
            this.cuadroTexto.Name = "cuadroTexto";
            this.cuadroTexto.Size = new System.Drawing.Size(714, 295);
            this.cuadroTexto.TabIndex = 0;
            this.cuadroTexto.Text = "";
            this.cuadroTexto.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(573, 359);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(167, 34);
            this.boton.TabIndex = 1;
            this.boton.Text = "Calcular";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.cuadroTexto);
            this.Name = "Form1";
            this.Text = "Contador de Palabras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox cuadroTexto;
        private Button boton;
    }
}