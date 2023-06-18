using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbkBank.ExceptionLibrary
{
    public class ParaKatla : Exception
    {
        public ParaKatla() : base("Kağıt paraları katlamadan kumbaraya atamazsınız!")
        {

        }
    }
}
