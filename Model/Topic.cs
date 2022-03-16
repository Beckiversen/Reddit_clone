using System;
namespace TodoApi.Model
{
	public class Topic
	{
		public Topic(string name)
		{
			
			this.Name = name;

		}

		public Topic()
        {

        }
		public long TopicId { get; set; }

		public string Name { get; set; }
	}
}

