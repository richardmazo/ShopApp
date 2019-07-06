namespace Data
{
    using ShopAppWeb.Data;
    using ShopAppWeb.Data.Entities;
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContext context) : base(context)
        {

        }
    }
}
