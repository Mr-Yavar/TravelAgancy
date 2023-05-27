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
            this.MainTabular.SuspendLayout();
            this.UsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabular
            // 
            this.MainTabular.Controls.Add(this.UsersTab);
            this.MainTabular.Controls.Add(this.TaavoniTab);
            this.MainTabular.Location = new System.Drawing.Point(12, 12);
            this.MainTabular.Name = "MainTabular";
            this.MainTabular.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainTabular.RightToLeftLayout = true;
            this.MainTabular.SelectedIndex = 0;
            this.MainTabular.Size = new System.Drawing.Size(1098, 503);
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
            this.UsersTab.Location = new System.Drawing.Point(4, 25);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTab.Size = new System.Drawing.Size(1090, 474);
            this.UsersTab.TabIndex = 0;
            this.UsersTab.Text = "کاربران";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // UserGridView
            // 
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Location = new System.Drawing.Point(26, 271);
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.ReadOnly = true;
            this.UserGridView.RowHeadersWidth = 51;
            this.UserGridView.RowTemplate.Height = 24;
            this.UserGridView.Size = new System.Drawing.Size(1041, 150);
            this.UserGridView.TabIndex = 19;
            // 
            // SearchUser
            // 
            this.SearchUser.Location = new System.Drawing.Point(755, 203);
            this.SearchUser.Name = "SearchUser";
            this.SearchUser.Size = new System.Drawing.Size(100, 23);
            this.SearchUser.TabIndex = 18;
            this.SearchUser.Text = "جستجو";
            this.SearchUser.UseVisualStyleBackColor = true;
            // 
            // SubmitUser
            // 
            this.SubmitUser.Location = new System.Drawing.Point(875, 203);
            this.SubmitUser.Name = "SubmitUser";
            this.SubmitUser.Size = new System.Drawing.Size(100, 23);
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
            this.gender.Location = new System.Drawing.Point(875, 161);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(100, 24);
            this.gender.TabIndex = 16;
            this.gender.Text = "انتخاب کنید";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1011, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "نام خانوادگی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1010, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "شماره موبایل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1042, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "کد ملی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1027, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "تاریخ تولد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1042, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "جنسیت";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1063, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "نام";
            // 
            // Brithdate
            // 
            this.Brithdate.Location = new System.Drawing.Point(775, 130);
            this.Brithdate.Name = "Brithdate";
            this.Brithdate.Size = new System.Drawing.Size(200, 22);
            this.Brithdate.TabIndex = 8;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(875, 46);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(100, 22);
            this.Lname.TabIndex = 7;
            // 
            // identifyCode
            // 
            this.identifyCode.Location = new System.Drawing.Point(875, 74);
            this.identifyCode.Name = "identifyCode";
            this.identifyCode.Size = new System.Drawing.Size(100, 22);
            this.identifyCode.TabIndex = 6;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(875, 102);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 22);
            this.phone.TabIndex = 5;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(875, 18);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(100, 22);
            this.Fname.TabIndex = 0;
            // 
            // TaavoniTab
            // 
            this.TaavoniTab.Location = new System.Drawing.Point(4, 25);
            this.TaavoniTab.Name = "TaavoniTab";
            this.TaavoniTab.Padding = new System.Windows.Forms.Padding(3);
            this.TaavoniTab.Size = new System.Drawing.Size(1090, 474);
            this.TaavoniTab.TabIndex = 1;
            this.TaavoniTab.Text = "تعاونی ها";
            this.TaavoniTab.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 574);
            this.Controls.Add(this.MainTabular);
            this.Name = "Main";
            this.Text = "آزانیس مسافربری";
            this.MainTabular.ResumeLayout(false);
            this.UsersTab.ResumeLayout(false);
            this.UsersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
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
    }
}

