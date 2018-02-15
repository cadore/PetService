using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetService
{
    public class Enum
    {
        public enum EspeciePet
        {
            canina = 0,
            felina = 1
        }
        public enum DiaDaSemana
        {
            domingo = 1,
            segunda = 2,
            terca = 3,
            quarta = 4,
            quinta = 5, 
            sexta = 6, 
            sabado = 7
        }
        public enum TurnoDia
        {
            matutino = 0,
            vespertino = 1,
            noturno = 2
        }
        public enum PorteAnimal
        {
            mini = 0,
            pequeno = 1,
            medio = 2,
            grande = 3,
            gigante = 4
        }
    }
}
