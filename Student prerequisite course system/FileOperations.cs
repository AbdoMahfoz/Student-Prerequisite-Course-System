using System;
using System.IO;

static public class FileOperations
{
    static public class UsersFile
    {
        static public void WriteUser(Student s)
        {
            throw new NotImplementedException();
        }
        static public bool CheckUser(Student s)
        {
            throw new NotImplementedException();
        }
    }
    static public class AdminFile
    {
        static public void WriteAdmin(Admin s)
        {
            throw new NotImplementedException();
        }
        static public void CheckAdmin(Admin s)
        {
            throw new NotImplementedException();
        }
    }
    static public class CoursesFile
    {
        static public void AddCourse(Course c)
        {
            FileStream FS = new FileStream("Courses.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FS);
            string str = c.Name + "@" + c.Description + "#";
            SW.Write(str);
            SW.Close();

        }
        static public Course GetCourse(string name)
        {
            FileStream fs = new FileStream("Courses.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] Records, Fields;
            bool found = false;
            Records = sr.ReadToEnd().Split('#');
            sr.Close();
            int index = 0;
            for (int i = 0; i < Records.Length - 1; i++)
            {
                Fields = Records[i].Split('@');
                if (Fields[0] == name)
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
                Course course = new Course();
                
                
            }
        }
    }
    static public class TreeFile
    {
        static public void Write(string[] data)
        {
            FileStream file = new FileStream("Tree.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            foreach(string s in data)
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
            while(!reader.EndOfStream)
            {
                list.Append(reader.ReadLine());
            }
            reader.Close();
            return list.ToArray();
        }
    }
    static public class Users_SubjectsFile
    {
        static ArrayList<Pair<int, ArrayList<Course>>> Data = null;
        static void LoadData()
        {
            FileStream FS = new FileStream("Users_Subjects.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            Data = new ArrayList<Pair<int, ArrayList<Course>>>();
            while(!SR.EndOfStream)
            {
                ArrayList<Course> s = new ArrayList<Course>();
                Pair<int, ArrayList<Course>> sn = new Pair<int, ArrayList<Course>>();
                int n;
                string line=SR.ReadLine();
                string[] fields = line.Split('@');
                n = int.Parse(fields[0]);
                for(int i = 1; i < fields.Length; i++)
                {
                    s.Append(CoursesFile.GetCourse(fields[i]));
                }
                sn.First = n;
                sn.Second = s;
                Data.Append(sn);
            }
            SR.Close();
        }
        static public void UpdateUser(Student s, Course c)
        {
            if(Data == null)
            {
                LoadData();
            }
            for(int i = 0; i < Data.Count; i++)
            {
                if (s.ID == Data[i].First)
                {
                    Data[i].Second.Append(c);
                    break;
                }
            }
        }
        static public Course[] GetSubjects(Student s)
        {
            if (Data == null)
            {
                LoadData();
            }
            for (int i = 0; i < Data.Count; i++)
            {
                if (s.ID == Data[i].First)
                {
                    return Data[i].Second.ToArray();
                }
            }
            return null;
        }
        static public void WriteData()
        {
            FileStream fs = new FileStream("Users_Subjects.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for(int i = 0; i < Data.Count; i++)
            {
                sw.Write(Data[i].First.ToString() + "@");
                for(int j = 0; i < Data[i].Second.Count; j++)
                {
                    sw.Write(Data[i].Second[j].Name);
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
        static public void UpdateSubject(Course c, Student s)
        {
            throw new NotImplementedException();
        }
        static public Student[] GetStudents(Course c)
        {
            throw new NotImplementedException();
        }
    }
}
