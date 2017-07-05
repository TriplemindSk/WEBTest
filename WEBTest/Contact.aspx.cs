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

           
        }

        
        public void getCity() {
            DBtestWEBDataContext ctx = new DBtestWEBDataContext();
            Table<City> Citys = ctx.GetTable<City>();
            
            var qr = from d in ctx.GetTable<City>() select d;
            
        }


        public void getTeam() {

            DBtestWEBDataContext ctx = new DBtestWEBDataContext();
            Table<Team> Teams = ctx.GetTable<Team>();

            var qrT= from dt in ctx.GetTable<Team>() select dt;

        }


        public void getPosition() {
            DBtestWEBDataContext ctx = new DBtestWEBDataContext();
            Table<Position> Positions = ctx.GetTable<Position>();

            var qrP = from dp in ctx.GetTable<Position>() select dp;
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