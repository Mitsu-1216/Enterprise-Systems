using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Data.Common;

class CodeFile1 : Form
{
    private Button[] bt = new Button[6];
    private Button loginbutton;
    private Label label1;
    private Label label2;
    private TextBox textBoxUserId;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private TextBox textBoxPassword;
    private TableLayoutPanel tlp;
        public static void Main()
    {
        Application.Run(new CodeFile1());

    }

        public CodeFile1()
    {
        this.Text = "Enterprise Systems";
        this.Width = 5000;
        this.Height = 1600;

        InitializeComponent();

        this.Load += new System.EventHandler(this.textBoxUserId_Load);
        this.Load += new System.EventHandler(this.textBoxPassword_Load);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeFile1));
            this.loginbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loginbutton.Location = new System.Drawing.Point(516, 489);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(121, 43);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "ログインする";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("BIZ UDPゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 101);
            this.label1.TabIndex = 1;
            this.label1.Text = "ログインID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("BIZ UDPゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(73, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 102);
            this.label2.TabIndex = 2;
            this.label2.Text = "パスワード";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserId.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxUserId.Location = new System.Drawing.Point(316, 54);
            this.textBoxUserId.Multiline = true;
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxUserId.Size = new System.Drawing.Size(165, 44);
            this.textBoxUserId.TabIndex = 3;
            this.textBoxUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUserId, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(306, 117);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(531, 305);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPassword.Location = new System.Drawing.Point(316, 206);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPassword.Size = new System.Drawing.Size(165, 44);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1134, 675);
            this.panel1.TabIndex = 6;
            // 
            // CodeFile1
            // 
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeFile1";
            this.Text = "ログイン画面";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    // 今だけ
    private void textBoxUserId_Load(object sender, EventArgs e)
    {
        textBoxUserId.Text = "ADMIN01";
    }

    private void textBoxPassword_Load(object sender, EventArgs e)
    {
        textBoxPassword.Text = "ADMIN01";
    }

    /// <summary>
    ///メイン画面へ遷移
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void loginbutton_Click(object sender, EventArgs e)
    {
        try
        {

        if(textBoxUserId.Text == "")
        {
            //アラート表示
            MessageBox.Show("ユーザーIDを入力してください。",
            "エラー",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
            return;
        }

        if (textBoxPassword.Text == "")
        {
            //アラート表示
            MessageBox.Show("パスワードを入力してください。",
            "エラー",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
            return;
        }

            string enteredUserId = textBoxUserId.Text;
            string enteredPassword = textBoxPassword.Text;
            string connectInfo = string.Empty;
            string sql = string.Empty;

            NpgsqlCommand command = null;
            DataTable dt = null;
            NpgsqlDataAdapter da = null;

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

            dt = new DataTable();
            sql = "SELECT * FROM user_table WHERE user_id = @user_id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

            ////パラメーター追加
            cmd.Parameters.Add(new NpgsqlParameter("user_id", NpgsqlDbType.Varchar));
            cmd.Parameters["user_id"].Value = enteredUserId;

            da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);

            //SQL実行
            NpgsqlDataReader dr = cmd.ExecuteReader();

            connection.Close();
            if (dt.Rows == null || dt.Rows.Count == 0)
            {
                //アラート表示
                MessageBox.Show("ユーザIDが間違っています。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            } else
            {
                DataRow dataRow = dt.Rows[0];
                string password = dt.Rows[0][2].ToString();
                if(password != enteredPassword)
                {
                    //アラート表示
                    MessageBox.Show("パスワードが間違っています。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
            }

            //顧客一覧リストへ
            ListFile listfile = new ListFile();
            listfile.Show();
        }
        catch(Exception ex)
        {

        }
    }

}