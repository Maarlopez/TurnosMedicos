using System;
using System.Collections;

namespace TurnosMedicos
{
	/// <summary>
	/// Description of ListaPacientes.
	/// </summary>
	public class ListaPacientes
	{
		ArrayList Medicos=new ArrayList(); /* Creo una nueva instancia de tipo Arraylist para almacenar
		los distintos medicos */
		
		
		public ListaMedicos() /* Constructor por defecto */
		{
		}
		
		public void Agregar(){ /* Creo un nuevo método para agregar medicos al Array */
			
			try{
			Console.WriteLine("Ingrese nombre del medico");
			string nombre=Console.ReadLine();
			Console.WriteLine("Ingrese dni del medico");
			int dni=Console.ReadLine();
			
			Medico m= new Medico(nombre,dni); //instancio un nuevo medico
			
			Medico.Add(m); /* Agrego medico al Arraylist */

			}
			
			catch(FormatException){
				Console.WriteLine("\nIngrese un valor correcto");
			}
			catch(Exception){
				Console.WriteLine("Ha ocurrido un error.");
			}
		}
		
		public void Imprimir(){ /* Creo un metodo Imprimir para mostrar en pantalla los medicos */
			int i=1;
			
			foreach(Medico p in Medicos){ /* Utilizo un foreach para recorrer el ArrayList */
				Console.WriteLine("\n{5}) [Medico nombre={0},dni={1}]",p.Nombre,p.Dni,i);
				i++;
				
			}
			
		}

		public Medico Obtener(int n){
			return (Medico)Medico[n-1];
		}

        public void Turnos(){
            string hora;

            int hora_atencion = 4; // 8 a 12 hs
            int turnos_disponibles = 8;

            try{
            
			Console.WriteLine("Ingrese hora del turno (hh:mm)");
			string hora=Console.ReadLine();
			Console.WriteLine("Ingrese nombre del paciente");
			string nombre=Console.ReadLine();
		
			Turno t= new Turno(hora,nombre); //instancio un nuevo turno
			
			Turno.Add(t); /* Agrego turno al Arraylist */

			}
			
			catch(FormatException){
				Console.WriteLine("\nIngrese un valor correcto");
			}
			catch(Exception){
				Console.WriteLine("Ha ocurrido un error.");
			}
        }
	}
}