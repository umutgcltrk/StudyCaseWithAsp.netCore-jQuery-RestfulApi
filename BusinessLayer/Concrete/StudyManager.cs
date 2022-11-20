using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StudyManager : IStudyService
    {
        IStudyDal _studyDal;
        public StudyManager(IStudyDal studyDal)
        {
            _studyDal = studyDal;
        }
        public void Add(Study study)
        {
            _studyDal.Add(study);
        }

        public void Delete(int id)
        {
            _studyDal.Delete(id);
        }

        public List<Study> GetAllStudy()
        {
            return _studyDal.GetAllStudy();
        }

        public Study GetStudyById(int id)
        {
            return _studyDal.GetStudyById(id);
        }

        public void Update(int id,Study study)
        {
            _studyDal.Update(id,study);
        }
    }
}
