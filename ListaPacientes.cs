using System;
using System.Collections;

namespace TurnosMedicos
{
	/// <summary>
	/// Description of ListaPacientes.
	/// </summary>
	public class ListaPacientes
	{
		ArrayList Pacientes=new ArrayList(); /* Creo una nueva instancia de tipo Arraylist para almacenar
		los distintos pacientes */
		
		
		public ListaPacientes() /* Constructor por defecto */
		{
		}
		
		public void Agregar(){ /* Creo un nuevo método para agregar pacientes al Array */
			
			try{
			Console.WriteLine("Ingrese nombre del paciente");
			string nombre=Console.ReadLine();

			Console.WriteLine("Ingrese dni del paciente");
			int dni=Console.ReadLine();

            Console.WriteLine("Ingrese obra social del paciente");
			string obra_social=Console.ReadLine();

			Console.WriteLine("Ingrese nro.afiliado del paciente");
			int nro_afiliado=Console.ReadLine();

			Console.WriteLine("Ingrese diagnóstico del paciente");
			string diagnostico=double.Parse(Console.ReadLine());
			
            
			Paciente p= new Paciente(nombre,dni,obra_social,diagnostico,nro_afiliado); //instancio un nuevo paciente
			Paciente.Add(p); /* Agrego paciente al Arraylist */

			}
			
			catch(FormatException){
				Console.WriteLine("\nIngrese un valor correcto");
			}
			catch(Exception){
				Console.WriteLine("Ha ocurrido un error.");
			}
		}
		
		public void Imprimir(){ /* Creo un metodo Imprimir para mostrar en pantalla los productos */
			int i=1;
			
			foreach(Paciente p in Pacientes){ /* Utilizo un foreach para recorrer el ArrayList */
				Console.WriteLine("\n{5}) [Paciente nombre={0},dni={1},obra_social={2},diagnostico={3},nro_afiliado={4}]",p.Nombre,p.Dni,p.Obra_social,p.Diagnostico,p.Nro_afiliado,i);
				i++;
				
			}
			
		}

		public Paciente Obtener(int n){
			return (Paciente)Pacientes[n-1];
		}
	}
}