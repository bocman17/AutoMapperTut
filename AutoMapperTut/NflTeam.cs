namespace AutoMapperTut
{
    public class NflTeam
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string StarPlayer { get; set; } = string.Empty;
        public int? SuperBowls { get; set; }
        public DateTime Founded { get; set; }
        public DateTime? Modified { get; set; }
    }
}
