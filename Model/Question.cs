using System;
namespace TodoApi.Model
{
	public class Question
	{
        public Question(string questions, Topic topics, DateTime date)
        {
            Questions = questions;           
            Topics = topics;
            Date = DateTime.Now;
            Points = 0;
        }

        public int QuestionId { get; set; }

        public string Questions { get; set; }

		public List<Answer> Answers { get; set; }

		public Topic Topics { get; set; }

		public DateTime Date { get; set; }

		public int Points { get; set; }

	}
}

