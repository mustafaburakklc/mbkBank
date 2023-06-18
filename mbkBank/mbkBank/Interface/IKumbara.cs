using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mbkBank.Abstract;

namespace mbkBank.Interface
{
    public interface IKumbara
    {
        void Shake(double minHacim);

        void ParaEkle(Para para);

        List<Para> Break();
    }
}
