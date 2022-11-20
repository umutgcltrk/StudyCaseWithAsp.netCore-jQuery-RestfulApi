using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class StudyRepository : IStudyDal
    {
        public void Add(Study study)
        {
            using var dbconnection = new DatabaseContext();
            dbconnection.Add(study);
            dbconnection.SaveChanges();
        }

        public void Delete(int id)
        {
            using var dbconnection = new DatabaseContext();
            var deletedStudy = dbconnection.Studies.FirstOrDefault(x=> x.StudyId == id);
            dbconnection.Remove(deletedStudy);
            dbconnection.SaveChanges();
        }

        public void Update(int id,Study study)
        {
            using var dbconnection = new DatabaseContext();
            var updatedStudy = dbconnection.Studies.FirstOrDefault(x=>x.StudyId == id);
            updatedStudy.Name = study.Name;
            updatedStudy.Surname = study.Surname;
            updatedStudy.Midterm = study.Midterm;
            updatedStudy.Final = study.Final;
            dbconnection.Update(updatedStudy);
            dbconnection.SaveChanges();
        }

        public List<Study> GetAllStudy()
        {
            using var dbconnection = new DatabaseContext();
            return dbconnection.Studies.ToList();
        }

        public Study GetStudyById(int id)
        {
            using var dbconnection = new DatabaseContext();
            var listById = dbconnection.Studies.FirstOrDefault(x => x.StudyId == id);
            return listById;
        }
    }
}
