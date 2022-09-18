namespace Vista
{
    partial class FormAltaGerente
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
            this.txt_nombreGerente = new System.Windows.Forms.TextBox();
            this.txt_antiguedadGerente = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lb_altaGerente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nombreGerente
            // 
            this.txt_nombreGerente.Location = new System.Drawing.Point(248, 67);
            this.txt_nombreGerente.Name = "txt_nombreGerente";
            this.txt_nombreGerente.PlaceholderText = "Ingrese nombre...";
            this.txt_nombreGerente.Size = new System.Drawing.Size(234, 23);
            this.txt_nombreGerente.TabIndex = 0;
            // 
            // txt_antiguedadGerente
            // 
            this.txt_antiguedadGerente.Location = new System.Drawing.Point(248, 129);
            this.txt_antiguedadGerente.Name = "txt_antiguedadGerente";
            this.txt_antiguedadGerente.PlaceholderText = "Ingrese antigüedad...";
            this.txt_antiguedadGerente.Size = new System.Drawing.Size(234, 23);
            this.txt_antiguedadGerente.TabIndex = 1;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(248, 191);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.PlaceholderText = "Ingrese edad...";
            this.txt_edad.Size = new System.Drawing.Size(234, 23);
            this.txt_edad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(135, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(135, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Antigüedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(135, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(171, 280);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(151, 33);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(383, 280);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(151, 33);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.Text = "ACEPTAR";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lb_altaGerente
            // 
            this.lb_altaGerente.AutoSize = true;
            this.lb_altaGerente.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_altaGerente.Location = new System.Drawing.Point(259, 9);
            this.lb_altaGerente.Name = "lb_altaGerente";
            this.lb_altaGerente.Size = new System.Drawing.Size(203, 30);
            this.lb_altaGerente.TabIndex = 8;
            this.lb_altaGerente.Text = "ALTA DE GERENTE";
            // 
            // FormAltaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 334);
            this.Controls.Add(this.lb_altaGerente);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_antiguedadGerente);
            this.Controls.Add(this.txt_nombreGerente);
            this.Name = "FormAltaGerente";
            this.Text = "AltaGerente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_nombreGerente;
        private TextBox txt_antiguedadGerente;
        private TextBox txt_edad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_cancelar;
        private Button btn_aceptar;
        private Label lb_altaGerente;
    }
}