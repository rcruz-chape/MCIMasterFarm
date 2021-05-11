using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCIMasterFarm.Negocio.BackOffice.Negocio
{
    public class ConfiguraControleNEG
    {
        public ComboBox SetComboBox (ComboBox pComboBox, string pDisplayedName, string pSelectValue)
        {
            ComboBox vCOmbobox = pComboBox;

            vCOmbobox.DisplayMember = pDisplayedName;
            vCOmbobox.ValueMember = pSelectValue;
            vCOmbobox.SelectedValue = pSelectValue;

            return vCOmbobox;
        }
        public DataGridViewComboBoxColumn SetComboBoxColumn(DataGridViewComboBoxColumn pComboBox, string pDisplayedNAme, string pSelectValue)
        {
            DataGridViewComboBoxColumn vComboBox = pComboBox;

            vComboBox.DisplayMember = pDisplayedNAme;
            vComboBox.ValueMember = pSelectValue;
            
            return vComboBox;
        }
    }
}
