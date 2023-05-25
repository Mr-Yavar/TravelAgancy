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
            this.TaavoniTab = new System.Windows.Forms.TabPage();
            this.MainTabular.SuspendLayout();
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
            this.MainTabular.Size = new System.Drawing.Size(878, 503);
            this.MainTabular.TabIndex = 0;
            // 
            // UsersTab
            // 
            this.UsersTab.Location = new System.Drawing.Point(4, 25);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTab.Size = new System.Drawing.Size(870, 474);
            this.UsersTab.TabIndex = 0;
            this.UsersTab.Text = "کاربران";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // TaavoniTab
            // 
            this.TaavoniTab.Location = new System.Drawing.Point(4, 25);
            this.TaavoniTab.Name = "TaavoniTab";
            this.TaavoniTab.Padding = new System.Windows.Forms.Padding(3);
            this.TaavoniTab.Size = new System.Drawing.Size(870, 474);
            this.TaavoniTab.TabIndex = 1;
            this.TaavoniTab.Text = "تعاونی ها";
            this.TaavoniTab.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 527);
            this.Controls.Add(this.MainTabular);
            this.Name = "Main";
            this.Text = "آزانیس مسافربری";
            this.MainTabular.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabular;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.TabPage TaavoniTab;
    }
}

