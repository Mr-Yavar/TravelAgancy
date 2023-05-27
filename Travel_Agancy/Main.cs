using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_Agancy.Model;

namespace Travel_Agancy
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            RefreshGrid();





        }

        private void SubmitUser_Click(object sender, EventArgs e)
        {
            string U_Fname = Fname.Text.Trim();
            string U_Lname = Lname.Text.Trim();
            DateTime U_Brith = Brithdate.Value;
            string U_identifyCode = identifyCode.Text.Trim();
            string U_phone = phone.Text.Trim();
            string U_gender = gender.Text.Trim();

            travelAgencyEntities db = new travelAgencyEntities();


            bool Ugener = false; // زن
            if (U_gender == "مرد")
            {
                Ugener = true;
            }

            User NewUser = new User() {
               
                phone_number = U_phone,
                first_name = U_Fname
                , last_name = U_Lname,
                gender = Ugener,
                birth_date = U_Brith,
                identification_code = U_identifyCode,
                credit = 0,
                
            };

            try
            {
                db.Users.Add(NewUser);
            }catch (Exception ex)
            {

            }
            db.SaveChanges();
            RefreshGrid();

        }


        private void RefreshGrid()
        {
            travelAgencyEntities db = new travelAgencyEntities();
            UserGridView.DataSource = (from U in db.Users
                                       select new
                                       {
                                           ID = U.id,
                                           FullName = U.first_name + " " + U.last_name,
                                           identifyCode = U.identification_code,
                                           BrithDate = U.birth_date,
                                           PhoneNumber = U.phone_number,
                                           gender = U.gender ? "مرد" : "زن"


                                       }).ToList();
        }
    }
}
