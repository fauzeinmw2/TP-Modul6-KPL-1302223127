using System;
namespace tpmodul6_1302223127
{
	public class SayaTubeVideo
	{
		private int id;
		private string title;
		private int playCount;

		public SayaTubeVideo(string title)
		{
			this.title = title;
			this.id = new Random().Next(11111, 99999);
			this.playCount = 0;
		}

		public void IncreasePlayCount(int playCount)
		{
			this.playCount += playCount;
		}

		public void PrintVideoDetail()
		{
			Console.WriteLine("=== Detail Video ===");
			Console.WriteLine($"ID : {this.id}");
			Console.WriteLine($"Title : {this.title}");
			Console.WriteLine($"Play Count : {this.playCount}");
		}
	}
}

