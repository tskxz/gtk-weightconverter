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

    protected void OnEntry2TextInserted(object o, TextInsertedArgs args)
    {
        Console.WriteLine("Text is inserted");
    }
}
