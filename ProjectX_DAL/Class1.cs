using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX_DAL
{
    public class MiniProjectDBConnection
    {
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;

       

        public string ConnectToDB()
        {
            try
            {

                sqlConObj = new SqlConnection();

                string conStr = ConfigurationManager.ConnectionStrings["MiniProjectConStr"].ToString();
                sqlConObj.ConnectionString = conStr;

                //or
                //sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["AdvConStr"].ToString());

                sqlConObj.Open();

                return sqlConObj.State.ToString();
            }

            catch (Exception ex)
            {

                Console.WriteLine("Something Went Wrong");
                Console.WriteLine(ex.Message);
                return sqlConObj.State.ToString();

            }

            finally
            {

                sqlConObj.Close();

                Console.WriteLine(sqlConObj.State);

            }


        }


        public List<string> GetAllFaculty()
        {
            List<string> lstFaculty = new List<string>();
            try
            {


                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniProjectConStr"].ToString()); //connection establishment
                sqlCmdObj = new SqlCommand(@"SELECT Name, Psnumber,EmailId  FROM Faculty", sqlConObj); //Which connection I am executing this command on

                sqlConObj.Open();
                SqlDataReader drFaculty = sqlCmdObj.ExecuteReader();

                while (drFaculty.Read())
                {
                    lstFaculty.Add(String.Concat(drFaculty["Name"], drFaculty["Psnumber"], drFaculty["EmailId"]));
                }

                return lstFaculty;


            }

            catch (Exception)
            {
                lstFaculty.Add("Something went Wrong");
                return lstFaculty;

            }

            finally
            {
                sqlConObj.Close();
            }

        }


        public List<string> GetAllCourse()
        {
            List<string> lstCourse = new List<string>();
            try
            {


                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniProjectConStr"].ToString()); //connection establishment
                sqlCmdObj = new SqlCommand(@"SELECT CourseID, CourseOwner, CourseTitle,AssessmentId, HoursAssigned,CourseSyllabus   FROM Course", sqlConObj); //Which connection I am executing this command on

                sqlConObj.Open();
                SqlDataReader drCourse = sqlCmdObj.ExecuteReader();

                while (drCourse.Read())
                {
                    lstCourse.Add(String.Concat(drCourse["CourseID"], drCourse["CourseOwner"], drCourse["CourseTitle"], drCourse["AssessmentId"], drCourse["HoursAssigned"], drCourse["CourseSyllabus"]));
                }

                return lstCourse;


            }

            catch (Exception)
            {
                lstCourse.Add("Something went Wrong");
                return lstCourse;

            }

            finally
            {
                sqlConObj.Close();
            }
        }


        public List<string> GetAllGrader()
        {
            List<string> lstGrader = new List<string>();
            try
            {


                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniProjectConStr"].ToString()); //connection establishment
                sqlCmdObj = new SqlCommand(@"SELECT NewBatchID, CourseID, Result  FROM Grader", sqlConObj); //Which connection I am executing this command on

                sqlConObj.Open();
                SqlDataReader drGrader = sqlCmdObj.ExecuteReader();

                while (drGrader.Read())
                {
                    lstGrader.Add(String.Concat(drGrader["NewBatchID"], drGrader["CourseID"], drGrader["Result"]));
                }

                return lstGrader;


            }

            catch (Exception)
            {
                lstGrader.Add("Something went Wrong");
                return lstGrader;

            }

            finally
            {
                sqlConObj.Close();
            }
        }

        public List<string> GetAllBatch()
        {
            List<string> lstBatch = new List<string>();
            try
            {


                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniProjectConStr"].ToString()); //connection establishment
                sqlCmdObj = new SqlCommand(@"SELECT NewBatchID, ModelID, DateOfStart  FROM Batch", sqlConObj); //Which connection I am executing this command on

                sqlConObj.Open();
                SqlDataReader drBatch = sqlCmdObj.ExecuteReader();

                while (drBatch.Read())
                {
                    lstBatch.Add(String.Concat(drBatch["NewBatchID"], drBatch["ModelID"], drBatch["DateOfStart"]));
                }

                return lstBatch;


            }

            catch (Exception)
            {
                lstBatch.Add("Something went Wrong");
                return lstBatch;

            }

            finally
            {
                sqlConObj.Close();
            }
        }


        public List<string> GetAllTrainee()
        {
            List<string> lstTrainee = new List<string>();
            try
            {


                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniProjectConStr"].ToString()); //connection establishment
                sqlCmdObj = new SqlCommand(@"SELECT NewBatchID, EmailID, Tsnumber  FROM Trainee", sqlConObj); //Which connection I am executing this command on

                sqlConObj.Open();
                SqlDataReader drTrainee = sqlCmdObj.ExecuteReader();

                while (drTrainee.Read())
                {
                    lstTrainee.Add(String.Concat(drTrainee["NewBatchID"], drTrainee["EmailID"], drTrainee["Tsnumber"]));
                }

                return lstTrainee;


            }

            catch (Exception)
            {
                lstTrainee.Add("Something went Wrong");
                return lstTrainee;

            }

            finally
            {
                sqlConObj.Close();
            }

        }


        public List<string> GetAllModel()
        {
            List<string> lstModel = new List<string>();
            try
            {


                sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniProjectConStr"].ToString()); //connection establishment
                sqlCmdObj = new SqlCommand(@"SELECT ModelId, ModelName FROM Model", sqlConObj); //Which connection I am executing this command on

                sqlConObj.Open();
                SqlDataReader drModel = sqlCmdObj.ExecuteReader();

                while (drModel.Read())
                {
                    lstModel.Add(String.Concat(drModel["ModelId"], drModel["ModelName"]));
                }

                return lstModel;


            }

            catch (Exception)
            {
                lstModel.Add("Something went Wrong");
                return lstModel;

            }

            finally
            {
                sqlConObj.Close();
            }

        }





    }


}


