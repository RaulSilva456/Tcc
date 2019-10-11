using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FERIADO_JARVIS_
{
    public class GrammarRules
    {
        public static List<string> QueHorasSão = new List<string>()
        {
            "Que horas São"
            
        };
        public static IList<string> QualData = new List<string>()
        {
            
            "Que dia e Hoje"
            


        };
        public static IList<string> FeriadoStar = new List<string>()
        {
           
             "ativado"
            
        };
        public static IList<string> FeriadoStop = new List<string>()
        {
            "desligar"
        };
        public static IList<string> MinimizarJanela = new List<string>()
        {
           
            "Desce Janela"
        };
        public static IList<string> MaximizarTela = new List<string>()
        {
            
            "tamanho normal",
            "subi janela"
        };
        
        public static IList<string> AbrirMenu = new List<string>()
        {
            "Abrir Menu"
        };
        public static IList<string> FecharMenu = new List<string>()
        {
            "Fechar Menu"
        };
        public static IList<string> MinimizarMenu = new List<string>()
        {
            "menu minimizar"
        };
        public static IList<string> SubirMenu = new List<string>()
        {
            "Menu subir"
        };


    }
}
