using Npgsql;
using System;
using System.Windows.Forms;

class ListFile : Form
{
    private Button[] bt = new Button[6];
    private Button detail_button;
    private Panel panel1;
    private Label label1;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn 購入日;
    private DataGridViewTextBoxColumn 購入内容;
    private DataGridViewTextBoxColumn 金額;
    private DataGridViewTextBoxColumn 支払方法;
    private DataGridViewTextBoxColumn 担当者;
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

        //SQL作成
        sql = "SELECT * FROM public.m_job";
        NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

        //SQL実行
        NpgsqlDataReader dr = cmd.ExecuteReader();

        Console.WriteLine("接続解除");
        connection.Close();
    }

    private void InitializeComponent()
    {
            this.detail_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.create_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.購入日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.購入内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金額 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.支払方法 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.担当者 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // detail_button
            // 
            this.detail_button.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.detail_button.Location = new System.Drawing.Point(820, 0);
            this.detail_button.Name = "detail_button";
            this.detail_button.Size = new System.Drawing.Size(150, 38);
            this.detail_button.TabIndex = 0;
            this.detail_button.Text = "顧客情報詳細へ";
            this.detail_button.UseVisualStyleBackColor = true;
            this.detail_button.Click += new System.EventHandler(this.detail_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.create_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.detail_button);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1129, 626);
            this.panel1.TabIndex = 6;
            // 
            // create_button
            // 
            this.create_button.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.create_button.Location = new System.Drawing.Point(846, 527);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(153, 36);
            this.create_button.TabIndex = 2;
            this.create_button.Text = "顧客情報新規作成";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "顧客一覧を表示します。";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.購入日,
            this.購入内容,
            this.金額,
            this.支払方法,
            this.担当者});
            this.dataGridView1.Location = new System.Drawing.Point(23, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(961, 489);
            this.dataGridView1.TabIndex = 3;
            // 
            // 購入日
            // 
            this.購入日.HeaderText = "購入日";
            this.購入日.Name = "購入日";
            // 
            // 購入内容
            // 
            this.購入内容.HeaderText = "購入内容";
            this.購入内容.Name = "購入内容";
            // 
            // 金額
            // 
            this.金額.HeaderText = "金額";
            this.金額.Name = "金額";
            // 
            // 支払方法
            // 
            this.支払方法.HeaderText = "支払方法";
            this.支払方法.Name = "支払方法";
            // 
            // 担当者
            // 
            this.担当者.HeaderText = "担当者";
            this.担当者.Name = "担当者";
            // 
            // ListFile
            // 
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.panel1);
            this.Name = "ListFile";
            this.Text = "顧客一覧画面";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

    }


    /// <summary>
    /// 詳細画面へ遷移
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void detail_button_Click(object sender, EventArgs e)
    {
        {
            TabFile tabfile = new TabFile();
            tabfile.Show();
        }
    }

    private void create_button_Click(object sender, EventArgs e)
    {
        NewFile newfile = new NewFile();
        newfile.Show();
    }
}