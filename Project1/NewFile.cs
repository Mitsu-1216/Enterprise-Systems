using Npgsql;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Data.Common;

class NewFile : Form
{
    private Button[] bt = new Button[6];
    private Panel panel1;
    private Label label1;
    private Button button2;
    private DateTimePicker dateTimePicker1;
    private RadioButton radioButton1;
    private TableLayoutPanel tableLayoutPanel4;
    private RadioButton radioButton2;
    private TableLayoutPanel tableLayoutPanel3;
    private TextBox textBoxKanjiSei;
    private TextBox textBoxKanjiMei;
    private TextBox textBoxKanaSei;
    private TextBox textBoxKanaMei;
    private TableLayoutPanel tableLayoutPanel2;
    private Label label3;
    private TableLayoutPanel tableLayoutPanel1;
    private Label label2;
    private Label label5;
    private Label label4;
    private TextBox textBoxAddress;
    private TextBox textBoxpostalNumber;
    private Label label7;
    private Label label6;
    private Label label8;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label13;
    private TextBox textBoxEmailAddress;
    private TextBox textBoxPhoneNumber;
    private TextBox textBoxHobby;
    private TextBox textBoxMemo;
    private ComboBox comboBoxBirthPlace;
    private ComboBox comboBoxJob;
    private TableLayoutPanel tlp;

    public NewFile()
    {
        this.Text = "Lists";
        this.Width = 1500;
        this.Height = 900;

        InitializeComponent();
    }

    private void InitializeComponent()
    {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxJob = new System.Windows.Forms.ComboBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.postalNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nameTextBoxKanjiSei = new System.Windows.Forms.TextBox();
            this.nameTextBoxKanjiMei = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.nameTextBoxKanaMei = new System.Windows.Forms.TextBox();
            this.nameTextBoxKanaSei = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.emailAddress = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxHobby = new System.Windows.Forms.TextBox();
            this.comboBoxBirthPlace = new System.Windows.Forms.ComboBox();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1123, 684);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxJob, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAddress, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.postalNumber, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.emailAddress, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.phoneNumber, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHobby, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxBirthPlace, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMemo, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("BIZ UDPゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 536);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // comboBoxJob
            // 
            this.comboBoxJob.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxJob.FormattingEnabled = true;
            this.comboBoxJob.Location = new System.Drawing.Point(180, 258);
            this.comboBoxJob.Name = "comboBoxJob";
            this.comboBoxJob.Size = new System.Drawing.Size(182, 27);
            this.comboBoxJob.TabIndex = 27;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxAddress.Location = new System.Drawing.Point(180, 162);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(353, 26);
            this.textBoxAddress.TabIndex = 14;
            // 
            // postalNumber
            // 
            this.postalNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.postalNumber.Location = new System.Drawing.Point(180, 130);
            this.postalNumber.Name = "textBoxPostalNumber";
            this.postalNumber.Size = new System.Drawing.Size(351, 26);
            this.postalNumber.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "住所";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "郵便番号";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "生年月日";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "性別";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "フリガナ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.nameTextBoxKanjiSei, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameTextBoxKanjiMei, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(180, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 24);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // nameTextBoxKanjiSei
            // 
            this.nameTextBoxKanjiSei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBoxKanjiSei.Location = new System.Drawing.Point(10, 3);
            this.nameTextBoxKanjiSei.Name = "nameTextBoxKanjiSei";
            this.nameTextBoxKanjiSei.Size = new System.Drawing.Size(162, 26);
            this.nameTextBoxKanjiSei.TabIndex = 3;
            // 
            // nameTextBoxKanjiMei
            // 
            this.nameTextBoxKanjiMei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBoxKanjiMei.Location = new System.Drawing.Point(191, 3);
            this.nameTextBoxKanjiMei.Name = "nameTextBoxKanjiMei";
            this.nameTextBoxKanjiMei.Size = new System.Drawing.Size(162, 26);
            this.nameTextBoxKanjiMei.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.nameTextBoxKanaMei, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.nameTextBoxKanaSei, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(180, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(360, 24);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // nameTextBoxKanaMei
            // 
            this.nameTextBoxKanaMei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBoxKanaMei.Location = new System.Drawing.Point(189, 3);
            this.nameTextBoxKanaMei.Name = "nameTextBoxKanaMei";
            this.nameTextBoxKanaMei.Size = new System.Drawing.Size(162, 26);
            this.nameTextBoxKanaMei.TabIndex = 3;
            // 
            // nameTextBoxKanaSei
            // 
            this.nameTextBoxKanaSei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBoxKanaSei.Location = new System.Drawing.Point(9, 3);
            this.nameTextBoxKanaSei.Name = "TextBoxKanaSei";
            this.nameTextBoxKanaSei.Size = new System.Drawing.Size(162, 26);
            this.nameTextBoxKanaSei.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "お名前";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "電話番号";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "メールアドレス";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "職業";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "出身地";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "趣味";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "メモ";
            // 
            // emailAddress
            // 
            this.emailAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.emailAddress.Location = new System.Drawing.Point(180, 226);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(353, 26);
            this.emailAddress.TabIndex = 22;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.phoneNumber.Location = new System.Drawing.Point(180, 194);
            this.phoneNumber.Name = "textBoxPhoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(351, 26);
            this.phoneNumber.TabIndex = 21;
            // 
            // textBoxHobby
            // 
            this.textBoxHobby.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxHobby.Location = new System.Drawing.Point(180, 324);
            this.textBoxHobby.Name = "textBoxHobby";
            this.textBoxHobby.Size = new System.Drawing.Size(353, 26);
            this.textBoxHobby.TabIndex = 24;
            // 
            // comboBoxBirthPlace
            // 
            this.comboBoxBirthPlace.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxBirthPlace.FormattingEnabled = true;
            this.comboBoxBirthPlace.Location = new System.Drawing.Point(180, 291);
            this.comboBoxBirthPlace.Name = "comboBoxBirthPlace";
            this.comboBoxBirthPlace.Size = new System.Drawing.Size(182, 27);
            this.comboBoxBirthPlace.TabIndex = 26;
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.AcceptsReturn = true;
            this.textBoxMemo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxMemo.BackColor = System.Drawing.Color.White;
            this.textBoxMemo.Location = new System.Drawing.Point(180, 356);
            this.textBoxMemo.Multiline = true;
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMemo.Size = new System.Drawing.Size(387, 187);
            this.textBoxMemo.TabIndex = 25;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.radioButton1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.radioButton2, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(180, 63);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(212, 29);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 3);
            this.radioButton1.Name = "radioButtonGender1";
            this.radioButton1.Size = new System.Drawing.Size(65, 23);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男性";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(127, 3);
            this.radioButton2.Name = "radioButtonGender2";
            this.radioButton2.Size = new System.Drawing.Size(65, 23);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "女性";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(393, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "登録する";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "新規顧客情報を登録します";
            // 
            // NewFile
            // 
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.panel1);
            this.Name = "NewFile";
            this.Text = "新規登録画面";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    /// <summary>
    /// 詳細画面へ遷移
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button1_Click(object sender, EventArgs e)
    {
        {
            TabFile tabfile = new TabFile();
            tabfile.Show();
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        string nameKanjiSei = textBoxKanjiSei.Text;
        string nameKanjiMei = textBoxKanjiMei.Text;
        string nameKanaSei = textBoxKanjiSei.Text;
        string nameKanaMei = textBoxKanaMei.Text;
        DateTime birthday = dateTimePicker1.Value;
        String phoneNumber = textBoxPhoneNumber.Text;
        String emailAddress = textBoxEmailAddress.Text;
        String postalNumber = textBoxpostalNumber.Text;
        String address = textBoxAddress.Text;
        //int job = textBoxAddress.Text;
        //int birthplace = textBoxAddress.Text;
        String hobby = textBoxHobby.Text;
        String memo = textBoxMemo.Text;


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

        //シーケンス取得
        NpgsqlCommand command = null;
        string cmd_str = null;
        DataTable dt = null;
        NpgsqlDataAdapter da = null;

        dt = new DataTable();
        cmd_str = "SELECT nextval('customer_id_seq')";
        command = new NpgsqlCommand(cmd_str, connection);
        da = new NpgsqlDataAdapter(command);
        da.Fill(dt);

        //次の顧客番号を取得
        int customerId = int.Parse(dt.Rows[0][0].ToString());

        //新規顧客情報登録
        sql = "INSERT INTO customer_table(customer_id,sei_kanji,mei_kanji,sei_kana,mei_kana,birthday) VALUES (@customer_id,@sei_kanji,@mei_kanji,@sei_kana,@mei_kana,@birthday)";
        NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);

        ////パラメーター追加
        cmd.Parameters.Add(new NpgsqlParameter("customer_id", NpgsqlDbType.Bigint));
        cmd.Parameters["customer_id"].Value = customerId;
        cmd.Parameters.Add(new NpgsqlParameter("sei_kanji", NpgsqlDbType.Varchar));
        cmd.Parameters["sei_kanji"].Value = nameKanjiSei;
        cmd.Parameters.Add(new NpgsqlParameter("mei_kanji", NpgsqlDbType.Varchar));
        cmd.Parameters["mei_kanji"].Value = nameKanjiMei;
        cmd.Parameters.Add(new NpgsqlParameter("sei_kana", NpgsqlDbType.Varchar));
        cmd.Parameters["sei_kana"].Value = nameKanaSei;
        cmd.Parameters.Add(new NpgsqlParameter("mei_kana", NpgsqlDbType.Varchar));
        cmd.Parameters["mei_kana"].Value = nameKanaMei;
        cmd.Parameters.Add(new NpgsqlParameter("birthday", NpgsqlDbType.Date));
        cmd.Parameters["birthday"].Value = birthday;

        //SQL実行
        NpgsqlDataReader dr = cmd.ExecuteReader();

        Console.WriteLine("接続解除");
        connection.Close();

    }
}