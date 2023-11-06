using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lab02
{
    public partial class MainForm : Form
    {
        private List<Student> _stlist;
        private List<Teacher> _tlist;

        public MainForm()
        {
            InitializeComponent();
            _stlist = new List<Student>();
            _tlist = new List<Teacher>();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            try
            {
                string[] linesStudents = File.ReadAllLines("C:\\Users\\gtvgv\\source\\repos\\Lab01\\Lab02\\list.txt");
                // StLastName, StFirstName, Grade, Classroom, Bus
                // COOKUS, XUAN, 3, 107, 52

                foreach (string line in linesStudents)
                {
                    string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    Student student = new Student()
                    {
                        StLastName = data[0],
                        StFirstName = data[1],
                        Grade = int.Parse(data[2]),
                        Classroom = int.Parse(data[3]),
                        Bus = int.Parse(data[4])
                    };
                    _stlist.Add(student);
                }

                string[] linesTeachers = File.ReadAllLines("C:\\Users\\gtvgv\\source\\repos\\Lab01\\Lab02\\teachers.txt");
                // TLastName, TFirstName, Classroom
                // FAFARD, ROCIO, 107

                foreach (string line in linesTeachers)
                {
                    string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    Teacher teacher = new Teacher()
                    {
                        TLastName = data[0],
                        TFirstName = data[1],
                        Classroom = int.Parse(data[2]),
                    };
                    _tlist.Add(teacher);
                }
                clock.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "";
            string? StudentSurname = StSurname.Text.Trim();
            Stopwatch clock = new Stopwatch();
            clock.Start();

            foreach (var item in _stlist)
                if (item.StLastName == StudentSurname)
                {
                    result.Text += item.ToStringStudent();
                    foreach (var item2 in _tlist)
                        if (item2.Classroom == item.Classroom)
                            result.Text += "  " + item2.ToStringTeacher();
                    result.Text += "************************************" + Environment.NewLine;
                }

            clock.Stop();
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = "";
            string? StudentSurname = StSurname2.Text.Trim();
            Stopwatch clock = new Stopwatch();
            clock.Start();

            foreach (var item in _stlist)
                if (item.StLastName == StudentSurname)
                    result.Text += item.ToStringStudentBus();

            clock.Stop();
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = "";
            string? TeacherSurname = TSurname.Text.Trim();
            Stopwatch clock = new Stopwatch();
            clock.Start();

            foreach (var item in _tlist)
                if (item.TLastName == TeacherSurname)
                {
                    result.Text += item.ToStringTeacher();

                    foreach (var item2 in _stlist)
                        if (item.Classroom == item2.Classroom)
                            result.Text += "  " + item2.ToStringStudent();

                    result.Text += "************************************" + Environment.NewLine;
                }

            clock.Stop();
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int BusNum = Convert.ToInt32(BusNumber.Text.Trim());
            Stopwatch clock = new Stopwatch();
            clock.Start();

            foreach (var item in _stlist)
                if (item.Bus == BusNum)
                    result.Text += item.ToStringStudentsByBus();

            clock.Stop();
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int Grade = Convert.ToInt32(GradeTB.Text.Trim());
            Stopwatch clock = new Stopwatch();
            clock.Start();

            foreach (var item in _stlist)
                if (item.Grade == Grade)
                    result.Text += item.ToStringStudent();

            clock.Stop();
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int Classroom = Convert.ToInt32(classroomTBTeach.Text.Trim());
            Stopwatch clock = new Stopwatch();
            clock.Start();

            foreach (var item in _tlist)
                if (item.Classroom == Classroom)
                    result.Text += item.ToStringTeacher();

            clock.Stop();
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int Grade = Convert.ToInt32(gradeTBTeach.Text.Trim());
            Stopwatch clock = new Stopwatch();
            clock.Start();

            foreach (var item in _stlist)
                if (item.Grade == Grade)
                {
                    foreach (var item2 in _tlist)
                        if (item.Classroom == item2.Classroom)
                            result.Text += "  " + item2.ToStringTeacher();

                    result.Text += "************************************" + Environment.NewLine;
                }

            clock.Stop();
            statusStrip1.Items[1].Text = Convert.ToString(clock.Elapsed);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Закрити програму?", "Обдумайте ваше рішення", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
                e.Cancel = true; //Вихід

        }
    }
}