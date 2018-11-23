namespace WebApp.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Number { get; set; }
        
        public virtual User User { get; set; }
    }
}