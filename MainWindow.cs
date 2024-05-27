using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    // Convert button
    protected void OnButton3Clicked(object sender, EventArgs e)
    {
        Console.WriteLine("Clicked button");
    }

    // Get input text
    protected void OnEntry2TextInserted(object o, TextInsertedArgs args)
    {

        // Convert string to integer
        float i;
        bool success = float.TryParse(entry2.Text, out i);

        // Check if its really an integer
        if (success)
        {
            Console.WriteLine(i);
            float kg_to_lbs = (float)(i * 2.204);
            Console.WriteLine("To pounds: " + kg_to_lbs);

        }
        else
        {
            Console.WriteLine("Invalid.");
        }
    }
}
