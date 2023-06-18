using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbkBank.ExceptionLibrary
{
    public class ParaSecimiYapilmadi : Exception
    {
        public ParaSecimiYapilmadi() : base("Lütfen para seçin.")
        {

        }
    }
}
