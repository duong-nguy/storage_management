using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace store_management
{
    static class Utility
    {
        public static void close_open_form(Form close_form, Form open_form)
        {
            close_form.Hide();
            open_form.ShowDialog();
            close_form.Close();
        }
        public static string make_pretty_string(string value)
        {
            string[] process_string =
                value.Contains('_') ? value.Split('_') : new string[] { value };
            string res = "";
            foreach (string smol in process_string)
            {
                res +=
                Char.ToUpper(smol[0])
                + smol.Substring(1) + " ";

            }
            return res;
        }
        public static string make_usable_string(string value)
        {
            value = value.ToLower();
            value = value.Contains(' ') ? value.Replace(' ','_') : value ;
            return value;

        }
        public static string check_valid_string(string value)
        {
            string pattern = @"^[a-zA-Z _-]+S";
            RegexOptions options = RegexOptions.Multiline;
            string res = "";
            foreach (Match m in Regex.Matches(value, pattern, options))
            {
                res += $"{m.Value} found at {m.Index}. \n";
            }
            return res;
        }
        public static void exit()
        {
            Application.Exit();
        }
    }
}
