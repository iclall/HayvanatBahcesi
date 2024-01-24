using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_211450002
{
    internal  class Insan
    {
        protected string isim;
        protected string yas;
        protected int id;
        
        public virtual void InsanMesaji()
        {
            Console.WriteLine("insan oluşturuldu");
        }
      
    }
}
