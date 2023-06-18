using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbkBank.ExceptionLibrary
{
    public class KumbaraDoldu : Exception
    {
        public KumbaraDoldu() : base("Kumbara dolu! Sallamayı deneyebilirsiniz.")
        {

        }
    }
}
