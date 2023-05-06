using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_06_05.Interface.IPersona
{
    
    internal interface IPersona
    {
        string Name { get; }

        int Edad { get;}

        void Saludar();
        void CumplirAnios();
        

        
    }
    
}
