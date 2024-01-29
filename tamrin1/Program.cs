using System;
namespace project 
{
    public class Teacher
    {
        private string id;
        private string name;
        private string lastname;
        private int hour;
        private int payoerhour;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        public int Payperhour
        {
            get { return payoerhour; }
            set
            {
                if (value > 0)
                {
                    payoerhour = value;

                }
            }
        }
        public Teacher(string teacherId, string teacherName, string teacherLastname, int teacherHour, int teacherPayperhour)
        {
            id = teacherId;
            name = teacherName;
            lastname = teacherLastname;
            hour = teacherHour;
            payoerhour = teacherPayperhour;
        }


        public double payment()
        {
            return hour * payoerhour;
        }
    }



    class test
    {
        static void Main(string[] args)
        {
            Teacher th = new Teacher("123", "Ali", "Ahmadi", 40, 4000);
            double pay = th.payment();
            Console.WriteLine(pay);

        }
    }
}
