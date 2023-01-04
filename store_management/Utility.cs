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
        //Todo ask Mahdi
        public static void controls_factory(
            Control.ControlCollection parents,
            string dtype, string text,
            int width, int height, int x, int y, int tab_index=0)
        {
            Control control = new Control();
            control.Location = new System.Drawing.Point(x, y);
            control.Size = new System.Drawing.Size(width, height);
            control.TabIndex = tab_index;
            control.Text = $"{text}";

            switch (dtype)
            {
                case "string":
                    TextBox text_box = (TextBox)control;
                    text_box.Name = $"tb_{text}";
                    parents.Add(text_box);
                    break;
                case "label":
                    Label label = (Label)control;
                    label.AutoSize = true;
                    label.Font = new System.Drawing.Font(
                        "Microsoft Sans Serif", 8.5F,
                        System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, 0);
                    label.Name = $"label_{text}";
                    parents.Add(label);
                    break;
                case "bool":
                    CheckBox check = (CheckBox)control;
                    parents.Add(check);
                    break;
                default:
                    System.Console.WriteLine($"Can not find control types for {dtype}" +
                        $" You may want to add it to Utility.controls_factory");
                    break;
            }
        }
        public static void exit()
        {
            Application.Exit();
        }
    }
}
