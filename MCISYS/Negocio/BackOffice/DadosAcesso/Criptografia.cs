using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MCIMasterFarm.Negocio.BackOffice.DadosAcesso
{
    public class Criptografia
    {
        private HashAlgorithm _algoritmo;
        
        public void Hash(HashAlgorithm algoritmo)
        {
             _algoritmo = algoritmo;
        }
        public string CritografiaDados (string Dados)
        {
            var encodedValue = Encoding.UTF8.GetBytes(Dados);
            Hash(SHA256.Create());
            var encryptedDados = _algoritmo.ComputeHash(encodedValue);

            var sb = new StringBuilder();

            foreach (var car in encryptedDados)
            {
                sb.Append(car.ToString("X2"));
            }

            return sb.ToString();
        }

        public Boolean VerifcaConteudo(string DadoNCriptografado, string DadoCriptografdo)
        {
            string sDadoCriptografado = CritografiaDados(DadoNCriptografado);
            return sDadoCriptografado == DadoCriptografdo;
        }


    }
}
