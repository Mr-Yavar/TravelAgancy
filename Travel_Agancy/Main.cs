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
            RefreshCoGrid();


            RefreshTrvaelGrid();

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
            UserView.Items.Clear();
            travelAgencyEntities db = new travelAgencyEntities();
            var list = (from U in db.Users
                        select new
                        {
                            ID = U.id,
                            FullName = U.first_name + " " + U.last_name,
                            identifyCode = U.identification_code,
                            BrithDate = U.birth_date,
                            PhoneNumber = U.phone_number,
                            gender = U.gender ? "مرد" : "زن"
                        }).ToList();

            var formattedList = list.Select(u => $"{u.ID},{u.FullName},{u.identifyCode},{u.BrithDate.Value.Date.ToString().Split(' ')[0]},{u.PhoneNumber},{u.gender}").Select(x => x.Split(',')).ToList();

            for (int i = 0; i < formattedList.Count(); i++)
            {
                ListViewItem item = new ListViewItem();
                for(int j = 0; j < 6; j++)
                {
                    item.SubItems.Add(formattedList[i][j]);
                }
                UserView.Items.Add(item);
            }

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

            UserView.Items.Clear();
        

            var formattedList = list.Select(u => $"{u.ID},{u.FullName},{u.identifyCode},{u.BrithDate.Value.Date.ToString().Split(' ')[0]},{u.PhoneNumber},{u.gender}").Select(x => x.Split(',')).ToList();

            for (int i = 0; i < formattedList.Count(); i++)
            {
                ListViewItem item = new ListViewItem();
                for (int j = 0; j < 6; j++)
                {
                    item.SubItems.Add(formattedList[i][j]);
                }
                UserView.Items.Add(item);
            }
        }

        private void SubmitCompany_Click(object sender, EventArgs e)
        {
            int Co_Nu =Convert.ToInt32(CoId.Text.Trim());
            string Co_name = CoName.Text.Trim();
            string Co_phone =CoPhone.Text.Trim();


            travelAgencyEntities db = new travelAgencyEntities();


            company NewCo = new company()
            {
                name = Co_name,
                phone = Co_phone,


            };

            try
            {
                db.companies.Add(NewCo);
            }
            catch (Exception ex)
            {

            }
            db.SaveChanges();
            
            
            RefreshCoGrid();
        }
        private void RefreshCoGrid()
        {
           
            travelAgencyEntities db = new travelAgencyEntities();
            CompanyGridView.DataSource = (from Co in db.companies
                                       select new
                                       {

                                           ID = Co.id,
                                           Name = Co.name,
                                           Phone = Co.phone,
 
                                       }).ToList();
        }

        private void SubmitDriver_Click(object sender, EventArgs e)
        {


            string D_Fname = DriverFname.Text.Trim();
            string D_Lname = DriverLname.Text.Trim();
            DateTime D_Brith = DriverBirthdate.Value;
            string D_identifyCode = DriverindentifyCode.Text.Trim();
            string D_phone = DriverPhone.Text.Trim();
            string D_licNo = DriverLiNo.Text.Trim();
           
        }

        private void UserView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserView.SelectedItems.Count == 1)
            {
                var subitems = UserView.SelectedItems[0].SubItems;
                UUSerID.Text = subitems[1].Text;
                
                UFName.Text = subitems[2].Text.Split(' ')[0];
                ULName.Text = subitems[2].Text.Split(' ')[1];
                UidentifyCode.Text = subitems[3].Text;
                UbrithDate.Text = subitems[4].Text;
                Uphone.Text = subitems[5].Text;
                Ugender.Text = subitems[6].Text;    
            }
        }

        private void updateuser_Click(object sender, EventArgs e)
        {
            if (UUSerID.Text == "")
                return;
            string U_Fname = UFName.Text.Trim();
            string U_Lname = ULName.Text.Trim();
            DateTime U_Brith = UbrithDate.Value;
            string U_identifyCode = UidentifyCode.Text.Trim();
            string U_phone = Uphone.Text.Trim();
            string U_gender = Ugender.Text.Trim();
            bool Ugener = false; // زن
            if (U_gender == "مرد")
            {
                Ugener = true;
            }

            travelAgencyEntities db = new travelAgencyEntities();


            int id =Convert.ToInt32(UUSerID.Text);
            var newuser = db.Users.FirstOrDefault(x => x.id == id);

            newuser.phone_number = U_phone;
                 newuser.first_name = U_Fname;
                 newuser.last_name = U_Lname;
                 newuser.gender = Ugener;
                 newuser.birth_date = U_Brith;
            newuser.identification_code = U_identifyCode;
             db.SaveChanges();

            RefreshGrid();

        }

        private void cancelupdateuser_Click(object sender, EventArgs e)
        {
            UUSerID.Text = "";

            UFName.Text = "";
            ULName.Text = "";
            UidentifyCode.Text = "";
            UbrithDate.Text = "";
            Uphone.Text = "";
            Ugender.Text = "";
        }

        private void SearchCompany_Click(object sender, EventArgs e)
        {
            int Co_Nu = Convert.ToInt32(CoId.Text.Trim()=="" ? "0" : CoId.Text.Trim());
            string Co_name = CoName.Text.Trim();
            string Co_phone = CoPhone.Text.Trim();


            travelAgencyEntities db = new travelAgencyEntities();
            var list = (from Com in db.companies select Com);

            if (CoId.Text != "")
                list= list.Where(x => x.id == Co_Nu);

            if (Co_name != "")
            {
                list = list.Where(x => x.name.StartsWith(Co_name));
            }

            if(Co_phone !="")
                list = list.Where(x => x.phone.StartsWith(Co_phone));

            CompanyGridView.DataSource = list.ToList();
        }

        private void RefreshTrvaelGrid()
        {

            travelAgencyEntities db = new travelAgencyEntities();
            TravelGrid.DataSource = (from Co in db.travels
                                     select Co).ToList();
        }
        private void SubmitTravel_Click(object sender, EventArgs e)
        {
            travel travel = new travel()
            {
                destination = Dest.Text,
                beginning = Mabda.Text.Trim(),
                time = TimeSpan.Parse(traveltime.Text),
                date = traveldate.Value.Date,
                ticket_cost = Decimal.Parse(price.Text.Trim())
            };

            travelAgencyEntities db = new travelAgencyEntities();
            db.travels.Add(travel);
            db.SaveChanges();
            RefreshTrvaelGrid();
        }
    }
}
