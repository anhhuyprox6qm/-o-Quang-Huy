namespace Lab4
{
    public class Student: Person
    {
        public int Program { set; get; }
        public override string ToString()
        {
            return $" Name: {Name}, Phone: {Phone}, Address: {Address}, Email: {Email}, Program: {Program}";
        }
    }
}