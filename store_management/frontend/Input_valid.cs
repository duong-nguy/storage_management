using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_management.frontend
{
    static class Input_valid
    {
        public static enums.Validation_result validation(
            params TextBox[] textBoxes)
        {
            foreach (TextBox box in textBoxes)
            {
                if (box.Text == string.Empty) return enums.Validation_result.No;
            }
            return enums.Validation_result.Yes;
        }
        public static enums.Validation_result validation(
            params ComboBox[] cumBoxes)
        {
            foreach (ComboBox box in cumBoxes)
            {
                if (box.SelectedIndex < 0 ) return enums.Validation_result.No;
                
            }
            return enums.Validation_result.Yes;
        }
        public static enums.Validation_result validation(
            params NumericUpDown[] numBoxes)
        {
            foreach (NumericUpDown box in numBoxes)
            {
                if (box.Value <= 0) return enums.Validation_result.No;
            }
            return enums.Validation_result.Yes;
        }
        public static enums.Validation_result validation(
            params Image[] images)
        {
            foreach (Image img in images)
            {
                if (img == null) return enums.Validation_result.No;
            }
            return enums.Validation_result.Yes;
        }



    }
}
