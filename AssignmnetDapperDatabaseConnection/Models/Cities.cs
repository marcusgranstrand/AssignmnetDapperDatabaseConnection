namespace AssignmnetDapperDatabaseConnection.Models
{
	public class Cities
	{
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Population { get; set; }
        public string? CountryCode { get; set; }
        public double LifeExpectancy { get; set; }
        public string? CountryName { get; set; }
		public string? Continent { get; set; }
    }
}
