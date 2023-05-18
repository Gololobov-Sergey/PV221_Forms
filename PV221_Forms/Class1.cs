using System.Collections.Generic;
using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace PV221_Forms
{
    [Serializable]
    public class StudentCard : IComparable<StudentCard>, ICloneable
    {
        /// <summary>
        /// Номер студентського білету
        /// </summary>
        public int Number { get; set; } = 999999;

        public string Series { get; set; }

        /// <summary>
        /// Clone Student card
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Метод порівняння двох студентських квитків
        /// </summary>
        /// <param name="obj">Студентський квіток 2</param>
        /// <returns>Повернення: -1 - першій меньший, 0 - рівні, 1 - другий меньший</returns>
        public int CompareTo(StudentCard obj)
        {
            if (Series == obj.Series)
            {
                return Number.CompareTo(obj.Number);
            }
            else
            {
                return Series.CompareTo(obj.Series);
            }
        }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }
    }

    [Serializable]
    public class Student : IComparable<Student>, ICloneable, ISerializable
    {
        //[NonSerialized]
        string id = "999999";
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public StudentCard StudentCard { get; set; }

        public static IComparer<Student> FromBirthDay { get { return new DateComparer(); } }

        public static IComparer<Student> FromStudentCard { get { return new StudentCardComparer(); } }

        public int CompareTo(Student obj)
        {
            return LastName.CompareTo(obj.LastName);
        }

        public override string ToString()
        {
            return $"{LastName?.PadRight(15)} {FirstName?.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public object Clone()
        {
            Student st = this.MemberwiseClone() as Student;
            st.StudentCard = this.StudentCard.Clone() as StudentCard;
            if (this.FirstName == null)
                throw new ArgumentNullException(nameof(this.FirstName));
            return st;
        }

        public override int GetHashCode()
        {
            return $"{LastName}".GetHashCode();
        }

        //public void Exam(object sender, ExamEventArgs e)
        //{
        //    Console.WriteLine($"Для {LastName} {FirstName} екзамен по {e.Subject} назначено на {e.DateExam.ToShortDateString()}, який пройде в аудиторії {e.Room}");
        //}

        public void Exam(DateTime d)
        {
            Console.WriteLine($"Для {LastName} {FirstName} екзамен на {d.ToShortDateString()}");
        }

        public Student() { }
        private Student(SerializationInfo info, StreamingContext context)
        {
            FirstName = info.GetString("fName");
            LastName = info.GetString("lName");
            BirthDay = new DateTime(info.GetInt32("date"));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("fName", FirstName.ToUpper());
            info.AddValue("lName", LastName.ToUpper());
            info.AddValue("date", BirthDay.Year);
        }
    }


    public class Group /*: IEnumerable<Student>*/
    {
        Student[] students =
        {
            new Student()
            {
                LastName = "Osipov",
                FirstName = "Oleg",
                BirthDay = new DateTime(2000, 12, 15),
                StudentCard = new StudentCard()
                {
                    Series = "AB",
                    Number = 123456
                }
            },
            new Student()
            {
                LastName = "Petrova",
                FirstName = "Maria",
                BirthDay = new DateTime(2002, 04, 20),
                StudentCard = new StudentCard()
                {
                    Series = "AB",
                    Number = 129956
                }
            },
            new Student()
            {
                LastName = "Fedorov",
                FirstName = "Petro",
                BirthDay = new DateTime(1999, 01, 10),
                StudentCard = new StudentCard()
                {
                    Series = "AC",
                    Number = 123456
                }
            },
            new Student()
            {
                LastName = "Abrampva",
                FirstName = "Olga",
                BirthDay = new DateTime(2000, 12, 14),
                StudentCard = new StudentCard()
                {
                    Series = "AA",
                    Number = 123451
                }
            }
        };

        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < students.Length; i++)
            {
                yield return students[i];
            }
        }


        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students, comparer);
        }

        public void Sort() => Array.Sort(students);

    }

    public class DateComparer : IComparer<Student>, IComparer<Point>
    {
        public int Compare(Student x, Student y)
        {
            return DateTime.Compare(x.BirthDay, y.BirthDay);
        }

        public int Compare(Point x, Point y)
        {
            throw new NotImplementedException();
        }
    }

    public class StudentCardComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.StudentCard.CompareTo(y.StudentCard);
        }
    }


    public delegate void ExamDelegate(DateTime dateTime);


    public class ExamEventArgs : EventArgs
    {
        public DateTime DateExam { get; set; }
        public string Subject { get; set; }
        public string Room { get; set; }
    }


    public class Teacher
    {
        ////public event ExamDelegate ExamEvent1;
        ////public event Action<DateTime, ..., ...> ExamEvent;
        //public EventHandler<ExamEventArgs> ExamEvent;

        //public void Exam(ExamEventArgs e)
        //{
        //    this.ExamEvent(this, e);
        //}

        SortedList<string, ExamDelegate> list = new();

        public event ExamDelegate ExamEvent
        {
            add
            {
                list.Add((value.Target as Student).LastName, value);
            }
            remove
            {
                list.Remove((value.Target as Student).LastName);
            }
        }
        //public event Action<DateTime, ..., ...> ExamEvent;
        //public EventHandler<ExamEventArgs> ExamEvent;

        public void Exam(DateTime d)
        {
            foreach (var item in list)
            {
                item.Value(d);
            }
        }

    }
}
