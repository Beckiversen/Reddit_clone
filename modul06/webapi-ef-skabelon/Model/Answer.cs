using System;
namespace TodoApi.Model
{
	public class Answer
	{
		public Answer(string answer)
		{
			this.Answers = answer;
			this.Points = 0;
		}

		public long AnswerId { get; set; }

		public string Answers { get; set; }

		public int Points { get; set; }
	}
}

