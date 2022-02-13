namespace floatType.Models
{
    public class Student
    {
        public string Name; // field 
        public string LastName { get; set; } //field 
        private static int Salary { get; set; }
        protected bool Love { get; set; } = true; //deafult holatda. 
        public bool IsDrink { get; } = true;// set -o'rnatish yo'q // read only -faqat o'qish uchun

        public Student(string name, string lastname)
        {
            this.Name = name;
            this.LastName = lastname;
        }

        public Student(string name)
        {
            this.Name = name;
        }
        public Student()
        {

        }

        public void setDrink(bool isdrink)
        {
            //IsDrink = isdrink;
        }
        public static void SetSalary(int sum)
        {
            Salary = sum;
        }

        public int GetSalary()
        {
            return Salary;
        }

        public bool CheckLoving()
        {
            return Love;
        }
    }
}