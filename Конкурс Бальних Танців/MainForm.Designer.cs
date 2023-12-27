namespace Конкурс_Бальних_Танців
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.action_choice = new System.Windows.Forms.TabControl();
            this.get_info = new System.Windows.Forms.TabPage();
            this.selected_team_name_box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.perfomed_dances_datePicker = new System.Windows.Forms.DateTimePicker();
            this.judge_category_box = new System.Windows.Forms.ComboBox();
            this.selected_dance_box = new System.Windows.Forms.ComboBox();
            this.overall_results_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.past_schedule_datePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.perfomed_dances = new System.Windows.Forms.Button();
            this.not_danced_dances = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.calculate_average_score = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.show_overall_results = new System.Windows.Forms.Button();
            this.display_past_schedule = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.set_info = new System.Windows.Forms.TabPage();
            this.selectedPairBoxToChangeDate = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.selectedArbitraryDanceBoxGrade = new System.Windows.Forms.ComboBox();
            this.selectedMainDanceBoxGrade = new System.Windows.Forms.ComboBox();
            this.selectTeam = new System.Windows.Forms.TextBox();
            this.selectedTeamBox = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.selectedForGradeArbitraryDanceBox = new System.Windows.Forms.ComboBox();
            this.selectedForGradeMainDanceBox = new System.Windows.Forms.ComboBox();
            this.newNameForSelectedDance = new System.Windows.Forms.TextBox();
            this.selectedDanceBoxToChangeDanceName = new System.Windows.Forms.ComboBox();
            this.newDateForSelectedDance = new System.Windows.Forms.DateTimePicker();
            this.selectedDanceBoxToChangeDate = new System.Windows.Forms.ComboBox();
            this.GradeArbitraryDanceButton = new System.Windows.Forms.Button();
            this.GradeMainDanceButton = new System.Windows.Forms.Button();
            this.ChangeDanceNameButton = new System.Windows.Forms.Button();
            this.changeDateForSelectedDance_Click = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.DataGridView();
            this.action_choice.SuspendLayout();
            this.get_info.SuspendLayout();
            this.set_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            this.SuspendLayout();
            // 
            // action_choice
            // 
            this.action_choice.Controls.Add(this.get_info);
            this.action_choice.Controls.Add(this.set_info);
            this.action_choice.ItemSize = new System.Drawing.Size(146, 21);
            this.action_choice.Location = new System.Drawing.Point(12, 12);
            this.action_choice.Name = "action_choice";
            this.action_choice.SelectedIndex = 0;
            this.action_choice.Size = new System.Drawing.Size(853, 571);
            this.action_choice.TabIndex = 0;
            // 
            // get_info
            // 
            this.get_info.Controls.Add(this.selected_team_name_box);
            this.get_info.Controls.Add(this.label6);
            this.get_info.Controls.Add(this.perfomed_dances_datePicker);
            this.get_info.Controls.Add(this.judge_category_box);
            this.get_info.Controls.Add(this.selected_dance_box);
            this.get_info.Controls.Add(this.overall_results_DatePicker);
            this.get_info.Controls.Add(this.past_schedule_datePicker);
            this.get_info.Controls.Add(this.label5);
            this.get_info.Controls.Add(this.label4);
            this.get_info.Controls.Add(this.label3);
            this.get_info.Controls.Add(this.label2);
            this.get_info.Controls.Add(this.label1);
            this.get_info.Controls.Add(this.textBox4);
            this.get_info.Controls.Add(this.perfomed_dances);
            this.get_info.Controls.Add(this.not_danced_dances);
            this.get_info.Controls.Add(this.textBox3);
            this.get_info.Controls.Add(this.calculate_average_score);
            this.get_info.Controls.Add(this.textBox2);
            this.get_info.Controls.Add(this.show_overall_results);
            this.get_info.Controls.Add(this.display_past_schedule);
            this.get_info.Controls.Add(this.textBox1);
            this.get_info.Location = new System.Drawing.Point(4, 25);
            this.get_info.Name = "get_info";
            this.get_info.Padding = new System.Windows.Forms.Padding(3);
            this.get_info.Size = new System.Drawing.Size(845, 542);
            this.get_info.TabIndex = 0;
            this.get_info.Text = "Вивести інформацію";
            this.get_info.UseVisualStyleBackColor = true;
            // 
            // selected_team_name_box
            // 
            this.selected_team_name_box.FormattingEnabled = true;
            this.selected_team_name_box.Location = new System.Drawing.Point(598, 71);
            this.selected_team_name_box.Name = "selected_team_name_box";
            this.selected_team_name_box.Size = new System.Drawing.Size(232, 24);
            this.selected_team_name_box.TabIndex = 32;
            this.selected_team_name_box.Tag = "selected_team_name_box";
            this.selected_team_name_box.SelectedIndexChanged += new System.EventHandler(this.selected_team_name_box_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Для даної команди:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // perfomed_dances_datePicker
            // 
            this.perfomed_dances_datePicker.Location = new System.Drawing.Point(598, 447);
            this.perfomed_dances_datePicker.Name = "perfomed_dances_datePicker";
            this.perfomed_dances_datePicker.Size = new System.Drawing.Size(232, 22);
            this.perfomed_dances_datePicker.TabIndex = 30;
            this.perfomed_dances_datePicker.Tag = "perfomed_dances_datePicker";
            // 
            // judge_category_box
            // 
            this.judge_category_box.FormattingEnabled = true;
            this.judge_category_box.Location = new System.Drawing.Point(598, 317);
            this.judge_category_box.Name = "judge_category_box";
            this.judge_category_box.Size = new System.Drawing.Size(232, 24);
            this.judge_category_box.TabIndex = 29;
            this.judge_category_box.Tag = "judge_category_box";
            // 
            // selected_dance_box
            // 
            this.selected_dance_box.FormattingEnabled = true;
            this.selected_dance_box.Location = new System.Drawing.Point(598, 265);
            this.selected_dance_box.Name = "selected_dance_box";
            this.selected_dance_box.Size = new System.Drawing.Size(232, 24);
            this.selected_dance_box.TabIndex = 28;
            this.selected_dance_box.Tag = "selected_dance_box";
            // 
            // overall_results_DatePicker
            // 
            this.overall_results_DatePicker.Location = new System.Drawing.Point(598, 144);
            this.overall_results_DatePicker.Name = "overall_results_DatePicker";
            this.overall_results_DatePicker.Size = new System.Drawing.Size(232, 22);
            this.overall_results_DatePicker.TabIndex = 27;
            this.overall_results_DatePicker.Tag = "overall_results_datePicker";
            // 
            // past_schedule_datePicker
            // 
            this.past_schedule_datePicker.Location = new System.Drawing.Point(598, 18);
            this.past_schedule_datePicker.MaxDate = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.past_schedule_datePicker.MinDate = new System.DateTime(2023, 12, 11, 0, 0, 0, 0);
            this.past_schedule_datePicker.Name = "past_schedule_datePicker";
            this.past_schedule_datePicker.Size = new System.Drawing.Size(232, 22);
            this.past_schedule_datePicker.TabIndex = 26;
            this.past_schedule_datePicker.Tag = "past_schedule_datePicker";
            this.past_schedule_datePicker.Value = new System.DateTime(2023, 12, 24, 2, 39, 32, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "На заданий день конкурсу:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Із заданою суддівською \r\nкатегорією:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "За вказаний танець:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "На заданий день конкурсу:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "На заданий день конкурсу:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.textBox4.Location = new System.Drawing.Point(8, 488);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(347, 44);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "Перелік упорядковується за кількістю виконань танцю окремими парами.";
            // 
            // perfomed_dances
            // 
            this.perfomed_dances.Location = new System.Drawing.Point(7, 440);
            this.perfomed_dances.Name = "perfomed_dances";
            this.perfomed_dances.Size = new System.Drawing.Size(347, 42);
            this.perfomed_dances.TabIndex = 19;
            this.perfomed_dances.Tag = "perfomed_dances";
            this.perfomed_dances.Text = "Скласти перелік виконаних танців";
            this.perfomed_dances.UseVisualStyleBackColor = true;
            this.perfomed_dances.Click += new System.EventHandler(this.perfomed_dances_Click);
            // 
            // not_danced_dances
            // 
            this.not_danced_dances.Location = new System.Drawing.Point(8, 376);
            this.not_danced_dances.Name = "not_danced_dances";
            this.not_danced_dances.Size = new System.Drawing.Size(347, 43);
            this.not_danced_dances.TabIndex = 18;
            this.not_danced_dances.Tag = "not_danced_dances";
            this.not_danced_dances.Text = "Визначити танці, які не танцює жодна з пар";
            this.not_danced_dances.UseVisualStyleBackColor = true;
            this.not_danced_dances.Click += new System.EventHandler(this.not_danced_dances_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.textBox3.Location = new System.Drawing.Point(8, 309);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(347, 44);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "*Виставлену членами журі\r\n";
            // 
            // calculate_average_score
            // 
            this.calculate_average_score.Location = new System.Drawing.Point(7, 260);
            this.calculate_average_score.Name = "calculate_average_score";
            this.calculate_average_score.Size = new System.Drawing.Size(347, 43);
            this.calculate_average_score.TabIndex = 13;
            this.calculate_average_score.Tag = "calculate_average_score";
            this.calculate_average_score.Text = "Вирахувати середню оцінку  \r\n";
            this.calculate_average_score.UseVisualStyleBackColor = true;
            this.calculate_average_score.Click += new System.EventHandler(this.calculate_average_score_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.textBox2.Location = new System.Drawing.Point(7, 186);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(347, 44);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Рейтинг пари визначається усередненням всіх отриманих нею на заданий момент оціно" +
    "к";
            // 
            // show_overall_results
            // 
            this.show_overall_results.Location = new System.Drawing.Point(6, 137);
            this.show_overall_results.Name = "show_overall_results";
            this.show_overall_results.Size = new System.Drawing.Size(347, 43);
            this.show_overall_results.TabIndex = 11;
            this.show_overall_results.Tag = "show_overall_results";
            this.show_overall_results.Text = "Підбити підсумки у загальному заліку\r\n";
            this.show_overall_results.UseVisualStyleBackColor = true;
            this.show_overall_results.Click += new System.EventHandler(this.show_overall_results_Click);
            // 
            // display_past_schedule
            // 
            this.display_past_schedule.Location = new System.Drawing.Point(6, 6);
            this.display_past_schedule.Name = "display_past_schedule";
            this.display_past_schedule.Size = new System.Drawing.Size(347, 51);
            this.display_past_schedule.TabIndex = 3;
            this.display_past_schedule.Tag = "display_past_schedule";
            this.display_past_schedule.Text = "Вивести розклад минулих виступів для пари";
            this.display_past_schedule.UseVisualStyleBackColor = true;
            this.display_past_schedule.Click += new System.EventHandler(this.display_past_schedule_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.textBox1.Location = new System.Drawing.Point(6, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(347, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Таким вважається виступ, оцінки за який вже виставлені та занесені до таблиці оці" +
    "нок. ";
            // 
            // set_info
            // 
            this.set_info.Controls.Add(this.selectedPairBoxToChangeDate);
            this.set_info.Controls.Add(this.textBox9);
            this.set_info.Controls.Add(this.selectedArbitraryDanceBoxGrade);
            this.set_info.Controls.Add(this.selectedMainDanceBoxGrade);
            this.set_info.Controls.Add(this.selectTeam);
            this.set_info.Controls.Add(this.selectedTeamBox);
            this.set_info.Controls.Add(this.textBox11);
            this.set_info.Controls.Add(this.textBox8);
            this.set_info.Controls.Add(this.textBox7);
            this.set_info.Controls.Add(this.textBox6);
            this.set_info.Controls.Add(this.selectedForGradeArbitraryDanceBox);
            this.set_info.Controls.Add(this.selectedForGradeMainDanceBox);
            this.set_info.Controls.Add(this.newNameForSelectedDance);
            this.set_info.Controls.Add(this.selectedDanceBoxToChangeDanceName);
            this.set_info.Controls.Add(this.newDateForSelectedDance);
            this.set_info.Controls.Add(this.selectedDanceBoxToChangeDate);
            this.set_info.Controls.Add(this.GradeArbitraryDanceButton);
            this.set_info.Controls.Add(this.GradeMainDanceButton);
            this.set_info.Controls.Add(this.ChangeDanceNameButton);
            this.set_info.Controls.Add(this.changeDateForSelectedDance_Click);
            this.set_info.Location = new System.Drawing.Point(4, 25);
            this.set_info.Name = "set_info";
            this.set_info.Padding = new System.Windows.Forms.Padding(3);
            this.set_info.Size = new System.Drawing.Size(845, 542);
            this.set_info.TabIndex = 1;
            this.set_info.Text = "Редагувати інформацію";
            this.set_info.UseVisualStyleBackColor = true;
            // 
            // selectedPairBoxToChangeDate
            // 
            this.selectedPairBoxToChangeDate.FormattingEnabled = true;
            this.selectedPairBoxToChangeDate.Location = new System.Drawing.Point(342, 130);
            this.selectedPairBoxToChangeDate.Name = "selectedPairBoxToChangeDate";
            this.selectedPairBoxToChangeDate.Size = new System.Drawing.Size(491, 24);
            this.selectedPairBoxToChangeDate.TabIndex = 57;
            this.selectedPairBoxToChangeDate.Tag = "selectedPairBoxToChangeDate";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.textBox9.Location = new System.Drawing.Point(9, 119);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(315, 44);
            this.textBox9.TabIndex = 56;
            this.textBox9.Text = "\r\nПара:   ";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // selectedArbitraryDanceBoxGrade
            // 
            this.selectedArbitraryDanceBoxGrade.FormattingEnabled = true;
            this.selectedArbitraryDanceBoxGrade.Location = new System.Drawing.Point(342, 499);
            this.selectedArbitraryDanceBoxGrade.Name = "selectedArbitraryDanceBoxGrade";
            this.selectedArbitraryDanceBoxGrade.Size = new System.Drawing.Size(488, 24);
            this.selectedArbitraryDanceBoxGrade.TabIndex = 55;
            this.selectedArbitraryDanceBoxGrade.Tag = "selectedArbitraryDanceBoxGrade";
            // 
            // selectedMainDanceBoxGrade
            // 
            this.selectedMainDanceBoxGrade.FormattingEnabled = true;
            this.selectedMainDanceBoxGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.selectedMainDanceBoxGrade.Location = new System.Drawing.Point(342, 392);
            this.selectedMainDanceBoxGrade.Name = "selectedMainDanceBoxGrade";
            this.selectedMainDanceBoxGrade.Size = new System.Drawing.Size(488, 24);
            this.selectedMainDanceBoxGrade.TabIndex = 54;
            this.selectedMainDanceBoxGrade.Tag = "selectedMainDanceBoxGrade";
            // 
            // selectTeam
            // 
            this.selectTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.selectTeam.Location = new System.Drawing.Point(6, 11);
            this.selectTeam.Multiline = true;
            this.selectTeam.Name = "selectTeam";
            this.selectTeam.ReadOnly = true;
            this.selectTeam.Size = new System.Drawing.Size(315, 44);
            this.selectTeam.TabIndex = 53;
            this.selectTeam.Tag = "";
            this.selectTeam.Text = "\r\nОберіть команду:";
            this.selectTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // selectedTeamBox
            // 
            this.selectedTeamBox.FormattingEnabled = true;
            this.selectedTeamBox.Location = new System.Drawing.Point(342, 20);
            this.selectedTeamBox.Name = "selectedTeamBox";
            this.selectedTeamBox.Size = new System.Drawing.Size(491, 24);
            this.selectedTeamBox.TabIndex = 52;
            this.selectedTeamBox.Tag = "selectedTeamBox";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.textBox11.Location = new System.Drawing.Point(9, 490);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(315, 44);
            this.textBox11.TabIndex = 50;
            this.textBox11.Text = "\r\nОцінка:   ";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.textBox8.Location = new System.Drawing.Point(9, 381);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(315, 44);
            this.textBox8.TabIndex = 48;
            this.textBox8.Text = "\r\nОцінка:   ";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.textBox7.Location = new System.Drawing.Point(9, 167);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(315, 44);
            this.textBox7.TabIndex = 47;
            this.textBox7.Text = "\r\nНова дата:   ";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.textBox6.Location = new System.Drawing.Point(9, 274);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(315, 44);
            this.textBox6.TabIndex = 46;
            this.textBox6.Text = "\r\nНова назва:   ";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // selectedForGradeArbitraryDanceBox
            // 
            this.selectedForGradeArbitraryDanceBox.FormattingEnabled = true;
            this.selectedForGradeArbitraryDanceBox.Location = new System.Drawing.Point(342, 445);
            this.selectedForGradeArbitraryDanceBox.Name = "selectedForGradeArbitraryDanceBox";
            this.selectedForGradeArbitraryDanceBox.Size = new System.Drawing.Size(488, 24);
            this.selectedForGradeArbitraryDanceBox.TabIndex = 44;
            this.selectedForGradeArbitraryDanceBox.Tag = "selectedForGradeArbitraryDanceBox";
            // 
            // selectedForGradeMainDanceBox
            // 
            this.selectedForGradeMainDanceBox.FormattingEnabled = true;
            this.selectedForGradeMainDanceBox.Location = new System.Drawing.Point(342, 338);
            this.selectedForGradeMainDanceBox.Name = "selectedForGradeMainDanceBox";
            this.selectedForGradeMainDanceBox.Size = new System.Drawing.Size(488, 24);
            this.selectedForGradeMainDanceBox.TabIndex = 45;
            this.selectedForGradeMainDanceBox.Tag = "selectedForGradeMainDanceBox";
            // 
            // newNameForSelectedDance
            // 
            this.newNameForSelectedDance.Location = new System.Drawing.Point(342, 274);
            this.newNameForSelectedDance.Multiline = true;
            this.newNameForSelectedDance.Name = "newNameForSelectedDance";
            this.newNameForSelectedDance.Size = new System.Drawing.Size(491, 44);
            this.newNameForSelectedDance.TabIndex = 43;
            this.newNameForSelectedDance.Tag = "newNameForSelectedDance";
            // 
            // selectedDanceBoxToChangeDanceName
            // 
            this.selectedDanceBoxToChangeDanceName.FormattingEnabled = true;
            this.selectedDanceBoxToChangeDanceName.Location = new System.Drawing.Point(342, 231);
            this.selectedDanceBoxToChangeDanceName.Name = "selectedDanceBoxToChangeDanceName";
            this.selectedDanceBoxToChangeDanceName.Size = new System.Drawing.Size(488, 24);
            this.selectedDanceBoxToChangeDanceName.TabIndex = 42;
            this.selectedDanceBoxToChangeDanceName.Tag = "selectedDanceBoxToChangeDanceName";
            // 
            // newDateForSelectedDance
            // 
            this.newDateForSelectedDance.Location = new System.Drawing.Point(342, 178);
            this.newDateForSelectedDance.Name = "newDateForSelectedDance";
            this.newDateForSelectedDance.Size = new System.Drawing.Size(200, 22);
            this.newDateForSelectedDance.TabIndex = 41;
            this.newDateForSelectedDance.Tag = "newDateForSelectedDance";
            // 
            // selectedDanceBoxToChangeDate
            // 
            this.selectedDanceBoxToChangeDate.FormattingEnabled = true;
            this.selectedDanceBoxToChangeDate.Location = new System.Drawing.Point(342, 76);
            this.selectedDanceBoxToChangeDate.Name = "selectedDanceBoxToChangeDate";
            this.selectedDanceBoxToChangeDate.Size = new System.Drawing.Size(491, 24);
            this.selectedDanceBoxToChangeDate.TabIndex = 40;
            this.selectedDanceBoxToChangeDate.Tag = "selectedDanceBoxToChangeDate";
            // 
            // GradeArbitraryDanceButton
            // 
            this.GradeArbitraryDanceButton.Location = new System.Drawing.Point(9, 431);
            this.GradeArbitraryDanceButton.Name = "GradeArbitraryDanceButton";
            this.GradeArbitraryDanceButton.Size = new System.Drawing.Size(318, 51);
            this.GradeArbitraryDanceButton.TabIndex = 38;
            this.GradeArbitraryDanceButton.Text = "Оцінити довільний танець";
            this.GradeArbitraryDanceButton.UseVisualStyleBackColor = true;
            this.GradeArbitraryDanceButton.Click += new System.EventHandler(this.GradeArbitraryDanceButton_Click);
            // 
            // GradeMainDanceButton
            // 
            this.GradeMainDanceButton.Location = new System.Drawing.Point(9, 324);
            this.GradeMainDanceButton.Name = "GradeMainDanceButton";
            this.GradeMainDanceButton.Size = new System.Drawing.Size(318, 51);
            this.GradeMainDanceButton.TabIndex = 39;
            this.GradeMainDanceButton.Text = "Оцінити обов\'язковий танець";
            this.GradeMainDanceButton.UseVisualStyleBackColor = true;
            this.GradeMainDanceButton.Click += new System.EventHandler(this.GradeMainDanceButton_Click);
            // 
            // ChangeDanceNameButton
            // 
            this.ChangeDanceNameButton.Location = new System.Drawing.Point(6, 217);
            this.ChangeDanceNameButton.Name = "ChangeDanceNameButton";
            this.ChangeDanceNameButton.Size = new System.Drawing.Size(318, 51);
            this.ChangeDanceNameButton.TabIndex = 37;
            this.ChangeDanceNameButton.Text = "Змінити назву виконуваного танцю";
            this.ChangeDanceNameButton.UseVisualStyleBackColor = true;
            this.ChangeDanceNameButton.Click += new System.EventHandler(this.ChangeDanceNameButton_Click);
            // 
            // changeDateForSelectedDance_Click
            // 
            this.changeDateForSelectedDance_Click.Location = new System.Drawing.Point(6, 62);
            this.changeDateForSelectedDance_Click.Name = "changeDateForSelectedDance_Click";
            this.changeDateForSelectedDance_Click.Size = new System.Drawing.Size(318, 51);
            this.changeDateForSelectedDance_Click.TabIndex = 36;
            this.changeDateForSelectedDance_Click.Text = "Змінити дату виконання танцю парою";
            this.changeDateForSelectedDance_Click.UseVisualStyleBackColor = true;
            this.changeDateForSelectedDance_Click.Click += new System.EventHandler(this.changeDateForSelectedDance_Click_Click);
            // 
            // Results
            // 
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Location = new System.Drawing.Point(871, 35);
            this.Results.Name = "Results";
            this.Results.RowHeadersWidth = 51;
            this.Results.RowTemplate.Height = 24;
            this.Results.Size = new System.Drawing.Size(524, 542);
            this.Results.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 589);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.action_choice);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.action_choice.ResumeLayout(false);
            this.get_info.ResumeLayout(false);
            this.get_info.PerformLayout();
            this.set_info.ResumeLayout(false);
            this.set_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl action_choice;
        private System.Windows.Forms.TabPage get_info;
        private System.Windows.Forms.TabPage set_info;
        private System.Windows.Forms.Button display_past_schedule;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button show_overall_results;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button perfomed_dances;
        private System.Windows.Forms.Button not_danced_dances;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button calculate_average_score;
        private System.Windows.Forms.DateTimePicker perfomed_dances_datePicker;
        private System.Windows.Forms.ComboBox judge_category_box;
        private System.Windows.Forms.ComboBox selected_dance_box;
        private System.Windows.Forms.DateTimePicker overall_results_DatePicker;
        private System.Windows.Forms.DateTimePicker past_schedule_datePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox selectedForGradeArbitraryDanceBox;
        private System.Windows.Forms.ComboBox selectedForGradeMainDanceBox;
        private System.Windows.Forms.TextBox newNameForSelectedDance;
        private System.Windows.Forms.ComboBox selectedDanceBoxToChangeDanceName;
        private System.Windows.Forms.DateTimePicker newDateForSelectedDance;
        private System.Windows.Forms.ComboBox selectedDanceBoxToChangeDate;
        private System.Windows.Forms.Button GradeArbitraryDanceButton;
        private System.Windows.Forms.Button GradeMainDanceButton;
        private System.Windows.Forms.Button ChangeDanceNameButton;
        private System.Windows.Forms.Button changeDateForSelectedDance_Click;
        private System.Windows.Forms.ComboBox selected_team_name_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectedTeamBox;
        private System.Windows.Forms.TextBox selectTeam;
        private System.Windows.Forms.ComboBox selectedArbitraryDanceBoxGrade;
        private System.Windows.Forms.ComboBox selectedMainDanceBoxGrade;
        private System.Windows.Forms.ComboBox selectedPairBoxToChangeDate;
        private System.Windows.Forms.TextBox textBox9;
    }
}

