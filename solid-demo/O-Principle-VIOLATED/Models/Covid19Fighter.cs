namespace D_Principle_VIOLATED.Models
{
    public class Covid19Fighter
    {
        public int Id { get; set; }
        
        
        public string Name { get; set; }
        
        public bool working { get; set; }

        public Covid19Fighter(int id, string name, bool working)
        {
            Id = id;
            Name = name;
            this.working = working;
        }
    }
}