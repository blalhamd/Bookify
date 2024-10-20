namespace Bookify.DataAccess.Seed
{
	public static class SeedData
	{
		public static IEnumerable<Category> LoadCategories()
		{
			return new List<Category>()
			{
				new Category()
				{
					Id = 1,
					Name = "Fighting",
					CreatedByUserId = 1,
				},
				new Category()
				{
					Id = 2,
					Name = "Adventure",
					CreatedByUserId = 1,
				},
				new Category()
				{
					Id = 3,
					Name = "Fiction",
					CreatedByUserId = 1,
				}
			};
		}
	}
}
