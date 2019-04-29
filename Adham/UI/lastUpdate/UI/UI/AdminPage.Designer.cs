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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEraseFlight = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtDYear = new System.Windows.Forms.TextBox();
            this.txtDMonth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDDay = new System.Windows.Forms.TextBox();
            this.txtAircraftID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.listVFlights = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericSeats = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(3, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(437, 427);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEraseFlight);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.cboSearch);
            this.tabPage1.Controls.Add(this.chkUpdate);
            this.tabPage1.Controls.Add(this.btnAddFlight);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtSearchBar);
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
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(347, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 22);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(9, 6);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(95, 21);
            this.cboSearch.TabIndex = 14;
            this.cboSearch.Text = "Search With";
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Location = new System.Drawing.Point(352, 342);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(61, 17);
            this.chkUpdate.TabIndex = 13;
            this.chkUpdate.Text = "Update";
            this.chkUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Location = new System.Drawing.Point(348, 365);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(75, 28);
            this.btnAddFlight.TabIndex = 12;
            this.btnAddFlight.Text = "Add";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericSeats);
            this.groupBox1.Controls.Add(this.txtDistination);
            this.groupBox1.Controls.Add(this.txtAYear);
            this.groupBox1.Controls.Add(this.txtAMonth);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtADay);
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Controls.Add(this.lblFlightID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDYear);
            this.groupBox1.Controls.Add(this.txtDMonth);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDDay);
            this.groupBox1.Controls.Add(this.txtAircraftID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(10, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 116);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // 
            // txtAMonth
            // 
            this.txtAMonth.Location = new System.Drawing.Point(266, 88);
            this.txtAMonth.MaxLength = 2;
            this.txtAMonth.Name = "txtAMonth";
            this.txtAMonth.Size = new System.Drawing.Size(22, 20);
            this.txtAMonth.TabIndex = 17;
            this.txtAMonth.Text = "MM";
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
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Flight ID : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Aircraft ID : ";
            // 
            // txtDDay
            // 
            this.txtDDay.Location = new System.Drawing.Point(72, 88);
            this.txtDDay.MaxLength = 2;
            this.txtDDay.Name = "txtDDay";
            this.txtDDay.Size = new System.Drawing.Size(21, 20);
            this.txtDDay.TabIndex = 8;
            this.txtDDay.Text = "DD";
            // 
            // txtAircraftID
            // 
            this.txtAircraftID.Location = new System.Drawing.Point(72, 36);
            this.txtAircraftID.Name = "txtAircraftID";
            this.txtAircraftID.Size = new System.Drawing.Size(88, 20);
            this.txtAircraftID.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "DepartTime :";
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(109, 6);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(237, 20);
            this.txtSearchBar.TabIndex = 2;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(429, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aircrafts";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "bind name";
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
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "bind ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericSeats
            // 
            this.numericSeats.Location = new System.Drawing.Point(254, 37);
            this.numericSeats.Name = "numericSeats";
            this.numericSeats.Size = new System.Drawing.Size(73, 20);
            this.numericSeats.TabIndex = 22;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 460);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listVFlights;
        private System.Windows.Forms.Label lblFlightID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.TextBox txtDYear;
        private System.Windows.Forms.TextBox txtDMonth;
        private System.Windows.Forms.TextBox txtDDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAircraftID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAYear;
        private System.Windows.Forms.TextBox txtAMonth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtADay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.TextBox txtDistination;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEraseFlight;
        private System.Windows.Forms.NumericUpDown numericSeats;
    }
}