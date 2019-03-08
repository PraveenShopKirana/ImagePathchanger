using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePathSetting
{
    class Program
    {
        static void Main(string[] args)
        {
            string constring = ConfigurationManager.ConnectionStrings["AuthContext"].ConnectionString;
            try
            {
                // Connect to SQL
                Console.Write("Connecting to SQL Server ... ");
                //For Base Category
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();
                    Console.WriteLine("Done.");

                    DataTable dt = new DataTable();

                    string Query = "Select BaseCategoryId from BaseCategories";
                    SqlDataAdapter dr = new SqlDataAdapter(Query, connection);
                    dr.Fill(dt);

                    int x = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string id = dt.Rows[i]["BaseCategoryId"].ToString();
                        //https://res.cloudinary.com/shopkirana/image/upload/v1/home/5.jpg
                        string logourl = "https://res.cloudinary.com/shopkirana/image/upload/v1/home/" + id + ".jpg";

                        string sql = "Update BaseCategories set LogoUrl = '" + logourl + "' where BaseCategoryid = '" + id + "' ";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                            x++;
                        }
                    }
                    Console.WriteLine(x + " Base Category LogoUrl Updated");
                }
                //For Category
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();

                    DataTable dt = new DataTable();

                    string Query = "select Categoryid from Categories";
                    SqlDataAdapter dr = new SqlDataAdapter(Query, connection);

                    dr.Fill(dt);

                    int x = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var id = Convert.ToInt32(dt.Rows[i]["Categoryid"]);

                        //https://res.cloudinary.com/shopkirana/image/upload/v1/category/41.jpg
                        string logourl = "https://res.cloudinary.com/shopkirana/image/upload/v1/category/" + id + ".jpg";

                        string sql = "Update Categories set LogoUrl = '" + logourl + "' where Categoryid = '" + id + "'";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                            x++;
                        }
                    }
                    Console.WriteLine(x + " Category LogoUrl Updated");
                }
                //For Sub Category
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();

                    DataTable dt = new DataTable();

                    string Query = "select SubCategoryId from SubCategories";
                    SqlDataAdapter dr = new SqlDataAdapter(Query, connection);

                    dr.Fill(dt);

                    int x = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var id = Convert.ToInt32(dt.Rows[i]["SubCategoryId"]);

                        //https://res.cloudinary.com/shopkirana/image/upload/v1/sub-category/7.jpg
                        string logourl = "https://res.cloudinary.com/shopkirana/image/upload/v1/sub-category/" + id + ".jpg";

                        string sql = "Update SubCategories set LogoUrl = '" + logourl + "' where SubCategoryId = '" + id + "'";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                            x++;
                        }
                    }
                    Console.WriteLine(x + " Sub Category LogoUrl Updated");
                }
                //For Sub-Sub Category
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();

                    DataTable dt = new DataTable();

                    string Query = "select SubsubCategoryid from SubsubCategories";
                    SqlDataAdapter dr = new SqlDataAdapter(Query, connection);

                    dr.Fill(dt);

                    int x = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var id = Convert.ToInt32(dt.Rows[i]["SubsubCategoryid"]);

                        //https://res.cloudinary.com/shopkirana/image/upload/v1551184244/sub%20sub/152.jpg
                        string logourl = "https://res.cloudinary.com/shopkirana/image/upload/v1/sub%20sub/" + id + ".jpg";

                        string sql = "Update SubsubCategories set LogoUrl = '" + logourl + "' where SubsubCategoryid = '" + id + "'";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                            x++;
                        }
                    }
                    Console.WriteLine(x + " Sub Sub Category LogoUrl Updated");

                }
                //For Item Master
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();

                    DataTable dt = new DataTable();

                    string Query = "select Id,Number from ItemMasterCentrals";
                    SqlDataAdapter dr = new SqlDataAdapter(Query, connection);

                    dr.Fill(dt);

                    int x = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var id = Convert.ToInt32(dt.Rows[i]["Id"]);
                        var number = dt.Rows[i]["Number"];

                        //https://res.cloudinary.com/shopkirana/image/upload/v1/items_images/item_1/CF3381750.jpg
                        string logourl = "https://res.cloudinary.com/shopkirana/image/upload/v1/items_images/item_1/" + number + ".jpg";

                        string sql = "Update ItemMasterCentrals set LogoUrl = '" + logourl + "' where Id = '" + id + "'";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                            x++;
                        }
                    }
                    Console.WriteLine(x + " Item LogoUrl Updated");

                }
                //For Slider
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();

                    DataTable dt = new DataTable();

                    string Query = "select SliderId from Sliders";
                    SqlDataAdapter dr = new SqlDataAdapter(Query, connection);

                    dr.Fill(dt);

                    int x = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var id = Convert.ToInt32(dt.Rows[i]["SliderId"]);

                        //https://res.cloudinary.com/shopkirana/image/upload/v1/home/6.jpg
                        string logourl = "https://res.cloudinary.com/shopkirana/image/upload/v1/home/" + id + ".jpg";

                        string sql = "Update Sliders set Pic = '" + logourl + "' where SliderId = '" + id + "'";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                            x++;
                        }
                    }
                    Console.WriteLine(x + " Slider LogoUrl Updated");

                }
                //For Item Brand
                using (SqlConnection connection = new SqlConnection(constring))
                {
                    connection.Open();

                    DataTable dt = new DataTable();

                    string Query = "select ItemBrandid,LogoUrl from ItemBrands";
                    SqlDataAdapter dr = new SqlDataAdapter(Query, connection);

                    dr.Fill(dt);

                    int x = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var id = Convert.ToInt32(dt.Rows[i]["ItemBrandid"]);

                        //https://res.cloudinary.com/shopkirana/image/upload/v1/home/6.jpg
                        string logourl = "https://res.cloudinary.com/shopkirana/image/upload/v1/home/" + id + ".jpg";

                        string sql = "Update ItemBrands set LogoUrl = '" + logourl + "' where ItemBrandid = '" + id + "'";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                            x++;
                        }
                    }
                    Console.WriteLine(x + " Item Brand LogoUrl Updated");

                }

                Console.WriteLine("Press any key to finish...");
                Console.ReadKey(true);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}