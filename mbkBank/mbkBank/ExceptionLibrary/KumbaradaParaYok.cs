using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbkBank.ExceptionLibrary
{
    public class KumbaradaParaYok : Exception
    {
        public KumbaradaParaYok() : base("Kumbarada para yok önce para atınız!")
        {

        }
    }
}
