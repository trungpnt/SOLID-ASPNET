namespace solid_demo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Dept { get; set; }
        
        public string Email { get; set; }
        
        public Employee(int id, string name, string dept, string email)
        {
            Id = id;
            Name = name;
            Dept = dept;
            Email = email;  
        }
        

    }
}