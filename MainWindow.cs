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
            // User wants to convert to KG
            if (combobox1.ActiveText == "KG")
            {
                Console.WriteLine("KG Selected");
                label2.Text = "LBS";

                float lbs_to_kg = (float)(i * 0.453);
                Console.WriteLine("To KG: " + lbs_to_kg);

                // Convert integer to string and display it in label
                label1.Text = lbs_to_kg.ToString() + " KG";
            } else if (combobox1.ActiveText == "LBS")
            {
                label2.Text = "KG";
                float kg_to_lbs = (float)(i * 2.204);
                label1.Text = kg_to_lbs.ToString() + " LBS";
            }
        }
        else
        {
            Console.WriteLine("Invalid.");
        }
    }
}
