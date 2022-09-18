namespace Vista
{
    partial class FormularioPrincipal
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
            this.btn_agregarGerente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregarGerente
            // 
            this.btn_agregarGerente.Location = new System.Drawing.Point(29, 27);
            this.btn_agregarGerente.Name = "btn_agregarGerente";
            this.btn_agregarGerente.Size = new System.Drawing.Size(178, 44);
            this.btn_agregarGerente.TabIndex = 0;
            this.btn_agregarGerente.Text = "Agregar Gerente";
            this.btn_agregarGerente.UseVisualStyleBackColor = true;
            this.btn_agregarGerente.Click += new System.EventHandler(this.btn_agregarGerente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(355, 212);
            this.dataGridView1.TabIndex = 1;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 251);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_agregarGerente);
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_agregarGerente;
        private DataGridView dataGridView1;
    }
}