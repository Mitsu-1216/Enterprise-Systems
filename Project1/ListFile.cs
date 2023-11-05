using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.IO;

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
        cmd_str = "SELECT * FROM customer_table ORDER BY customer_id";
        command = new NpgsqlCommand(cmd_str, connection);
        da = new NpgsqlDataAdapter(command);
        da.Fill(dt);

        dataGridView_customerinfo.DataSource = dt;

        dt.Columns["customer_id"].ColumnName = "顧客ID";
        dt.Columns["sei_kanji"].ColumnName = "名前（姓）";
        dt.Columns["mei_kanji"].ColumnName = "名前（名）";
        dt.Columns["sei_kana"].ColumnName = "フリガナ（姓）";
        dt.Columns["mei_kana"].ColumnName = "フリガナ（名）";
        dt.Columns["gender"].ColumnName = "性別";
        dt.Columns["birthday"].ColumnName = "生年月日";
        dt.Columns["postal_number"].ColumnName = "郵便番号";
        dt.Columns["address"].ColumnName = "住所";
        dt.Columns["phone_number"].ColumnName = "電話番号";
        dt.Columns["email_Address"].ColumnName = "メールアドレス";
        dt.Columns["job"].ColumnName = "職業";
        dt.Columns["birthplace"].ColumnName = "出身地";
        dt.Columns["hobby"].ColumnName = "趣味";
        dt.Columns["memo"].ColumnName = "備考";
        dt.AcceptChanges();

        Console.WriteLine("接続解除");
        connection.Close();
    }

    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridView_customerinfo.Location = new System.Drawing.Point(23, 61);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.detail_button.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.label1.Font = new System.Drawing.Font("BIZ UDPゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(205, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "顧客一覧を表示します。";
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
            this.create_button.Click += new System.EventHandler(this.create_button_Click_1);
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

    private void create_button_Click_1(object sender, EventArgs e)
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
        int clickId = int.Parse(dataGridView_customerinfo[1, e.RowIndex].Value.ToString());

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

        //顧客情報取得
        NpgsqlCommand cmd = null;
        string cmd_str = null;
        DataTable dt_customer = null;
        NpgsqlDataAdapter da = null;

        dt_customer = new DataTable();
        cmd_str = "SELECT * FROM customer_table WHERE customer_id = @customer_id";
        cmd = new NpgsqlCommand(cmd_str, connection);

        ////パラメーター追加
        cmd.Parameters.Add(new NpgsqlParameter("customer_id", NpgsqlDbType.Bigint));
        cmd.Parameters["customer_id"].Value = clickId;

        da = new NpgsqlDataAdapter(cmd);
        da.Fill(dt_customer);

        //SQL実行
        NpgsqlDataReader dr = cmd.ExecuteReader();

        connection.Close();
        connection.Open();

        //購入情報取得
        NpgsqlCommand cmd_p = null;
        string cmd_str_p = null;
        DataTable dt_purchase = null;
        NpgsqlDataAdapter da_p = null;

        dt_purchase = new DataTable();
        cmd_str_p = "SELECT * FROM purchase_table WHERE customer_id = @customer_id";
        cmd_p = new NpgsqlCommand(cmd_str_p, connection);

        ////パラメーター追加
        cmd_p.Parameters.Add(new NpgsqlParameter("customer_id", NpgsqlDbType.Bigint));
        cmd_p.Parameters["customer_id"].Value = clickId;

        da_p = new NpgsqlDataAdapter(cmd_p);
        da_p.Fill(dt_purchase);

        //SQL実行
        NpgsqlDataReader dr_p = cmd_p.ExecuteReader();

        //データベース接続解除
        connection.Close();

        TabFile tabfile = new TabFile(dt_customer, dt_purchase);
        tabfile.Show();
    }
}