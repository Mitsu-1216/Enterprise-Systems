using System;
using System.Windows.Forms;

class TabFile : Form
{
    private Button[] bt = new Button[6];
    private Panel panel1;
    private TabControl tabControl1;
    private TabPage 顧客基本情報;
    private TabPage 購入履歴;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage5;
    private TabPage tabPage6;
    private TabPage tabPage7;
    private TableLayoutPanel tlp;

    public TabFile()
    {
        this.Text = "detail screen";
        this.Width = 3000;
        this.Height = 1600;

        InitializeComponent();
    }

    private void InitializeComponent()
    {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.顧客基本情報 = new System.Windows.Forms.TabPage();
            this.購入履歴 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(788, 594);
            this.panel1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.顧客基本情報);
            this.tabControl1.Controls.Add(this.購入履歴);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 515);
            this.tabControl1.TabIndex = 7;
            // 
            // 顧客基本情報
            // 
            this.顧客基本情報.BackColor = System.Drawing.Color.FloralWhite;
            this.顧客基本情報.Location = new System.Drawing.Point(4, 22);
            this.顧客基本情報.Name = "顧客基本情報";
            this.顧客基本情報.Padding = new System.Windows.Forms.Padding(3);
            this.顧客基本情報.Size = new System.Drawing.Size(777, 489);
            this.顧客基本情報.TabIndex = 0;
            this.顧客基本情報.Text = "顧客基本情報";
            this.顧客基本情報.ToolTipText = "顧客の基本情報を表示します。";
            // 
            // 購入履歴
            // 
            this.購入履歴.Location = new System.Drawing.Point(4, 22);
            this.購入履歴.Name = "tabPage2";
            this.購入履歴.Padding = new System.Windows.Forms.Padding(3);
            this.購入履歴.Size = new System.Drawing.Size(777, 489);
            this.購入履歴.TabIndex = 1;
            this.購入履歴.Text = "購入履歴";
            this.購入履歴.UseVisualStyleBackColor = true;
            //  
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 489);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(777, 489);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(777, 489);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(777, 489);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(777, 489);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // TabFile
            // 
            this.ClientSize = new System.Drawing.Size(786, 513);
            this.Controls.Add(this.panel1);
            this.Name = "TabFile";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }


    private void button1_Click(object sender, EventArgs e)
    { 

    }
}