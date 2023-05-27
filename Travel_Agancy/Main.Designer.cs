namespace Travel_Agancy
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.MainTabular = new System.Windows.Forms.TabControl();
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.SearchUser = new System.Windows.Forms.Button();
            this.SubmitUser = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Brithdate = new System.Windows.Forms.DateTimePicker();
            this.Lname = new System.Windows.Forms.TextBox();
            this.identifyCode = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.TaavoniTab = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CoName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CoPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SubmitCompany = new System.Windows.Forms.Button();
            this.CompanyGridView = new System.Windows.Forms.DataGridView();
            this.SearchCompany = new System.Windows.Forms.Button();
            this.Drivers = new System.Windows.Forms.TabPage();
            this.CoId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MainTabular.SuspendLayout();
            this.UsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.TaavoniTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabular
            // 
            this.MainTabular.Controls.Add(this.UsersTab);
            this.MainTabular.Controls.Add(this.TaavoniTab);
            this.MainTabular.Controls.Add(this.tabPage1);
            this.MainTabular.Controls.Add(this.Drivers);
            this.MainTabular.Location = new System.Drawing.Point(11, 11);
            this.MainTabular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainTabular.Name = "MainTabular";
            this.MainTabular.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainTabular.RightToLeftLayout = true;
            this.MainTabular.SelectedIndex = 0;
            this.MainTabular.Size = new System.Drawing.Size(833, 447);
            this.MainTabular.TabIndex = 0;
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.UserGridView);
            this.UsersTab.Controls.Add(this.SearchUser);
            this.UsersTab.Controls.Add(this.SubmitUser);
            this.UsersTab.Controls.Add(this.gender);
            this.UsersTab.Controls.Add(this.label7);
            this.UsersTab.Controls.Add(this.label6);
            this.UsersTab.Controls.Add(this.label5);
            this.UsersTab.Controls.Add(this.label4);
            this.UsersTab.Controls.Add(this.label3);
            this.UsersTab.Controls.Add(this.label1);
            this.UsersTab.Controls.Add(this.Brithdate);
            this.UsersTab.Controls.Add(this.Lname);
            this.UsersTab.Controls.Add(this.identifyCode);
            this.UsersTab.Controls.Add(this.phone);
            this.UsersTab.Controls.Add(this.Fname);
            this.UsersTab.Location = new System.Drawing.Point(4, 22);
            this.UsersTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsersTab.Size = new System.Drawing.Size(825, 421);
            this.UsersTab.TabIndex = 0;
            this.UsersTab.Text = "کاربران";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // UserGridView
            // 
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Location = new System.Drawing.Point(20, 220);
            this.UserGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.ReadOnly = true;
            this.UserGridView.RowHeadersWidth = 51;
            this.UserGridView.RowTemplate.Height = 24;
            this.UserGridView.Size = new System.Drawing.Size(781, 122);
            this.UserGridView.TabIndex = 19;
            // 
            // SearchUser
            // 
            this.SearchUser.Location = new System.Drawing.Point(566, 165);
            this.SearchUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchUser.Name = "SearchUser";
            this.SearchUser.Size = new System.Drawing.Size(75, 19);
            this.SearchUser.TabIndex = 18;
            this.SearchUser.Text = "جستجو";
            this.SearchUser.UseVisualStyleBackColor = true;
            this.SearchUser.Click += new System.EventHandler(this.SearchUser_Click);
            // 
            // SubmitUser
            // 
            this.SubmitUser.Location = new System.Drawing.Point(656, 165);
            this.SubmitUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubmitUser.Name = "SubmitUser";
            this.SubmitUser.Size = new System.Drawing.Size(75, 19);
            this.SubmitUser.TabIndex = 17;
            this.SubmitUser.Text = "ثبت";
            this.SubmitUser.UseVisualStyleBackColor = true;
            this.SubmitUser.Click += new System.EventHandler(this.SubmitUser_Click);
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "زن",
            "مرد"});
            this.gender.Location = new System.Drawing.Point(656, 131);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(76, 21);
            this.gender.TabIndex = 16;
            this.gender.Text = "انتخاب کنید";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "نام خانوادگی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "شماره موبایل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(782, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "کد ملی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(770, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "تاریخ تولد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(782, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "جنسیت";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "نام";
            // 
            // Brithdate
            // 
            this.Brithdate.Location = new System.Drawing.Point(581, 106);
            this.Brithdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Brithdate.Name = "Brithdate";
            this.Brithdate.Size = new System.Drawing.Size(151, 20);
            this.Brithdate.TabIndex = 8;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(656, 37);
            this.Lname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(76, 20);
            this.Lname.TabIndex = 7;
            // 
            // identifyCode
            // 
            this.identifyCode.Location = new System.Drawing.Point(656, 60);
            this.identifyCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.identifyCode.Name = "identifyCode";
            this.identifyCode.Size = new System.Drawing.Size(76, 20);
            this.identifyCode.TabIndex = 6;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(656, 83);
            this.phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(76, 20);
            this.phone.TabIndex = 5;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(656, 15);
            this.Fname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(76, 20);
            this.Fname.TabIndex = 0;
            // 
            // TaavoniTab
            // 
            this.TaavoniTab.Controls.Add(this.label9);
            this.TaavoniTab.Controls.Add(this.CoId);
            this.TaavoniTab.Controls.Add(this.SearchCompany);
            this.TaavoniTab.Controls.Add(this.CompanyGridView);
            this.TaavoniTab.Controls.Add(this.SubmitCompany);
            this.TaavoniTab.Controls.Add(this.label8);
            this.TaavoniTab.Controls.Add(this.label2);
            this.TaavoniTab.Controls.Add(this.CoPhone);
            this.TaavoniTab.Controls.Add(this.CoName);
            this.TaavoniTab.Location = new System.Drawing.Point(4, 22);
            this.TaavoniTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TaavoniTab.Name = "TaavoniTab";
            this.TaavoniTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TaavoniTab.Size = new System.Drawing.Size(825, 421);
            this.TaavoniTab.TabIndex = 1;
            this.TaavoniTab.Text = "تعاونی ها";
            this.TaavoniTab.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(825, 421);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "رزرو ها";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CoName
            // 
            this.CoName.Location = new System.Drawing.Point(641, 9);
            this.CoName.Name = "CoName";
            this.CoName.Size = new System.Drawing.Size(72, 20);
            this.CoName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CoPhone
            // 
            this.CoPhone.Location = new System.Drawing.Point(641, 63);
            this.CoPhone.Name = "CoPhone";
            this.CoPhone.Size = new System.Drawing.Size(72, 20);
            this.CoPhone.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "شماره تلفن تعاونی";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(758, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "نام تعاونی";
            // 
            // SubmitCompany
            // 
            this.SubmitCompany.Location = new System.Drawing.Point(641, 89);
            this.SubmitCompany.Name = "SubmitCompany";
            this.SubmitCompany.Size = new System.Drawing.Size(72, 26);
            this.SubmitCompany.TabIndex = 4;
            this.SubmitCompany.Text = "ثبت";
            this.SubmitCompany.UseVisualStyleBackColor = true;
            this.SubmitCompany.Click += new System.EventHandler(this.SubmitCompany_Click);
            // 
            // CompanyGridView
            // 
            this.CompanyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyGridView.Location = new System.Drawing.Point(22, 149);
            this.CompanyGridView.Margin = new System.Windows.Forms.Padding(2);
            this.CompanyGridView.Name = "CompanyGridView";
            this.CompanyGridView.ReadOnly = true;
            this.CompanyGridView.RowHeadersWidth = 51;
            this.CompanyGridView.RowTemplate.Height = 24;
            this.CompanyGridView.Size = new System.Drawing.Size(781, 122);
            this.CompanyGridView.TabIndex = 20;
            // 
            // SearchCompany
            // 
            this.SearchCompany.Location = new System.Drawing.Point(554, 89);
            this.SearchCompany.Name = "SearchCompany";
            this.SearchCompany.Size = new System.Drawing.Size(81, 26);
            this.SearchCompany.TabIndex = 21;
            this.SearchCompany.Text = "جستجو";
            this.SearchCompany.UseVisualStyleBackColor = true;
            // 
            // Drivers
            // 
            this.Drivers.Location = new System.Drawing.Point(4, 22);
            this.Drivers.Name = "Drivers";
            this.Drivers.Size = new System.Drawing.Size(825, 421);
            this.Drivers.TabIndex = 3;
            this.Drivers.Text = "رانندگان";
            this.Drivers.UseVisualStyleBackColor = true;
            // 
            // CoId
            // 
            this.CoId.Location = new System.Drawing.Point(641, 37);
            this.CoId.Name = "CoId";
            this.CoId.Size = new System.Drawing.Size(72, 20);
            this.CoId.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(742, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "شماره تعاونی";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 466);
            this.Controls.Add(this.MainTabular);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "آزانیس مسافربری";
            this.MainTabular.ResumeLayout(false);
            this.UsersTab.ResumeLayout(false);
            this.UsersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.TaavoniTab.ResumeLayout(false);
            this.TaavoniTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabular;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.TabPage TaavoniTab;
        private System.Windows.Forms.DateTimePicker Brithdate;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox identifyCode;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Button SearchUser;
        private System.Windows.Forms.Button SubmitUser;
        private System.Windows.Forms.DataGridView UserGridView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button SubmitCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CoPhone;
        private System.Windows.Forms.TextBox CoName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView CompanyGridView;
        private System.Windows.Forms.Button SearchCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CoId;
        private System.Windows.Forms.TabPage Drivers;
    }
}

