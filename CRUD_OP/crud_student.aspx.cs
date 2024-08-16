using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;

namespace CRUD_OP
{
    public partial class crud_student : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(cs)) {

                string query = "INSERT INTO student (Id, Name, [Roll No.], Semester, CPI, City) VALUES ("
     + Convert.ToInt16(TextBox1.Text) + ", '"
     + TextBox2.Text + "', '"
     + TextBox6.Text + "', "  
     + Convert.ToInt16(TextBox3.Text) + ", "
     + Convert.ToDouble(TextBox4.Text) + ", '"
     + TextBox5.Text + "');";


                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows == 0)
                {
                    Response.Write("Error executing operation.");
                }
                else
                {
                    Response.Write("Inserted Sucessfully");
                }
                display();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(cs))
            {
                string query = "DELETE FROM student WHERE Id = " + Convert.ToInt16(TextBox1.Text) + ";";
                SqlCommand command = new SqlCommand(query, conn);   
                conn.Open();
                int rows = command.ExecuteNonQuery();
                if (rows == 0)
                {
                    Response.Write("Error executing operation.");
                }
                else
                {
                    Response.Write("Deleted Sucessfully");
                }
                display();

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(cs))
            {
                string query = "UPDATE student SET Name = '" + TextBox2.Text
    + "', [Roll No.] = '" + TextBox6.Text + "', Semester = "
    + Convert.ToInt16(TextBox3.Text) + ", CPI = "
    + Convert.ToDouble(TextBox4.Text) + ", City = '"
    + TextBox5.Text + "' WHERE Id = "
    + Convert.ToInt16(TextBox1.Text) + ";";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                conn.Open();
                int rows = sqlCommand.ExecuteNonQuery();
                if (rows == 0)
                {
                    Response.Write("Error executing operation.");
                }
                else
                {
                    Response.Write("Updated Sucessfully");
                }
                display();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            display();
        }

        private void display()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandText = "select * from student";

                SqlDataReader reader;

                conn.Open();
                reader = sqlCommand.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();

            }
            cleartb();
        }
        private void cleartb()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";

        }
    }
}