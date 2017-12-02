using System;
using System.IO;

static public class FileOperations
{
    static public void Write()
    {
        CoursesFile.Write();
        Users_SubjectsFile.WriteData();
        Subjects_UsersFile.WriteSubjects();
    }
    static public class UsersFile
    {
        static public void WriteUser(Student s)
        {
            FileStream FW = new FileStream("User.Txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FW);
            SW.WriteLine(s.ID + "@" + s.Name + "@" + s.Password + "@" + s.AcademicYear);
            SW.Close();
        }
        static public bool CheckUser(Student s)
        {
            FileStream FR = new FileStream("User.Txt", FileMode.Open);
            StreamReader SR = new StreamReader(FR);
            bool found = false;
            while ((SR.Peek() != -1) && (found == false))
            {
                string Recored = SR.ReadLine();
                string[] field;
                field = Recored.Split('@');
                string ID = field[0];
                string Name = field[1];
                string password = field[2];
                string Academic_Year = field[3];
                if ((s.Name.CompareTo(Name) == 0) && (s.Password.CompareTo(password) == 0))
                    found = true;
            }
            SR.Close();
            if (found == true)
                return true;
            else
                return false;
        }
        static public Student GetUser(int ID)
        {
            FileStream fs = new FileStream("User.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] Records, Fields;
            bool found = false;
            Records = sr.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            sr.Close();
            int index = 0;
            for (int i = 0; i < Records.Length - 1; i++)
            {
                Fields = Records[i].Split('@');
                if (int.Parse(Fields[0]) == ID)
                {
                    found = true;
                    index = i;
                    break;
                }
            }
            if (found == false)
            {
                return null;
            }
            else
            {
                Student student = new Student();
                Fields = Records[index].Split('@');
                student.ID = int.Parse(Fields[0]);
                student.Name = Fields[1];
                student.Password = Fields[2];
                student.AcademicYear = Fields[3];
                return student;
            }
        }
    }
    static public class AdminFile
    {
        static public void WriteAdmin(Admin s)
        {
            FileStream FW = new FileStream("Admin.Txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FW);
            SW.WriteLine(s.Name + "@" + s.Password);
            SW.Close();
        }
        static public bool CheckAdmin(Admin s)
        {
            FileStream FR = new FileStream("Admin.Txt", FileMode.Open);
            StreamReader SR = new StreamReader(FR);
            bool found = false;
            while ((SR.Peek() != -1) && (found == false))
            {
                string Recored = SR.ReadLine();
                string[] field;
                field = Recored.Split('@');
                string Name = field[0];
                string password = field[1];
                if ((s.Name.CompareTo(Name) == 0) && (s.Password.CompareTo(password) == 0))
                    found = true;
            }
            SR.Close();
            if (found == true)
                return true;
            else
                return false;
        }
    }
    static public class CoursesFile
    {
        static ArrayList<Course> Data = null;
        static void Read()
        {
            if (Data != null) return;
            Data = new ArrayList<Course>();
            FileStream fs = new FileStream("Courses.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] Records, Fields;
            Records = sr.ReadToEnd().Split('#');
            sr.Close();
            for (int i = 0; i < Records.Length - 1; i++)
            {
                Fields = Records[i].Split('@');
                Course course = new Course()
                {
                    Name = Fields[0],
                    Description = Fields[1]
                };
                Data.Append(course);
            }
        }
        static public bool AddCourse(Course c)
        {
            if (Data == null)
            {
                Read();
            }
            foreach (Course s in Data)
            {
                if (s.Name == c.Name)
                {
                    return false;
                }
            }
            Data.Append(c);
            return true;
        }
        static public Course GetCourse(string name)
        {
            if (Data == null)
            {
                Read();
            }
            foreach (Course c in Data)
            {
                if (c.Name == name)
                {
                    return c;
                }
            }
            return null;
        }
        static public Course[] GetAllCourse()
        {
            if (Data == null)
            {
                Read();
            }
            return Data.ToArray();
        }
        static public void Write()
        {
            if (Data == null)
            {
                return;
            }
            FileStream FS = new FileStream("Courses.txt", FileMode.Create);
            StreamWriter SW = new StreamWriter(FS);
            string str = "";
            foreach (Course c in Data)
            {
                str += c.Name + "@" + c.Description + "#";
            }
            SW.Write(str.Substring(0, str.Length - 1));
            SW.Close();
        }
    }
    static public class TreeFile
    {
        static public void Write(string[] data)
        {
            FileStream file = new FileStream("Tree.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            foreach (string s in data)
            {
                writer.WriteLine(s);
            }
            writer.Close();
        }
        static public string[] Read()
        {
            ArrayList<string> list = new ArrayList<string>();
            FileStream file = new FileStream("Tree.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                list.Append(reader.ReadLine());
            }
            reader.Close();
            return list.ToArray();
        }
    }
    static public class Users_SubjectsFile
    {
        static ArrayList<Pair<int, ArrayList<Pair<bool, Course>>>> Data = null;
        static void LoadData()
        {
            FileStream FS = new FileStream("Users_Subjects.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            Data = new ArrayList<Pair<int, ArrayList<Pair<bool, Course>>>>();
            while (!SR.EndOfStream)
            {
                ArrayList<Pair<bool, Course>> s = new ArrayList<Pair<bool, Course>>();
                Pair<int, ArrayList<Pair<bool, Course>>> sn = new Pair<int, ArrayList<Pair<bool, Course>>>();
                int n;
                string line = SR.ReadLine();
                string[] fields = line.Split('@');
                n = int.Parse(fields[0]);
                for (int i = 1; i < fields.Length; i += 2)
                {
                    Pair<bool, Course> bc = new Pair<bool, Course>();
                    if (fields[i] == "1")
                    {
                        bc.First = true;
                    }
                    else
                    {
                        bc.First = false;
                    }
                    bc.Second = CoursesFile.GetCourse(fields[i + 1]);
                    s.Append(bc);
                }
                sn.First = n;
                sn.Second = s;
                Data.Append(sn);
            }
            SR.Close();
        }
        static public ArrayList<Pair<bool, Course>> GetSubjects(Student s)
        {
            if (Data == null)
            {
                LoadData();
            }
            for (int i = 0; i < Data.Count; i++)
            {
                if (s.ID == Data[i].First)
                {
                    return Data[i].Second;
                }
            }
            return null;
        }
        static public void WriteData()
        {
            if (Data == null) return;
            FileStream fs = new FileStream("Users_Subjects.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < Data.Count; i++)
            {
                sw.Write(Data[i].First.ToString() + "@");
                for (int j = 0; i < Data[i].Second.Count; j++)
                {
                    if (Data[i].Second[j].First)
                    {
                        sw.Write("1@");
                    }
                    else
                    {
                        sw.Write("0@");
                    }
                    sw.Write(Data[i].Second[j].Second.Name);
                    if (j != Data[i].Second.Count - 1)
                        sw.Write("@");
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
    static public class Subjects_UsersFile
    {
        static ArrayList<Pair<Course, ArrayList<Student>>> Data = null;
        static void LoadData()
        {
            FileStream FS = new FileStream("Subjects_User.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            Data = new ArrayList<Pair<Course, ArrayList<Student>>>();
            while (!SR.EndOfStream)
            {
                ArrayList<Student> s = new ArrayList<Student>();
                Pair<Course, ArrayList<Student>> cs = new Pair<Course, ArrayList<Student>>();
                Course c;
                string line = SR.ReadLine();
                string[] fields = line.Split('@');
                c = CoursesFile.GetCourse(fields[0]);
                for (int i = 1; i < fields.Length; i++)
                {
                    s.Append(UsersFile.GetUser(int.Parse(fields[i])));
                }
                cs.First = c;
                cs.Second = s;
                Data.Append(cs);
            }
            SR.Close();
        }
        static public void UpdateSubject(Course c, Student s)
        {
            if (Data == null)
            {
                LoadData();
            }
            for (int i = 0; i < Data.Count; i++)
            {
                if (c == Data[i].First)
                {
                    Data[i].Second.Append(s);
                    break;
                }
            }
        }
        static public Student[] GetStudents(Course c)
        {
            if (Data == null)
            {
                LoadData();
            }
            for (int i = 0; i < Data.Count; i++)
            {
                if (c == Data[i].First)
                {
                    return Data[i].Second.ToArray();
                }
            }
            return null;
        }
        static public void WriteSubjects()
        {
            if (Data == null) return;
            FileStream fs = new FileStream("Subjects_User.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < Data.Count; i++)
            {
                sw.Write(Data[i].First.Name + "@");
                for (int j = 0; i < Data[i].Second.Count; j++)
                {
                    sw.Write(Data[i].Second[j].ID.ToString());
                    if (j != Data[i].Second.Count - 1)
                        sw.Write("@");
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
}
