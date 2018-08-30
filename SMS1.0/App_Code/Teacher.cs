using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace SMS1._0.App_Code
{
    public class Teacher:CommonProperties
    {
        public string qualification { get; set; }
        public string subject { get; set; }
        public string post { get; set; }
        public string loginName { get; set; }
        public string maritalSatues { get; set; }
        public string bloodGroup { get; set; }
        public int result;


        //Insertion
        public int Insert(Teacher teacher)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("teaInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Surname", teacher.surname);
                cmd.Parameters.AddWithValue("@OtherNames", teacher.othernames);
                cmd.Parameters.AddWithValue("@Gender", teacher.gender);
                cmd.Parameters.AddWithValue("@DOB", teacher.DOB);
                cmd.Parameters.AddWithValue("@Phone", teacher.phone);
                cmd.Parameters.AddWithValue("@Qualification", teacher.qualification);
                cmd.Parameters.AddWithValue("@Subjects", teacher.subject);
                cmd.Parameters.AddWithValue("@Post", teacher.post);
                cmd.Parameters.AddWithValue("@Photo", teacher.photo);
                cmd.Parameters.AddWithValue("@Login_Name", teacher.loginName);
                cmd.Parameters.AddWithValue("@Marital_Statues", teacher.maritalSatues);
                cmd.Parameters.AddWithValue("@Blood_Group", teacher.bloodGroup);
                cmd.Parameters.AddWithValue("@Religion", teacher.religion);
                cmd.Parameters.AddWithValue("@Nationality", teacher.nationality);
                cmd.Parameters.AddWithValue("@State", teacher.state);

                con.Open();
                result = (int)cmd.ExecuteScalar();
                return result;
            }
        }

        //Update
        public int Update(Teacher teacher)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("teaUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Surname", teacher.surname);
                cmd.Parameters.AddWithValue("@OtherNames", teacher.othernames);
                cmd.Parameters.AddWithValue("@Gender", teacher.gender);
                cmd.Parameters.AddWithValue("@DOB", teacher.DOB);
                cmd.Parameters.AddWithValue("@Phone", teacher.phone);
                cmd.Parameters.AddWithValue("@Qualification", teacher.qualification);
                cmd.Parameters.AddWithValue("@Subjects", teacher.subject);
                cmd.Parameters.AddWithValue("@Post", teacher.post);
                cmd.Parameters.AddWithValue("@Photo", teacher.photo);
                cmd.Parameters.AddWithValue("@Login_Name", teacher.loginName);
                cmd.Parameters.AddWithValue("@Marital_Statues", teacher.maritalSatues);
                cmd.Parameters.AddWithValue("@Blood_Group", teacher.bloodGroup);
                cmd.Parameters.AddWithValue("@Religion", teacher.religion);
                cmd.Parameters.AddWithValue("@Nationality", teacher.nationality);
                cmd.Parameters.AddWithValue("@State", teacher.state);

                con.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }

        //Deletion
        public int Delete(string Phone)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("teaDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Phone", Phone);

                con.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }

        //Selection
        public Teacher Select(string Phone)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter adap = new SqlDataAdapter("teaInsert", con);
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                adap.SelectCommand.Parameters.AddWithValue("@Phone", Phone);

                con.Open();
                DataSet ds = new DataSet();
                adap.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    Teacher teacher = new Teacher();
                    teacher.surname = ds.Tables[0].Rows[0]["Surname"].ToString();
                    teacher.othernames = ds.Tables[0].Rows[0]["OtherNames"].ToString();
                    teacher.gender = ds.Tables[0].Rows[0]["Gender"].ToString();
                    teacher.DOB = DateTime.Parse(ds.Tables[0].Rows[0]["DOB"].ToString());
                    teacher.phone = ds.Tables[0].Rows[0]["Phone"].ToString();
                    teacher.qualification = ds.Tables[0].Rows[0]["Qualification"].ToString();
                    teacher.subject = ds.Tables[0].Rows[0]["Subject"].ToString();
                    teacher.post = ds.Tables[0].Rows[0]["Post"].ToString();
                    teacher.photo = ds.Tables[0].Rows[0]["Photo"].ToString();
                    teacher.loginName = ds.Tables[0].Rows[0]["Login_Name"].ToString();
                    teacher.maritalSatues = ds.Tables[0].Rows[0]["Marital_Satues"].ToString();
                    teacher.bloodGroup = ds.Tables[0].Rows[0]["Blood_Group"].ToString();
                    teacher.religion = ds.Tables[0].Rows[0]["Religion"].ToString();
                    teacher.nationality = ds.Tables[0].Rows[0]["Nationality"].ToString();
                    teacher.state = ds.Tables[0].Rows[0]["State"].ToString();

                    return teacher;
                }
                return new Teacher();
            }
        }

        //Authentication
        public int Authenticate(string loginName, string phone)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter adap = new SqlDataAdapter("teaAuth", con);
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;

                adap.SelectCommand.Parameters.AddWithValue("@LoginName", loginName);
                adap.SelectCommand.Parameters.AddWithValue("@Phone", phone);

                DataTable dt = new DataTable();
                adap.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    result = 1;
                }
                else
                {
                    result = 0;
                }
                return result;
            }
        }

    }
}