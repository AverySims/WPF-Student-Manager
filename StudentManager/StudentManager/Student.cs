using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
	public class Student
	{
		public Student(int id, string name, List<double> grades)
		{
			ID = id;
			Name = name;
			Grades = grades;
		}

		public double AverageGrade
		{
			// If there are no grades, return 0
			// Otherwise, return the average of the grades
			get { return Grades.Count == 0 ? 0f : (float)Grades.Average(); }
		}

		public string AverageGradeString
		{
			get { return $"{AverageGrade:F}"; }
		}

		public string GradeCollection
		{
			get
			{
				string temp = "";
				foreach (var grade in Grades)
				{
					if (grade != Grades.Last())
					{
						temp += $"{(float)grade}, ";
					}
					else
					{
						temp += $"{(float)grade}";
					}
				}
				return temp;
			}
		}

		public int ID { get; set; }
		public string Name { get; set; }
		public List<double> Grades { get; set; }

		public static List<Student> ListOfStudents = new List<Student>
		{
			new Student(13192, "Olivia Brown", new List<double>() { 72.5, 89.2, 61.8, 95.3, 76.1 }),
			new Student(15876, "Emily Johnson", new List<double>() { 63.7, 83.4, 97.0, 67.9, 74.6 }),
			new Student(29956, "Noah Davis", new List<double>() { 79.2, 66.8, 91.5, 62.3, 88.7 }),
			new Student(38987, "Liam Smith", new List<double>() { 71.9, 98.6, 65.4, 82.1, 69.0 }),
			new Student(67890, "William Anderson", new List<double>() { 80.3, 94.7, 68.2, 77.8, 86.6 })
		};
	}
}