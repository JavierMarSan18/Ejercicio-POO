using System;

namespace ListaEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
			{
				Estudiante[] listaEstudiantes = new Estudiante[2];
				string[] curso;
				int cont = 0;
				
				while(cont < 2)
				{
					//Informacion personal
					string nombre;
					int edad;
					string carnet;
					bool solvente;
					
					//Informacion del curso
					string nombreCurso;
					string nota_1;
					string nota_2;
					string notaFinal;
					
					Console.WriteLine($"\nESTUDIANTE {cont + 1}");
					Console.WriteLine("\nInformación personal:");
					
					Console.WriteLine("\nIngrese nombre");
					nombre = Console.ReadLine();
					
					Console.WriteLine("\nIngrese edad");
					edad = Convert.ToInt32(Console.ReadLine());
					
					Console.WriteLine("\nIngrese carnet");
					carnet = Console.ReadLine();
					
					Console.WriteLine("\nIngrese si esta solvente");
					solvente = Convert.ToBoolean(Console.ReadLine());
					

					Console.WriteLine("\n\nInformación del curso:");
					
					Console.WriteLine("\nIngrese nombre");
					nombreCurso = Console.ReadLine();
					
					Console.WriteLine("\nIngrese nota del parcial 1");
					nota_1 = Console.ReadLine();
					
					Console.WriteLine("\nIngrese nota del parcial 2");
					nota_2 = Console.ReadLine();
					
					Console.WriteLine("\nIngrese nota del final");
					notaFinal = Console.ReadLine();
					
					curso = new string[4]{nombreCurso, nota_1, nota_2, notaFinal};
				
					Estudiante estudiante = new Estudiante(nombre, edad, carnet, solvente, curso);
					
					listaEstudiantes[cont] = estudiante; 
					
					cont++;
					Console.Clear();
				}
				
				Console.WriteLine("\nLISTA DE ESTUDIANTES\n");
				Console.WriteLine("-----------------------------------------------------------");
				
				for(int i = 0 ; i < listaEstudiantes.Length ; i++)
				{
					Estudiante estudiante = listaEstudiantes[i];
					
					//Personal
					Console.WriteLine("Informacion Personal:");
					Console.WriteLine($"Nombre: {estudiante.nombre}\nCarnet: {estudiante.carnet}\nEdad: {estudiante.edad}\nSolvente: {estudiante.solvente}");
					
					//Curso
					Console.WriteLine("\n\tInformacion del Curso:");
					Console.WriteLine($"\tNombre curso: {estudiante.curso[0]}\n\tNota parcial 1: {estudiante.curso[1]} \n\tNota parcial 2: {estudiante.curso[2]} \n\tNota Final: {estudiante.curso[3]}");
					
					Console.WriteLine("-----------------------------------------------------------");						
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
			Console.ReadKey();
        }
    }
}

