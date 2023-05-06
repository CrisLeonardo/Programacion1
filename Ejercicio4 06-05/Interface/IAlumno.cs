using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_06_05.Interface.IPersona
{
    internal class IAlumno : IPersona
    {
        public string Name = NameA;

        public int Edad => throw new NotImplementedException();

        public void CumplirAnios()
        {

            Console.WriteLine($"Hola mi nombre es {Name}");
        }

        public void Saludar()
        {
            int AniosA = Edad + 1;
            Console.WriteLine($"{Name} a Cumplido anios!!!\n{Name} ahora tiene {AniosA}");
        }
    }
}
