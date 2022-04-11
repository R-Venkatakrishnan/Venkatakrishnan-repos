using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
namespace ConsoleApp2
{
    class Class11
    {
        public static void Main()
        {
            IList<Doctor> DocData = new List<Doctor>()
            {
                new Doctor() { DoctorID = 1, DoctorName = "Dr.venkat", Age = 26, SpecializationId = 1},
                new Doctor() { DoctorID = 2, DoctorName = "Dr.Giri", Age = 29, SpecializationId = 2},
                new Doctor() { DoctorID = 3, DoctorName = "Dr.John", Age = 30, SpecializationId = 3},
                new Doctor() { DoctorID = 4, DoctorName = "Dr.vishal", Age = 36, SpecializationId = 4},
                new Doctor() { DoctorID = 5, DoctorName = "Dr.vignesh", Age = 38, SpecializationId = 5},
                new Doctor() { DoctorID = 6, DoctorName = "Dr.haris", Age = 40, SpecializationId = 6},
                new Doctor() { DoctorID = 7, DoctorName = "Dr.shivaa", Age = 52, SpecializationId = 7},
                new Doctor() { DoctorID = 8, DoctorName = "Dr.Ananth", Age = 39, SpecializationId = 8},
            };
            IList<Specialization> SpecData = new List<Specialization>()
            {
                new Specialization() { SpecializationId = 1, SpecializationName = "Ortho"},
                new Specialization() { SpecializationId = 2, SpecializationName = "dental"},
                new Specialization() { SpecializationId = 3, SpecializationName = "physio"},
                new Specialization() { SpecializationId = 4, SpecializationName = "ortho"},
                new Specialization() { SpecializationId = 5, SpecializationName = "GS"},
                new Specialization() { SpecializationId = 6, SpecializationName = "HS"},
                new Specialization() { SpecializationId = 7, SpecializationName = "Gynaecologist"},
                new Specialization() { SpecializationId = 8, SpecializationName = "ortho" }
            };
            var JoinData = DocData.Join(
                SpecData,
                stu => stu.SpecializationId,
                doc => doc.SpecializationId,
                (stu, doc) => new
                {
                    DocName = stu.DoctorName,
                    SpecData = doc.SpecializationName

                }
                );
            foreach (var item in JoinData)
            {
                Console.WriteLine(item.DocName + " " + item.SpecData);










            }
        }
        public class Specialization
        {
            public int SpecializationId { get; set; }
            public string SpecializationName { get; set; }
        }

        class Doctor
        {

            public int DoctorID { get; set; }
            public string DoctorName { get; set; }
            public int Age { get; set; }
            public int SpecializationId { get; set; }
        }
    }
}

