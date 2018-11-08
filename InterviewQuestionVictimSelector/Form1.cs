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
        public Form1()
        {
            InitializeComponent();
            cmd.CommandType = CommandType.StoredProcedure;
            populateNamePool();
            resetQuestionPool();
            populateSelectQuestion();
            populateSelectName();
        }

        private static SqlConnection conn = new SqlConnection("Data Source=THINKPAD-P71;Initial Catalog=VictimSelector;Integrated Security=True");
        private static SqlCommand cmd = conn.CreateCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        private static DataTable table = new DataTable();
        private static Random rnd = new Random();

        private List<List<string>> questionList = new List<List<string>>();
        private List<List<string>> nameList = new List<List<string>>();

        // Fills the ListView namePool with the names of the students.
        public void populateNamePool()
        {
            cmd.CommandText = "GET_NOTSELECTED_STUDENTS";
            ExecuteNonQuery();
            adapter.Fill(table);
            List<List<string>> currentRoster = new List<List<string>>();
            int run = 0;
            foreach (DataRow row in table.Rows)
            {
                List<string> currentItem = new List<string>();
                currentItem.Add($"{row["STUDENT_ID"]}");
                currentItem.Add($"{row["FIRST_NAME"]}");
                currentItem.Add($"{row["LAST_NAME"]}");
                currentRoster.Add(currentItem);
                run++;
            }
            table.Clear();
            nameList = currentRoster;
            for (int i = 0; i <= currentRoster.Count - 1; i = i + 1)
            {
                lvNamePool.Items.Add($"{currentRoster[i][1]} " + $"{currentRoster[i][2]}");
            }
        }

        // Resets te question list.
        private void resetQuestionPool()
        {
            cmd.CommandText = "GET_NOTSELECTED_QUESTIONS";
            ExecuteNonQuery();
            adapter.Fill(table);
            List<List<string>> questions = new List<List<string>>();
            foreach (DataRow row in table.Rows)
            {
                List<string> currentItem = new List<string>();
                currentItem.Add($"{row["QUESTION_ID"]}");
                currentItem.Add($"{row["QUESTION"]}");
                questions.Add(currentItem);
            }
            table.Clear();
            questionList = questions;
        }

        // Randomly selects a student (from the namePool) and a questions (from the question list).
        private void select_Click(object sender, EventArgs e)
        {
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
                Reset_SELECTED_Status("RESET_SELECTED_STUDENTS");
                populateNamePool();
            }
            if (countQuestions == 1)
            {
                Reset_SELECTED_Status("RESET_SELECTED_QUESTIONS");
                resetQuestionPool();
            }
        }

        // Updates the SELECTED field of the Students table in the database
        private void UpdateStudentSelected(int i)
        {
            cmd.CommandText = "UPDATE_STUDENTS";
            cmd.Parameters.Add("@STUDENT_ID", SqlDbType.BigInt).Value = Int64.Parse(nameList[i][0]);
            cmd.Parameters.Add("@FIRST_NAME", SqlDbType.VarChar).Value = nameList[i][1];
            cmd.Parameters.Add("@LAST_NAME", SqlDbType.VarChar).Value = nameList[i][2];
            cmd.Parameters.Add("@SELECTED", SqlDbType.Bit).Value = 1;
            ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        // Updates the SELECTED field of the Questions table in the database 
        private void UpdateQuestionSelected(int i)
        {
            cmd.CommandText = "UPDATE_QUESTIONS";
            cmd.Parameters.Add("@QUESTION_ID", SqlDbType.BigInt).Value = Int64.Parse(questionList[i][0]);
            cmd.Parameters.Add("@QUESTION", SqlDbType.VarChar).Value = questionList[i][1];
            cmd.Parameters.Add("@SELECTED", SqlDbType.Bit).Value = 1;
            ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        // Resets the value of SELECTED field of the appropriate table in the database
        private void Reset_SELECTED_Status(string commandText)
        {
            cmd.CommandText = commandText;
            ExecuteNonQuery();
        }

        // Creates the list of questions in the cmbSelectQuestion dropdown menu.
        private void populateSelectQuestion()
        {
            List<List<string>> myList = new List<List<string>>();
            cmd.CommandText = "GET_QUESTIONS";
            ExecuteNonQuery();
            adapter.Fill(table);
            List<List<string>> questions = new List<List<string>>();
            foreach (DataRow row in table.Rows)
            {
                List<string> currentItem = new List<string>();
                currentItem.Add($"{row["QUESTION_ID"]}");
                currentItem.Add($"{row["QUESTION"]}");
                questions.Add(currentItem);
            }
            table.Clear();
            myList = questions;

            // populates the cmbSelectQuestion dropdown menu
            for (int i = 0; i <= myList.Count() - 1; i = i + 1)
            {
                cmbSelectQuestion.Items.Add(myList[i][1]);
            }
        }

        // Creates the list of names in the cmbSelectName dropdown menu.
        private void populateSelectName()
        {

            List < List<string> >myList = new List<List<string>>();
            cmd.CommandText = "GET_STUDENTS";
            ExecuteNonQuery();
            adapter.Fill(table);
            List<List<string>> currentRoster = new List<List<string>>();
            int run = 0;
            foreach (DataRow row in table.Rows)
            {
                List<string> currentItem = new List<string>();
                currentItem.Add($"{row["STUDENT_ID"]}");
                currentItem.Add($"{row["FIRST_NAME"]}");
                currentItem.Add($"{row["LAST_NAME"]}");
                currentRoster.Add(currentItem);
                run++;
            }
            table.Clear();
            myList = currentRoster;
            for (int i = 0; i <= myList.Count() - 1; i = i + 1)
            {
                cmbSelectName.Items.Add($"{myList[i][1]} " + $"{myList[i][2]}");
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
            cmd.CommandText = "INSERT_QUESTION";
            cmd.Parameters.Add("@QUESTION", SqlDbType.VarChar).Value = txtSelectedQuestion.Text;
            cmd.Parameters.Add("@SELECTED", SqlDbType.Bit).Value = 0;
            ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        // Inserts a new record in the STUDENTS table of the database
        private void btnAddName_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT_STUDENT";
            cmd.Parameters.Add("@FIRST_NAME", SqlDbType.VarChar).Value = txtFirstName.Text;
            cmd.Parameters.Add("@LAST_NAME", SqlDbType.VarChar).Value = txtLastName.Text;
            cmd.Parameters.Add("@SELECTED", SqlDbType.Bit).Value = 0;
            ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void ExecuteNonQuery()
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
