using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupPersonalGain
{
    public class Configuracion
    {
        public SCKey shortcuts;
        public Misc miscs;
        public class SCKey
        {
            public string play { get; set; }
            public string pause { get; set; }
            public string stop { get; set; }
            public string floadkey { get; set; }
            public string volup { get; set; }
            public string voldown { get; set; }
            public string ffward { get; set; }
            public string fbward { get; set; }
            public string hidewin { get; set; }
            public string showwin { get; set; }
        }
        public class Misc
        {
            public bool closeonfinish { get; set; }
            public bool fullscreen { get; set; }
        }
    }
}
