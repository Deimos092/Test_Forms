using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Test_Forms.Properties;

namespace Test_Forms
{
	public partial class Main_Form : Form
	{
		public Main_Form()
		{
			InitializeComponent();
		}
		MoveForm moveForm = new MoveForm();
		int[] LastQA;
		int index;
		private int count = 0;
		public Student User { get; set; }//Свойство в котором храняться данные нашего пользователя вошедшего в программу
		private DateTime Time { get; set; }//Свойство для отслеживания времени
		QAList QA { get; set; }//Свойство для загрузки всех вопросов сюда

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolEnd_Click(sender, e);
			this.Close();
		}

		//Загрузка формы
		private void Main_Form_Load(object sender, EventArgs e)
		{
			QA = new QAList();
			using (StreamReader sr = new StreamReader(Settings.Default.PathQA))
			{
				string question;
				while ((question = sr.ReadLine()) != null)
					QA.Add(question, sr.ReadLine().Split(':'), sr.ReadLine());
			}
			LastQA = new int[1];
		}

		#region ---------- Старт и Остановка тестирования ----------
		private void ToolStart_Click(object sender, EventArgs eventArgs)
		{
			if (ToolTB_LimitTime.Text == "" || ToolTB_LimitTime.Text == "Лимит времени")
			{
					MessageBox.Show("Введите кол-во времени для тестирования не меньше 1 минуты");
					ToolTB_LimitTime.Select();
			}
			else
			{
				ToolTB_LimitTime.Enabled = false;
				Time = DateTime.Now.AddSeconds(int.Parse(ToolTB_LimitTime.Text) * 60);//Задаем в секундах кол-во времени
				timer1.Interval = 500;//Интервал обновления 1 секундка
				User.Grade = 0;//Обнуляем оценку
				timer1.Start();//Стартуем таймер
				NextQuestion();//Включаем вопрос
				ToolStart.Enabled = false;//Отключаем кнопку СТАРТ
				ToolEnd.Enabled = true;//Вкл кнопку Завершить
				следующийВопросToolStripMenuItem.Enabled = true;//Вкл кнопку Следующий вопрос
			}
		}
		private void ToolEnd_Click(object sender, EventArgs e)
		{
			try
			{
				timer1.Stop();
				ToolTB_LimitTime.Enabled = true;
				CheckRadioForQuestion();
				User.Grade = User.Grade * 100 / QA.Count;
				MessageBox.Show($"!Тест завершен у вас {User.Grade,-3:F1}% Из 100% ");
				index = 0;
				count = 0;
				LastQA = new int[1];
				ToolStart.Enabled = true;
				следующийВопросToolStripMenuItem.Enabled = false;
				ToolEnd.Enabled = false;

				//--------- Перезаписываем результат нашего пользователя обратно в файл -------
				Students StudentsList = new Students();
				string line;
				using (StreamReader sr = new StreamReader(Settings.Default.PathStudents))//Сначала загрузим старые данные из файла
					while ((line = sr.ReadLine()) != null)
					{
						string[] User = line.Split(':').ToArray();
						StudentsList.AddNew(User[0], User[1], int.Parse(User[2]));//Добавим каждого пользователя в нашу коллекцию StudentList
					}

				using (StreamReader sr = new StreamReader(Settings.Default.PathStudents))//А теперь заменим нашего пользователя в файле
				{
					line = sr.ReadToEnd();//Считываем весь файл еше раз.
					line = Regex.Replace(line, StudentsList[User.Login].ToString(), User.ToString());//Находим и заменяем его в строке
				}

				using (StreamWriter sw = new StreamWriter(Settings.Default.PathStudents))
					sw.Write(line);//Записываем с новым результатом обратно в файл
				
			}
			catch(Exception ex)
			{
				MessageBox.Show($"ОШИБКА : {ex.Message}");
			}
		}
		#endregion

		//Следующий вопрос
		private void NextQuestion()
		{
			Random rnd = new Random();
			index = rnd.Next(QA.Count);

			//Проверка на генерацию разных вопросов что бы они шли не попорядку и не повторялись по два раза
			while (LastQA.Contains(index))//Проверяем есть уже такой номер вопроса если есть то генерируем другую цифру вопроса
				if (LastQA.Length <= QA.Count)//Проверяем наш вспомогательный массив, меньше ли в нем кол-во вопрос чем общее кол-во вопросов в файле.
					index = rnd.Next(QA.Count);//Генерируем новый номер вопроса
				else break;

			if (!LastQA.Contains(index))//Содержиться ли уже этот номер вопроса в массиве
			{
				lb_questiontext.Text = QA[index].Question;//Добавляем вопрос на экран в строку
				rb_1.Text = QA[index].Answers[0];//Добавляем варианты ответов
				rb_2.Text = QA[index].Answers[1];
				rb_3.Text = QA[index].Answers[2];
				rb_4.Text = QA[index].Answers[3];
				lb_number.Text = (count + 1).ToString() + " / " + QA.Count.ToString();//Номер вопроса
				LastQA[count++] = index;//Заносим этот вопрос в наш вспомогательный массив что бы он больше не повторялся
				Array.Resize(ref LastQA, LastQA.Length + 1);//Увеличиваем массив на +1
				LastQA[LastQA.Length - 1] = -1;//Изменяем значение на -1 что бы не прошел верхнюю проверку при = 0
			}
		}

		//Проверяем правильность выбора ответа в вопросе
		private void CheckRadioForQuestion()
		{
			//С помошью LINQ находим radiobutton который выбрали
			var radioButton = from RadioButton rb in GBox_Answers.Controls
							  where rb.Checked == true
							  select rb;

			if (radioButton.Count() > 0)
				if (QA[index].CorrectAnswer == radioButton.First().Text)
					User.Grade += 1;
		}
		private void следующийВопросToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (LastQA.Length <= QA.Count || timer1.Enabled)
			{
				CheckRadioForQuestion();
				NextQuestion();
				foreach (RadioButton RB in GBox_Answers.Controls.OfType<RadioButton>())
					RB.Checked = false;

			}
			else
				следующийВопросToolStripMenuItem.Enabled = true;
		}


		//Красив в зеленый цвет выбранный пользователем ответ
		private void RB_Chek_Click(object sender, EventArgs e)
		{
			RadioButton rb = sender as RadioButton;
			if (rb.Checked)
				rb.ForeColor = Color.YellowGreen;
			else
				rb.ForeColor = Color.FromArgb(200, 200, 200);
		}

		#region --------- Работа с таймером и временем ---------
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (TimeLeft().Minutes == 0 && TimeLeft().Seconds == 0)
				ToolEnd_Click(sender, e);

			ToolTimeNow.Text = "Вермя " + DateTime.Now.ToLongTimeString();
			ToolTimer.Text = "Осталось " + TimeLeft().ToString(@"mm\:ss");
		}
		//возвращает сколько времени осталось до конца
		private TimeSpan TimeLeft()
		{
			return Time - DateTime.Now;
		}
		#endregion

		#region -------- Методы для перетаскивания формы мышкой --------
		private void Main_MouseMove(object sender, MouseEventArgs e)
		{
			Location = moveForm.MouseMove(e, Location);
		}

		private void Main_MouseUp(object sender, MouseEventArgs e)
		{
			moveForm.MouseUP(e);
		}

		private void Main_MouseDown(object sender, MouseEventArgs e)
		{
			moveForm.MouseDown(e);
		}
		#endregion

		private void ToolTB_LimitTime_Click(object sender, EventArgs e)
		{
			if (ToolTB_LimitTime.Text.Length != 0)
				ToolTB_LimitTime.Text = "";
		}
	}
}
