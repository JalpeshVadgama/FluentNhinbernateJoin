namespace FluentNhibernateJoin
{
    public class Employee
    {
        public virtual int EmployeeId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int DepartmentId { get; set; }
    }
}