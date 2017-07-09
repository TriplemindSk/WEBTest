using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEBTest.DB;
using System.Windows.Forms;

namespace WEBTest
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getCity();
            getPosition();
            getTeam();


        }
                
        public void getCity() {
            DBtestWEBDataContext ctx = new DBtestWEBDataContext();
            Table<City> Citys = ctx.GetTable<City>();
            
            var sqlCity = (from rows in ctx.GetTable<City>() orderby rows.CityName select new { rows.ID, rows.CityName }).ToList();

            ddl_City.DataSource = sqlCity;
            ddl_City.DataTextField = "CityName";
            ddl_City.DataValueField = "CityName";
            ddl_City.DataBind();
        }


        public void getTeam() {

            DBtestWEBDataContext ctx = new DBtestWEBDataContext();
            Table<Team> Teams = ctx.GetTable<Team>();

            var sqlTeam = (from rows in ctx.GetTable<Team>() select new { rows.ID, rows.TeamName }).ToList();


            ddl_Team.DataSource = sqlTeam;
            ddl_Team.DataTextField = "TeamName";
            ddl_Team.DataValueField = "TeamName";
            ddl_Team.DataBind();

        }

        public void getPosition() {
            DBtestWEBDataContext ctx = new DBtestWEBDataContext();
            Table<Position> Positions = ctx.GetTable<Position>();

            var sqlPosition = (from rows in ctx.GetTable<Position>() select new { rows.ID, rows.Position1 }).ToList();

            ddl_Position.DataSource = sqlPosition;
            ddl_Position.DataTextField = "Position1";
            ddl_Position.DataValueField = "Position1";
            ddl_Position.DataBind();
        }

        public void AddData() {

            using (DBtestWEBDataContext ctx = new DBtestWEBDataContext())
                        
            try{           
            UserN objCourse = new UserN();
            objCourse.Name = txt_Name.Text;  
            objCourse.Email = txt_Email.Text;
            objCourse.Telephon = txt_Tel.Text;
            objCourse.Team_id = ddl_City.Text.FirstOrDefault();
            objCourse.City_id = ddl_City.Text.FirstOrDefault();
            objCourse.Position_id = ddl_Position.Text.FirstOrDefault();
            objCourse.Date = DateTime.Now;

                            

           ctx.GetTable<UserN>().InsertOnSubmit(objCourse);
                      
            ctx.SubmitChanges();
            }catch(Exception e){

                Console.WriteLine(e.Message);
                

            }

           
        }


        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            AddData();
            MessageBox.Show("ADD Data Complete!" , "ADD" );
            
        }


        protected void btnUpload_ServerClick(object sender, EventArgs e)
        {
            if (this.ful_Img.HasFile)
            {
                this.ful_Img.SaveAs(Server.MapPath("Myfiles/" + ful_Img.FileName));
                //this.lblText.Text = fiUpload.FileName + " Uploaded.<br>";
            }

            MessageBox.Show("FileUpload", "Upload File Complete!");
        }
    }
}