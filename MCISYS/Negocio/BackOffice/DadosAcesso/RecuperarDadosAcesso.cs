using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;

namespace MCIMasterFarm.Negocio.BackOffice
{
    public class DadosACessos
    {
        public string RecuperarDadosAcesso(ref Banco pBanco)
        {
            string[] linhasConfiguracao = System.IO.File.ReadAllLines(@"c:\temp\mcisys.conf");

            foreach(string linhaConfiguracao in linhasConfiguracao)
            {
                int c_2_ponto = linhaConfiguracao.IndexOf("=");
                string Par = linhaConfiguracao.Substring(0,c_2_ponto);
                if (Par =="Host")
                {
                    pBanco.Host = linhaConfiguracao.Substring(c_2_ponto + 1, linhaConfiguracao.Length - 5 ) ;
                }
                else if (Par== "Port")
                {
                    pBanco.Porta = linhaConfiguracao.Substring(c_2_ponto + 1, linhaConfiguracao.Length - 5);
                }
                else if (Par == "Dbase")
                {
                    pBanco.DbName = linhaConfiguracao.Substring(c_2_ponto + 1, linhaConfiguracao.Length - 6);
                }
                else if (Par == "User")
                {
                    pBanco.User = linhaConfiguracao.Substring(c_2_ponto + 1, linhaConfiguracao.Length - 5);
                }

            }
            return "1";
        }

    }
}
