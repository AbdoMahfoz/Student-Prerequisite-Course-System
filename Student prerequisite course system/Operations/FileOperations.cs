using System.IO;

static public class FileOperations
{
    static public void Write()
    {
        CoursesFile.Write();
        Users_SubjectsFile.WriteData();
        Subjects_UsersFile.WriteSubjects();
        UsersFile.WriteinFile();
    }
    static public class UsersFile
    {
        static ArrayList<Student> data;
        static ArrayList<Student> Data
        {
            get
            {
                if(data == null)
                {
                    Read();
                }
                return data;
            }
        }
        static public Student[] GetAllStudents()
        {
            return Data.ToArray();
        }
        static public void AddStudent(Student s)
        {
            Data.Append(s);
            Users_SubjectsFile.RegisterStudent(s);
        }
        static public bool DeleteStudent(Student s)
        {
            for (int i = 0; i < Data.Count; i++)
            {
                if (Data[i] == s)
                {
                    Users_SubjectsFile.DeleteStudent(s);
                    Subjects_UsersFile.DeleteStudent(s);
                    Data.DeleteAt(i);
                    return true;
                }
            }
            return false;
        }
        static public Student GetUser(int ID)
        {
            foreach (Student s in Data)
            {
                if (s.ID == ID)
                {
                    return s;
                }
            }
            return null;
        }
        static void Read()
        {
            if (data != null) return;
            data = new ArrayList<Student>();
            if (!File.Exists("User.txt"))
            {
                return;
            }
            FileStream fs = new FileStream("User.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] Records, Fields;
            Records = sr.ReadToEnd().Split('#');
            sr.Close();
            for (int i = 0; i < Records.Length; i++)
            {
                Fields = Records[i].Split('@');
                if (Fields.Length == 1) continue;
                data.Append(new Student()
                {
                    ID = int.Parse(Fields[0]),
                    Name = Fields[1],
                    Password = Fields[2],
                    AcademicYear = Fields[3],
                    RegisteredCourses = Users_SubjectsFile.GetSubjects(int.Parse(Fields[0])),
                });
            }
            sr.Close();
        }
        static public void WriteinFile()
        {
            if (data == null) return;
            FileStream fs = new FileStream("User.Txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            string Recordss = "";
            for (int i = 0; i < Data.Count; i++)
            {
                Recordss += Data[i].ID + "@" + Data[i].Name + "@" + Data[i].Password + "@" + Data[i].AcademicYear;
                if (i != Data.Count - 1) Recordss += '#';
            }
            sw.Write(Recordss);
            sw.Close();
        }
        static public int CheckUser(string Name, string Password)
        {
            bool found = false;
            bool RightPass = false;
            int res = -1;
            for (int i = 0; i < Data.Count; i++)
            {
                if (Data[i].Name.CompareTo(Name) == 0)
                {
                    found = true;
                    if (Data[i].Password.CompareTo(Password) == 0)
                    {
                        RightPass = true;
                    }
                    res = Data[i].ID;
                    break;
                }
            }
            if (found && RightPass) return res;
            else return -1;
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
        static ArrayList<Course> data = null;
        static ArrayList<Course> Data
        {
            get
            {
                if(data == null)
                {
                    Read();
                }
                return data;
            }
        }
        static void Read()
        {
            if (data != null) return;
            data = new ArrayList<Course>();
            FileStream fs = new FileStream("Courses.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string[] Records, Fields;
            Records = sr.ReadToEnd().Split('#');
            sr.Close();
            for (int i = 0; i < Records.Length; i++)
            {
                Fields = Records[i].Split('@');
                if (Fields.Length == 1) continue;
                Course course = new Course()
                {
                    Name = Fields[0],
                    Description = Fields[1]
                };
                data.Append(course);
            }
        }
        static public void DeleteCourse(Course c)
        {
            for (int i = 0; i < Data.Count; i++)
            {
                if (Data[i] == c)
                {
                    Subjects_UsersFile.DeleteCourse(c);
                    Users_SubjectsFile.DeleteCourse(c);
                    Data.DeleteAt(i);
                    return;
                }
            }
        }
        static public bool AddCourse(Course c)
        {
            foreach (Course s in Data)
            {
                if (s.Name == c.Name)
                {
                    return false;
                }
            }
            Data.Append(c);
            Subjects_UsersFile.RegisterCourse(c);
            return true;
        }
        static public Course GetCourse(string name)
        {
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
            return Data.ToArray();
        }
        static public void Write()
        {
            if (data == null)
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
            if (str != "")
            {
                SW.Write(str.Substring(0, str.Length - 1));
            }
            SW.Close();
        }
    }
    static public class TreeFile
    {
        static public void Write(string[] data)
        {
            FileStream file = new FileStream("Tree.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            foreach (string s in data)
            {
                writer.WriteLine(s);
            }
            writer.Close();
        }
        static public string[] Read()
        {
            if (!File.Exists("Tree.txt"))
            {
                return null;
            }
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
        static ArrayList<Pair<int, ArrayList<Pair<bool, Course>>>> data = null;
        static ArrayList<Pair<int, ArrayList<Pair<bool, Course>>>> Data
        {
            get
            {
                if (data == null)
                {
                    LoadData();
                }
                return data;
            }
        }
        static void LoadData()
        {
            FileStream FS = new FileStream("Users_Subjects.txt", FileMode.OpenOrCreate);
            StreamReader SR = new StreamReader(FS);
            data = new ArrayList<Pair<int, ArrayList<Pair<bool, Course>>>>();
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
                    if (fields[i] == "") continue;
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
                data.Append(sn);
            }
            SR.Close();
        }
        static public void DeleteStudent(Student s)
        {
            for(int i = 0; i < Data.Count; i++)
            {
                if(Data[i].First == s.ID)
                {
                    Data.DeleteAt(i);
                    return;
                }
            }
        }
        static public void DeleteCourse(Course c)
        {
            foreach(Pair<int, ArrayList<Pair<bool, Course>>> P in Data)
            {
                for(int i = 0; i < P.Second.Count; i++)
                {
                    if(P.Second[i].Second.Name == c.Name)
                    {
                        P.Second.DeleteAt(i);
                        break;
                    }
                }
            }
        }
        static public void RegisterStudent(Student s)
        {
            Data.Append(new Pair<int, ArrayList<Pair<bool, Course>>>()
            {
                First = s.ID,
                Second = s.RegisteredCourses
            });
        }
        static public ArrayList<Pair<bool, Course>> GetSubjects(int ID)
        {
            for (int i = 0; i < Data.Count; i++)
            {
                if (ID == Data[i].First)
                {
                    return Data[i].Second;
                }
            }
            return null;
        }
        static public void WriteData()
        {
            if (data == null) return;
            FileStream fs = new FileStream("Users_Subjects.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < Data.Count; i++)
            {
                sw.Write(Data[i].First.ToString());
                if(Data[i].Second.Count > 0)
                {
                    sw.Write('@');
                }
                for (int j = 0; j < Data[i].Second.Count; j++)
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
        static ArrayList<Pair<Course, ArrayList<Student>>> data = null;
        static ArrayList<Pair<Course, ArrayList<Student>>> Data
        {
            get
            {
                if(data == null)
                {
                    LoadData();
                }
                return data;
            }
        }
        static void LoadData()
        {
            FileStream FS = new FileStream("Subjects_User.txt", FileMode.OpenOrCreate);
            StreamReader SR = new StreamReader(FS);
            data = new ArrayList<Pair<Course, ArrayList<Student>>>();
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
                    if (fields[i] == "") continue;
                    s.Append(UsersFile.GetUser(int.Parse(fields[i])));
                }
                cs.First = c;
                cs.Second = s;
                data.Append(cs);
            }
            SR.Close();
        }
        static public void DeleteCourse(Course c)
        {
            for(int i = 0; i < Data.Count; i++)
            {
                if(Data[i].First == c)
                {
                    Data.DeleteAt(i);
                    return;
                }
            }
        }
        static public void DeleteStudent(Student s)
        {
            foreach(Pair<Course, ArrayList<Student>> P in Data)
            {
                for(int i = 0; i < P.Second.Count; i++)
                {
                    if(P.Second[i].ID == s.ID)
                    {
                        P.Second.DeleteAt(i);
                        break;
                    }
                }
            }
        }
        static public void RegisterCourse(Course c)
        {
            Data.Append(new Pair<Course, ArrayList<Student>>()
            {
                First = c,
                Second = new ArrayList<Student>()
            });
        }
        static public void DeleteStudentFromCourse(Course c, Student s)
        {
            foreach(Pair<Course, ArrayList<Student>> P in Data)
            {
                if(P.First.Name == c.Name)
                {
                    for(int i = 0; i < P.Second.Count; i++)
                    {
                        if(P.Second[i].ID == s.ID)
                        {
                            P.Second.DeleteAt(i);
                            break;
                        }
                    }
                    break;
                }
            }
        }
        static public void UpdateSubject(Course c, Student s)
        {
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
            if (data == null) return;
            FileStream fs = new FileStream("Subjects_User.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < Data.Count; i++)
            {
                sw.Write(Data[i].First.Name);
                if (Data[i].Second.Count > 0) sw.Write('@');
                for (int j = 0; j < Data[i].Second.Count; j++)
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