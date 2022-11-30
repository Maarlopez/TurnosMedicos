using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnosMedicos
{
    class Paciente
    {
        public Paciente(string nombre, int dni, string obra_social, string diagnostico, int nro_afiliado)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.Obra_social = obra_social;
            this.Nro_afiliado = nro_afiliado;
            this.Diagnostico = diagnostico; 
        }

        public Paciente() { }
        string nombre, diagnostico, obra_social;
        int dni, nro_afiliado;

        public virtual int Dni { get; set; }
        public virtual string Nombre { get; set; }

        public virtual int Obra_social { get; set; }
        public virtual string Diagnostico { get; set; }
        public virtual int Nro_afiliado { get; set; }


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
