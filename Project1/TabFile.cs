using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

class TabFile : Form
{
    private Button[] bt = new Button[6];
    private Timer timer1;
    private System.ComponentModel.IContainer components;
    private ErrorProvider errorProvider1;
    private ImageList imageList1;
    private System.IO.FileSystemWatcher fileSystemWatcher1;
    private BindingSource bindingSource1;
    private ColorDialog colorDialog1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private Panel panel1;
    private TabControl tabControl1;
    internal TabPage tabPage1;
    private Panel panel2;
    private Label label1;
    private TabPage tabPage2;
    private DataGridView dataGridView_purchaseinfo;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage5;
    private TabPage tabPage6;
    private TabPage tabPage7;
    private CheckBox checkBox1;
    private BindingNavigator bindingNavigator1;
    private ToolStripButton bindingNavigatorAddNewItem;
    private ToolStripLabel bindingNavigatorCountItem;
    private ToolStripButton bindingNavigatorDeleteItem;
    private ToolStripButton bindingNavigatorMoveFirstItem;
    private ToolStripButton bindingNavigatorMovePreviousItem;
    private ToolStripSeparator bindingNavigatorSeparator;
    private ToolStripTextBox bindingNavigatorPositionItem;
    private ToolStripSeparator bindingNavigatorSeparator1;
    private ToolStripButton bindingNavigatorMoveNextItem;
    private ToolStripButton bindingNavigatorMoveLastItem;
    private ToolStripSeparator bindingNavigatorSeparator2;
    private FlowLayoutPanel flowLayoutPanel1;
    private TextBox textBox1;
    private TextBox textBox2;
    private TableLayoutPanel tableLayoutPanel1;
    private ComboBox comboBoxJob;
    private TextBox textBoxAddress;
    private TextBox textBoxPostalNumber;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private TableLayoutPanel tableLayoutPanel2;
    private TextBox textBoxKanjiSei;
    private TextBox textBoxKanjiMei;
    private DateTimePicker dateTimePicker1;
    private TableLayoutPanel tableLayoutPanel3;
    private TextBox textBoxKanaMei;
    private TextBox textBoxKanaSei;
    private Label label2;
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
    private TableLayoutPanel tableLayoutPanel4;
    private RadioButton radioButtonMan;
    private RadioButton radioButtonWoman;
    private ComboBox comboBoxBirthPlace;
    private Button edit_button;
    private DataGridViewButtonColumn purchase_detail_button;
    private TableLayoutPanel tableLayoutPanel5;
    private Label label14;
    private Label label16;
    private Label label18;
    private Label label17;
    private Label label21;
    private DateTimePicker dateTimePicker2;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private FlowLayoutPanel flowLayoutPanel3;
    private RadioButton radioButton3;
    private RadioButton radioButton4;
    private RadioButton radioButton5;
    private RadioButton radioButton6;
    private RadioButton radioButton7;
    private RadioButton radioButton8;
    private ComboBox comboBox1;
    private TextBox textBox3;
    private TableLayoutPanel tableLayoutPanel6;
    private TextBox textBox5;
    private Label label22;
    private ComboBox comboBox3;
    private Label label20;
    private Label label15;
    private ComboBox comboBox2;
    private TextBox textBox4;
    private Label label19;
    private RadioButton radioButton9;
    private RadioButton radioButton10;
    private int customerId;

    public TabFile(DataTable customerData, DataTable dt_purchase)
    {
        this.Text = "detail screen";
        this.Width = 3000;
        this.Height = 1600;

        InitializeComponent();

        comboBoxJob_set();
        comboBoxBirthPlace_set();

        DataTable dt = new DataTable();
        dt = customerData;

        customerId = int.Parse(dt.Rows[0][0].ToString());
        textBoxKanjiSei.Text = (string)dt.Rows[0][1];
        textBoxKanjiMei.Text = (string)dt.Rows[0][2];
        textBoxKanaSei.Text = (string)dt.Rows[0][3];
        textBoxKanaMei.Text = (string)dt.Rows[0][4];
        dateTimePicker1.Value = (DateTime)dt.Rows[0][6];
        if (!dt.Rows[0][7].Equals(DBNull.Value))
        {
            textBoxPostalNumber.Text = dt.Rows[0][7].ToString();
        }
        if (!dt.Rows[0][8].Equals(DBNull.Value))
        {
            textBoxAddress.Text = (string)dt.Rows[0][8];
        }
        if (!dt.Rows[0][9].Equals(DBNull.Value))
        {
            textBoxPhoneNumber.Text = (string)dt.Rows[0][9];
        }
        if (!dt.Rows[0][10].Equals(DBNull.Value))
        {
            textBoxEmailAddress.Text = (string)dt.Rows[0][10];
        }
        if (!dt.Rows[0][13].Equals(DBNull.Value))
        {
            textBoxHobby.Text = (string)dt.Rows[0][13];
        }
        if (!dt.Rows[0][14].Equals(DBNull.Value))
        {
            textBoxMemo.Text = (string)dt.Rows[0][14];
        }
        if (!dt.Rows[0][11].Equals(DBNull.Value))
        {
            comboBoxJob.SelectedIndex = int.Parse(dt.Rows[0][11].ToString()) - 1;
        }
        if (!dt.Rows[0][12].Equals(DBNull.Value))
        {
            comboBoxBirthPlace.SelectedIndex = int.Parse(dt.Rows[0][12].ToString()) - 1;
        }
        if (!dt.Rows[0][5].Equals(DBNull.Value))
        {
            if (int.Parse(dt.Rows[0][5].ToString()) == 1)
            {
                radioButtonMan.Checked = true;
            }
            else
            {
                radioButtonWoman.Checked = true;
            }
        }

        dataGridView_purchaseinfo.DataSource = dt_purchase;

        dt_purchase.Columns["purchase_id"].ColumnName = "顧客ID";
        dt_purchase.Columns["customer_id"].ColumnName = "名前（姓）";
        dt_purchase.Columns["amount"].ColumnName = "単価";
        dt_purchase.Columns["manager"].ColumnName = "担当者";
        dt_purchase.Columns["payment"].ColumnName = "支払方法";
        dt_purchase.Columns["purchase_date"].ColumnName = "購入日";
    }


    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabFile));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.edit_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxJob = new System.Windows.Forms.ComboBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPostalNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxKanjiSei = new System.Windows.Forms.TextBox();
            this.textBoxKanjiMei = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxKanaMei = new System.Windows.Forms.TextBox();
            this.textBoxKanaSei = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxHobby = new System.Windows.Forms.TextBox();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.comboBoxBirthPlace = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_purchaseinfo = new System.Windows.Forms.DataGridView();
            this.purchase_detail_button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_purchaseinfo)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // edit_button
            // 
            this.edit_button.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edit_button.Location = new System.Drawing.Point(1312, 644);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(106, 59);
            this.edit_button.TabIndex = 14;
            this.edit_button.Text = "編集する\r\n";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl1.Location = new System.Drawing.Point(3, 28);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1466, 762);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FloralWhite;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1458, 736);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "顧客基本情報";
            this.tabPage1.ToolTipText = "顧客の基本情報を表示します。";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.edit_button);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(1502, 843);
            this.panel2.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxJob, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAddress, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPostalNumber, 0, 4);
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
            this.tableLayoutPanel1.Controls.Add(this.textBoxEmailAddress, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPhoneNumber, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHobby, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMemo, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxBirthPlace, 0, 9);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("BIZ UDPゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 34);
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
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // comboBoxJob
            // 
            this.comboBoxJob.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxJob.DisplayMember = "job_name";
            this.comboBoxJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJob.FormattingEnabled = true;
            this.comboBoxJob.Location = new System.Drawing.Point(180, 258);
            this.comboBoxJob.Name = "comboBoxJob";
            this.comboBoxJob.Size = new System.Drawing.Size(351, 27);
            this.comboBoxJob.TabIndex = 11;
            this.comboBoxJob.ValueMember = "job_name";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxAddress.Location = new System.Drawing.Point(180, 162);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxAddress.Size = new System.Drawing.Size(353, 26);
            this.textBoxAddress.TabIndex = 8;
            // 
            // textBoxPostalNumber
            // 
            this.textBoxPostalNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxPostalNumber.Location = new System.Drawing.Point(180, 130);
            this.textBoxPostalNumber.Name = "textBoxPostalNumber";
            this.textBoxPostalNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPostalNumber.Size = new System.Drawing.Size(351, 26);
            this.textBoxPostalNumber.TabIndex = 7;
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
            this.tableLayoutPanel2.Controls.Add(this.textBoxKanjiSei, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxKanjiMei, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(180, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 24);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // textBoxKanjiSei
            // 
            this.textBoxKanjiSei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxKanjiSei.Location = new System.Drawing.Point(10, 3);
            this.textBoxKanjiSei.Name = "textBoxKanjiSei";
            this.textBoxKanjiSei.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxKanjiSei.Size = new System.Drawing.Size(162, 26);
            this.textBoxKanjiSei.TabIndex = 0;
            // 
            // textBoxKanjiMei
            // 
            this.textBoxKanjiMei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxKanjiMei.Location = new System.Drawing.Point(191, 3);
            this.textBoxKanjiMei.Name = "textBoxKanjiMei";
            this.textBoxKanjiMei.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxKanjiMei.Size = new System.Drawing.Size(162, 26);
            this.textBoxKanjiMei.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxKanaMei, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxKanaSei, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(180, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(360, 24);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // textBoxKanaMei
            // 
            this.textBoxKanaMei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxKanaMei.Location = new System.Drawing.Point(189, 3);
            this.textBoxKanaMei.Name = "textBoxKanaMei";
            this.textBoxKanaMei.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxKanaMei.Size = new System.Drawing.Size(162, 26);
            this.textBoxKanaMei.TabIndex = 3;
            // 
            // textBoxKanaSei
            // 
            this.textBoxKanaSei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxKanaSei.Location = new System.Drawing.Point(9, 3);
            this.textBoxKanaSei.Name = "textBoxKanaSei";
            this.textBoxKanaSei.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxKanaSei.Size = new System.Drawing.Size(162, 26);
            this.textBoxKanaSei.TabIndex = 2;
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
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxEmailAddress.Location = new System.Drawing.Point(180, 226);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxEmailAddress.Size = new System.Drawing.Size(353, 26);
            this.textBoxEmailAddress.TabIndex = 10;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(180, 194);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(351, 26);
            this.textBoxPhoneNumber.TabIndex = 9;
            // 
            // textBoxHobby
            // 
            this.textBoxHobby.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxHobby.Location = new System.Drawing.Point(180, 324);
            this.textBoxHobby.Name = "textBoxHobby";
            this.textBoxHobby.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxHobby.Size = new System.Drawing.Size(353, 26);
            this.textBoxHobby.TabIndex = 13;
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.AcceptsReturn = true;
            this.textBoxMemo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxMemo.BackColor = System.Drawing.Color.White;
            this.textBoxMemo.Location = new System.Drawing.Point(180, 356);
            this.textBoxMemo.Multiline = true;
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMemo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMemo.Size = new System.Drawing.Size(387, 187);
            this.textBoxMemo.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.radioButtonMan, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.radioButtonWoman, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(180, 63);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(212, 29);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(21, 3);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(65, 23);
            this.radioButtonMan.TabIndex = 5;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "男性";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(127, 3);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(65, 23);
            this.radioButtonWoman.TabIndex = 6;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "女性";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // comboBoxBirthPlace
            // 
            this.comboBoxBirthPlace.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxBirthPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBirthPlace.FormattingEnabled = true;
            this.comboBoxBirthPlace.Location = new System.Drawing.Point(180, 291);
            this.comboBoxBirthPlace.Name = "comboBoxBirthPlace";
            this.comboBoxBirthPlace.Size = new System.Drawing.Size(351, 27);
            this.comboBoxBirthPlace.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BIZ UDPゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(8, 2);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(260, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "顧客情報を修正してください。";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_purchaseinfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1458, 736);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "購入履歴";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_purchaseinfo
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataGridView_purchaseinfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_purchaseinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_purchaseinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_purchaseinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchase_detail_button});
            this.dataGridView_purchaseinfo.Location = new System.Drawing.Point(26, 34);
            this.dataGridView_purchaseinfo.Name = "dataGridView_purchaseinfo";
            this.dataGridView_purchaseinfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_purchaseinfo.RowTemplate.Height = 21;
            this.dataGridView_purchaseinfo.Size = new System.Drawing.Size(818, 466);
            this.dataGridView_purchaseinfo.TabIndex = 0;
            this.dataGridView_purchaseinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_purchaseinfo_CellContentClick);
            // 
            // purchase_detail_button
            // 
            this.purchase_detail_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.purchase_detail_button.HeaderText = "";
            this.purchase_detail_button.Name = "purchase_detail_button";
            this.purchase_detail_button.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.purchase_detail_button.Text = "詳細";
            this.purchase_detail_button.ToolTipText = "購買履歴詳細を表示します。";
            this.purchase_detail_button.UseColumnTextForButtonValue = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel6);
            this.tabPage3.Controls.Add(this.tableLayoutPanel5);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1458, 736);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "購入履歴登録";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1458, 736);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1458, 736);
            this.tabPage5.TabIndex = 18;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1458, 736);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.checkBox1);
            this.tabPage7.Controls.Add(this.bindingNavigator1);
            this.tabPage7.Controls.Add(this.flowLayoutPanel1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1458, 736);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(695, 235);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1452, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(45, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(195, 88);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 19);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 19);
            this.textBox2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1472, 809);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.84633F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.15368F));
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label16, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label18, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label17, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.comboBox1, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.textBox3, 0, 3);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(28, 57);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(604, 206);
            this.tableLayoutPanel5.TabIndex = 0;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "購入日";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "支払方法";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "注文合計金額";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "担当者";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label21.Location = new System.Drawing.Point(15, 16);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(173, 16);
            this.label21.TabIndex = 7;
            this.label21.Text = "購入履歴を追加します。";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker2.Location = new System.Drawing.Point(119, 16);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(147, 19);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "現金";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(56, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "クレジットカード";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.radioButton1);
            this.flowLayoutPanel3.Controls.Add(this.radioButton2);
            this.flowLayoutPanel3.Controls.Add(this.radioButton3);
            this.flowLayoutPanel3.Controls.Add(this.radioButton4);
            this.flowLayoutPanel3.Controls.Add(this.radioButton5);
            this.flowLayoutPanel3.Controls.Add(this.radioButton6);
            this.flowLayoutPanel3.Controls.Add(this.radioButton7);
            this.flowLayoutPanel3.Controls.Add(this.radioButton8);
            this.flowLayoutPanel3.Controls.Add(this.radioButton9);
            this.flowLayoutPanel3.Controls.Add(this.radioButton10);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(126, 54);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel3.Size = new System.Drawing.Size(475, 45);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(168, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 16);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "QUICPay";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(257, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 16);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "PayPay";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(334, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(68, 16);
            this.radioButton5.TabIndex = 10;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "楽天ペイ";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(3, 25);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(70, 16);
            this.radioButton6.TabIndex = 11;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "au PAY";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(79, 25);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(81, 16);
            this.radioButton7.TabIndex = 12;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "LINE Pay";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(166, 25);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(78, 16);
            this.radioButton8.TabIndex = 13;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "FamiPay";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox3.Location = new System.Drawing.Point(119, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 19);
            this.textBox3.TabIndex = 10;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 8;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel6.Controls.Add(this.textBox5, 7, 0);
            this.tableLayoutPanel6.Controls.Add(this.label22, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.comboBox3, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label20, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label15, 6, 0);
            this.tableLayoutPanel6.Controls.Add(this.comboBox2, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBox4, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.label19, 4, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(28, 269);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(966, 48);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(728, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "合計金額";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(538, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 9;
            this.label19.Text = "個数";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(598, 14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 20);
            this.comboBox2.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(413, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 19);
            this.textBox4.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(335, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 10;
            this.label20.Text = "単価";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(128, 14);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(160, 20);
            this.comboBox3.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(30, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 12;
            this.label22.Text = "購入内容";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(840, 14);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(89, 19);
            this.textBox5.TabIndex = 12;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(250, 25);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(59, 16);
            this.radioButton9.TabIndex = 14;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "後払い";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(315, 25);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(58, 16);
            this.radioButton10.TabIndex = 15;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "その他";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // TabFile
            // 
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.panel1);
            this.Name = "TabFile";
            this.Text = "顧客情報詳細画面";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_purchaseinfo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

    }

    private void comboBoxJob_set()
    {
        //DB接続
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

        NpgsqlCommand command = null;
        string cmd_str = null;
        DataTable dt = null;
        NpgsqlDataAdapter da = null;

        dt = new DataTable();
        cmd_str = "SELECT job_id,job_name FROM m_job";
        command = new NpgsqlCommand(cmd_str, connection);
        da = new NpgsqlDataAdapter(command);
        da.Fill(dt);

        connection.Close();

        comboBoxJob.DataSource = dt;
        ////コンボボックスに表示させる内容を設定
        comboBoxJob.DisplayMember = "job_name";
    }

    private void comboBoxBirthPlace_set()
    {
        //DB接続
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

        NpgsqlCommand command = null;
        string cmd_str = null;
        DataTable dt = null;
        NpgsqlDataAdapter da = null;

        dt = new DataTable();
        cmd_str = "SELECT prefecture_id,prefecture_name FROM m_prefecture ORDER BY prefecture_id";
        command = new NpgsqlCommand(cmd_str, connection);
        da = new NpgsqlDataAdapter(command);
        da.Fill(dt);

        connection.Close();

        comboBoxBirthPlace.DataSource = dt;
        ////コンボボックスに表示させる内容を設定
        comboBoxBirthPlace.DisplayMember = "prefecture_name";

    }

    private void edit_button_Click(object sender, EventArgs e)
    {
        try
        {
            //入力された値を取得
            string nameKanjiSei = textBoxKanjiSei.Text;
            string nameKanjiMei = textBoxKanjiMei.Text;
            string nameKanaSei = textBoxKanaSei.Text;
            string nameKanaMei = textBoxKanaMei.Text;
            DateTime birthday = dateTimePicker1.Value;
            string phoneNumber = textBoxPhoneNumber.Text;
            string emailAddress = textBoxEmailAddress.Text;
            string address = textBoxAddress.Text;
            int job = comboBoxJob.SelectedIndex + 1;
            int birthplace = comboBoxBirthPlace.SelectedIndex + 1;
            string hobby = textBoxHobby.Text;
            string memo = textBoxMemo.Text;

            //性別
            int gender = 0;
            if (radioButtonMan.Checked == true)
            {
                gender = 1;
            }
            else if (radioButtonWoman.Checked == true)
            {
                gender = 2;
            }


            //入力チェック
            if (nameKanjiSei == "")
            {
                //アラート表示
                MessageBox.Show("お名前(姓)を入力してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            if (nameKanjiMei == "")
            {
                //アラート表示
                MessageBox.Show("お名前(名)を入力してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            if (nameKanaSei == "")
            {
                //アラート表示
                MessageBox.Show("フリガナ(姓)を入力してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            if (nameKanaMei == "")
            {
                //アラート表示
                MessageBox.Show("フリガナ(名)を入力してください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            // 郵便番号
            int postalNumber = 0;
            if (textBoxPostalNumber.Text != "")
            {
                if (isHanSu(textBoxPostalNumber.Text))
                {
                    postalNumber = int.Parse(textBoxPostalNumber.Text);
                } else
                {
                    MessageBox.Show("郵便番号は半角数字で入力してください。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
            }

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

            //顧客情報修正
            sql = "UPDATE customer_table SET ";
            sql += "sei_kanji = @sei_kanji,";
            sql += "mei_kanji = @mei_kanji,";
            sql += "sei_kana = @sei_kana,";
            sql += "mei_kana = @mei_kana,";
            sql += "gender = @gender,";
            sql += "birthday = @birthday,";
            sql += "postal_number = @postal_number,";
            sql += "address = @address,";
            sql += "phone_number = @phone_number,";
            sql += "email_Address = @email_Address,";
            sql += "job = @job,";
            sql += "birthplace = @birthplace,";
            sql += "hobby = @hobby,";
            sql += "memo = @memo ";
            sql += "WHERE customer_id = @customer_id";
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
            cmd.Parameters.Add(new NpgsqlParameter("gender", NpgsqlDbType.Smallint));
            cmd.Parameters["gender"].Value = gender;
            cmd.Parameters.Add(new NpgsqlParameter("birthday", NpgsqlDbType.Date));
            cmd.Parameters["birthday"].Value = birthday;
            cmd.Parameters.Add(new NpgsqlParameter("postal_number", NpgsqlDbType.Integer));
            cmd.Parameters["postal_number"].Value = postalNumber;
            cmd.Parameters.Add(new NpgsqlParameter("address", NpgsqlDbType.Varchar));
            cmd.Parameters["address"].Value = address;
            cmd.Parameters.Add(new NpgsqlParameter("phone_number", NpgsqlDbType.Varchar));
            cmd.Parameters["phone_number"].Value = phoneNumber;
            cmd.Parameters.Add(new NpgsqlParameter("email_Address", NpgsqlDbType.Varchar));
            cmd.Parameters["email_Address"].Value = emailAddress;
            cmd.Parameters.Add(new NpgsqlParameter("job", NpgsqlDbType.Smallint));
            cmd.Parameters["job"].Value = job;
            cmd.Parameters.Add(new NpgsqlParameter("birthplace", NpgsqlDbType.Smallint));
            cmd.Parameters["birthplace"].Value = birthplace;
            cmd.Parameters.Add(new NpgsqlParameter("hobby", NpgsqlDbType.Varchar));
            cmd.Parameters["hobby"].Value = hobby;
            cmd.Parameters.Add(new NpgsqlParameter("memo", NpgsqlDbType.Text));
            cmd.Parameters["memo"].Value = memo;

            //SQL実行     
            NpgsqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("接続解除");
            connection.Close();

            //編集処理完了
            MessageBox.Show("編集処理が完了しました。",
            "正常",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            //例外処理時
            MessageBox.Show("登録処理に失敗しました。",
            "エラー",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
            return;
        }
    }

    /// <summary>
    /// 半角数字チェック
    /// </summary>
    /// <param name="val">対象文字列</param>
    /// <returns>true:半角数字のみ　false:半角数字以外を含む</returns>
    public static bool isHanSu(string val)
    {
        // nullの場合はfalseを返す
        if (val == null)
        {
            return false;
        }

        // 半角英数チェック
        return Regex.IsMatch(val, @"^[0-9]+$");
    }

    private void dataGridView_purchaseinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
    {

    }

    private void tabPage3_Click(object sender, EventArgs e)
    {

    }
}