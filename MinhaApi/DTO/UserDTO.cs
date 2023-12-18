namespace MinhaApi.DTO
{
    public class UserDTO
    {
        public int Document { get; set; }
        public int Telephone1 { get; set; }
        public int? Telephone2 { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int Type { get; set; }
        public string CNH { get; set; }
        public string Photo { get; set; }
    }
}
