using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfStudentList
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static List<Student> StudentList = new List<Student>();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        Student IService1.addStudent(string name)
        {
            var student = new Student(name);
            StudentList.Add(student);
            return student;
            
        }

        Student IService1.deleteStudent(string name)
        {
            var student = new Student(name);
            StudentList.Remove(student);
            return student;
        }

        Student IService1.editStudent(string name)
        {
            throw new NotImplementedException();
        }

        Student IService1.findStudent(string name)
        {
            throw new NotImplementedException();
        }

        Student IService1.getAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}
