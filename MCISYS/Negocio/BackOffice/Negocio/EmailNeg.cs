using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.Global;
using System.Net.Mime;
using System.Net.Configuration;
using System.Net;

namespace MCIMasterFarm.Negocio.BackOffice.Negocio
{
    public class EmailNeg
    {
        private SmtpClient vsSmtp = new SmtpClient();
        private SisConfiguracaoEmail vConfiguracaoEmail = new SisConfiguracaoEmail();
        private SisConfiguracaoEmail_DAL vConfiEMailDal = new SisConfiguracaoEmail_DAL();
        public Boolean NegInsereMail(ref Banco pBanco, SisConfiguracaoEmail pConfiguracaoEmail)
        {
            return vConfiEMailDal.bInsereCOnfiguracaoEMail(ref pBanco, pConfiguracaoEmail);
        }
        public Boolean SendEmailTeste(SisConfiguracaoEmail pConfiguracaoEmail)
        {
            Boolean vReturn;
            try
            {
                string sTitulo = "Envio de E-mail teste";
                string sMessagem = "Parabéns!";
                sMessagem += Environment.NewLine + "Você recebeu esse e-mail como sinal positivo do teste de envio de e-mail durante a configuração do MCISYS";
                Boolean vbReturn = true;
                MailMessage mail = MontaEmail(sTitulo, sMessagem, pConfiguracaoEmail.DS_EMAIL, pConfiguracaoEmail.DS_EMAIL, pConfiguracaoEmail);
                vsSmtp.Host = pConfiguracaoEmail.DS_HOST;
                vsSmtp.EnableSsl = pConfiguracaoEmail.BO_ENABLE_SSL;
                vsSmtp.Port = pConfiguracaoEmail.NR_PORT;
                vsSmtp.UseDefaultCredentials = pConfiguracaoEmail.BO_USE_DEFAULT_CREDENTIALS;
                vsSmtp.Credentials = new NetworkCredential(vConfiguracaoEmail.DS_EMAIL, vConfiguracaoEmail.DS_SENHA);
                vsSmtp.Send(mail);
                vReturn = true;
            }
            catch (Exception e)
            {
                vReturn = false;
            }
            return vReturn;
        }
        public Boolean SendEmail(string psTitulo, string psMessagem, string psDestinatario, string psnMDestinario, ref Banco pBanco)
        {
            Boolean vbReturn = true;
            vConfiguracaoEmail = MontaConfiguracaoEmail(ref pBanco);
            MailMessage mail = MontaEmail(psTitulo, psMessagem, psDestinatario, psnMDestinario, vConfiguracaoEmail);
            vsSmtp.Host = vConfiguracaoEmail.DS_HOST;
            vsSmtp.EnableSsl = vConfiguracaoEmail.BO_ENABLE_SSL;
            vsSmtp.Port = vConfiguracaoEmail.NR_PORT;
            vsSmtp.UseDefaultCredentials = false;
            vsSmtp.Credentials = new NetworkCredential(vConfiguracaoEmail.DS_EMAIL, vConfiguracaoEmail.DS_SENHA);
            vsSmtp.Send(mail);
            return vbReturn;
        }
        private MailMessage MontaEmail(string psTitulo, string psMessagem, string psDestinatario, string psnMDestinario, SisConfiguracaoEmail pSisConfiguracaoEmail)
        {
            MailMessage vMessageMail = new MailMessage();
            vMessageMail.Sender = new MailAddress(pSisConfiguracaoEmail.DS_EMAIL,"MCISYS");
            vMessageMail.From = new MailAddress(pSisConfiguracaoEmail.DS_EMAIL, "MCISYS");
            vMessageMail.To.Add(new MailAddress(psDestinatario, psDestinatario));
            vMessageMail.Subject = psTitulo;
            vMessageMail.Body ="<br/>" + psMessagem;
            vMessageMail.Priority = MailPriority.High;
            return vMessageMail;
        }
        public SisConfiguracaoEmail MontaConfiguracaoEmail(ref Banco pBanco)
        {
            var vSisConfigDAL = new SisConfiguracaoEmail_DAL();
            return vSisConfigDAL.ObtemCOnfiguracaoEmail(ref pBanco);
        }
        
    }
}
