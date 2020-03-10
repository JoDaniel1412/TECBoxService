namespace TECBoxService.Models
{
    public class Client : Person
    {
        public string Email { get; set; }
        public int Locker { get; set; }
        public int CellPhone { get; set; }
        public int HomePhone { get; set; }
        public Place Direction { get; set; }
    }
}