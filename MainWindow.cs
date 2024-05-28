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

        // Convert entry text to number (float)
        float i;
        bool success = float.TryParse(entry2.Text, out i);

        // Check if its really a number
        if (success)
        {
            Console.WriteLine(i);
            // User wants to convert that entry to KG
            if (combobox1.ActiveText == "KG")
            {
                Console.WriteLine("KG Selected");

                // Entry given is on LBS
                label2.Text = "LBS";

                float lbs_to_kg = (float)(i * 0.453);
                Console.WriteLine("To KG: " + lbs_to_kg);

                // Gets converted weight and display it
                label1.Text = lbs_to_kg.ToString() + " KG";
            } 
            // User wants to convert that entry to LBS
            else if (combobox1.ActiveText == "LBS")
            {
                // Entry given is on KG
                label2.Text = "KG";
                float kg_to_lbs = (float)(i * 2.204);

                // Gets converted weight and display it
                label1.Text = kg_to_lbs.ToString() + " LBS";
            }
        }
        else
        {
            Console.WriteLine("Invalid.");
        }
    }
}
