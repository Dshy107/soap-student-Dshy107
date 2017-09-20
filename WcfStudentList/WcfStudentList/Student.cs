using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfStudentList
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Id { get; set; }
        public Student(string name)
        {
            Name = name;
        }
        public Student()
        {

        }
    }
}