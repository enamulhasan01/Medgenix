using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Medgenix
{
    public static class UseDatabase
    {
        private static string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Medgenix;Integrated Security=True;Encrypt=False";

      
        public static SqlConnection DB()
        {
            return new SqlConnection(conStr);
        }


        public static void InsertTempData(ContributorData TempData)
        {
            if (TempData == null) return;

            using (SqlConnection con = DB())
            {
            
                string query = @"INSERT INTO Temp_Data (Disease_Name, Disease_Symptoms, Area, Hospital_Name, Doctots_Treatment, Blood_Group, Age_Group, Cure_Status, [Date], Disease_Reason, Status, Submitted_By_Role, Drive) 
                                VALUES (@DiseaseName, @Symptom, @Area, @Hospital, @Treatment, @BloodGroup, @AgeGroup, @CureStatus, @Date, @Reason, @Status, @SubmittedByRole, @Drive)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DiseaseName", TempData.DiseaseName ?? "");
                    cmd.Parameters.AddWithValue("@Symptom", TempData.Symptom ?? "");
                    cmd.Parameters.AddWithValue("@Area", TempData.Area ?? "");
                    cmd.Parameters.AddWithValue("@Hospital", TempData.Hospital ?? "");
                    cmd.Parameters.AddWithValue("@Treatment", TempData.Treatment ?? "");
                    cmd.Parameters.AddWithValue("@BloodGroup", TempData.BloodGroup ?? "");
                    cmd.Parameters.AddWithValue("@AgeGroup", TempData.AgeGroup ?? "");
                    cmd.Parameters.AddWithValue("@CureStatus", TempData.CureStatus ?? "");
                    cmd.Parameters.AddWithValue("@Date", string.IsNullOrEmpty(TempData.DateTime) ? (object)DBNull.Value : TempData.DateTime);
                    cmd.Parameters.AddWithValue("@Reason", TempData.Reason ?? "");
                    cmd.Parameters.AddWithValue("@Drive", TempData.Drive ?? "");
                    cmd.Parameters.AddWithValue("@Status", "Pending");
                    cmd.Parameters.AddWithValue("@SubmittedByRole", UserSession.Role);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }



//reword

        public static void AssignRewardPoint(int contributorId)
        {
            using (SqlConnection con = DB())
            {
                string q = @"
        IF EXISTS (SELECT 1 FROM RewardPoint WHERE ContributorId=@cid)
            UPDATE RewardPoint 
            SET Points = Points + 5 
            WHERE ContributorId=@cid
        ELSE
            INSERT INTO RewardPoint (ContributorId, Points)
            VALUES (@cid, 5)";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@cid", contributorId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // reword

        public static int GetRewardForContributor(int contributorId)
        {
            using (SqlConnection con = DB())
            {
                string q = "SELECT Points FROM RewardPoint WHERE ContributorId=@cid";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@cid", contributorId);

                con.Open();
                object result = cmd.ExecuteScalar();

                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        // reword point

        public static void ResetRewardAfterClaim(int contributorId)
        {
            using (SqlConnection con = DB())
            {
                string q = "UPDATE RewardPoint SET Points=0 WHERE ContributorId=@cid";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@cid", contributorId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }











        public static List<ContributorData> GetPendingData(string role)
        {
            List<ContributorData> list = new List<ContributorData>();
            using (SqlConnection con = DB())
            {
                string q = "SELECT * FROM Temp_Data WHERE Status='Pending' AND Submitted_By_Role=@r";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@r", role);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new ContributorData
                    {
                        Id = Convert.ToInt32(dr["Disease_ID"]), 
                        DiseaseName = dr["Disease_Name"].ToString(),
                        Reason = dr["Disease_Reason"].ToString(),
                        Symptom = dr["Disease_Symptoms"].ToString(),
                        Treatment = dr["Doctots_Treatment"].ToString(),
                        Hospital = dr["Hospital_Name"].ToString(),
                        BloodGroup = dr["Blood_Group"].ToString(),
                        AgeGroup = dr["Age_Group"].ToString(),
                        CureStatus = dr["Cure_Status"].ToString(),
                        Area = dr["Area"].ToString(),
                        DateTime = dr["Date"].ToString(),
                        Drive = dr["Drive"].ToString()
                    });
                }
            }
            return list;
        }
        public static void DeleteFromTemp(int id)
        {
            using (SqlConnection con = DB())
            {
               
                string q = "DELETE FROM Temp_Data WHERE Disease_ID=@id";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }





        public static void UpdateStatus(int id, string status)
        {
            using (SqlConnection con = DB())
            {
                string q = @"UPDATE Temp_Data 
                     SET Status = @s 
                     WHERE Disease_ID = @id";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.Add("@s", SqlDbType.VarChar).Value = status;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }



        public static int GetPendingCount(string role)
        {
            using (SqlConnection con = DB())
            {
                string q = "SELECT COUNT(*) FROM Temp_Data WHERE Status='Pending' AND Submitted_By_Role=@r";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@r", role);
                con.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }


        public static void InsertIntoDisease1(ContributorData d)
        {
            using (SqlConnection con = DB())
            {
                string q = @"INSERT INTO Disease_1
        (Disease_Name, Disease_Symptoms, Area, Hospital_Name,
         Doctots_Treatment, Blood_Group, Age_Group, Cure_Status,
         Date, Disease_Reason)
        VALUES
        (@n,@s,@a,@h,@t,@b,@ag,@c,@dt,@r)";

                SqlCommand cmd = new SqlCommand(q, con);

                cmd.Parameters.AddWithValue("@n", d.DiseaseName);
                cmd.Parameters.AddWithValue("@s", d.Symptom);
                cmd.Parameters.AddWithValue("@a", d.Area);
                cmd.Parameters.AddWithValue("@h", d.Hospital);
                cmd.Parameters.AddWithValue("@t", d.Treatment);
                cmd.Parameters.AddWithValue("@b", d.BloodGroup);
                cmd.Parameters.AddWithValue("@ag", d.AgeGroup);
                cmd.Parameters.AddWithValue("@c", d.CureStatus);
                cmd.Parameters.AddWithValue("@dt", (object)d.DateTime ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@r", d.Reason);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}