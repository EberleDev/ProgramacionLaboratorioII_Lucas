using Entidades;

namespace Ejercicio02_WindowsForms
{
    public partial class Registro : Form
    {
        Ingresante ingresante = new Ingresante();

        public Registro()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string direccion = txt_direccion.Text;
            int edad = ((int)nud_edad.Value);
            string genero = GetGenero();
            string pais = GetPais();
            String[] cursos = GetCursos();

            if (!String.IsNullOrEmpty(nombre) &&
                !String.IsNullOrEmpty(direccion) &&
                edad != 0 &&
                !String.IsNullOrEmpty(genero) &&
                !String.IsNullOrEmpty(pais))
            {
                //ingresante = new Ingresante(nombre, edad, genero, direccion, pais, cursos);
                ingresante.Nombre = nombre;
                ingresante.Direccion = direccion;
                ingresante.Genero = genero;
                ingresante.Pais = pais;
                ingresante.Edad = edad;
                ingresante.Cursos = cursos;

                MessageBox.Show(ingresante.Mostrar());
            }
            else
            {
                MessageBox.Show("Error en la carga de datos");
            }

        }

        private string GetGenero()
        {
            string genero = null;

            if(rdo_masculino.Checked)
            {
                genero = rdo_masculino.Text;
            }
            else if(rdo_femenino.Checked)
            {
                genero = rdo_femenino.Text;
            }
            else if(rdo_nobinario.Checked)
            {
                genero = rdo_nobinario.Text;
            }

            return genero;
        }

        private string GetPais()
        {
            if (!String.IsNullOrEmpty(this.lst_paises.Items[lst_paises.SelectedIndex].ToString()))
                return this.lst_paises.Items[lst_paises.SelectedIndex].ToString();
            else
                return null;
        }

        private String[] GetCursos()
        {
            List<string> cursos = new List<string>();

            if(chk_csharp.Checked)
            {
                cursos.Add(chk_csharp.Text);
            }

            if(chk_cmasmas.Checked)
            {
                cursos.Add(chk_cmasmas.Text);
            }

            if(chk_javascript.Checked)
            {
                cursos.Add(chk_javascript.Text);
            }

            if(!chk_cmasmas.Checked &&
               !chk_csharp.Checked &&
               !chk_javascript.Checked)
            {
                cursos.Add("No ha realizado cursos");
            }

            return cursos.ToArray();
        }
    }
}