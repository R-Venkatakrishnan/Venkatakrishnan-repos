using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace day12

{
    [Serializable]
    class Employeedets
    {

        public string name = "Venkat";
        public int age = 25;
        public string Empid = "38110638";
        public string gender = "Male";

    }
    class day12task
    {
        public void SeretoFile()
        {
            Employeedets sobj = new Employeedets();
            FileStream fs = new FileStream("emplo.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(fs, sobj);
            fs.Close();
        }
        public void Dserial()
        {
            FileStream fs = new FileStream("emplo.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            Employeedets stu = (Employeedets)f.Deserialize(fs);
            Console.WriteLine(stu.name);
            Console.WriteLine(stu.age);
            Console.WriteLine(stu.gender);
            Console.WriteLine(stu.Empid);



        }

        public static void Main()
        {
            day12task lobj = new day12task();
            lobj.SeretoFile();
            lobj.Dserial();
            Console.ReadLine();

        }
    }
}