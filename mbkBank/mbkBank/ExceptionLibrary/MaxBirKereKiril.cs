using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbkBank.ExceptionLibrary
{
    public class MaxBirKereKiril : Exception
    {
        public MaxBirKereKiril() : base("Kırılma sayısını aştınız daha fazla kumbarayı kıramazsınız!")
        {

        }
    }
}
