using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1
{
    public partial class AdminForm : Form
    {
        Login loginPage;
        ExaminationSysEntities Ent;
        // Course Topics
        string Id;
        string name;
        //Exam
        List<GroupBox> Groupsbox = new List<GroupBox>();
        int iteratorOfQ = 0;
        public AdminForm()
        {
            InitializeComponent();
            Ent = new ExaminationSysEntities();
        }
        public AdminForm(Login login)
        {
            InitializeComponent();
            loginPage = login;
            Ent = new ExaminationSysEntities();
            foreach (Course course in Ent.Courses)
            {
                CourseIdOfExam.Items.Add(course.Course_Id + ":" + course.Course_Name.ToString());
            };
            foreach (Instructor instructor in Ent.Instructors)
            {
                instructorIDofExam.Items.Add(instructor.Ins_ID.ToString() + ":" + instructor.Ins_Name.ToString());
            };
            NextQbutton.Visible = false;
            prevQ.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TabsSizes();
            //Student Tab
            var students = Ent.SelectAllStudentsIDs();
            foreach (var student in students)
            {
                ShowStudentcomboBox.Items.Add(student);
                EditStudentcomboBox.Items.Add(student);
                E_St_LeadercomboBox.Items.Add(student);
            }
            //Instructor Tab
            var instructors = Ent.SelectAllInstructorsIDs();
            foreach (var i in instructors)
            {
                ViewInstructor.Items.Add(i);
                EditInstructorcomboBox.Items.Add(i);
            }
            //Track Tab
            FillComboBoxesWithTracks();
            //Course Tab
            var AllCourses = Ent.course_select(null, null);
            foreach(var C in AllCourses)
            {
                d_crs_id.Items.Add(C.Course_Id.ToString() + " " + C.Course_Name);
                crsBox.Items.Add(C.Course_Id.ToString() + " " + C.Course_Name);
            }
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
            this.reportViewer7.RefreshReport();
        }
        #region Student
        private void ShowStudentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            V_StIDtextBox.Text = ShowStudentcomboBox.Text;
            V_StNametextBox.Text = Ent.SelectStudentById(int.Parse(V_StIDtextBox.Text)).First().Std_Name;
            V_StAgetextBox.Text = Ent.SelectStudentById(int.Parse(V_StIDtextBox.Text)).First().Std_Age.ToString();
            V_StEmailtextBox.Text = Ent.SelectStudentById(int.Parse(V_StIDtextBox.Text)).First().Std_Email;
            V_StUsernametextBox.Text = Ent.SelectStudentById(int.Parse(V_StIDtextBox.Text)).First().Std_UserName;
            V_TrackIDtextBox.Text = Ent.SelectStudentById(int.Parse(V_StIDtextBox.Text)).First().Track_Id.ToString();
            V_LeaderIDtextBox.Text = Ent.SelectStudentById(int.Parse(V_StIDtextBox.Text)).First().Leader_ID.ToString();
            V_TrackNametextBox.Text = Ent.SelectFromTrack(int.Parse(V_TrackIDtextBox.Text)).First().Track_Name;
            V_LeaderNametextBox.Text = Ent.SelectStudentById(int.Parse(V_LeaderIDtextBox.Text)).First().Std_Name;
            //V_StIDtextBox.ReadOnly = V_StNametextBox.ReadOnly = V_StAgetextBox.ReadOnly = V_StEmailtextBox.ReadOnly = V_StUsernametextBox.ReadOnly = V_TrackIDtextBox.ReadOnly = V_LeaderIDtextBox.ReadOnly = V_TrackNametextBox.ReadOnly = V_LeaderNametextBox.ReadOnly = true;
        }
        private void EditStudentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //E_St_ID.ReadOnly = true;
            E_St_ID.Text = EditStudentcomboBox.Text;
            E_St_Name.Text = Ent.SelectStudentById(int.Parse(E_St_ID.Text)).First().Std_Name;
            E_St_Age.Text = Ent.SelectStudentById(int.Parse(E_St_ID.Text)).First().Std_Age.ToString();
            E_St_Email.Text = Ent.SelectStudentById(int.Parse(E_St_ID.Text)).First().Std_Email;
            E_St_UName.Text = Ent.SelectStudentById(int.Parse(E_St_ID.Text)).First().Std_UserName;
            //E_St_Track.Text = Ent.SelectStudentById(int.Parse(E_St_ID.Text)).First().Track_Id.ToString();
            //E_St_Leader.Text = Ent.SelectStudentById(int.Parse(E_St_ID.Text)).First().Leader_ID.ToString();
            E_St_TrackcomboBox.Text = Ent.SelectStudentById(int.Parse(E_St_ID.Text)).First().Track_Id.ToString();
            E_St_Track.Text = Ent.SelectFromTrack(int.Parse(E_St_TrackcomboBox.Text)).First().Track_Name;
            E_St_LeadercomboBox.Text = Ent.SelectStudentById(int.Parse(E_St_ID.Text)).First().Leader_ID.ToString();
            E_St_Leader.Text = Ent.SelectStudentById(int.Parse(E_St_LeadercomboBox.Text)).First().Std_Name;
            E_St_Track.ReadOnly = E_St_Leader.ReadOnly = true;
        }
        private void E_St_TrackcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            E_St_Track.Text = Ent.SelectFromTrack(int.Parse(E_St_TrackcomboBox.Text)).First().Track_Name;
        }
        private void E_St_LeadercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            E_St_Leader.Text = Ent.SelectStudentById(int.Parse(E_St_LeadercomboBox.Text)).First().Std_Name;
        }
        private void Add_St_Click(object sender, EventArgs e)
        {
            if (E_St_ID.Text == "" || E_St_Name.Text == "" || E_St_Age.Text == "" || E_St_Email.Text == "" || E_St_UName.Text == "" || E_St_Pass.Text == "" || E_St_Track.Text == "" || E_St_Leader.Text == "")
            {
                MessageBox.Show("Some data fields are empty");
            }
            else
            {
                Student std = Ent.Students.Find(int.Parse(E_St_ID.Text));
                if (std != null)
                {
                    MessageBox.Show("Can't add this student, it's already exists");
                    E_St_ID.Text = E_St_Name.Text = E_St_Age.Text = E_St_Email.Text = E_St_UName.Text = E_St_Pass.Text = E_St_Track.Text = E_St_Leader.Text = string.Empty;
                }
                else
                {
                    Student stdsup = Ent.Students.Find(int.Parse(E_St_LeadercomboBox.Text));
                    Track tr = Ent.Tracks.Find(int.Parse(E_St_TrackcomboBox.Text));
                    if (stdsup == null || tr == null)
                    {
                        MessageBox.Show("Data is not compatible");
                        E_St_ID.Text = E_St_Name.Text = E_St_Age.Text = E_St_Email.Text = E_St_UName.Text = E_St_Pass.Text = E_St_Track.Text = E_St_Leader.Text = string.Empty;
                    }
                    else
                    {
                        string Password = Ent.ComputeSha256Hash(E_St_Pass.Text);
                        Ent.InsertStudentData(int.Parse(E_St_ID.Text), E_St_Email.Text, E_St_UName.Text, Password, E_St_Name.Text, int.Parse(E_St_Age.Text), int.Parse(E_St_TrackcomboBox.Text), int.Parse(E_St_LeadercomboBox.Text));
                        MessageBox.Show("Student added to database successfully");
                        EditStudentcomboBox.Text = E_St_ID.Text = E_St_Name.Text = E_St_Age.Text = E_St_Email.Text = E_St_UName.Text = E_St_Pass.Text = E_St_Track.Text = E_St_Leader.Text = E_St_TrackcomboBox.Text = E_St_LeadercomboBox.Text = string.Empty;
                    }
                }
            }
        }
        private void Edit_St_Click(object sender, EventArgs e)
        {
            if (E_St_ID.Text == "" || E_St_Name.Text == "" || E_St_Age.Text == "" || E_St_Email.Text == "" || E_St_UName.Text == "" || E_St_Track.Text == "" || E_St_Leader.Text == "" || EditStudentcomboBox.Text == "")
            {
                MessageBox.Show("Some data fields are empty");
            }
            else
            {
                Student std = Ent.Students.Find(int.Parse(E_St_ID.Text));
                if (std == null || std.Std_ID != int.Parse(EditStudentcomboBox.Text))
                {
                    MessageBox.Show("Can't change ID of student");
                    E_St_ID.Text = EditStudentcomboBox.Text;
                }
                else
                {
                    Student stdsup = Ent.Students.Find(int.Parse(E_St_LeadercomboBox.Text));
                    Track tr = Ent.Tracks.Find(int.Parse(E_St_TrackcomboBox.Text));
                    if (stdsup == null || tr == null)
                    {
                        MessageBox.Show("Data is not compatible");
                        E_St_Name.Text = E_St_Age.Text = E_St_Email.Text = E_St_UName.Text = E_St_Track.Text = E_St_Leader.Text = string.Empty;
                    }
                    else
                    {
                        Ent.UpdateStudentData(int.Parse(E_St_ID.Text), E_St_Email.Text, E_St_UName.Text, E_St_Name.Text, int.Parse(E_St_Age.Text), int.Parse(E_St_TrackcomboBox.Text), int.Parse(E_St_LeadercomboBox.Text));
                        MessageBox.Show("Student with ID = " + E_St_ID.Text + " is updated successfully");
                        ShowStudentcomboBox.Text = V_StIDtextBox.Text = V_StNametextBox.Text = V_StAgetextBox.Text = V_StEmailtextBox.Text = V_StUsernametextBox.Text = V_TrackIDtextBox.Text = V_TrackNametextBox.Text = V_LeaderIDtextBox.Text = V_LeaderNametextBox.Text = string.Empty;
                        EditStudentcomboBox.Text = E_St_ID.Text = E_St_Name.Text = E_St_Age.Text = E_St_Email.Text = E_St_UName.Text = E_St_Pass.Text = E_St_Track.Text = E_St_Leader.Text = E_St_TrackcomboBox.Text = E_St_LeadercomboBox.Text = string.Empty;
                    }
                }
            }
            if (E_St_Pass.Text != "")
            {
                string Password = Ent.ComputeSha256Hash(E_St_Pass.Text);
                Ent.UpdateStudentPassword(int.Parse(E_St_ID.Text), Password);
            }
            E_St_ID.Text = E_St_Pass.Text = string.Empty;
        }
        private void Delete_St_Click(object sender, EventArgs e)
        {
            if (E_St_ID.Text == "")
            {
                MessageBox.Show("Please enter ID of the student you want to delete");
            }
            else
            {
                Student std = Ent.Students.Find(int.Parse(E_St_ID.Text));
                if (std == null)
                {
                    MessageBox.Show("Please enter a valid student ID");
                    E_St_ID.Text = "";
                }
                else
                {
                    Ent.DeleteStudent(int.Parse(E_St_ID.Text));
                    MessageBox.Show("Data of student with ID = " + E_St_ID.Text + " is deleted successfully");
                    EditStudentcomboBox.Text = E_St_ID.Text = E_St_Name.Text = E_St_Age.Text = E_St_Email.Text = E_St_UName.Text = E_St_Pass.Text = E_St_Track.Text = E_St_Leader.Text = string.Empty;
                    ShowStudentcomboBox.Text = V_StIDtextBox.Text = V_StNametextBox.Text = V_StAgetextBox.Text = V_StEmailtextBox.Text = V_StUsernametextBox.Text = V_TrackIDtextBox.Text = V_TrackNametextBox.Text = V_LeaderIDtextBox.Text = V_LeaderNametextBox.Text = string.Empty;
                    ShowStudentcomboBox.Items.Clear();
                    EditStudentcomboBox.Items.Clear();
                    E_St_LeadercomboBox.Items.Clear();
                    var students = Ent.SelectAllStudentsIDs();
                    foreach (var student in students)
                    {
                        ShowStudentcomboBox.Items.Add(student);
                        EditStudentcomboBox.Items.Add(student);
                        E_St_LeadercomboBox.Items.Add(student);
                    }

                }
            }
        }

        #endregion

        #region Instructor
        private void EditInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            E_Ins_ID.Text = EditInstructorcomboBox.Text;
            E_Ins_Name.Text = Ent.SelectInstructor(int.Parse(E_Ins_ID.Text)).First().Ins_Name;
            E_Ins_Email.Text = Ent.SelectInstructor(int.Parse(E_Ins_ID.Text)).First().Ins_Email;
            E_Ins_UName.Text = Ent.SelectInstructor(int.Parse(E_Ins_ID.Text)).First().Ins_UserName;
            //E_Ins_ID.ReadOnly = true;
        }
        private void AddInst_Click(object sender, EventArgs e)
        {
            if (E_Ins_ID.Text == "" || E_Ins_Name.Text == "" || E_Ins_Email.Text == "" || E_Ins_UName.Text == "" || E_Ins_Pass.Text == "")
            {
                MessageBox.Show("Some data fields are empty");
            }
            else
            {
                Instructor ins = Ent.Instructors.Find(int.Parse(E_Ins_ID.Text));
                if (ins != null)
                {
                    MessageBox.Show("Can't add this instructor, it's already exists");
                    E_Ins_Name.Text = E_Ins_Email.Text = E_Ins_UName.Text = E_Ins_Pass.Text = E_Ins_ID.Text = string.Empty;
                }
                else
                {
                    string Password = Ent.ComputeSha256Hash(E_Ins_Pass.Text);
                    Ent.InsertInstructor(int.Parse(E_Ins_ID.Text), E_Ins_UName.Text, Password, E_Ins_Name.Text, E_Ins_Email.Text);
                    MessageBox.Show("Instructor added to database successfully");
                }
            }
        }
        private void ChangeInst_Click(object sender, EventArgs e)
        {
            if (E_Ins_ID.Text == "" || E_Ins_Name.Text == "" || E_Ins_Email.Text == "" || E_Ins_UName.Text == "")
            {
                MessageBox.Show("Some data fields are empty");
            }
            else
            {
                Instructor ins = Ent.Instructors.Find(int.Parse(E_Ins_ID.Text));
                if (ins == null || ins.Ins_ID != int.Parse(EditInstructorcomboBox.Text))
                {
                    MessageBox.Show("Can't change ID of Instructor");
                    E_Ins_ID.Text = EditInstructorcomboBox.Text;
                }
                else
                {
                    Ent.UpdateInstructor(int.Parse(E_Ins_ID.Text), E_Ins_UName.Text, E_Ins_Name.Text, E_Ins_Email.Text);
                    MessageBox.Show("Instructor with ID = " + E_Ins_ID.Text + " is updated successfully");
                    ViewInstructor.Text = V_Ins_ID.Text = V_Ins_Name.Text = V_Ins_Email.Text = V_Ins_UName.Text = V_Ins_Pass.Text = string.Empty;
                }
            }
            if (E_Ins_Pass.Text != "")
            {
                string Password = Ent.ComputeSha256Hash(E_Ins_Pass.Text);
                Ent.UpdateInstructorPassword(int.Parse(E_Ins_ID.Text), Password);
            }
            E_Ins_ID.Text = E_Ins_Name.Text = E_Ins_Email.Text = E_Ins_UName.Text = E_Ins_Pass.Text = string.Empty;
        }
        private void DeleteInst_Click(object sender, EventArgs e)
        {
            if (E_Ins_ID.Text == "")
            {
                MessageBox.Show("Please enter ID of the instructor you want to delete");
            }
            else
            {
                Instructor ins = Ent.Instructors.Find(int.Parse(E_Ins_ID.Text));
                if (ins == null)
                {
                    MessageBox.Show("Please enter a valid instructor ID");
                    E_Ins_ID.Text = "";
                }
                else
                {
                    Ent.DeleteInstructor(int.Parse(E_Ins_ID.Text));
                    MessageBox.Show("Data of instructor with ID = " + E_Ins_ID.Text + " is deleted successfully");
                    EditInstructorcomboBox.Text = E_Ins_Name.Text = E_Ins_Email.Text = E_Ins_UName.Text = E_Ins_Pass.Text = E_Ins_ID.Text = string.Empty;
                    ViewInstructor.Text = V_Ins_ID.Text = V_Ins_Name.Text = V_Ins_Email.Text = V_Ins_UName.Text = V_Ins_Pass.Text = string.Empty;

                    ViewInstructor.Items.Clear();
                    EditInstructorcomboBox.Items.Clear();
                    var instructors = Ent.SelectAllInstructorsIDs();
                    foreach (var i in instructors)
                    {
                        ViewInstructor.Items.Add(i);
                        EditInstructorcomboBox.Items.Add(i);
                    }
                }
            }
        }
        private void ViewInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            V_Ins_ID.Text = ViewInstructor.Text;
            V_Ins_Name.Text = Ent.SelectInstructor(int.Parse(V_Ins_ID.Text)).First().Ins_Name;
            V_Ins_Email.Text = Ent.SelectInstructor(int.Parse(V_Ins_ID.Text)).First().Ins_Email;
            V_Ins_UName.Text = Ent.SelectInstructor(int.Parse(V_Ins_ID.Text)).First().Ins_UserName;
            V_Ins_Pass.Text = Ent.SelectInstructor(int.Parse(V_Ins_ID.Text)).First().Ins_Password;
        }

        #endregion

        #region Courses
        private void ADD_button_Click(object sender, EventArgs e)
        {
            int course_id = int.Parse(crs_id.Text);
            string course_name = crs_name.Text;
            Ent.course_insert(course_id, course_name);
        }
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (d_crs_id.Text == "")
            {
                MessageBox.Show("Please Select Course");
            }
            else
            {
                int course_id = int.Parse(d_crs_id.Text.Split(' ')[0]);
                Ent.course_delete(course_id, null);
            }
        }
        #region Topic
        private void CrsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(crsBox.Text.Split(' ')[0]);
            var T = from t in Ent.Topics where (t.Course_Id == id) select t.Topic_Name;
            foreach (var topic in T)
            {
                ItemsLlistBox.Items.Add(topic);
            }
        }
        private void ItemsLlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsLlistBox.SelectedIndex>=0)
            {
                txttopname.Text = ItemsLlistBox.SelectedItem.ToString();
            }
        }
        private void Rmvbtntop_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(crsBox.Text.Split(' ')[0]);
                if (txttopname.Text != "" && crsBox.Text != "")
                {
                    Ent.DeleteTopic(txttopname.Text, id);
                    MessageBox.Show("Deleted successfully");
                    ItemsLlistBox.Items.Remove(txttopname.Text);
                    txttopname.Text = "";
                }
                else
                {
                    MessageBox.Show("Please complete your data");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This topic dosen't exist");
            }
        }

        private void TopAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(crsBox.Text.Split(' ')[0]);
                if (txttopname.Text != "" && crsBox.Text != "")
                {
                    Ent.Insert_Topic(txttopname.Text, id);
                    MessageBox.Show("your Data is saved");
                    ItemsLlistBox.Items.Add(txttopname.Text);
                    txttopname.Text = "";
                }
                else
                {
                    MessageBox.Show("Please complete your data");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This topic already exists");
                txttopname.Text = "";
            }
        }

        #endregion
        #endregion

        #region Track 
        public void FillComboBoxesWithTracks()
        {
            CoursesListBox.Items.Clear();
            TrackComboBox.Items.Clear();
            TrackComboBox2.Items.Clear();
            E_St_TrackcomboBox.Items.Clear();
            var AllTracks = Ent.SelectFromTrack(null);
            foreach (var Track in AllTracks)
            {
                TrackComboBox.Items.Add(Track.Track_Id.ToString());
                TrackComboBox2.Items.Add(Track.Track_Id.ToString());
                E_St_TrackcomboBox.Items.Add(Track.Track_Id.ToString());
            }
        }
        private void TrackComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(TrackComboBox.Text);
            var Track = Ent.SelectFromTrack(id).First();
            TrackNameTextBox.Text = Track.Track_Name;
            SuperIDTextBox.Text = Track.Super_ID.ToString();
            SuperNameTextBox.Text = Track.Supervisor;
            var TrackCourses = Ent.SelectTrackCourses(id);
            CoursesListBox.Items.Clear();
            foreach (var Course in TrackCourses)
            {
                CoursesListBox.Items.Add(Course.ToString());
            }
        }
        private void TrackComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(TrackComboBox2.Text);
            var Track = Ent.SelectFromTrack(id).First();
            TrackIDTextBox.Text = Track.Track_Id.ToString();
            TrackNameTextBox2.Text = Track.Track_Name;
            SuperIDTextBox2.Text = Track.Super_ID.ToString();
            TrackIDTextBox.Enabled = false;
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TrackIDTextBox.Enabled = true;
            TrackIDTextBox.Text = TrackNameTextBox2.Text = SuperIDTextBox2.Text = TrackComboBox2.Text = string.Empty;
        }
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TrackIDTextBox.Text != "" && TrackNameTextBox2.Text != "" && SuperIDTextBox2.Text != "")
                {
                    int Response = (int)Ent.InsertIntoTrack(int.Parse(TrackIDTextBox.Text), TrackNameTextBox2.Text, int.Parse(SuperIDTextBox2.Text)).First();
                    if (Response == 0)
                    {
                        MessageBox.Show("Duplicated ID");
                    }
                    else if (Response == 1)
                    {
                        FillComboBoxesWithTracks();
                        TrackNameTextBox.Text = SuperIDTextBox.Text = TrackComboBox.Text = SuperNameTextBox.Text = string.Empty;
                        TrackIDTextBox.Text = TrackNameTextBox2.Text = SuperIDTextBox2.Text = TrackComboBox2.Text = string.Empty;
                        MessageBox.Show("Inserted Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("complate all data please");
                }
            }catch(Exception )
            {
                MessageBox.Show("please write the data in correct format");
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TrackIDTextBox.Text != "" && TrackNameTextBox2.Text != "" && SuperIDTextBox2.Text != "")
                {
                    Ent.UpdateTrack(int.Parse(TrackIDTextBox.Text), TrackNameTextBox2.Text, int.Parse(SuperIDTextBox2.Text));
            CoursesListBox.Items.Clear();
            TrackNameTextBox.Text = SuperIDTextBox.Text = TrackComboBox.Text = SuperNameTextBox.Text = string.Empty;
            TrackIDTextBox.Text = TrackNameTextBox2.Text = SuperIDTextBox2.Text = TrackComboBox2.Text = string.Empty;
            MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("complate all data please");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("please write the data in correct format");
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            {
                if (TrackIDTextBox.Text != "" && TrackNameTextBox2.Text != "" && SuperIDTextBox2.Text != "")
                {

                    Ent.DeleteTrack(int.Parse(TrackIDTextBox.Text));
                    FillComboBoxesWithTracks();
                    TrackNameTextBox.Text = SuperIDTextBox.Text = TrackComboBox.Text = SuperNameTextBox.Text = string.Empty;
                    TrackIDTextBox.Text = TrackNameTextBox2.Text = SuperIDTextBox2.Text = TrackComboBox2.Text = string.Empty;
                    MessageBox.Show("Track Deleted");
                }
                else
                {
                    MessageBox.Show("complate all data please");
                }
                }
            
        }
        #endregion

        #region Exam
        private void NextQbutton_Click(object sender, EventArgs e)
        {
            foreach (GroupBox boxIterator in Groupsbox)
            {

                boxIterator.Visible = false;

            }

            Groupsbox[(++iteratorOfQ) % Groupsbox.Count].Visible = true;
        }
        private void GenerateExam_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(mcqSpilt.Text) + int.Parse(T_f_spilt.Text) == 10)
            {
                DateTime Exam_Date = ExamDate.Value;
                string Exam_Time = ExamTime.Value.TimeOfDay.ToString();
                Ent.GenerateExam(int.Parse(IdOfExam.Text), (instructorIDofExam.Text), Exam_Date, Exam_Time, int.Parse(DurationText.Text), (CourseIdOfExam.Text), int.Parse(mcqSpilt.Text), int.Parse(T_f_spilt.Text), Groupsbox, this);
                IdOfExam.Visible = CourseIdOfExam.Visible = ExamDate.Visible = ExamTime.Visible = DurationText.Visible =
                    instructorIDofExam.Visible = mcqSpilt.Visible = T_f_spilt.Visible = ExamId_label.Visible = CourseIdLabel.Visible =
                    label22.Visible = label23.Visible = Duration_label.Visible = instructor_id_label.Visible =
                    label20.Visible = label19.Visible = GenerateExam.Visible = false;
                MessageBox.Show("you added the Exam Succ");
                NextQbutton.Visible = prevQ.Visible = true;
            }
            else
            {
                MessageBox.Show(" number of Q's must be 10");
            }
        }
        private void PrevQ_Click_1(object sender, EventArgs e)
        {
            foreach (GroupBox boxIterator in Groupsbox)
            {

                boxIterator.Visible = false;

            }
            if (iteratorOfQ == 0)
            {
                iteratorOfQ = Groupsbox.Count - 1;
            }
            Groupsbox[(--iteratorOfQ) % Groupsbox.Count].Visible = true;
        }

        #endregion



        private void AdminForm_Resize(object sender, EventArgs e)
        {
            TabsSizes();
        }
        public void TabsSizes()
        {
            Contaunter.Size = tabPage1.Size = tabPage2.Size = tabPage3.Size = tabPage4.Size = this.Size;
            tabControl1.Size = tabControl2.Size = tabControl3.Size = tabControl4.Size = topPage.Size = this.Size;
            Student_tabControl.Size = Exams_tap.Size = ViewStudents.Size = EditStudent.Size = this.Size;
            ShowInstructors.Size = AddInstructor.Size = AddCourse.Size = DeleteCourse.Size = this.Size;
        }

    }
}
