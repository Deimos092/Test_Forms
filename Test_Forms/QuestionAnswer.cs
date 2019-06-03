using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Forms
{
	class QuestionAnswer
	{
		public QuestionAnswer() { }
		public QuestionAnswer(string question,string[] answer,string correctAnswer)
		{
			Question = question;
			Answers = answer;
			CorrectAnswer = correctAnswer;
		}
		public string Question { get; set; }
		public string[] Answers { get; set; }
		public string CorrectAnswer { get; set; }
	}
	class QAList
	{
		List<QuestionAnswer> _ListQA = new List<QuestionAnswer>();

		public QAList() { }

		public int Count
		{
			get { return _ListQA.Count; }
		}
		public QuestionAnswer this[int index]
		{
			get { return _ListQA[index]; }
		}
		public void Add(string question,string[] answers,string correct)
		{
			_ListQA.Add(new QuestionAnswer(question, answers, correct));
		}

	}
}
