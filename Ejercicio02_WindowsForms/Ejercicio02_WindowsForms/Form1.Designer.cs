namespace Ejercicio02_WindowsForms
{
    partial class Registro
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
            this.gbox_detalles = new System.Windows.Forms.GroupBox();
            this.nud_edad = new System.Windows.Forms.NumericUpDown();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.gbox_genero = new System.Windows.Forms.GroupBox();
            this.rdo_nobinario = new System.Windows.Forms.RadioButton();
            this.rdo_femenino = new System.Windows.Forms.RadioButton();
            this.rdo_masculino = new System.Windows.Forms.RadioButton();
            this.gbox_cursos = new System.Windows.Forms.GroupBox();
            this.chk_javascript = new System.Windows.Forms.CheckBox();
            this.chk_cmasmas = new System.Windows.Forms.CheckBox();
            this.chk_csharp = new System.Windows.Forms.CheckBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.lst_paises = new System.Windows.Forms.ListBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.gbox_detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).BeginInit();
            this.gbox_genero.SuspendLayout();
            this.gbox_cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_detalles
            // 
            this.gbox_detalles.Controls.Add(this.nud_edad);
            this.gbox_detalles.Controls.Add(this.txt_direccion);
            this.gbox_detalles.Controls.Add(this.txt_nombre);
            this.gbox_detalles.Controls.Add(this.lbl_edad);
            this.gbox_detalles.Controls.Add(this.lbl_direccion);
            this.gbox_detalles.Controls.Add(this.lbl_nombre);
            this.gbox_detalles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbox_detalles.Location = new System.Drawing.Point(32, 35);
            this.gbox_detalles.Name = "gbox_detalles";
            this.gbox_detalles.Size = new System.Drawing.Size(310, 225);
            this.gbox_detalles.TabIndex = 0;
            this.gbox_detalles.TabStop = false;
            this.gbox_detalles.Text = "Detalles del Usuario";
            // 
            // nud_edad
            // 
            this.nud_edad.Location = new System.Drawing.Point(101, 172);
            this.nud_edad.Name = "nud_edad";
            this.nud_edad.Size = new System.Drawing.Size(177, 27);
            this.nud_edad.TabIndex = 2;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(101, 113);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(177, 27);
            this.txt_direccion.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(101, 46);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(177, 27);
            this.txt_nombre.TabIndex = 0;
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(17, 174);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(43, 20);
            this.lbl_edad.TabIndex = 2;
            this.lbl_edad.Text = "Edad";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(17, 116);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(72, 20);
            this.lbl_direccion.TabIndex = 1;
            this.lbl_direccion.Text = "Dirección";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(17, 49);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(64, 20);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // gbox_genero
            // 
            this.gbox_genero.Controls.Add(this.rdo_nobinario);
            this.gbox_genero.Controls.Add(this.rdo_femenino);
            this.gbox_genero.Controls.Add(this.rdo_masculino);
            this.gbox_genero.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbox_genero.Location = new System.Drawing.Point(408, 35);
            this.gbox_genero.Name = "gbox_genero";
            this.gbox_genero.Size = new System.Drawing.Size(236, 140);
            this.gbox_genero.TabIndex = 2;
            this.gbox_genero.TabStop = false;
            this.gbox_genero.Text = "Género";
            // 
            // rdo_nobinario
            // 
            this.rdo_nobinario.AutoSize = true;
            this.rdo_nobinario.Location = new System.Drawing.Point(40, 98);
            this.rdo_nobinario.Name = "rdo_nobinario";
            this.rdo_nobinario.Size = new System.Drawing.Size(97, 24);
            this.rdo_nobinario.TabIndex = 2;
            this.rdo_nobinario.TabStop = true;
            this.rdo_nobinario.Text = "No Binarie";
            this.rdo_nobinario.UseVisualStyleBackColor = true;
            // 
            // rdo_femenino
            // 
            this.rdo_femenino.AutoSize = true;
            this.rdo_femenino.Location = new System.Drawing.Point(40, 65);
            this.rdo_femenino.Name = "rdo_femenino";
            this.rdo_femenino.Size = new System.Drawing.Size(92, 24);
            this.rdo_femenino.TabIndex = 1;
            this.rdo_femenino.TabStop = true;
            this.rdo_femenino.Text = "Femenino";
            this.rdo_femenino.UseVisualStyleBackColor = true;
            // 
            // rdo_masculino
            // 
            this.rdo_masculino.AutoSize = true;
            this.rdo_masculino.Location = new System.Drawing.Point(40, 35);
            this.rdo_masculino.Name = "rdo_masculino";
            this.rdo_masculino.Size = new System.Drawing.Size(94, 24);
            this.rdo_masculino.TabIndex = 0;
            this.rdo_masculino.TabStop = true;
            this.rdo_masculino.Text = "Masculino";
            this.rdo_masculino.UseVisualStyleBackColor = true;
            // 
            // gbox_cursos
            // 
            this.gbox_cursos.Controls.Add(this.chk_javascript);
            this.gbox_cursos.Controls.Add(this.chk_cmasmas);
            this.gbox_cursos.Controls.Add(this.chk_csharp);
            this.gbox_cursos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbox_cursos.Location = new System.Drawing.Point(408, 197);
            this.gbox_cursos.Name = "gbox_cursos";
            this.gbox_cursos.Size = new System.Drawing.Size(244, 165);
            this.gbox_cursos.TabIndex = 3;
            this.gbox_cursos.TabStop = false;
            this.gbox_cursos.Text = "Cursos";
            // 
            // chk_javascript
            // 
            this.chk_javascript.AutoSize = true;
            this.chk_javascript.Location = new System.Drawing.Point(40, 117);
            this.chk_javascript.Name = "chk_javascript";
            this.chk_javascript.Size = new System.Drawing.Size(94, 24);
            this.chk_javascript.TabIndex = 2;
            this.chk_javascript.Text = "JavaScript";
            this.chk_javascript.UseVisualStyleBackColor = true;
            // 
            // chk_cmasmas
            // 
            this.chk_cmasmas.AutoSize = true;
            this.chk_cmasmas.Location = new System.Drawing.Point(40, 78);
            this.chk_cmasmas.Name = "chk_cmasmas";
            this.chk_cmasmas.Size = new System.Drawing.Size(57, 24);
            this.chk_cmasmas.TabIndex = 1;
            this.chk_cmasmas.Text = "C++";
            this.chk_cmasmas.UseVisualStyleBackColor = true;
            // 
            // chk_csharp
            // 
            this.chk_csharp.AutoSize = true;
            this.chk_csharp.Location = new System.Drawing.Point(40, 39);
            this.chk_csharp.Name = "chk_csharp";
            this.chk_csharp.Size = new System.Drawing.Size(46, 24);
            this.chk_csharp.TabIndex = 0;
            this.chk_csharp.Text = "C#";
            this.chk_csharp.UseVisualStyleBackColor = true;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(505, 396);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(147, 42);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // lst_paises
            // 
            this.lst_paises.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_paises.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_paises.FormattingEnabled = true;
            this.lst_paises.ItemHeight = 20;
            this.lst_paises.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lst_paises.Location = new System.Drawing.Point(32, 314);
            this.lst_paises.Name = "lst_paises";
            this.lst_paises.Size = new System.Drawing.Size(310, 120);
            this.lst_paises.TabIndex = 1;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pais.Location = new System.Drawing.Point(32, 286);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(35, 20);
            this.lbl_pais.TabIndex = 5;
            this.lbl_pais.Text = "País";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.lst_paises);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.gbox_cursos);
            this.Controls.Add(this.gbox_genero);
            this.Controls.Add(this.gbox_detalles);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Registro";
            this.Text = "Registro";
            this.gbox_detalles.ResumeLayout(false);
            this.gbox_detalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).EndInit();
            this.gbox_genero.ResumeLayout(false);
            this.gbox_genero.PerformLayout();
            this.gbox_cursos.ResumeLayout(false);
            this.gbox_cursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbox_detalles;
        private GroupBox gbox_genero;
        private GroupBox gbox_cursos;
        private Button btn_ingresar;
        private ListBox lst_paises;
        private Label lbl_pais;
        private TextBox txt_direccion;
        private TextBox txt_nombre;
        private Label lbl_edad;
        private Label lbl_direccion;
        private Label lbl_nombre;
        private NumericUpDown nud_edad;
        private RadioButton rdo_nobinario;
        private RadioButton rdo_femenino;
        private RadioButton rdo_masculino;
        private CheckBox chk_javascript;
        private CheckBox chk_cmasmas;
        private CheckBox chk_csharp;
    }
}