using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FormAltaGerente : Form
    {
        Gerente unGerente;
        string nombreIngresado;
        int antiguedadIngresada;
        int edadIngresada;

        public FormAltaGerente()
        {
            InitializeComponent();
        }

        public Gerente Gerente
        {
            get { return unGerente; }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            nombreIngresado = txt_nombreGerente.Text;

            if(!int.TryParse(txt_antiguedadGerente.Text, out antiguedadIngresada) ||
                !int.TryParse(txt_edad.Text, out edadIngresada))
            {
                MessageBox.Show("Dato incorrecto");
            }
            else
            {
                unGerente = new Gerente(nombreIngresado, antiguedadIngresada, edadIngresada, 250000);
                txt_nombreGerente.Clear();
                txt_antiguedadGerente.Clear();
                txt_edad.Clear();
                MessageBox.Show("¡Alta Exitosa!");
                MessageBox.Show(unGerente.NombreCompleto);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
