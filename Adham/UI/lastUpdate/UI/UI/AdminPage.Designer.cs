namespace UI
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ACtab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEraseFlight = new System.Windows.Forms.Button();
            this.btnSearchF = new System.Windows.Forms.Button();
            this.cboSearchF = new System.Windows.Forms.ComboBox();
            this.chkUpdateF = new System.Windows.Forms.CheckBox();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.gbxF = new System.Windows.Forms.GroupBox();
            this.numericSeats = new System.Windows.Forms.NumericUpDown();
            this.txtDistination = new System.Windows.Forms.TextBox();
            this.txtAYear = new System.Windows.Forms.TextBox();
            this.txtAMonth = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtADay = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblFlightID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtDYear = new System.Windows.Forms.TextBox();
            this.txtDMonth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDDay = new System.Windows.Forms.TextBox();
            this.txtAircraftID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchBarF = new System.Windows.Forms.TextBox();
            this.listVFlights = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btneraseAC = new System.Windows.Forms.Button();
            this.chckUpdateAC = new System.Windows.Forms.CheckBox();
            this.btnAddAC = new System.Windows.Forms.Button();
            this.cbosearchAC = new System.Windows.Forms.ComboBox();
            this.btnsearchAC = new System.Windows.Forms.Button();
            this.gbxAC = new System.Windows.Forms.GroupBox();
            this.txtPIDAC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdminAC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtAdminIDAC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblACID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtsearchAC = new System.Windows.Forms.TextBox();
            this.listVAC = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbluserAdmin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIDAdmin = new System.Windows.Forms.Label();
            this.btnBackAdmin = new System.Windows.Forms.Button();
            this.ACtab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeats)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbxAC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ACtab
            // 
            this.ACtab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ACtab.Controls.Add(this.tabPage1);
            this.ACtab.Controls.Add(this.tabPage2);
            this.ACtab.Controls.Add(this.tabPage3);
            this.ACtab.Controls.Add(this.tabPage4);
            this.ACtab.Controls.Add(this.tabPage5);
            this.ACtab.Controls.Add(this.tabPage6);
            this.ACtab.Location = new System.Drawing.Point(3, 33);
            this.ACtab.Name = "ACtab";
            this.ACtab.SelectedIndex = 0;
            this.ACtab.Size = new System.Drawing.Size(437, 427);
            this.ACtab.TabIndex = 0;
            this.ACtab.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEraseFlight);
            this.tabPage1.Controls.Add(this.btnSearchF);
            this.tabPage1.Controls.Add(this.cboSearchF);
            this.tabPage1.Controls.Add(this.chkUpdateF);
            this.tabPage1.Controls.Add(this.btnAddFlight);
            this.tabPage1.Controls.Add(this.gbxF);
            this.tabPage1.Controls.Add(this.txtSearchBarF);
            this.tabPage1.Controls.Add(this.listVFlights);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(429, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Flights";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnEraseFlight
            // 
            this.btnEraseFlight.Location = new System.Drawing.Point(347, 285);
            this.btnEraseFlight.Name = "btnEraseFlight";
            this.btnEraseFlight.Size = new System.Drawing.Size(75, 28);
            this.btnEraseFlight.TabIndex = 16;
            this.btnEraseFlight.Text = "Erase";
            this.btnEraseFlight.UseVisualStyleBackColor = true;
            this.btnEraseFlight.Click += new System.EventHandler(this.btnEraseFlight_Click);
            // 
            // btnSearchF
            // 
            this.btnSearchF.Location = new System.Drawing.Point(347, 5);
            this.btnSearchF.Name = "btnSearchF";
            this.btnSearchF.Size = new System.Drawing.Size(75, 22);
            this.btnSearchF.TabIndex = 15;
            this.btnSearchF.Text = "Search";
            this.btnSearchF.UseVisualStyleBackColor = true;
            this.btnSearchF.Click += new System.EventHandler(this.button3_Click);
            // 
            // cboSearchF
            // 
            this.cboSearchF.FormattingEnabled = true;
            this.cboSearchF.Location = new System.Drawing.Point(9, 6);
            this.cboSearchF.Name = "cboSearchF";
            this.cboSearchF.Size = new System.Drawing.Size(95, 21);
            this.cboSearchF.TabIndex = 14;
            this.cboSearchF.Text = "Search by";
            this.cboSearchF.SelectedIndexChanged += new System.EventHandler(this.cboSearch_SelectedIndexChanged);
            // 
            // chkUpdateF
            // 
            this.chkUpdateF.AutoSize = true;
            this.chkUpdateF.Location = new System.Drawing.Point(352, 342);
            this.chkUpdateF.Name = "chkUpdateF";
            this.chkUpdateF.Size = new System.Drawing.Size(61, 17);
            this.chkUpdateF.TabIndex = 13;
            this.chkUpdateF.Text = "Update";
            this.chkUpdateF.UseVisualStyleBackColor = true;
            this.chkUpdateF.CheckedChanged += new System.EventHandler(this.chkUpdate_CheckedChanged);
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Location = new System.Drawing.Point(348, 365);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(75, 28);
            this.btnAddFlight.TabIndex = 12;
            this.btnAddFlight.Text = "Add";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // gbxF
            // 
            this.gbxF.Controls.Add(this.numericSeats);
            this.gbxF.Controls.Add(this.txtDistination);
            this.gbxF.Controls.Add(this.txtAYear);
            this.gbxF.Controls.Add(this.txtAMonth);
            this.gbxF.Controls.Add(this.label14);
            this.gbxF.Controls.Add(this.label12);
            this.gbxF.Controls.Add(this.txtADay);
            this.gbxF.Controls.Add(this.txtSource);
            this.gbxF.Controls.Add(this.lblFlightID);
            this.gbxF.Controls.Add(this.label5);
            this.gbxF.Controls.Add(this.label13);
            this.gbxF.Controls.Add(this.label);
            this.gbxF.Controls.Add(this.txtDYear);
            this.gbxF.Controls.Add(this.txtDMonth);
            this.gbxF.Controls.Add(this.label8);
            this.gbxF.Controls.Add(this.txtDDay);
            this.gbxF.Controls.Add(this.txtAircraftID);
            this.gbxF.Controls.Add(this.label9);
            this.gbxF.Location = new System.Drawing.Point(10, 277);
            this.gbxF.Name = "gbxF";
            this.gbxF.Size = new System.Drawing.Size(336, 116);
            this.gbxF.TabIndex = 11;
            this.gbxF.TabStop = false;
            this.gbxF.Text = "Flight";
            this.gbxF.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericSeats
            // 
            this.numericSeats.Location = new System.Drawing.Point(254, 37);
            this.numericSeats.Name = "numericSeats";
            this.numericSeats.Size = new System.Drawing.Size(73, 20);
            this.numericSeats.TabIndex = 22;
            this.numericSeats.ValueChanged += new System.EventHandler(this.numericSeats_ValueChanged);
            // 
            // txtDistination
            // 
            this.txtDistination.Location = new System.Drawing.Point(239, 62);
            this.txtDistination.Name = "txtDistination";
            this.txtDistination.Size = new System.Drawing.Size(88, 20);
            this.txtDistination.TabIndex = 21;
            this.txtDistination.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // txtAYear
            // 
            this.txtAYear.Location = new System.Drawing.Point(294, 88);
            this.txtAYear.MaxLength = 4;
            this.txtAYear.Name = "txtAYear";
            this.txtAYear.Size = new System.Drawing.Size(33, 20);
            this.txtAYear.TabIndex = 18;
            this.txtAYear.Text = "YYYY";
            this.txtAYear.TextChanged += new System.EventHandler(this.txtAYear_TextChanged);
            // 
            // txtAMonth
            // 
            this.txtAMonth.Location = new System.Drawing.Point(266, 88);
            this.txtAMonth.MaxLength = 2;
            this.txtAMonth.Name = "txtAMonth";
            this.txtAMonth.Size = new System.Drawing.Size(22, 20);
            this.txtAMonth.TabIndex = 17;
            this.txtAMonth.Text = "MM";
            this.txtAMonth.TextChanged += new System.EventHandler(this.txtAMonth_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(174, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Destination :";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(174, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "RequiredSeats :";
            // 
            // txtADay
            // 
            this.txtADay.Location = new System.Drawing.Point(239, 88);
            this.txtADay.MaxLength = 2;
            this.txtADay.Name = "txtADay";
            this.txtADay.Size = new System.Drawing.Size(21, 20);
            this.txtADay.TabIndex = 16;
            this.txtADay.Text = "DD";
            this.txtADay.TextChanged += new System.EventHandler(this.txtADay_TextChanged);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(55, 62);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(105, 20);
            this.txtSource.TabIndex = 19;
            this.txtSource.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // lblFlightID
            // 
            this.lblFlightID.AutoSize = true;
            this.lblFlightID.Location = new System.Drawing.Point(174, 16);
            this.lblFlightID.Name = "lblFlightID";
            this.lblFlightID.Size = new System.Drawing.Size(41, 13);
            this.lblFlightID.TabIndex = 4;
            this.lblFlightID.Text = "bind ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Source :";
            this.label5.Click += new System.EventHandler(this.label10_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(174, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "ArriveTime :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(105, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Flight ID : ";
            this.label.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtDYear
            // 
            this.txtDYear.Location = new System.Drawing.Point(127, 88);
            this.txtDYear.MaxLength = 4;
            this.txtDYear.Name = "txtDYear";
            this.txtDYear.Size = new System.Drawing.Size(33, 20);
            this.txtDYear.TabIndex = 10;
            this.txtDYear.Text = "YYYY";
            this.txtDYear.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtDMonth
            // 
            this.txtDMonth.Location = new System.Drawing.Point(99, 88);
            this.txtDMonth.MaxLength = 2;
            this.txtDMonth.Name = "txtDMonth";
            this.txtDMonth.Size = new System.Drawing.Size(22, 20);
            this.txtDMonth.TabIndex = 9;
            this.txtDMonth.Text = "MM";
            this.txtDMonth.TextChanged += new System.EventHandler(this.txtDMonth_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Aircraft ID : ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtDDay
            // 
            this.txtDDay.Location = new System.Drawing.Point(72, 88);
            this.txtDDay.MaxLength = 2;
            this.txtDDay.Name = "txtDDay";
            this.txtDDay.Size = new System.Drawing.Size(21, 20);
            this.txtDDay.TabIndex = 8;
            this.txtDDay.Text = "DD";
            this.txtDDay.TextChanged += new System.EventHandler(this.txtDDay_TextChanged);
            // 
            // txtAircraftID
            // 
            this.txtAircraftID.Location = new System.Drawing.Point(72, 36);
            this.txtAircraftID.Name = "txtAircraftID";
            this.txtAircraftID.Size = new System.Drawing.Size(88, 20);
            this.txtAircraftID.TabIndex = 6;
            this.txtAircraftID.TextChanged += new System.EventHandler(this.txtAircraftID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "DepartTime :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtSearchBarF
            // 
            this.txtSearchBarF.Location = new System.Drawing.Point(109, 6);
            this.txtSearchBarF.Name = "txtSearchBarF";
            this.txtSearchBarF.Size = new System.Drawing.Size(237, 20);
            this.txtSearchBarF.TabIndex = 2;
            this.txtSearchBarF.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            // 
            // listVFlights
            // 
            this.listVFlights.Location = new System.Drawing.Point(9, 32);
            this.listVFlights.Name = "listVFlights";
            this.listVFlights.Size = new System.Drawing.Size(413, 239);
            this.listVFlights.TabIndex = 0;
            this.listVFlights.UseCompatibleStateImageBehavior = false;
            this.listVFlights.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btneraseAC);
            this.tabPage2.Controls.Add(this.chckUpdateAC);
            this.tabPage2.Controls.Add(this.btnAddAC);
            this.tabPage2.Controls.Add(this.cbosearchAC);
            this.tabPage2.Controls.Add(this.btnsearchAC);
            this.tabPage2.Controls.Add(this.gbxAC);
            this.tabPage2.Controls.Add(this.txtsearchAC);
            this.tabPage2.Controls.Add(this.listVAC);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(429, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aircrafts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btneraseAC
            // 
            this.btneraseAC.Location = new System.Drawing.Point(346, 286);
            this.btneraseAC.Name = "btneraseAC";
            this.btneraseAC.Size = new System.Drawing.Size(75, 28);
            this.btneraseAC.TabIndex = 24;
            this.btneraseAC.Text = "Erase";
            this.btneraseAC.UseVisualStyleBackColor = true;
            // 
            // chckUpdateAC
            // 
            this.chckUpdateAC.AutoSize = true;
            this.chckUpdateAC.Location = new System.Drawing.Point(351, 343);
            this.chckUpdateAC.Name = "chckUpdateAC";
            this.chckUpdateAC.Size = new System.Drawing.Size(61, 17);
            this.chckUpdateAC.TabIndex = 21;
            this.chckUpdateAC.Text = "Update";
            this.chckUpdateAC.UseVisualStyleBackColor = true;
            // 
            // btnAddAC
            // 
            this.btnAddAC.Location = new System.Drawing.Point(347, 366);
            this.btnAddAC.Name = "btnAddAC";
            this.btnAddAC.Size = new System.Drawing.Size(75, 28);
            this.btnAddAC.TabIndex = 20;
            this.btnAddAC.Text = "Add";
            this.btnAddAC.UseVisualStyleBackColor = true;
            // 
            // cbosearchAC
            // 
            this.cbosearchAC.FormattingEnabled = true;
            this.cbosearchAC.Location = new System.Drawing.Point(8, 7);
            this.cbosearchAC.Name = "cbosearchAC";
            this.cbosearchAC.Size = new System.Drawing.Size(95, 21);
            this.cbosearchAC.TabIndex = 22;
            this.cbosearchAC.Text = "Search by";
            // 
            // btnsearchAC
            // 
            this.btnsearchAC.Location = new System.Drawing.Point(346, 6);
            this.btnsearchAC.Name = "btnsearchAC";
            this.btnsearchAC.Size = new System.Drawing.Size(75, 22);
            this.btnsearchAC.TabIndex = 23;
            this.btnsearchAC.Text = "Search";
            this.btnsearchAC.UseVisualStyleBackColor = true;
            // 
            // gbxAC
            // 
            this.gbxAC.Controls.Add(this.txtPIDAC);
            this.gbxAC.Controls.Add(this.label4);
            this.gbxAC.Controls.Add(this.lblAdminAC);
            this.gbxAC.Controls.Add(this.label2);
            this.gbxAC.Controls.Add(this.numericUpDown1);
            this.gbxAC.Controls.Add(this.txtAdminIDAC);
            this.gbxAC.Controls.Add(this.label7);
            this.gbxAC.Controls.Add(this.label19);
            this.gbxAC.Controls.Add(this.textBox2);
            this.gbxAC.Controls.Add(this.lblACID);
            this.gbxAC.Controls.Add(this.label11);
            this.gbxAC.Controls.Add(this.label15);
            this.gbxAC.Location = new System.Drawing.Point(9, 278);
            this.gbxAC.Name = "gbxAC";
            this.gbxAC.Size = new System.Drawing.Size(336, 116);
            this.gbxAC.TabIndex = 19;
            this.gbxAC.TabStop = false;
            this.gbxAC.Text = "Aircraft";
            // 
            // txtPIDAC
            // 
            this.txtPIDAC.Location = new System.Drawing.Point(55, 89);
            this.txtPIDAC.Name = "txtPIDAC";
            this.txtPIDAC.Size = new System.Drawing.Size(105, 20);
            this.txtPIDAC.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Pilot ID :";
            // 
            // lblAdminAC
            // 
            this.lblAdminAC.AutoSize = true;
            this.lblAdminAC.Location = new System.Drawing.Point(240, 92);
            this.lblAdminAC.Name = "lblAdminAC";
            this.lblAdminAC.Size = new System.Drawing.Size(67, 13);
            this.lblAdminAC.TabIndex = 24;
            this.lblAdminAC.Text = "Manged By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Admin Name :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(151, 36);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtAdminIDAC
            // 
            this.txtAdminIDAC.Location = new System.Drawing.Point(239, 62);
            this.txtAdminIDAC.Name = "txtAdminIDAC";
            this.txtAdminIDAC.Size = new System.Drawing.Size(88, 20);
            this.txtAdminIDAC.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Manged By :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Maximum number of seats :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 20);
            this.textBox2.TabIndex = 19;
            // 
            // lblACID
            // 
            this.lblACID.AutoSize = true;
            this.lblACID.Location = new System.Drawing.Point(174, 16);
            this.lblACID.Name = "lblACID";
            this.lblACID.Size = new System.Drawing.Size(41, 13);
            this.lblACID.TabIndex = 4;
            this.lblACID.Text = "bind ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Model :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(105, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Aircraft ID : ";
            // 
            // txtsearchAC
            // 
            this.txtsearchAC.Location = new System.Drawing.Point(108, 7);
            this.txtsearchAC.Name = "txtsearchAC";
            this.txtsearchAC.Size = new System.Drawing.Size(237, 20);
            this.txtsearchAC.TabIndex = 18;
            // 
            // listVAC
            // 
            this.listVAC.Location = new System.Drawing.Point(8, 33);
            this.listVAC.Name = "listVAC";
            this.listVAC.Size = new System.Drawing.Size(413, 239);
            this.listVAC.TabIndex = 17;
            this.listVAC.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(429, 401);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Monitors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(429, 401);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pilots";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(429, 401);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tickets";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(429, 401);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Admins";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbluserAdmin
            // 
            this.lbluserAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbluserAdmin.AutoSize = true;
            this.lbluserAdmin.Location = new System.Drawing.Point(375, 9);
            this.lbluserAdmin.Name = "lbluserAdmin";
            this.lbluserAdmin.Size = new System.Drawing.Size(56, 13);
            this.lbluserAdmin.TabIndex = 2;
            this.lbluserAdmin.Text = "bind name";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Admin ID :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblIDAdmin
            // 
            this.lblIDAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDAdmin.AutoSize = true;
            this.lblIDAdmin.Location = new System.Drawing.Point(375, 33);
            this.lblIDAdmin.Name = "lblIDAdmin";
            this.lblIDAdmin.Size = new System.Drawing.Size(41, 13);
            this.lblIDAdmin.TabIndex = 4;
            this.lblIDAdmin.Text = "bind ID";
            // 
            // btnBackAdmin
            // 
            this.btnBackAdmin.Location = new System.Drawing.Point(3, 4);
            this.btnBackAdmin.Name = "btnBackAdmin";
            this.btnBackAdmin.Size = new System.Drawing.Size(43, 23);
            this.btnBackAdmin.TabIndex = 14;
            this.btnBackAdmin.Text = "Back";
            this.btnBackAdmin.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 460);
            this.Controls.Add(this.btnBackAdmin);
            this.Controls.Add(this.lblIDAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbluserAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ACtab);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.ACtab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxF.ResumeLayout(false);
            this.gbxF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeats)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbxAC.ResumeLayout(false);
            this.gbxAC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ACtab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbluserAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIDAdmin;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnBackAdmin;
        private System.Windows.Forms.ListView listVFlights;
        private System.Windows.Forms.Label lblFlightID;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtSearchBarF;
        private System.Windows.Forms.TextBox txtDYear;
        private System.Windows.Forms.TextBox txtDMonth;
        private System.Windows.Forms.TextBox txtDDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAircraftID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxF;
        private System.Windows.Forms.TextBox txtAYear;
        private System.Windows.Forms.TextBox txtAMonth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtADay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSearchF;
        private System.Windows.Forms.ComboBox cboSearchF;
        private System.Windows.Forms.CheckBox chkUpdateF;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.TextBox txtDistination;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEraseFlight;
        private System.Windows.Forms.NumericUpDown numericSeats;
        private System.Windows.Forms.Button btneraseAC;
        private System.Windows.Forms.CheckBox chckUpdateAC;
        private System.Windows.Forms.Button btnAddAC;
        private System.Windows.Forms.ComboBox cbosearchAC;
        private System.Windows.Forms.Button btnsearchAC;
        private System.Windows.Forms.GroupBox gbxAC;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtAdminIDAC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblACID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtsearchAC;
        private System.Windows.Forms.ListView listVAC;
        private System.Windows.Forms.Label lblAdminAC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPIDAC;
        private System.Windows.Forms.Label label4;
    }
}