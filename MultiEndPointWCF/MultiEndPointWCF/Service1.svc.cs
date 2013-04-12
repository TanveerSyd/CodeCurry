using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MultiEndPointWCF;
using Reference.Repository;

namespace MultiEndPointWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public class Service1 : IStudentService
    {
        //public Reference.Repository.Student GetStudentById(int value)
        //{
        //    StudentRepository rs = new StudentRepository();
        //    return rs.GetStudent(17);

        //    //return new Student { StudentID = 1, FirstName = "Rowan", LastName = "Atkinson", Age = 55 };
        //}

        public Student GetStudent()
        {
            StudentRepository rs = new StudentRepository();
            //return rs.GetStudent(17).ToString();
           // return "Bullocks";

            return new Student { StudentID = 1, FirstName = "Rowan", LastName = "Atkinson", Age = 55 };
        }

    }
}
