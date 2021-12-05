using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.DictionarysVersion
{
    public class DicVersionImplemented
    {
        public Dictionary<int, string> VersaoImplementada = new Dictionary<int, string>()
        {
            {1,"1.0.0.0"}
        };
        public int ObtemQtdVErsaoNotImplemented(Dictionary<int, string> pVersaoImplementada, string nrVersao)
        {
            int index = 0;
            foreach(var linha in pVersaoImplementada)
            {
                if (linha.Value == nrVersao)
                {
                    index = linha.Key;
                    break;
                }
            }
            int VersoesImplementar = pVersaoImplementada.Count(linha => linha.Key >= index);
            return VersoesImplementar;
        }
        public Dictionary<int, string> VersoesImplementar(Dictionary<int, string> pVersaoImplementada, string nrVersao)
        {
            var vVersoesImplementar = new Dictionary<int, string>();
            int index = 0;
            foreach (var linha in pVersaoImplementada)
            {
                if (linha.Value == nrVersao)
                {
                    index = linha.Key;
                    break;
                }
            }
            foreach (var linha in pVersaoImplementada)
            {
                if (linha.Key >= index)
                {
                    vVersoesImplementar.Add(linha.Key, linha.Value);
                }
            }
            return vVersoesImplementar;

        }
    }
}
