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
        SqlConnection con = new SqlConnection("Data Source=THINKPAD-P71;Initial Catalog=VictimSelector;Integrated Security=True");
        List<string> questionList = new List<string>();
        List<string> nameList = new List<string>();
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
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM STUDENTS_OLD";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            con.Close();
            List<string> currentRoster = new List<string>();
            int run = 0;
            foreach (DataRow row in dt.Rows)
            {
                currentRoster.Add($"{row["FirstName"]} {row["LastName"]}");
                run++;
            }
            nameList = currentRoster;
            for (int i = 0; i <= currentRoster.Count - 1; i = i + 1)
            {
                lvNamePool.Items.Add(currentRoster[i]);
            }
        }
        // Resets te question list.
        private void resetQuestionPool()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM QUESTIONS_OLD";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            con.Close();
            List<string> questions = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                questions.Add($"{row["Question"]}");
            }
            questionList = questions;
        }
        //Randomly selects a student (from the namePool) and a questions (from the question list).
        private void select_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int countQuestions = questionList.Count;
            int i = rnd.Next(countQuestions);
            lblQuestionBox.Text = questionList[i];
            questionList.Remove($"{questionList[i]}");
            int countNames = lvNamePool.Items.Count;
            int j = rnd.Next(countNames);
            lblCurrentVictim.Text = lvNamePool.Items[j].Text;
            lvNamePool.Items[j].Remove();
            if (countNames == 1)
            {
                populateNamePool();
            }
            if (countQuestions == 1)
            {
                resetQuestionPool();
            }
        }
        // Creates the list of questions in the cmbSelectQuestion dropdown menu.
        private void populateSelectQuestion(List<string> questionList)
        {
            for (int i = 0; i <= questionList.Count() - 1; i = i + 1)
            {
                cmbSelectQuestion.Items.Add(questionList[i]);
            }
        }
        // Creates the list of names in the cmbSelectName dropdown menu.
        private void populateSelectName(List<string> nameList)
        {
            for (int i = 0; i <= nameList.Count() - 1; i = i + 1)
            {
                cmbSelectName.Items.Add(nameList[i]);
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
    }
}
