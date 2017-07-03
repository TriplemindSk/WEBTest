using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEBTest.DB;

namespace WEBTest
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.SearchData();
            }
        }


        public void SearchData()
        {

            DBtestWEBDataContext ctx = new DBtestWEBDataContext();
            // Table<UserN> UserNs = ctx.GetTable<UserN>();


            string strKeyword = this.txb_Search.Text.Trim();


            var obj = from uc in ctx.GetTable<UserN>()
                      join ct in ctx.GetTable<City>()
                      on uc.City_id equals ct.ID
                      join Tt in ctx.GetTable<Team>()
                      on uc.Team_id equals Tt.ID
                      join Pt in ctx.GetTable<Position>()
                      on uc.Position_id equals Pt.ID
                      where uc.Name.Contains(strKeyword) || ct.CityName.Contains(strKeyword)
                      || Tt.TeamName.Contains(strKeyword) || Pt.Position1.Contains(strKeyword)
                      select new
                      {
                          uc.Name,
                          uc.Email,
                          uc.Telephon,
                          Tt.TeamName,
                          ct.CityName,
                          Pt.Position1,
                          uc.Date
                      };


            // Assign to GridView               
            this.gv_Search.DataSource = obj;
            this.gv_Search.DataBind();


        }

        protected void gv_Search_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gv_Search.PageIndex = e.NewPageIndex;
            this.SearchData();
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            this.SearchData();
        }

        //protected void gv_Search_DataBound(object sender, EventArgs e)
        //{


        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        e.Row.Cells[6].Text = Regex.Replace(e.Row.Cells[6].Text, txb_Search.Text.Trim(), delegate (Match match)
        //        {
        //            return string.Format("<span style = 'background-color:#D9EDF7'>{6}</span>", match.Value);
        //        }, RegexOptions.IgnoreCase);
        //    }
            
            
        //}




            //}

            //protected void gv_Search_RowDeleting(object sender, GridViewDeleteEventArgs e)
            //{

            //    //int UserID = Convert.ToInt32(gv_Search.DataKeys[e.RowIndex].Values[0]);
            //    //using (DBtestWEBDataContext ctx = new DBtestWEBDataContext())
            //    //{
            //    //    UserN objCourse = (from c in ctx.UserNs
            //    //                       where c.U_ID == UserID
            //    //                       select c).FirstOrDefault();
            //    //    ctx.UserNs.DeleteOnSubmit(objCourse);
            //    //    ctx.SubmitChanges();
            //    //}
            //    //this.SearchData();




            //}

            //protected void gv_Search_RowEditing(object sender, GridViewEditEventArgs e)
            //{

            //    gv_Search.EditIndex = e.NewEditIndex;
            //    this.SearchData();



            //}

            //protected void gv_Search_RowUpdating(object sender, GridViewUpdateEventArgs e)
            //{

            //}

            //protected void gv_Search_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
            //{
            //   gv_Search.EditIndex = -1;
            //    this.SearchData();

            //}

            ////protected void btnAdd_Click(object sender, EventArgs e)
            ////{
            ////    DBtestWEBDataContext ctx = new DBtestWEBDataContext();

            ////    UserN objCourse = new UserN();
            ////    objCourse.Name = txtName.Text;
            ////    objCourse.Email = txtEmail.Text;
            ////    objCourse.Telephon = txtTel.Text;
            ////    objCourse.Team_id = ddl_Team.Text.FirstOrDefault();
            ////    objCourse.City_id = ddl_City.Text.FirstOrDefault();
            ////    objCourse.Position_id = ddl_Position.Text.FirstOrDefault();
            ////    objCourse.Date = DateTime.Now;

            ////    ctx.GetTable<UserN>().InsertOnSubmit(objCourse);
            ////    ctx.SubmitChanges();

            ////    this.SearchData();

            ////}
        }
    }
