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
            bool Ugener = false; // زن
            if (U_gender == "مرد")
            {
                Ugener = true;
            }

            travelAgencyEntities db = new travelAgencyEntities();



            User NewUser = new User()
            {

                phone_number = U_phone,
                first_name = U_Fname
                ,
                last_name = U_Lname,
                gender = Ugener,
                birth_date = U_Brith,
                identification_code = U_identifyCode,
                credit = 0

            };

            try
            {
                db.Users.Add(NewUser);
            }
            catch (Exception ex)
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

        private void SearchUser_Click(object sender, EventArgs e)
        {
            string U_Fname = Fname.Text.Trim();
            string U_Lname = Lname.Text.Trim();
            DateTime U_Brith = Brithdate.Value;
            string U_identifyCode = identifyCode.Text.Trim();
            string U_phone = phone.Text.Trim();
            string U_gender = gender.Text.Trim();

            travelAgencyEntities db = new travelAgencyEntities();
            var query = (from U in db.Users select U);

            if (U_Fname != "")
                query = query.Where(x => x.first_name.StartsWith(U_Fname) == true);

            if (U_Lname != "")
                query = query.Where(x => x.last_name.StartsWith(U_Lname) == true);

            if (U_identifyCode != "")
                query = query.Where(x => x.identification_code.StartsWith(U_identifyCode) == true);

            if (U_gender != "انتخاب کنید" && U_gender != "")
            {
                bool Ugener = false; // زن
                if (U_gender == "مرد")
                {
                    Ugener = true;
                }
                query = query.Where(x => x.gender == Ugener);
            }

            if (U_phone != "")
            {
                query = query.Where(x => x.phone_number.StartsWith(U_phone) == true);
            }

            var list = query.Select(x => new
            {
                ID = x.id,
                FullName = x.first_name + " " + x.last_name,
                identifyCode = x.identification_code,
                BrithDate = x.birth_date,
                PhoneNumber = x.phone_number,
                gender = x.gender ? "مرد" : "زن"


            }).ToList();

            UserGridView.DataSource = list;
        }
    }
}
