//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YourNamespace {
    using System;
    using Terminal.Gui;
    
    
    public partial class MyWindow : Terminal.Gui.Window {
        
        private Terminal.Gui.FrameView frameview1;
        
        private Terminal.Gui.Label label2;
        
        private Terminal.Gui.Button button1;
        
        private Terminal.Gui.Label label3;
        
        private Terminal.Gui.Label label1;
        
        private Terminal.Gui.DateField datefield1;
        
        private Terminal.Gui.HexView hexview1;
        
        private Terminal.Gui.Views.LineView lineview1;
        
        private Terminal.Gui.Label label4;
        
        private Terminal.Gui.ListView listview2;
        
        private Terminal.Gui.ListView listview1;
        
        private void InitializeComponent() {
            this.Text = "";
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.TextAlignment = TextAlignment.Centered;
            this.Title = "Welcome to Demo";
            this.frameview1 = new Terminal.Gui.FrameView();
            this.frameview1.Data = "frameview1";
            this.frameview1.Text = "";
            this.frameview1.Width = 29;
            this.frameview1.Height = 11;
            this.frameview1.X = 23;
            this.frameview1.Y = 1;
            this.frameview1.TextAlignment = TextAlignment.Left;
            this.Add(this.frameview1);
            this.label2 = new Terminal.Gui.Label();
            this.label2.Data = "label2";
            this.label2.Text = "I\'m in a frame view";
            this.label2.Width = 19;
            this.label2.Height = 1;
            this.label2.X = 4;
            this.label2.Y = 3;
            this.label2.TextAlignment = TextAlignment.Left;
            this.frameview1.Add(this.label2);
            this.button1 = new Terminal.Gui.Button();
            this.button1.Data = "button1";
            this.button1.Text = "Yay";
            this.button1.Width = 7;
            this.button1.Height = 1;
            this.button1.X = 9;
            this.button1.Y = 5;
            this.button1.TextAlignment = TextAlignment.Centered;
            this.button1.IsDefault = false;
            this.frameview1.Add(this.button1);
            this.label3 = new Terminal.Gui.Label();
            this.label3.Data = "label3";
            this.label3.Text = "Cool eh?";
            this.label3.Width = 8;
            this.label3.Height = 1;
            this.label3.X = 25;
            this.label3.Y = 1;
            this.label3.TextAlignment = TextAlignment.Left;
            this.Add(this.label3);
            this.label1 = new Terminal.Gui.Label();
            this.label1.Data = "label1";
            this.label1.Text = "Dob:";
            this.label1.Width = 4;
            this.label1.Height = 1;
            this.label1.X = 6;
            this.label1.Y = 3;
            this.label1.TextAlignment = TextAlignment.Left;
            this.Add(this.label1);
            this.datefield1 = new Terminal.Gui.DateField();
            this.datefield1.Data = "datefield1";
            this.datefield1.Text = " 02/03/22";
            this.datefield1.Width = 10;
            this.datefield1.Height = 1;
            this.datefield1.X = 10;
            this.datefield1.Y = 3;
            this.datefield1.TextAlignment = TextAlignment.Left;
            this.Add(this.datefield1);
            this.hexview1 = new Terminal.Gui.HexView();
            this.hexview1.Data = "hexview1";
            this.hexview1.Text = "Heya";
            this.hexview1.Width = 4;
            this.hexview1.Height = 5;
            this.hexview1.X = 60;
            this.hexview1.Y = 3;
            this.hexview1.TextAlignment = TextAlignment.Left;
            this.Add(this.hexview1);
            this.lineview1 = new Terminal.Gui.Views.LineView();
            this.lineview1.Data = "lineview1";
            this.lineview1.Text = "Heya";
            this.lineview1.Width = 76;
            this.lineview1.Height = 1;
            this.lineview1.X = 0;
            this.lineview1.Y = 14;
            this.lineview1.TextAlignment = TextAlignment.Left;
            this.Add(this.lineview1);
            this.label4 = new Terminal.Gui.Label();
            this.label4.Data = "label4";
            this.label4.Text = "(This is a line view)";
            this.label4.Width = 21;
            this.label4.Height = 1;
            this.label4.X = 28;
            this.label4.Y = 14;
            this.label4.TextAlignment = TextAlignment.Left;
            this.Add(this.label4);
            this.listview2 = new Terminal.Gui.ListView();
            this.listview2.Data = "listview2";
            this.listview2.Text = "";
            this.listview2.Width = 20;
            this.listview2.Height = 3;
            this.listview2.X = 20;
            this.listview2.Y = 19;
            this.listview2.TextAlignment = TextAlignment.Left;
            this.listview2.Source = new Terminal.Gui.ListWrapper(new string[] {
                        "Bob",
                        "Frank",
                        "Fish head",
                        "Dave"});
            this.Add(this.listview2);
            this.listview1 = new Terminal.Gui.ListView();
            this.listview1.Data = "listview1";
            this.listview1.Text = "Heya";
            this.listview1.Width = 19;
            this.listview1.Height = 5;
            this.listview1.X = 60;
            this.listview1.Y = 19;
            this.listview1.TextAlignment = TextAlignment.Left;
            this.listview1.Source = null;
            this.Add(this.listview1);
        }
    }
}
