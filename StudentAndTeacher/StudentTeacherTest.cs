using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTeacher
{
    public static class StudentTeacherTest
    {
        public static void Main(){
        Person person = new Person();

        person.Greet();

        Student student = new Student();

        student.SetAge(18);
        student.Greet();
        student.ShowAge();

        Teacher teacher = new Teacher();
        teacher.Greet();
        teacher.Explain();

        }
}


}
