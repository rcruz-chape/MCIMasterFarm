using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.Telas;
using MCIMasterFarm.Negocio.Global;

namespace MCIMasterFarm.Negocio.BackOffice.Negocio
{
    public class SIS_PARAMETRO_NEG
    {
        string psDS_Caracter_Obrigatorio = "S";
        List<String> lsCaracterEspecial = new List<String>() { "@","!","$","%","¨","&","Ç","ç","?"};
        public SisParametro ObtemParametro(ref Banco pBanco)
        {
            var vSisParametroDal = new SIS_PARAMETRO_DAL();
            return vSisParametroDal.getParametro(ref pBanco); 
        }
        public Boolean bAtualizaParametro(ref Banco pBanco, SisParametro pParametro)
        {
            var vSisParametroDal = new SIS_PARAMETRO_DAL();
            return vSisParametroDal.bUpdateParametro(ref pBanco, pParametro);
        }
        public Boolean bValidaDSCaracter(string pdsPWd, SisParametro pParametro)
        {
            Boolean bValidaCaracter = pParametro.ds_car_especial != psDS_Caracter_Obrigatorio;
            if (!bValidaCaracter)
            {
                foreach (string CaracterEspecial in lsCaracterEspecial)
                {
                    if (pdsPWd.Contains(CaracterEspecial))
                    {
                        bValidaCaracter = true;
                        break;
                    }
                }
            }
            return bValidaCaracter;
        }
        public Boolean bValidaNumeroCaracterMaiuscula(string pdsPWd, SisParametro pParametro)
        {
            Boolean vbValidaNumeroCaracterMaiuscula = pParametro.ind_car_maisculo < 1;
            if (!vbValidaNumeroCaracterMaiuscula)
            {
                var ContaCar = pdsPWd.Count(char.IsUpper);
                vbValidaNumeroCaracterMaiuscula = ContaCar >= pParametro.ind_car_maisculo;
            }
            return vbValidaNumeroCaracterMaiuscula;
        }
        public Boolean bValidaNumeroCaracterMinuscula(string pdsPWd, SisParametro pParametro)
        {
            Boolean vbValidaNumeroCaracterMinuscula = pParametro.ind_car_minisculo < 1;
            if (!vbValidaNumeroCaracterMinuscula)
            {
                var ContaCar = pdsPWd.Count(char.IsLower);
                vbValidaNumeroCaracterMinuscula = ContaCar >= pParametro.ind_car_minisculo;
            }
            return vbValidaNumeroCaracterMinuscula;
        }
        public Boolean bValidaNumero(string pdsPWd, SisParametro pParametro)
        {
            int totCar = 0;
            Boolean vbValidaNumero = pParametro.ind_numero < 1;
            if (!vbValidaNumero)
            {
                totCar += pdsPWd.Count(char.IsNumber);
                if (totCar >= pParametro.ind_numero)
                {
                    vbValidaNumero = true;
                }
            }
            return vbValidaNumero;
        }
        public Boolean bValidaIndTotalCar(string pdsPWd, SisParametro pParametro)
        {
            int totCar = 0;
            Boolean vbValidaIndTotalCar = pParametro.ind_total_car < 1;
            if (!vbValidaIndTotalCar)
            {
                totCar += pdsPWd.Length;
                if (totCar >= pParametro.ind_total_car)
                {
                    vbValidaIndTotalCar = true;
                }
            }
            return vbValidaIndTotalCar;
        }
    }
}
