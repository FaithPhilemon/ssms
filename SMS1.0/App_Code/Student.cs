using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace SMS1._0.App_Code
{
    public class Student:CommonProperties
    {
        public string yearOfEntry { get; set; }
        public string sports { get; set; }
        public string disabilities { get; set; }
        public string classType { get; set; }

        //Insertion
        public int Insert(Student student)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("stuInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Surname", student.surname);
                cmd.Parameters.AddWithValue("@OtherNames", student.othernames);
                cmd.Parameters.AddWithValue("@Gender", student.gender);
                cmd.Parameters.AddWithValue("@DOB", student.DOB);
                cmd.Parameters.AddWithValue("@Photo", student.photo);
                cmd.Parameters.AddWithValue("@Phone", student.phone);
                cmd.Parameters.AddWithValue("@YearOfEntry", student.yearOfEntry);
                cmd.Parameters.AddWithValue("@Sports", student.sports);
                cmd.Parameters.AddWithValue("@ClassType", student.classType);
                cmd.Parameters.AddWithValue("@Disablilities", student.disabilities);
                cmd.Parameters.AddWithValue("@Religion", student.religion);
                cmd.Parameters.AddWithValue("@Nationality", student.nationality);
                cmd.Parameters.AddWithValue("@State", student.state);
                con.Open();
                int result = cmd.ExecuteNonQuery();

                return result;
            }
        }

        //Update
        public int Update(Student student)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("stuUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Surname", student.surname);
                cmd.Parameters.AddWithValue("@OtherNames", student.othernames);
                cmd.Parameters.AddWithValue("@Gender", student.gender);
                cmd.Parameters.AddWithValue("@DOB", student.DOB);
                cmd.Parameters.AddWithValue("@Photo", student.photo);
                cmd.Parameters.AddWithValue("@Phone", student.phone);
                cmd.Parameters.AddWithValue("@YearOfEntry", student.yearOfEntry);
                cmd.Parameters.AddWithValue("@Sports", student.sports);
                cmd.Parameters.AddWithValue("@ClassType", student.classType);
                cmd.Parameters.AddWithValue("@Disablilities", student.disabilities);
                cmd.Parameters.AddWithValue("@Religion", student.religion);
                cmd.Parameters.AddWithValue("@Nationality", student.nationality);
                cmd.Parameters.AddWithValue("@State", student.state);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }

        //Deletion
        public int Delete(int Id)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("stuDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                int result = cmd.ExecuteNonQuery();

                return result;
            }
        }

        //Selection
        public Student Select(int Id)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter adap = new SqlDataAdapter("stuInsert", con);
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                adap.SelectCommand.Parameters.AddWithValue("@Id", Id);
                con.Open();
                DataSet ds = new DataSet();
                adap.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    Student student = new Student();
                    student.surname = ds.Tables[0].Rows[0]["Surname"].ToString();
                    student.othernames = ds.Tables[0].Rows[0]["OtherNames"].ToString();
                    student.gender = ds.Tables[0].Rows[0]["Gender"].ToString();
                    student.DOB = DateTime.Parse(ds.Tables[0].Rows[0]["DOB"].ToString());
                    student.photo = ds.Tables[0].Rows[0]["Photo"].ToString();
                    student.phone = ds.Tables[0].Rows[0]["Phone"].ToString();
                    student.yearOfEntry = ds.Tables[0].Rows[0]["YearOfEntry"].ToString();
                    student.sports = ds.Tables[0].Rows[0]["Sports"].ToString();
                    student.classType = ds.Tables[0].Rows[0]["ClassType"].ToString();
                    student.disabilities = ds.Tables[0].Rows[0]["Disabilities"].ToString();
                    student.religion = ds.Tables[0].Rows[0]["Religion"].ToString();
                    student.nationality = ds.Tables[0].Rows[0]["Nationality"].ToString();
                    student.state = ds.Tables[0].Rows[0]["State"].ToString();

                    return student;
                }
                return new Student();
            }
        }
    }
}