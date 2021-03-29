using System;

namespace ListaEstudiantes
{
    class Estudiante
    {
        public string nombre;
		public int edad;
		public string carnet;
		public bool solvente;
		public string[] curso;
		
		public Estudiante(string nombre, int edad, string carnet, bool solvente, string[] curso)
		{
			this.nombre = nombre;
			this.edad = edad;
			this.carnet = carnet;
			this.solvente = solvente;
			this.curso = curso;
		}
    }
}
