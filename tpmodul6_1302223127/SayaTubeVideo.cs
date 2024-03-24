using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace tpmodul6_1302223127
{
	public class SayaTubeVideo
	{
		private int id;
		private string title;
		private int playCount;

		public SayaTubeVideo(string title)
		{
            // Precondition
            Debug.Assert(title != null && title.Length != 0, "Title tidak boleh null");
            Debug.Assert(title.Length <= 100, "Panjang title tidak boleh lebih dari 100");
            

            this.title = title;
			this.id = new Random().Next(11111, 99999);
			this.playCount = 0;
		}

		public void IncreasePlayCount(int playCount)
		{
			// Precondition
			Debug.Assert(playCount <= 10000000, "play count melebihi batas maksimal");

			// Exception
			try
			{
                int result = checked(this.playCount + playCount);

				// Postcondition
				this.playCount = result;
            }
			catch (Exception e)
			{
				Console.WriteLine($"Error : {e.Message}");
			}
			
		}

		public void PrintVideoDetail()
		{
			Console.WriteLine("=== Detail Video ===");
			Console.WriteLine($"ID : {this.id}");
			Console.WriteLine($"Title : {this.title}");
			Console.WriteLine($"Play Count : {this.playCount}\n");
		}
	}
}

