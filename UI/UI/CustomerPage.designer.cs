namespace UI
{
    partial class CustomerPage
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
            this.tabCustomerhandler = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericInfant = new System.Windows.Forms.DomainUpDown();
            this.numericChild = new System.Windows.Forms.DomainUpDown();
            this.numericAdult = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.listVFlights = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listVMyFlights = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMyNewPassword = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.txtMyOldPassword = new System.Windows.Forms.TextBox();
            this.txtMyUsername = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMyLastName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMyFirstName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabCustomerhandler.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCustomerhandler
            // 
            this.tabCustomerhandler.Controls.Add(this.tabPage1);
            this.tabCustomerhandler.Controls.Add(this.tabPage2);
            this.tabCustomerhandler.Controls.Add(this.tabPage3);
            this.tabCustomerhandler.Location = new System.Drawing.Point(3, 12);
            this.tabCustomerhandler.Name = "tabCustomerhandler";
            this.tabCustomerhandler.SelectedIndex = 0;
            this.tabCustomerhandler.Size = new System.Drawing.Size(439, 447);
            this.tabCustomerhandler.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(431, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book Flight";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericInfant);
            this.groupBox2.Controls.Add(this.numericChild);
            this.groupBox2.Controls.Add(this.numericAdult);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboClass);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnBookFlight);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 145);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book your Flight";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(76, 107);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(53, 13);
            this.lblTotalPrice.TabIndex = 18;
            this.lblTotalPrice.Text = "bind price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total Price :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Class :";
            // 
            // numericInfant
            // 
            this.numericInfant.Location = new System.Drawing.Point(336, 20);
            this.numericInfant.Name = "numericInfant";
            this.numericInfant.Size = new System.Drawing.Size(75, 20);
            this.numericInfant.TabIndex = 15;
            this.numericInfant.Text = "0";
            // 
            // numericChild
            // 
            this.numericChild.Location = new System.Drawing.Point(206, 20);
            this.numericChild.Name = "numericChild";
            this.numericChild.Size = new System.Drawing.Size(74, 20);
            this.numericChild.TabIndex = 14;
            this.numericChild.Text = "0";
            // 
            // numericAdult
            // 
            this.numericAdult.Location = new System.Drawing.Point(60, 20);
            this.numericAdult.Name = "numericAdult";
            this.numericAdult.Size = new System.Drawing.Size(77, 20);
            this.numericAdult.TabIndex = 13;
            this.numericAdult.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "under 2 years";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "above 11 years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "2 : 11 years";
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(60, 71);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(351, 21);
            this.cboClass.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Infant(s) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Child(ren) :";
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.Location = new System.Drawing.Point(335, 102);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(75, 23);
            this.btnBookFlight.TabIndex = 1;
            this.btnBookFlight.Text = "Book";
            this.btnBookFlight.UseVisualStyleBackColor = true;
            this.btnBookFlight.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adult(s) :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cboSearch);
            this.groupBox1.Controls.Add(this.txtSearchBar);
            this.groupBox1.Controls.Add(this.listVFlights);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Flights";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(336, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 22);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(6, 15);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(90, 21);
            this.cboSearch.TabIndex = 18;
            this.cboSearch.Text = "Search by";
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(97, 15);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(237, 20);
            this.txtSearchBar.TabIndex = 17;
            // 
            // listVFlights
            // 
            this.listVFlights.Location = new System.Drawing.Point(6, 40);
            this.listVFlights.Name = "listVFlights";
            this.listVFlights.Size = new System.Drawing.Size(405, 237);
            this.listVFlights.TabIndex = 16;
            this.listVFlights.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listVMyFlights);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(431, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Flights";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listVMyFlights
            // 
            this.listVMyFlights.Location = new System.Drawing.Point(4, 4);
            this.listVMyFlights.Name = "listVMyFlights";
            this.listVMyFlights.Size = new System.Drawing.Size(424, 414);
            this.listVMyFlights.TabIndex = 0;
            this.listVMyFlights.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(431, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.txtMyNewPassword);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.btnSaveInfo);
            this.groupBox3.Controls.Add(this.txtMyOldPassword);
            this.groupBox3.Controls.Add(this.txtMyUsername);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtMyLastName);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtMyFirstName);
            this.groupBox3.Location = new System.Drawing.Point(5, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 181);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "My Info";
            // 
            // txtMyNewPassword
            // 
            this.txtMyNewPassword.Location = new System.Drawing.Point(282, 82);
            this.txtMyNewPassword.Name = "txtMyNewPassword";
            this.txtMyNewPassword.Size = new System.Drawing.Size(120, 20);
            this.txtMyNewPassword.TabIndex = 26;
            this.txtMyNewPassword.UseSystemPasswordChar = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(199, 85);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "New Password :";
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Location = new System.Drawing.Point(119, 142);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(164, 23);
            this.btnSaveInfo.TabIndex = 24;
            this.btnSaveInfo.Text = "Save Info";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            // 
            // txtMyOldPassword
            // 
            this.txtMyOldPassword.Location = new System.Drawing.Point(282, 52);
            this.txtMyOldPassword.Name = "txtMyOldPassword";
            this.txtMyOldPassword.Size = new System.Drawing.Size(120, 20);
            this.txtMyOldPassword.TabIndex = 23;
            this.txtMyOldPassword.UseSystemPasswordChar = true;
            // 
            // txtMyUsername
            // 
            this.txtMyUsername.Location = new System.Drawing.Point(76, 52);
            this.txtMyUsername.Name = "txtMyUsername";
            this.txtMyUsername.Size = new System.Drawing.Size(120, 20);
            this.txtMyUsername.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(202, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Old Password :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Username :";
            // 
            // txtMyLastName
            // 
            this.txtMyLastName.Location = new System.Drawing.Point(282, 22);
            this.txtMyLastName.Name = "txtMyLastName";
            this.txtMyLastName.Size = new System.Drawing.Size(120, 20);
            this.txtMyLastName.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(202, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Last Name :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "First Name : ";
            // 
            // txtMyFirstName
            // 
            this.txtMyFirstName.Location = new System.Drawing.Point(76, 22);
            this.txtMyFirstName.Name = "txtMyFirstName";
            this.txtMyFirstName.Size = new System.Drawing.Size(120, 20);
            this.txtMyFirstName.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nationality : ";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Birth Date :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 31;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(202, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Passport :";
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 460);
            this.Controls.Add(this.tabCustomerhandler);
            this.Name = "CustomerPage";
            this.Text = "CustomerPage";
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            this.tabCustomerhandler.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCustomerhandler;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown numericInfant;
        private System.Windows.Forms.DomainUpDown numericChild;
        private System.Windows.Forms.DomainUpDown numericAdult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.ListView listVFlights;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listVMyFlights;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMyNewPassword;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.TextBox txtMyOldPassword;
        private System.Windows.Forms.TextBox txtMyUsername;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMyLastName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtMyFirstName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}