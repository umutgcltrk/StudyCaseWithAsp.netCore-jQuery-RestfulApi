using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStudyService
    {
        void Add(Study study);
        void Delete(int id);
        void Update(int id, Study study);
        List<Study> GetAllStudy();
        Study GetStudyById(int id);
    }
}
