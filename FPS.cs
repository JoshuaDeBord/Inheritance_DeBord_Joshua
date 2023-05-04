using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_DeBord_Joshua
{
    class FPS : Game
    {

        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }
        public override string Describe()
        {
            return $"{Title} is a fps game rated {Esrb}!";
        }




    }
}
