namespace Clase_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string , int> agendaTelefonica = new Dictionary<string, int>();

            agendaTelefonica.Add("Carlos", 1150552243);
            agendaTelefonica.Add("Rosa", 1145896532);
            agendaTelefonica.Add("Julieta", 1174441521);
            agendaTelefonica.Add("Rosario", 116593552);
            agendaTelefonica.Add("Pedro", 1122224878);

            foreach (KeyValuePair<string,int> item in agendaTelefonica)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }


        }
    }
}