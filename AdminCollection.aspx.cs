using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DejaBrew
{
    public partial class AdminCollection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        protected void Button6_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DejaBrew.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            string sqlquery = "SELECT * from Orders where cast(DeliveryDate as Date) between '" + TextBox10.Text + "'and'" + TextBox11.Text + "'";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            if (sdr.Read())
            {
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
            else
            {

            }
            con.Close();




        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
           

            TextBox12.Text = "0";
            for (int i = 0; i < GridView2.Rows.Count; i++)
            {

                TextBox12.Text = Convert.ToString(decimal.Parse(TextBox12.Text) + decimal.Parse(GridView2.Rows[i].Cells[1].Text.ToString()));

            }
        }

        protected void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
           

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DejaBrew.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            string sqlquery = "SELECT * from Orders where cast(DeliveryDate as Date) = '" + TextBox15.Text +  "'";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            if (sdr.Read())
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {

            }
            con.Close();
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
           

            TextBox14.Text = "0";
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {

                TextBox14.Text = Convert.ToString(decimal.Parse(TextBox14.Text) + decimal.Parse(GridView1.Rows[i].Cells[1].Text.ToString()));

            }
        }


        protected void Button16_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
           

            TextBox17.Text = "0";
            for (int i = 0; i < GridView4.Rows.Count; i++)
            {

                TextBox17.Text = Convert.ToString(decimal.Parse(TextBox17.Text) + decimal.Parse(GridView4.Rows[i].Cells[2].Text.ToString()));

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;

            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox14.Text = "";
            TextBox15.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox17.Text = "";
            TextBox19.Text = "";
        }

        protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = GridView4.SelectedRow;
            TextBox2.Text = gr.Cells[1].Text;
            TextBox3.Text = gr.Cells[2].Text;
            TextBox4.Text = gr.Cells[3].Text;
            TextBox5.Text = gr.Cells[4].Text;
            TextBox6.Text = gr.Cells[5].Text;
            TextBox7.Text = gr.Cells[6].Text;
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel5.Visible = true;


            TextBox19.Text = "0";
            for (int i = 0; i < GridView5.Rows.Count; i++)
            {

                TextBox19.Text = Convert.ToString(decimal.Parse(TextBox19.Text) + decimal.Parse(GridView5.Rows[i].Cells[1].Text.ToString()));

            }
        }
    }
}