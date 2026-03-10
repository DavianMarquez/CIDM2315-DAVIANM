namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //Q1 and Q2
        Professor prof1 = new Professor();
        prof1.profName = "Alice";
        prof1.profTeach = "Java";
        prof1.SetSalary(9000);

        Professor prof2 = new Professor();
        prof2.profName = "Bob";
        prof2.profTeach = "Math";
        prof2.SetSalary(8000);

        Student student1 = new Student();
        student1.studentName = "Lisa";
        student1.studentCourse = "Java";
        student1.SetGrade(90);

        Student student2 = new Student();
        student2.studentName = "Tom";
        student2.studentCourse = "Math";
        student2.SetGrade(80);

        Console.WriteLine("Professor " + prof1.profName + " teaches " + prof1.profTeach + ", and the salary is: " + prof1.GetSalary());
        Console.WriteLine("Professor " + prof2.profName + " teaches " + prof2.profTeach + ", and the salary is: " + prof2.GetSalary());

        Console.WriteLine("Student " + student1.studentName + " enrolls " + student1.studentCourse + ", and the grade is: " + student1.GetGrade());
        Console.WriteLine("Student " + student2.studentName + " enrolls " + student2.studentCourse + ", and the grade is: " + student2.GetGrade());

        double salaryDiff = prof1.GetSalary() - prof2.GetSalary();
        Console.WriteLine("The salary difference between Alice and Bob is: " + salaryDiff);
        
        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine("The total grade of Lisa and Tom is: " + totalGrade);
    }
    class Professor
    {
        //code for Professor class
        public string profName;
        public string profTeach;
        private double salary;

        public void SetSalary(double salary_amount)
        {
            salary = salary_amount;
        }

        public double GetSalary()
        {
            return salary;
        }
    }
    class Student
    {
        // code for Student class
        public string studentName;
        public string studentCourse;
        private double grade;

        public void SetGrade(double NewGrade)
        {
            grade = NewGrade;
        }
        public double GetGrade()
        {
            return grade; 
        }
    }
}
