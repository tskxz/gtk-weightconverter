using System;
using Gtk;

namespace Weightconv
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();

            // Label
            Label label_lbs = new Label();
            label_lbs.Text = "LBS";

            win.Add(label_lbs);

            win.ShowAll();
            Application.Run();
        }
    }
}
