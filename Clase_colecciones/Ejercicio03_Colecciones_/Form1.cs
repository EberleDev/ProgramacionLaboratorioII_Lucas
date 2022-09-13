namespace Ejercicio03_Colecciones_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string texto = cuadroTexto.Text;

            String[] subStrings = new String[5000];
            texto.Split(" ");

        }
    }
}