using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace calendar_02
{	
	[Serializable]
	public class MonthRecord
	{
		public ArrayList monthly = new ArrayList();

		public void Add(DayRecord temp)
		{
			monthly.Add(temp);
		}

		internal IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
	[Serializable]
	public class DayRecord
	{
		public int DD;
		public Coffee Coffee { get; set; }
		public Exercise Exercise { get; set; }
		public Study study { get; set; }
		public Meditation meditation { get; set; }
		public Stress stress { get; set; }

		public DayRecord( int DD, Coffee coffee, Exercise exercise, Study study, Meditation meditation, Stress stress)
		{	
			this.DD = DD;
			this.Coffee = coffee;
			this.Exercise = exercise;
			this.study = study;
			this.meditation = meditation;
			this.stress = stress;	
		}
	}


	[Serializable]
	public class Coffee
	{
		public string Name  { get; set; }
		public int Count { get; set; }

		public Coffee(string Name, int Count)
		{
			this.Name = Name;
			this.Count = Count;
		}
	}
	[Serializable]
	public class Exercise
	{
		public string Name { get; set; }
		public int Count { get; set; }

		public Exercise(string Name, int Count)
		{
			this.Name = Name;
			this.Count = Count;
		}
	}
	[Serializable]
	public class Meditation
	{
		public string Name { get; set; }
		public int Count { get; set; }

		public Meditation(string Name, int Count)
		{
			this.Name = Name;
			this.Count = Count;
		}
	}
	[Serializable]
	public class Study
	{
		public string Name { get; set; }
		public int Count { get; set; }

		public Study(string Name, int Count)
		{
			this.Name = Name;
			this.Count = Count;
		}
	}
	[Serializable]
	public class Stress
	{
		public int Percent { get; set; }
	
		public Stress(int Percent)
		{
			this.Percent = Percent;
		}
	}
}