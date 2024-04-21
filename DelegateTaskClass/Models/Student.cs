namespace DelegateTask.Models
{
    internal class Student
    {
        private string _name;
        private string _surname;
        private int _age;
        private short _credits;
        private int _id;
        static int count = 1;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }

        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public short Credit
        {
            get { return _credits; }
            set { _credits = value; }
        }


        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public Group Group { get; set; }

        public Student(string name, string surname, int age, short credit, Group group)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Credit = credit;
            count++;
            _id = count;
            Group = group;

        }


    }
}
