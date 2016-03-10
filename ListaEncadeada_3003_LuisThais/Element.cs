using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada_3003_LuisThais
{

    public class Element
    {
        public int value = 0;
        public Element nextValue;

        public Element CopyElement()
        {
            return (Element)this.MemberwiseClone();
        }
    }
}
