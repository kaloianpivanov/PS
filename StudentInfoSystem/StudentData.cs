﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class StudentData
    {
        public List<Student> TestStudents { get; } = new List<Student>();

        public StudentData()
        {
            Student student = new Student() { Name="Gosho", Surname="Petrov", Family="Todorov", Faculty="FKST", Speciality="ITI",
            Degree="Bakalavur", Status="deistvasht", FacNum="90488485", Course=1, Stream=9,Group=34,};
            TestStudents.Add(student);
        }
    }
}
