using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCISYS.DictionarysVersion;
using MCISYS.Negocio.BackOffice.DAL;
using MCISYS.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DadosAcesso;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCISYS.Negocio.BackOffice.Negocio;
using MCISYS.Negocio.BackOffice;
using MCIMasterFarm.Negocio.BackOffice;
using MCISYS.Negocio.BackOffice.Version;


namespace MCISYS.Negocio.Telas
{
    public partial class Frm_Implementa : Form
    {
        private string sVersaoImplementar;

        private Boolean vbAtualizada = false;
        private DialogResult vDialog = new DialogResult();
        private Banco vBanco = new Banco(); 
        private string sVersaoExecutavel;
        const string sVErsao_1_0_0_0 = "1.0.0.0";
        const string sVErsao_0_0_0_0 = "0.0.0.0";
        const string Instalacao = "Processo de Instalação";
        const string Atualizacao = "Processo de Atualização";
        public string DescricaoProcessoAtualizacao = $@"O Processo de Atualização do MCI será inicializado,{Environment.NewLine}Poderá demorar por alguns instantes.";
        public string DescricaoProcessoInstalacao = $@"O Processo de Instalação do MCI será inicializado,{Environment.NewLine}Poderá demorar por alguns instantes.";
        public Frm_Implementa(string VersaoImplementar, string VersaoExecutavel, Banco pBanco)
        {
            sVersaoImplementar = VersaoImplementar;
            sVersaoExecutavel = VersaoExecutavel;
            vBanco = pBanco;
            InitializeComponent();
        }

        private void Frm_Implementa_Load(object sender, EventArgs e)
        {

            this.lblStatusUpdate.Text = "Início . . . .";
            if (sVersaoImplementar == sVErsao_0_0_0_0)
            {
                this.Text = Instalacao;
                this.lbl_StatusMCI.Text = DescricaoProcessoInstalacao;
                this.grpSit.Text = "Bem Vindo a Instalação";
            }
            else
            {
                this.Text = Atualizacao;
                this.lbl_StatusMCI.Text = DescricaoProcessoAtualizacao;
                this.grpSit.Text = "Bem Vindo a Atualização";

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Boolean bExit = false;
            if (!vbAtualizada)
            {
                vDialog = MessageBox.Show($@"{this.Text} não finalizado com sucesso, Deseja sair?", $@"{this.Text} sem sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                bExit = (vDialog == DialogResult.Yes);
                if (vDialog == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                bExit = vbAtualizada;
            }
            if (bExit)
            {
                this.Dispose();
            }


            
        }
        private string sImplementaMCISYS(ref Banco pBanco, int pQtdVersao, Dictionary<int, string> VersoesImplementar, int pFator, int pProgresso)
        {
            string vREturn = "OK";
            var vVersionDict = new VersionDict();
            int vProgresso = pProgresso;
            foreach(var linha in VersoesImplementar)
            {
                this.lblStatusUpdate.Text = $"Implementando a versão  {linha.Value}";               
                this.lblStatusUpdate.Text = $"Implementando a versão  {linha.Value}. Criando a estrutura de Banco de Dados";
                var vstring = vVersionDict.ImplementaBanco(ref pBanco, linha.Value);
                if (vstring != "OK")
                {
                    vREturn = vstring;
                    break;
                }
                vProgresso += pFator;
                this.pgbImplementa.Value = vProgresso;
                this.lblStatusUpdate.Text = $"Implementando a versão  {linha.Value}. Realizando a Carga de Dados";
                vstring = vVersionDict.CargaDado(ref pBanco, linha.Value);
                if (vstring != "OK")
                {
                    vREturn = vstring;
                    break;
                }
            }
            vProgresso += pFator;
            this.pgbImplementa.Value = vProgresso;

            return vREturn;
        }

        private void btSetup_Click(object sender, EventArgs e)
        {

            int vProgresso = 0;
            string Implementa;
            int Fator = 0;
            this.pgbImplementa.Value = vProgresso;
            var DictVersion = new DicVersionImplemented();
            this.lblStatusUpdate.Text = "Obtendo quantidade de versões a implementar";
            vProgresso += 5;
            var totVerImpl = DictVersion.ObtemQtdVErsaoNotImplemented(DictVersion.VersaoImplementada, sVersaoExecutavel);
            this.lblStatusUpdate.Text = "Obtendo as versões a implementar";
            vProgresso += 5;
            var vVersoesImplementar = DictVersion.VersoesImplementar(DictVersion.VersaoImplementada, sVersaoExecutavel);
            this.pgbImplementa.Value = vProgresso;
            Fator = (100 - vProgresso) / (totVerImpl * 2);
            Implementa = sImplementaMCISYS(ref vBanco, totVerImpl, vVersoesImplementar, Fator, vProgresso);
            if (Implementa == "OK")
            {
                vbAtualizada = true;
                this.lblStatusUpdate.Text = "Pronto....";
            }
            else
            {
                vbAtualizada = false;
                vDialog = MessageBox.Show($@"{this.Text} não finalizado com sucesso.", $@"{this.Text} sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.lblStatusUpdate.Text = "";
            }
        }    
    }
}
