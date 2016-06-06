using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;
using ODATAExample.Models;

namespace ODATAExample.Controllers
{
    public class StudentsController : ODataController
    {

        List<Student> students = new List<Student>() { new Student { StudentId = 1, Name = "Mark", Subject = "Pure Maths", Marks = 80}, new Student { StudentId = 2, Name = "Bob", Subject = "Physics", Marks = 56 },
            new Student {StudentId = 3, Name = "Ann", Subject = "Mathamatical Induction", Marks = 89 }, new Student {StudentId = 4, Name = "Kenny", Subject = "Applied Maths", Marks = 90 },
            new Student {StudentId = 5, Name = "Rose", Subject = "Mathamatical Induction", Marks = 87 }, new Student {StudentId = 6, Name = "Mike", Subject = "Mathamatical Physics", Marks = 78 },
            new Student {StudentId = 7, Name = "Joe", Subject = "Mathamatical Physics", Marks = 87 }, new Student {StudentId = 8, Name = "Andrew", Subject = "Mathamatical Physics", Marks = 87 } };

        [EnableQuery]
        public IQueryable<Student> Get()
        {
            return students.AsQueryable();
        }

        [EnableQuery]
        public IQueryable<Student> Get(int marks)
        {
            return students.Where(s => s.Marks > marks).AsQueryable();
        }


    }
}
