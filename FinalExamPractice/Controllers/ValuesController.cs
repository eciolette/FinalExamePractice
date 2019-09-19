﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;       
using System.Net.Http;
using System.Web.Http;

namespace FinalExamPractice.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public List<FinalExamPratice>ListStudentsBirth(DateTime date)
        {
            GrupoBhmaisEntities myDB = new GrupoBhmaisEntities();
            List<FinalExamPratice> listBirth = myDB.FinalExamPratices.Where(s => s.BirthDate == date).ToList<FinalExamPratice>();
            return listBirth;
        }
        [HttpGet]
        public List<FinalExamPratice>ListStudentsEmail(string email)
        {
            GrupoBhmaisEntities myDB = new GrupoBhmaisEntities();
            List<FinalExamPratice> listEmail = myDB.FinalExamPratices.Where(s => s.EmailAddress == email).ToList<FinalExamPratice>();
            return listEmail;
        }
        [HttpGet]
        public List<FinalExamPratice>ListStudentsLast(string lastName)
        {
            GrupoBhmaisEntities myDB = new GrupoBhmaisEntities();
            List<FinalExamPratice> listLastName = myDB.FinalExamPratices.Where(s => s.LastName == lastName).ToList<FinalExamPratice>();
            return listLastName;
        }
        //----------------------------------
        [HttpGet]
        public List<FinalExamPratice>ListStudents()
        {
            GrupoBhmaisEntities myDB = new GrupoBhmaisEntities();
            List<FinalExamPratice> listStudents = myDB.FinalExamPratices.Where(s => s.Id > 0).ToList<FinalExamPratice>();
            return listStudents;
        }

        [HttpGet]
        public List<FinalExamPratice>ListGender()
        {
            GrupoBhmaisEntities myDB = new GrupoBhmaisEntities();
            List<FinalExamPratice> listGender = myDB.FinalExamPratices.Where(s => s.Id > 0).ToList<FinalExamPratice>();
            return listGender;
        }
        // GET api/values/5
        public string Get(int id)
        {
            return "GET WITH ID value";
        }

        // POST api/values
        [HttpGet]
        public string PostNewStudent(string FirstName, string LastName, string EmailAddress, DateTime BirthDate, string Gender)
        {
            GrupoBhmaisEntities myDB = new GrupoBhmaisEntities();
            FinalExamPratice myStudent = new FinalExamPratice();


            myStudent.FirstName = FirstName;
            myStudent.LastName = LastName;
            myStudent.EmailAddress = EmailAddress;
            myStudent.BirthDate = BirthDate;
            myStudent.Gender = Gender;

            myDB.FinalExamPratices.Add(myStudent);

            myDB.SaveChanges();

            return "POST Success!";
        }

        [HttpGet]
        public string PutStudents(int id, string FirstName, string LastName, string EmailAddress, DateTime BirthDate, string Gender)
        {
            GrupoBhmaisEntities myDB = new GrupoBhmaisEntities();
            FinalExamPratice myStudent = myDB.FinalExamPratices.Where(s => s.Id == id).FirstOrDefault();

            myStudent.FirstName = FirstName;
            myStudent.LastName = LastName;
            myStudent.EmailAddress = EmailAddress;
            myStudent.BirthDate = BirthDate;
            myStudent.Gender = Gender;

            myDB.SaveChanges();

            return "PUT Success!";
        }

        // DELETE api/values/5
        [HttpGet]
             public string RemoveStudents(int id)
        {

            GrupoBhmaisEntities myDB = new GrupoBhmaisEntities();
            FinalExamPratice myStudent = myDB.FinalExamPratices.Where(s => s.Id == id).FirstOrDefault();

            myDB.FinalExamPratices.Remove(myStudent);
            myDB.SaveChanges();

            return "DELETE Success!";
        }
    }

}
