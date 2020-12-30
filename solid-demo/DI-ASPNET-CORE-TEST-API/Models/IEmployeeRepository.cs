namespace solid_demo.Models
{
    public interface IEmployeeRepository
    {
         Employee GetEmployeeById(int Id);
    }
}