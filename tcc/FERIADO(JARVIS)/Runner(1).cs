using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_
{
  public static  class Runner
    {//fala que hrs sao
        public static void qualHORAS()
        {
            speaker.speak(DateTime.Now.ToShortTimeString());


        }
        public static void QualDia()
        {
            speaker.speak(DateTime.Now.ToShortDateString());
        }
    }
}
