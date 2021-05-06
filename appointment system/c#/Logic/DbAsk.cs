using System;
using ProjeSon.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon.Logic
{
    class DbAsk : DBEntity
    {

        public void Ask(AskAnswer askAnswer)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("INSERT INTO tblQuestionReply(CompanyID,QuestionerID,Question,Status) values (@CompanyID,@QuestionerID,@Question,@Status)", con);
                cmd.Parameters.AddWithValue("CompanyID", askAnswer.CompanyID);
                cmd.Parameters.AddWithValue("QuestionerID", askAnswer.QuestionerID);
                cmd.Parameters.AddWithValue("Question", askAnswer.Question);
                cmd.Parameters.AddWithValue("Status", askAnswer.Status);

                con.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public List<AskAnswer> Showq(int companyid, int status)
        {

            List<AskAnswer> questions = new List<AskAnswer>();

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select * From tblQuestionReply WHERE Status=@Status AND CompanyID=@CompanyID ", con);
                cmd.Parameters.AddWithValue("CompanyID", companyid);
                cmd.Parameters.AddWithValue("Status", status);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new AskAnswer
                            {
                                ID = reader.GetInt32(0),
                                CompanyID = reader.GetInt32(1),
                                QuestionerID = reader.GetInt32(2),
                                Question = reader.GetString(3),
                                Status = reader.GetInt32(6)
                            };
                            questions.Add(entity);
                        }
                    }

                }
                return questions;

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public List<AskAnswer> ShowR(int userid, int status)
        {

            List<AskAnswer> questions = new List<AskAnswer>();

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select * From tblQuestionReply WHERE Status=@Status AND QuestionerID=@QuestionerID ", con);
                cmd.Parameters.AddWithValue("QuestionerID", userid);
                cmd.Parameters.AddWithValue("Status", status);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new AskAnswer
                            {
                                ID = reader.GetInt32(0),
                                CompanyID = reader.GetInt32(1),
                               QuestionerID = reader.GetInt32(2),
                                Question = reader.GetString(3),
                                
                                ReplyID=reader.GetInt32(4),
                                Reply = reader.GetString(5),
                                Status = reader.GetInt32(6)
                                
                            };
                            questions.Add(entity);
                        }
                    }

                }
                return questions;

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }






        public void Answer(AskAnswer answer)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("UPDATE tblQuestionReply SET ReplyID=@ReplyID,Reply=@Reply,Status=@Status WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("ReplyID", answer.ReplyID);
                cmd.Parameters.AddWithValue("Reply", answer.Reply);
                cmd.Parameters.AddWithValue("Status", answer.Status);
                cmd.Parameters.AddWithValue("ID", answer.ID);


                con.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
   







}
