using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace calendar_02
{
	/*class MainClass
	{
		public static void Main(string[] args)
		{
			DayRecord day1 = new DayRecord(new Coffee("1", 10), new Exercise("2", 10), new Study("3", 1), new Meditation("3", 2), new Stress(10), 1);
			DayRecord day2 = new DayRecord(new Coffee("1", 10), new Exercise("2", 10), new Study("3", 1), new Meditation("3", 2), new Stress(10), 2);
			DayRecord day3 = new DayRecord(new Coffee("1", 10), new Exercise("2", 10), new Study("3", 1), new Meditation("3", 2), new Stress(10), 3);

			MonthRecord month6 = new MonthRecord();
			month6.Add(day1);
			month6.Add(day2);
			month6.Add(day3);
			Stream ws = new FileStream("201406.dat", FileMode.Create);
			BinaryFormatter serializer = new BinaryFormatter();
			serializer.Serialize(ws, month6);
			ws.Close();





			FileStream rs = new FileStream("201406.dat", FileMode.Open);
			BinaryFormatter deserializer = new BinaryFormatter();
			month6 = (MonthRecord)deserializer.Deserialize(rs);
			rs.Close();

		}
	}
	*/
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