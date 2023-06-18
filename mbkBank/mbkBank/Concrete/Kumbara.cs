using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mbkBank.Abstract;
using mbkBank.Interface;

namespace mbkBank.Concrete
{
    public class Kumbara : IKumbara
    {
        #region Fields & Propertys

        private double _paraMiktari;

        public double BirikenParaMiktari
        {
            get { return _paraMiktari; }
            set { _paraMiktari = value; }
        }

        public double KumbaraHacmi { get; set; }

        public double BirikenHacim { get; set; }

        public List<Para> KumbaradakiParalar { get; set; }

        #endregion

        #region Constructor

        public Kumbara(int hacim)
        {
            KumbaraHacmi = hacim;
        }

        #endregion

        #region Methods

        public void Shake(double minHacim)
        {
            BirikenHacim = minHacim;
        }

        public void ParaEkle(Para para)
        {
            _paraMiktari += para.Miktar;
            if (KumbaradakiParalar == null)
            {
                KumbaradakiParalar = new List<Para>();
            }
            KumbaradakiParalar.Add(para);
        }

        public List<Para> Break()
        {
            return KumbaradakiParalar;
        }

        #endregion
    }
}
