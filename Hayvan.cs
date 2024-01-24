using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_211450002
{
    internal abstract class Hayvan
    {
        protected int id;
        protected string kafes_numarasi;
        protected string isim;
        protected string yas;

        public abstract void AyakSayisi();
    }
}
