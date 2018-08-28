using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterviewQuestionVictimSelector
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=THINKPAD-P71;Initial Catalog=VictimSelector;Integrated Security=True");
        List<List<string>> questionList = new List<List<string>>();
        List<List<string>> nameList = new List<List<string>>();
        public Form1() 
        {
            InitializeComponent();
            populateNamePool();
            resetQuestionPool();
            populateSelectQuestion(questionList);
            populateSelectName(nameList);
        }
        // Fills the ListView namePool with the names of the students.
        public void populateNamePool()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GET_NOTSELECTED_STUDENTS";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            sqlConnection.Close();
            List<List<string>> currentRoster = new List<List<string>>();
            int run = 0;
            foreach (DataRow row in dt.Rows)
            {
                List<string> currentItem = new List<string>();
                currentItem.Add($"{row["STUDENT_ID"]}");
                currentItem.Add($"{row["FIRST_NAME"]}");
                currentItem.Add($"{row["LAST_NAME"]}");
                currentRoster.Add(currentItem);
                run++;
            }
            nameList = currentRoster;
            for (int i = 0; i <= currentRoster.Count - 1; i = i + 1)
            {
                lvNamePool.Items.Add($"{currentRoster[i][1]} " + $"{currentRoster[i][2]}");
            }
        }

        // Resets te question list.
        private void resetQuestionPool()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "GET_NOTSELECTED_QUESTIONS";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            sqlConnection.Close();
            List<List<string>> questions = new List<List<string>>();
            foreach (DataRow row in dt.Rows)
            {
                List<string> currentItem = new List<string>();
                currentItem.Add($"{row["QUESTION_ID"]}");
                currentItem.Add($"{row["QUESTION"]}");
                questions.Add(currentItem);
            }
            questionList = questions;
        }

        // Randomly selects a student (from the namePool) and a questions (from the question list).
        private void select_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int countQuestions = questionList.Count;
            int i = rnd.Next(countQuestions);
            lblQuestionBox.Text = questionList[i][1];
            // Marks selected question as SELECTED in database
            UpdateQuestionSelected(i);
            // Deletes selected question from questionList
            questionList.Remove(questionList[i]);

            int countNames = lvNamePool.Items.Count;
            int j = rnd.Next(countNames);
            lblCurrentVictim.Text = lvNamePool.Items[j].Text;
            // Marks selected name as SELECTED in database
            UpdateStudentSelected(j);
            // Deletes the selected name from nameList
            nameList.Remove(nameList[j]);
            // Deletes selectedd Name from the pool
            lvNamePool.Items[j].Remove();

            if (countNames == 1)
            {
                Reset_Students_SELECTED_Status();
                populateNamePool();
            }
            if (countQuestions == 1)
            {
                Reset_Questions_SELECTED_Status();
                resetQuestionPool();
            }
        }

        private void Reset_Questions_SELECTED_Status()
        {
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "RESET_SELECTED_QUESTIONS";
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void Reset_Students_SELECTED_Status()
        {
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "RESET_SELECTED_STUDENTS";
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void UpdateStudentSelected(int i)
        {
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UPDATE_STUDENTS";
            cmd.Parameters.Add("@STUDENT_ID", SqlDbType.BigInt).Value = Int64.Parse(nameList[i][0]);
            cmd.Parameters.Add("@FIRST_NAME", SqlDbType.VarChar).Value = nameList[i][1];
            cmd.Parameters.Add("@LAST_NAME", SqlDbType.VarChar).Value = nameList[i][2];
            cmd.Parameters.Add("@SELECTED", SqlDbType.Bit).Value = 1;
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void UpdateQuestionSelected(int i)
        {
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UPDATE_QUESTION";
            cmd.Parameters.Add("@QUESTION_ID", SqlDbType.BigInt).Value = Int64.Parse(questionList[i][0]);
            cmd.Parameters.Add("@QUESTION", SqlDbType.VarChar).Value = questionList[i][1];
            cmd.Parameters.Add("@SELECTED", SqlDbType.Bit).Value = 1;
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        // Creates the list of questions in the cmbSelectQuestion dropdown menu.
        private void populateSelectQuestion(List<List<string>> questionList)
        {
            for (int i = 0; i <= questionList.Count() - 1; i = i + 1)
            {
                cmbSelectQuestion.Items.Add(questionList[i][1]);
            }
        }

        // Creates the list of names in the cmbSelectName dropdown menu.
        private void populateSelectName(List<List<string>> nameList)
        {
            for (int i = 0; i <= nameList.Count() - 1; i = i + 1)
            {
                cmbSelectName.Items.Add(nameList[i][1]);
            }
        }

        // Copies the selected question into the txtSelectedQuestion textbox to be edited.
        private void cmbSelectQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectedQuestion.Text = cmbSelectQuestion.GetItemText(cmbSelectQuestion.SelectedItem);
        }

        // Copies the selected first and last names into their respective textboxes to be edited.
        private void cmbSelectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fullName = cmbSelectName.GetItemText(cmbSelectName.SelectedItem);
            string[] names = fullName.Split(' ');
            txtFirstName.Text = names[0];
            txtLastName.Text = names[1];
        }

        // Inserts a new record in the QUESTIONS table of the database.
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "INSERT_QUESTION";
            cmd.Parameters.Add("@QUESTION", SqlDbType.VarChar).Value = txtSelectedQuestion.Text;
            cmd.Parameters.Add("@SELECTED", SqlDbType.Bit).Value = 0;
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        // Inserts a new record in the STUDENTS table of the database
        private void btnAddName_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "INSERT_STUDENT";
            cmd.Parameters.Add("@FIRST_NAME", SqlDbType.VarChar).Value = txtFirstName.Text;
            cmd.Parameters.Add("@LAST_NAME", SqlDbType.VarChar).Value = txtLastName.Text;
            cmd.Parameters.Add("@SELECTED", SqlDbType.Bit).Value = 0;
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}
