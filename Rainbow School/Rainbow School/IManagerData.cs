using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow_Schools.Interfaces
{
    interface IManagerData
    {
        
        Boolean Data();

        void ShowStudants();

       
        void ShowTeachers();

        
        List<string> SearchByName(string search);

        
        List<Person> GetStudantsByClass(string classe);

        
        List<Subject> GetSubjectsByTeacher(string teacher);
    }
}