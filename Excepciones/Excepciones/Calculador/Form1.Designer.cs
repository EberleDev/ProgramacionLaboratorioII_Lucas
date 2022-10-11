namespace Calculador
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kilometros = new System.Windows.Forms.TextBox();
            this.txt_litros = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.rtb_monitor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilometros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Litros";
            // 
            // txt_kilometros
            // 
            this.txt_kilometros.Location = new System.Drawing.Point(23, 44);
            this.txt_kilometros.Name = "txt_kilometros";
            this.txt_kilometros.Size = new System.Drawing.Size(235, 23);
            this.txt_kilometros.TabIndex = 2;
            // 
            // txt_litros
            // 
            this.txt_litros.Location = new System.Drawing.Point(23, 122);
            this.txt_litros.Name = "txt_litros";
            this.txt_litros.Size = new System.Drawing.Size(235, 23);
            this.txt_litros.TabIndex = 3;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(23, 178);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(235, 23);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click_1);
            // 
            // rtb_monitor
            // 
            this.rtb_monitor.Location = new System.Drawing.Point(292, 12);
            this.rtb_monitor.Name = "rtb_monitor";
            this.rtb_monitor.ReadOnly = true;
            this.rtb_monitor.Size = new System.Drawing.Size(211, 189);
            this.rtb_monitor.TabIndex = 5;
            this.rtb_monitor.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 223);
            this.Controls.Add(this.rtb_monitor);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_litros);
            this.Controls.Add(this.txt_kilometros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_kilometros;
        private TextBox txt_litros;
        private Button btn_calcular;
        private RichTextBox rtb_monitor;
    }
}