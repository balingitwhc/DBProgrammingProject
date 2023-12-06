using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemProject
{
    internal static class UIUtilities
    {
        public static void BindComboBox(ComboBox cmb, DataTable dt, string displayMember, string valueMember)
        {
            //Adding an empty DataRow in the DataTable at first index
            DataRow row = dt.NewRow();
            row[valueMember] = DBNull.Value;
            row[displayMember] = "";
            dt.Rows.InsertAt(row, 0);

            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.DataSource = dt;
        }

        public static void Bind(this ComboBox cmb, DataTable dt, string displayMember, string valueMember, string defaultValue = "")
        {
            //Adding an empty DataRow in the DataTable at first index
            DataRow row = dt.NewRow();
            row[valueMember] = DBNull.Value;
            row[displayMember] = defaultValue;
            dt.Rows.InsertAt(row, 0);

            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.DataSource = dt;
        }

        public static void ClearControls(this Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                switch (ctl)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case GroupBox gB:
                        ClearControls(gB.Controls);
                        break;
                }
            }
        }
    }
}
