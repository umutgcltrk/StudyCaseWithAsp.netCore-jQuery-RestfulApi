using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IStudyDal
    {
        void Add(Study study);
        void Delete(int id);
        void Update(int id,Study study);
        List<Study> GetAllStudy();
        Study GetStudyById(int id);
    }
}
