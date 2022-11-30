namespace TurnosMedicos
{
   public abstract class IPaciente : Persona
   {  
        public abstract double Nro_afiliado { get; set; }
        public abstract int Diagnostico { get; set; }
        public abstract int Obra_social { get; set; }

        public abstract override bool sosIgual(IComparable elemento);

        public abstract override bool sosMenor(IComparable elemento);

        public abstract override bool sosMayor(IComparable elemento);

        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Dni:" + Dni + ", legajo: " + Nro_afiliado;
        }
    }
}