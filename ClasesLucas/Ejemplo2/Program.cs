namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();

            Profesor profesor = new Profesor();

            Aula aula = new Aula("2D");

            aula.AgregarAlumno(alumno1);

            Materia materia = new Materia("Laboratorio II");
        }
    }
}