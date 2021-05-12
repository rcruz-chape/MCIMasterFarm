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
        private SisConfiguracaoEmail MontaConfiguracaoEmail(ref Banco pBanco)
        {
            var vSisConfigDAL = new SisConfiguracaoEmail_DAL();
            return vSisConfigDAL.ObtemCOnfiguracaoEmail(ref pBanco);
        }
        
    }
}
