using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnosMedicos
{
    public class Persona : IComparable
    {
        public Persona(string nombre, int dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }
        public Persona() { }

        public virtual int Dni { get; set; }
        public virtual string Nombre { get; set; }

        public virtual bool sosIgual(IComparable elemento)
        {
            return this.Dni == ((Persona)elemento).Dni;
        }

        public virtual bool sosMenor(IComparable elemento)
        {
            return this.Dni > ((Persona)elemento).Dni;
        }

        public virtual  bool sosMayor(IComparable elemento)
        {
            return this.Dni < ((Persona)elemento).Dni;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Dni:" + Dni.ToString();
        }
    }
}   