class Program
{
    static void Main(string[] args)
    {
        var student1 = new Student() { Id = 1, FirstName = "St1 first", LastName = "St1 last" };
        var student2 = new MyClass() { Id = 2, FirstName = "St2 first", LastName = "St2 last" };
        var student3 = new Student() { Id = 3, FirstName = "St2 first", LastName = "St2 last" };
        Console.WriteLine(student2.IsEqual(student1));
        Console.WriteLine(student2.IsEqual(student3));
    }

    public abstract class GenericTestClassBase<T>
    {
        public T Params { get; set; }
        public abstract bool IsEqual(T param);
    }
    public class MyClass : GenericTestClassBase<Student>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override bool IsEqual(Student param)
        {
            if (param.FirstName == this.FirstName && param.LastName == this.LastName) return true;
            return false;
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}