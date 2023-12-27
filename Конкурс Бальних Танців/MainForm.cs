using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Конкурс_Бальних_Танців
{
    public partial class MainForm : Form
    {
        readonly DataContext db = new DataContext("Data Source=.;Initial Catalog=КБТ;Integrated Security=True");
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Отримати список всіх танців
            var dances = (from dance in db.GetTable<Dance>()
                          select dance).ToList();

            // Очистити комбобокс
            selected_dance_box.Items.Clear();
            selectedDanceBoxToChangeDate.Items.Clear();
            selectedDanceBoxToChangeDanceName.Items.Clear();
            selectedForGradeMainDanceBox.Items.Clear();
            selectedForGradeArbitraryDanceBox.Items.Clear();
            // Додати назви танців у комбобокс
            foreach (Dance dance in dances)
            {
                selected_dance_box.Items.Add(dance.dance_name);
                selectedDanceBoxToChangeDate.Items.Add(dance.dance_name);
                selectedDanceBoxToChangeDanceName.Items.Add(dance.dance_name);
                selectedForGradeMainDanceBox.Items.Add(dance.dance_name);
                selectedForGradeArbitraryDanceBox.Items.Add(dance.dance_name);

            }


            // Отримати список всіх категорій суддів
            var categories = (from category in db.GetTable<Judge>()
                            select category).Distinct().ToList();

            // Очистити комбобокс
            judge_category_box.Items.Clear();
            // Додати категорії суддів у комбобокс
            foreach (Judge category in categories)
                judge_category_box.Items.Add(category.judge_category);


            // Отримати список всіх команд
            var team_names = (from team_name in db.GetTable<Pair>()
                              select team_name).Distinct().ToList();
            // Очистити комбобокси
            selectedTeamBox.Items.Clear();
            selected_team_name_box.Items.Clear();

            foreach (Pair team_name in team_names) 
            {
                selected_team_name_box.Items.Add(team_name.team_name);
                selectedTeamBox.Items.Add(team_name.team_name);
            }


            // Отримати список всіх команд
            var Pairs = (from Pair in db.GetTable<Pair>()
                              select Pair).Distinct().ToList();
            foreach (Pair pair in Pairs)
                selectedPairBoxToChangeDate.Items.Add(pair.pairID);
        }
        private void display_past_schedule_Click(object sender, EventArgs e)
        {
            // past_schedule_datePicker - дата
            // Отримати дату виступу 
            DateTime date = (DateTime)past_schedule_datePicker.Value;
            string teamName = selected_team_name_box.SelectedItem.ToString();

            // Отримати список всіх пар
            var selectedPair = (from pair in db.GetTable<Pair>()
                         where pair.team_name == teamName
                         select pair);

            // Отримати список всіх виступів, які відбулися на задану дату
            var perfomances = (from performance in db.GetTable<Performance>()
                                where performance.performance_date == date && performance.pairID == selectedPair.First().pairID
                                select performance).ToList();
            var surnames = (from Dancer in db.GetTable<Dancer>()
                            where Dancer.dancerID == selectedPair.First().dancer1ID
                            select Dancer.dancer_surname).ToString()
                            + " " +
                            (from Dancer in db.GetTable<Dancer>()
                             where Dancer.dancerID == selectedPair.First().dancer2ID
                             select Dancer.dancer_surname).ToString();
             

            // Очистити таблицю результатів
            Results.Rows.Clear();

            // Додати заголовки стовпців
            Results.Columns.Add("time_of_perfomance", "Час виступу");
            Results.Columns.Add("surnames_of_pir", "Прізвища пари");
            Results.Columns.Add("team", "Команда");

            // Для кожної пари
            for (int i = 0; i < perfomances.Count; i++)
            { 
                // Вписати дані в рядок
                var newRow = new DataGridViewRow();
                newRow.CreateCells(Results,new object[] { perfomances[i].performance_time,  surnames, teamName});
            }
        }

        private void show_overall_results_Click(object sender, EventArgs e)
        {
            // Отримати дату виступу 
            DateTime date = (DateTime)past_schedule_datePicker.Value;

            // Очистити таблицю результатів
            Results.Rows.Clear();

            // Додати заголовки стовпців
            Results.Columns.Add("time_of_perfomance", "Час виступу");
            Results.Columns.Add("surnames_of_pir", "Прізвища пари");
            Results.Columns.Add("team", "Команда");
            Results.Columns.Add("grade_of_perf", "Оцінка");

            var pairs = (from Pair in db.GetTable<Pair>()
                                select Pair).ToList();

            string[] surnames = new string[pairs.Count()];

            for (int i = 0; i < pairs.Count(); i++)
                surnames[i] = (from Dancer in db.GetTable<Dancer>()
                                where Dancer.dancerID == pairs.ElementAt(i).dancer1ID
                                select Dancer.dancer_surname).ToString()
                                + " " +
                                (from Dancer in db.GetTable<Dancer>()
                                 where Dancer.dancerID == pairs.ElementAt(i).dancer2ID
                                 select Dancer.dancer_surname).ToString();

            int?[] averageScores = new int?[pairs.Count()];

            // Для кожної пари
            for (int i = 0; i < pairs.Count(); i++)
            {
                // Отримати список всіх виступів для поточної пари
                var performances = (from performance in db.GetTable<Performance>()
                                    where performance.pairID == pairs.ElementAt(i).pairID && performance.performance_date == date
                                    select performance).ToList();

                // Обчислити середню оцінку
                int? averageScore = 0;
                for (int j = 0; j < performances.Count; j++)
                    averageScore += performances[j].grade;
                // Зберегти середню оцінку в масиві
                averageScores[i] = averageScore / performances.Count;

                // Вписати дані в рядок
                var newRow = new DataGridViewRow();
                newRow.CreateCells(Results, new object[] { performances[i].performance_time, surnames[i], pairs[i].team_name, performances[i].grade});
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void selected_team_name_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculate_average_score_Click(object sender, EventArgs e)
        {
            string selectedJudgeCategory = judge_category_box.SelectedItem.ToString();
            string selectedDanceName = selected_dance_box.SelectedItem.ToString();

            var selectedDance = (from Dance in db.GetTable<Dance>()
                                 where Dance.dance_name == selectedDanceName
                                 select Dance.danceID).ToString();
            var selectedJudge = (from Judge in db.GetTable<Judge>()
                                 where Judge.judge_category == selectedJudgeCategory
                                 select Judge.judgeID);

            var perfomances = (from performance in db.GetTable<Performance>()
                               where performance.danceID.ToString() == selectedDance
                               select performance).ToList();

            IQueryable<int?> grades = (from Grade in db.GetTable<Grade>()
                                       where Grade.performanceID == perfomances.ElementAt(0).performanceID
                                       select Grade.gradeAmount);
            for (int i = 1; i < perfomances.Count(); i++)
                grades = grades.Concat(from Grade in db.GetTable<Grade>()
                          where Grade.performanceID == perfomances.ElementAt(i).performanceID
                          select Grade.gradeAmount);

            double? averageGrade = grades.Average();

            // Очистити таблицю результатів
            Results.Rows.Clear();

            // Додати заголовки стовпців
            Results.Columns.Add("dance_name", "Назва танцю");
            Results.Columns.Add("average_score", "Середня оцінка");


            // Вписати дані в рядок
            var newRow = new DataGridViewRow();
            newRow.CreateCells(Results, new object[] { selectedDance, averageGrade});
        }

        private void not_danced_dances_Click(object sender, EventArgs e)
        {
            // Отримати список всіх танців
            var notDancedDancesIds = (from Grade in db.GetTable<Grade>()
                          where Grade.gradeAmount == null
                          select Grade.danceID).ToList();

            List<string> notDancedDancesNames = null;
            for (int i = 0; i < notDancedDancesIds.Count(); i++)
                notDancedDancesNames.Add((from Dance in db.GetTable<Dance>()
                                          where Dance.danceID == notDancedDancesIds[i]
                                          select Dance.dance_name).ToString());



            // Очистити таблицю результатів
            Results.Rows.Clear();

            // Додати заголовки стовпців
            Results.Columns.Add("dance_name", "Назва танцю");
            // Вписати дані в рядок
            for (int i = 1; i < notDancedDancesNames.Count(); i++)
            {
                var newRow = new DataGridViewRow();
                newRow.CreateCells(Results, new object[] { notDancedDancesNames.ElementAt(i) });
            }   
        }

        private void perfomed_dances_Click(object sender, EventArgs e)
        {
            // Отримати дату
            DateTime date = (DateTime)perfomed_dances_datePicker.Value;
            // Створити словник, який буде містити кількість виконань кожного танцю
            var perfomancesForDanceCounts = new Dictionary<int, int>();

            // Отримати список всіх танців, які виконувалися в заданий день
            var danceIDs = (from performance in db.GetTable<Performance>()
                          where performance.performance_date == date
                          select performance.danceID).Distinct().ToList<int>();


            // Для кожного танцю в списку
            foreach (var danceID in danceIDs)
            {
                // Отримати кількість виконань цього танцю
                var count = (from performances in db.GetTable<Performance>()
                             where performances.danceID == danceID && performances.performance_date == date
                            select performances).Count();

                // Додати цю кількість до словника
                perfomancesForDanceCounts[danceID] = count;
            }


            // Відсортувати танці за кількістю виконань
            var sortedDancesIDs = perfomancesForDanceCounts.OrderByDescending(x => x.Value);
            var sortedDancesNames = new Dictionary<int, string>();

            for (int i = 0; i < sortedDancesIDs.Count(); i++)            
                sortedDancesNames[i] = (from Dance in db.GetTable<Dance>()
                                        where Dance.danceID == sortedDancesIDs.ElementAt(i).Value
                                        select Dance.dance_name).ToString();
            


            // Очистити таблицю результатів
            Results.Rows.Clear();

            // Додати заголовки стовпців
            Results.Columns.Add("dance_name", "Назва танцю");
            Results.Columns.Add("count", "Кількість виконань");

            // Вписати дані в таблицю результатів
            foreach (var dance in sortedDancesIDs)
            {
                var newRow = new DataGridViewRow();
                newRow.CreateCells(Results, new object[] { dance.Value });
                Results.Rows.Add(newRow);
            }
        }


        private void changeDateForSelectedDance_Click_Click(object sender, EventArgs e)
        {
            string danceName = (string)selectedDanceBoxToChangeDate.SelectedItem;
            DateTime newDate = (DateTime)newDateForSelectedDance.Value;
            int pairID = selectedPairBoxToChangeDate.SelectedIndex;
            // Отримати ID танцю
            int danceID = (from Dance in db.GetTable<Dance>()
                           where Dance.dance_name == danceName
                           select Dance.danceID).FirstOrDefault();

            // Отримати ID виступу
            int performanceID = (from Performance in db.GetTable<Performance>()
                                 where Performance.danceID == danceID && Performance.pairID == pairID
                                 select Performance.performanceID).FirstOrDefault();

            // Якщо ID виступу знайдено, оновити дату виступу
            if (performanceID != 0)
            {
                var performance = (from perfomance in db.GetTable<Performance>() where perfomance.performanceID == performanceID select perfomance).Single();
                performance.performance_date = newDate;
                db.SubmitChanges();
                // Очистити таблицю результатів
                Results.Rows.Clear();

                // Вивести повідомлення про те, що виступ не знайдено
                var newRow = new DataGridViewRow();
                newRow.CreateCells(Results, new object[] { " Дата виступу змінена " });
                Results.Rows.Add(newRow);
            }
            else
            { 
                // Очистити таблицю результатів
                Results.Rows.Clear();

                // Вивести повідомлення про те, що виступ не знайдено
                var newRow = new DataGridViewRow();
                newRow.CreateCells(Results, new object[] { "Виступ не знайдено" });
                Results.Rows.Add(newRow);
            }
        }

        private void ChangeDanceNameButton_Click(object sender, EventArgs e)
        {
            string danceOldName = (string)selectedDanceBoxToChangeDanceName.SelectedItem;
            int pairID = selectedPairBoxToChangeDate.SelectedIndex;
            string danceNewName = (string)newNameForSelectedDance.Text;


            // Отримати ID танцю
            int danceNewID = (from Dance in db.GetTable<Dance>()
                           where Dance.dance_name == danceNewName
                           select Dance.danceID).FirstOrDefault();
            // Отримати ID танцю
            int danceOldID = (from Dance in db.GetTable<Dance>()
                              where Dance.dance_name == danceOldName
                              select Dance.danceID).FirstOrDefault();
            // Отримати ID виступу
            int performanceID = (from Performance in db.GetTable<Performance>()
                                 where Performance.danceID == danceOldID && Performance.pairID == pairID
                                 select Performance.performanceID).FirstOrDefault();

            // Якщо ID виступу знайдено, оновити дату виступу
            if (performanceID != 0)
            {
                var performance = (from perfomance in db.GetTable<Performance>() where perfomance.performanceID == performanceID select perfomance).Single();
                performance.danceID = danceNewID;
                db.SubmitChanges();
                // Очистити таблицю результатів
                Results.Rows.Clear();

                // Вивести повідомлення про те, що виступ не знайдено
                var newRow = new DataGridViewRow();
                newRow.CreateCells(Results, new object[] { " Танець виступу змінений " });
                Results.Rows.Add(newRow);
            }
            else
            {
                // Очистити таблицю результатів
                Results.Rows.Clear();

                // Вивести повідомлення про те, що виступ не знайдено
                var newRow = new DataGridViewRow();
                newRow.CreateCells(Results, new object[] { "Виступ з таким танцем не знайдено" });
                Results.Rows.Add(newRow);
            }
        }

        private void GradeMainDanceButton_Click(object sender, EventArgs e)
        {
            string danceName = (string)selectedForGradeMainDanceBox.SelectedItem;
            int danceID = (from Dance in db.GetTable<Dance>()
                           where Dance.dance_name == danceName
                           select Dance.danceID).FirstOrDefault();
            int pairID = selectedPairBoxToChangeDate.SelectedIndex;
            // Отримати ID танцю

            int grade = (int)selectedMainDanceBoxGrade.SelectedIndex;
            // Отримати ID виступу
            int performanceID = (from Performance in db.GetTable<Performance>()
                                 where Performance.danceID == danceID && Performance.pairID == pairID
                                 select Performance.performanceID).FirstOrDefault();

            if (performanceID != 0)
            {
                var performance = (from perfomance in db.GetTable<Performance>() where perfomance.performanceID == performanceID select perfomance).Single();
                performance.grade = grade;
                db.SubmitChanges();
                // Очистити таблицю результатів
                Results.Rows.Clear();

                // Вивести повідомлення про те, що виступ не знайдено
                var newRow = new DataGridViewRow();
                newRow.CreateCells(Results, new object[] { " Танець виступу змінений " });
                Results.Rows.Add(newRow);
            }
            else
            {
                // Очистити таблицю результатів
                Results.Rows.Clear();

                // Вивести повідомлення про те, що виступ не знайдено
                var newRow = new DataGridViewRow();
                newRow.CreateCells(Results, new object[] { "Виступ з таким танцем не знайдено" });
                Results.Rows.Add(newRow);
            }
        }

        private void GradeArbitraryDanceButton_Click(object sender, EventArgs e)
        {
                string danceName = (string)selectedForGradeArbitraryDanceBox.SelectedItem;
            int danceID = (from Dance in db.GetTable<Dance>()
                           where Dance.dance_name == danceName
                           select Dance.danceID).FirstOrDefault();
            int pairID = selectedPairBoxToChangeDate.SelectedIndex;
            // Отримати ID танцю

            int grade = (int)selectedMainDanceBoxGrade.SelectedIndex;
            // Отримати ID виступу
            int performanceID = (from Performance in db.GetTable<Performance>()
                                 where Performance.danceID == danceID && Performance.pairID == pairID
                                 select Performance.performanceID).FirstOrDefault();

            if (performanceID != 0)
            {
                var performance = (from perfomance in db.GetTable<Performance>() where perfomance.performanceID == performanceID select perfomance).Single();
                performance.grade = grade;
                db.SubmitChanges();
                // Очистити таблицю результатів
                Results.Rows.Clear();

                // Вивести повідомлення про те, що виступ не знайдено
                var newRow = new DataGridViewRow();
                newRow.CreateCells(Results, new object[] { " Танець виступу змінений " });
                Results.Rows.Add(newRow);
            }
            else
            {
                // Очистити таблицю результатів
                Results.Rows.Clear();

                // Вивести повідомлення про те, що виступ не знайдено
                var newRow = new DataGridViewRow();
                newRow.CreateCells(Results, new object[] { "Виступ з таким танцем не знайдено" });
                Results.Rows.Add(newRow);
            }
        }
    }
}
