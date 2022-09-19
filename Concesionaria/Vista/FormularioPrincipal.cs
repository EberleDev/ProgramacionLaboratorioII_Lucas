
using Entidades;

namespace Vista
{
    public partial class FormularioPrincipal : Form
    {

        List<Gerente> listaGerentes;


        public FormularioPrincipal()
        {
            InitializeComponent();
            listaGerentes = new List<Gerente>();
        }

        private void btn_agregarGerente_Click(object sender, EventArgs e)
        {
            FormAltaGerente altaGerente = new FormAltaGerente();
            DialogResult dialogResult = altaGerente.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                listaGerentes.Add(altaGerente.Gerente);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaGerentes;


            }
            else
            {
                MessageBox.Show("CANCELADOOOOOO!!!");
            }

        }
    }
}