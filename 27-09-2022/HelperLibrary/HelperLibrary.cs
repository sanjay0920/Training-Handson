using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disconnected_DAL;
using Disconnected_BLL;

namespace HelperLibrary
{
    public class HelperLibrary
    {
        Disconnected_DAL dal = null;
        public HelperLibrary()
        {
            dal = new Disconnected_DAL ();
        }


        public int RowCount()
        {
            return dal.RowCount();

        }
        public bool AddNew(Disconnected_BLL COURSE)
        {
            return dal.Insert(COURSE);
        }
        public Disconnected_BLL Locate(Disconnected_BLL course)
        {

            return dal.Find(course.CourseID);
        }

        public List<Disconnected_BLL> EmployeeList()
        {
            return dal.ShowAll();
        }

        public bool Remove(Disconnected_BLL Course)
        {
            return dal.Delete(Course.CourseID);
        }



        public bool Edit(Disconnected_BLL Course)
        {
            return dal.Update(Course.CourseID, Course);
        }



    }


}
