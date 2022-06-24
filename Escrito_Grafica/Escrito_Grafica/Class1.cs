using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Escrito_Grafica
{
    class Class1
    {
        ArrayList Lista = new ArrayList();
        public class Deportista
        {
            public int cI { get; set; }
            public string nombre { get; set; }
            public string fechaNac { get; set; }
            public int horasEntren { get; set; }

            public Deportista() { }
            public Deportista(int cI, string nombre, string fechaNac, int horasEntren)
            {
                this.cI = cI;
                this.nombre = nombre;
                this.fechaNac = fechaNac;
                this.horasEntren = horasEntren;
            }
        }

        public class Amateur:Deportista
        {
            private int añosPract { get; set; }
            public Amateur() { }
            public Amateur(int cI, string nombre, string fechaNac, int horasEntren, int añosPract):base(cI,nombre,fechaNac,horasEntren)
            {
                this.añosPract = añosPract;
            }

            public int CostoMenA()
            {
                int costo;
                costo = horasEntren * 300;
                return costo;
            }

            public string MostrarAmat()
            {
               return ("La cedula del deportista es: " + cI + ",el nombre es: " + nombre + ", la fecha de nacimiento es: " + fechaNac + ",las horas de entrenamiento son: " + horasEntren + ", los años de practica son: " + añosPract + " y el costo mensual es: " + CostoMenA());
            }
        }
        public class Profesional : Deportista
        { 
            private int sueldo { get; set; }
            public Profesional() { }
            public Profesional(int cI, string nombre, string fechaNac, int horasEntren, int sueldo) : base(cI, nombre, fechaNac, horasEntren)
            {
                this.sueldo = sueldo;
            }

            public int CostoMenP()
            {
                int costo;
                costo = (horasEntren * 30000) + sueldo;
                return costo;
            }
            
            public string MostrarProf()
            {
                return ("La cedula del deportista es: " + cI + ",el nombre es: " + nombre + ", la fecha de nacimiento es: " + fechaNac + ",las horas de entrenamiento son: " + horasEntren + ", el sueldo es: " + sueldo + " y el costo mensual es: " +CostoMenP());
            }

           
        }
    }
}
