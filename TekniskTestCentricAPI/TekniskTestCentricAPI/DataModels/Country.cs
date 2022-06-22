namespace TekniskTestCentricAPI.DataModels
{
    public class Country
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid ContinentId { get; set; }

        public Continent Continent { get; set; }



    }
}
