using System.Runtime.Serialization;

namespace Calculador
{
    public partial class Form1 : Form
    {

        int num1;
        int num2;
        public Form1()
        {
            InitializeComponent();
        }

        public float Calcular(float num1, float num2)
        {
            return 0;
        }
        public float Dividir(float num1, float num2)
        {
            return num1 / num2;
        }

        private void btn_calcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_kilometros.Text) || string.IsNullOrEmpty(txt_litros.Text))
                {

                    throw new ParametrosVacioException("Campos incompletos");

                }

                if (txt_litros.Text == "0")
                {
                    throw new DivideByZeroException();
                }

                num1 = int.Parse(txt_kilometros.Text);
                num2 = int.Parse(txt_litros.Text);
                rtb_monitor.Text = Dividir(num1, num2).ToString();

            }
            catch (ParametrosVacioException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato erróneo: debe ingresar datos numéricos");
            }
        }
    }

    
}