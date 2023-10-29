using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

class ListFile : Form
{
    private Button[] bt = new Button[6];
    private Panel panel1;
    private Label label1;
    private DataGridView dataGridView_customerinfo;
    private DataGridViewButtonColumn detail_button;
    private Button create_button;

        public ListFile()
    {
        this.Text = "Lists";
        this.Width = 1500;
        this.Height = 900;

        InitializeComponent();

        string connectInfo = string.Empty;
        string sql = string.Empty;
        string userid = string.Empty;
        string username = string.Empty;

        //接続情報を作成
        connectInfo = "Server=localhost;" //接続先サーバ 
                    + "Port=5432;"  //ポート番号
                    + "User Id=postgres;"  //接続ユーザ
                    + "Password=root;" //パスワード
                    + "Database=postgres;"; //接続先データベース

        //インスタンスを生成
        NpgsqlConnection connection = new NpgsqlConnection(connectInfo);

        //データベース接続
        connection.Open();
        Console.WriteLine("接続開始");

        //顧客情報取得
        NpgsqlCommand command = null;
        string cmd_str = null;
        DataTable dt = null;
        NpgsqlDataAdapter da = null;

        dt = new DataTable();
        cmd_str = "SELECT * FROM customer_table";
        command = new NpgsqlCommand(cmd_str, connection);
        da = new NpgsqlDataAdapter(command);
        da.Fill(dt);

        dataGridView_customerinfo.DataSource = dt;

        Console.WriteLine("接続解除");
        connection.Close();
    }

    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_customerinfo = new System.Windows.Forms.DataGridView();
            this.detail_button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.create_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customerinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_customerinfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1460, 786);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView_customerinfo
            // 
            this.dataGridView_customerinfo.AllowUserToDeleteRows = false;
            this.dataGridView_customerinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_customerinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customerinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail_button});
            this.dataGridView_customerinfo.Location = new System.Drawing.Point(23, 44);
            this.dataGridView_customerinfo.Name = "dataGridView_customerinfo";
            this.dataGridView_customerinfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_customerinfo.RowTemplate.Height = 21;
            this.dataGridView_customerinfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView_customerinfo.Size = new System.Drawing.Size(1535, 808);
            this.dataGridView_customerinfo.TabIndex = 3;
            this.dataGridView_customerinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_customerinfo_CellContentClick);
            // 
            // detail_button
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.detail_button.DefaultCellStyle = dataGridViewCellStyle1;
            this.detail_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detail_button.HeaderText = "";
            this.detail_button.Name = "detail_button";
            this.detail_button.Text = "詳細";
            this.detail_button.ToolTipText = "顧客情報詳細画面を表示します。";
            this.detail_button.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "顧客一覧を表示します";
            // 
            // create_button
            // 
            this.create_button.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.create_button.Location = new System.Drawing.Point(1319, 792);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(153, 36);
            this.create_button.TabIndex = 2;
            this.create_button.Text = "顧客情報新規作成";
            this.create_button.UseVisualStyleBackColor = true;
            // 
            // ListFile
            // 
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.create_button);
            this.Name = "ListFile";
            this.Text = "顧客一覧画面";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customerinfo)).EndInit();
            this.ResumeLayout(false);

    }





    private void create_button_Click(object sender, EventArgs e)
    {
        NewFile newfile = new NewFile();
        newfile.Show();
    }

    /// <summary>
    /// 詳細画面へ遷移
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void dataGridView_customerinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        //詳細画面へ
        TabFile tabfile = new TabFile();
        tabfile.Show();
    }
}