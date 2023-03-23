using Comet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $rootnamespace$
{
    public class $safeitemname$ : View
    {
        public $safeitemname$()
        {
            Body = () => new VStack
            {
                new Text(() => "Comet is super cool!!!")
            };
        }
    }
}
