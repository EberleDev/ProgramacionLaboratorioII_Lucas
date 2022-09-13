namespace Ejemplo2
{
    public class Aula
    {
        private string comision;
        public Materia materia;
        public Profesor profesor;
        public Alumno[] alumnos;

        private Aula(string comision, Materia materia, Profesor profesor)
        {
            this.comision = comision;
            this.materia = materia;
            this.profesor = profesor;
        }

        public Aula(string comision, Materia materia, Profesor profesor, int cantidad)
        {
            this.alumnos = new Alumno[cantidad];
        }

        public Aula(string comision, Materia materia, Profesor profesor, Alumno[] alumnos)
        {
            this.alumnos = alumnos;
        }

        public void AgregarAlumno(Alumno alumno1)
        {
            
        }
    }
}