using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CodeReviewAddin
{
    public class Connection
    {
        public static List<Questions> questions = new List<Questions>();

        public static void SetQuestions()
        {
            using (SqlConnection connection = new SqlConnection( "data source=gtpdb;persist security info=True;initial catalog=GtpDbC3POTest;User id=GTPDB;Password=GTPDB"))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM GTPBR_CODE_REVIEW_QUESTIONS (NOLOCK)", connection);
                connection.Open();

                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Questions question = new Questions();
                        question.Question = dr["QUESTION"].ToString();
                        question.QuestionNo = Convert.ToInt32(dr["QUESTION_NO"]);
                        question.QuestionRow = Convert.ToInt32(dr["QUESTION_ROW"]);
                        questions.Add(question);
                    }
                    connection.Close();
                }
            }
        }     
    }
}
