namespace AustinWebAPI.API.Models.Domains
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double Length { get; set; }

        public Guid RegionId { get; set; }
        public Guid WalkingDifficultyId { get; set; }

        //Nav props
        public Region Region { get; set; }
        public WalkingDifficulty WalkingDifficulty { get; set; }
    }
}
