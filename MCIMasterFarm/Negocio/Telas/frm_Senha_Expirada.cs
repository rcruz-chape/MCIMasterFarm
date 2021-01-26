﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.BackOffice.DadosAcesso;
using MCIMasterFarm.Negocio.BackOffice.Install;
using MCIMasterFarm.Negocio.BackOffice.Model;

namespace MCIMasterFarm.Negocio.Telas
{
    public partial class frm_Senha_Expirada : Form
    {
        SisUsuario vSisUsu = new SisUsuario();
        Banco vBanco = new Banco();
        public frm_Senha_Expirada(SisUsuario pSisUsu, ref Banco pBanco)
        {
            vSisUsu = pSisUsu;
            vBanco = pBanco;
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAlterarSenha_Click(object sender, EventArgs e)
        {
            var Criptografia = new Criptografia();
            var vNegSisParameto = new SIS_PARAMETRO_NEG();
            string vMensagem = "";
            Boolean vbResultado = true;
            Boolean vbValida = Criptografia.VerifcaConteudo(txtSenha.Text,vSisUsu.ds_pwd);
            if (!vbValida)
            {
                vbResultado = vbValida;
                var vDialog = MessageBox.Show("Senha não confere!", "Erro no Login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (vbResultado)
            {
                var sNEgSisUsuario = new SIS_USUARIO_NEG();
                vbResultado = sNEgSisUsuario.
            }
        }
    }
}
