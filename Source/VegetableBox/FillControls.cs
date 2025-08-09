using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableBox
{
    internal static class FillControls
    {
        internal static void ComboBoxFill(System.Windows.Forms.ComboBox ComboBox, DataTable dataTable, String valueMember,
                                           String displayMember, bool isReqDispChar, String dispChar)
        {
            try
            {
                DataTable m_DataTable = dataTable.Copy();

                DataRow Dr = m_DataTable.NewRow();

                ComboBox.DataSource = m_DataTable;
                ComboBox.DisplayMember = displayMember;
                ComboBox.ValueMember = valueMember;

                if (isReqDispChar == true)
                {
                    DataRow DRow = m_DataTable.NewRow();
                    if (dataTable.Columns[valueMember].DataType == typeof(string))
                    {
                        DRow[valueMember] = "";
                    }
                    else
                    {
                        DRow[valueMember] = 0;
                    }
                    DRow[displayMember] = dispChar;
                    m_DataTable.Rows.InsertAt(DRow, 0);
                }

                ComboBox.SelectedIndex = 0;               
            }
            catch
            {
                throw;
            }
        }
    }
}
