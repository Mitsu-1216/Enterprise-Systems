using System;
using System.Windows.Forms;

class CodeFile1 : Form
{
    private Button[] bt = new Button[6];
    private TableLayoutPanel tlp;

    public static void Main()
    {
        Application.Run(new CodeFile1());

    }

        public CodeFile1()
    {
        this.Text = "Enterprise Systems";
        this.Width = 1500;
        this.Height = 800;
    }

}