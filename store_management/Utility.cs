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


        public static void exit()
        {
            Application.Exit();
        }
    }
}
