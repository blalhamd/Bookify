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

		public static IEnumerable<Author> LoadAuthors()
		{
			var authors = new List<Author>
	        {
		        new Author { Id = 1, Name = "Taha Hussien", Nationality = "Egypt", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 2, Name = "Naguib Mahfouz", Nationality = "Egypt", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 3, Name = "Mahmoud Darwish", Nationality = "Palestine", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 4, Name = "Khalil Gibran", Nationality = "Lebanon", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 5, Name = "Adonis", Nationality = "Syria", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 6, Name = "Hanan al-Shaykh", Nationality = "Lebanon", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 7, Name = "Ahlam Mosteghanemi", Nationality = "Algeria", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 8, Name = "Ibrahim Nasrallah", Nationality = "Palestine", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 9, Name = "Hanan al-Shaykh", Nationality = "Lebanon", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 10, Name = "Nawal El Saadawi", Nationality = "Egypt", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 11, Name = "Yasmina Khadra", Nationality = "Algeria", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 12, Name = "Salman Rushdie", Nationality = "India", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 13, Name = "Orhan Pamuk", Nationality = "Turkey", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 14, Name = "Elif Shafak", Nationality = "Turkey", CreationTime = DateTime.Now, CreatedByUserId = 1 },
		        new Author { Id = 15, Name = "Amitav Ghosh", Nationality = "India", CreationTime = DateTime.Now, CreatedByUserId = 1 },
	        };

			return authors;
		}

		public static IEnumerable<Book> LoadBooks()
		{
			return new List<Book>
	        {
		new Book
		{
			Id = 1,
			Title = "The Cairo Trilogy",
			Description = "A sweeping saga of a family in Cairo during the early 20th century.",
			AuthorId = 1, // Assuming Taha Hussien is the author
            CreatedByUserId = 1,
			CreationTime = DateTime.Now,
			Hall = "Main Hall",
			ImageUrl = "https://example.com/cairo_trilogy.jpg",
			Price = 150,
			PublishedOn = new DateTime(1956, 1, 1),
			Type = BookType.Drama,
			Publisher = "Publishing House",
		},
		new Book
		{
			Id = 2,
			Title = "Palace Walk",
			Description = "The first book in the Cairo Trilogy, focusing on family life in Cairo.",
			AuthorId = 1,
			CreatedByUserId = 1,
			CreationTime = DateTime.Now,
			Hall = "Main Hall",
			ImageUrl = "https://example.com/palace_walk.jpg",
			Price = 120,
			PublishedOn = new DateTime(1956, 1, 1),
			Type = BookType.Drama,
			Publisher = "Publishing House",
		},
		new Book
		{
			Id = 3,
			Title = "Season of Migration to the North",
			Description = "A postcolonial narrative exploring identity and belonging.",
			AuthorId = 2, // Assuming Naguib Mahfouz is the author
            CreatedByUserId = 1,
			CreationTime = DateTime.Now,
			Hall = "Main Hall",
			ImageUrl = "https://example.com/season_of_migration.jpg",
			Price = 130,
			PublishedOn = new DateTime(1966, 1, 1),
			Type = BookType.Fiction,
			Publisher = "Publishing House",
		},
		new Book
		{
			Id = 4,
			Title = "The Prophet",
			Description = "A collection of poetic essays covering various aspects of life.",
			AuthorId = 3, // Assuming Khalil Gibran is the author
            CreatedByUserId = 1,
			CreationTime = DateTime.Now,
			Hall = "Poetry Section",
			ImageUrl = "https://example.com/the_prophet.jpg",
			Price = 90,
			PublishedOn = new DateTime(1923, 1, 1),
			Type = BookType.Poetry,
			Publisher = "Publishing House",
		},
		new Book
		{
			Id = 5,
			Title = "The Map of Love",
			Description = "A historical novel set in Egypt and America, intertwining love stories.",
			AuthorId = 4, // Assuming Ahdaf Soueif is the author
            CreatedByUserId = 1,
			CreationTime = DateTime.Now,
			Hall = "Main Hall",
			ImageUrl = "https://example.com/map_of_love.jpg",
			Price = 140,
			PublishedOn = new DateTime(1999, 1, 1),
			Type = BookType.HistoricalFiction,
			Publisher = "Publishing House",
		},
		new Book
		{
			Id = 6,
			Title = "The Yacoubian Building",
			Description = "A novel set in a once-grand building in downtown Cairo.",
			AuthorId = 5, // Assuming Alaa Al Aswany is the author
            CreatedByUserId = 1,
			CreationTime = DateTime.Now,
			Hall = "Main Hall",
			ImageUrl = "https://example.com/yacoubian_building.jpg",
			Price = 110,
			PublishedOn = new DateTime(2002, 1, 1),
			Type = BookType.Fiction,
			Publisher = "Publishing House",
		},
		new Book
		{
			Id = 7,
			Title = "The Open Door",
			Description = "A poignant coming-of-age story set in Egypt.",
			AuthorId = 6, // Assuming Latifa al-Zayyat is the author
            CreatedByUserId = 1,
			CreationTime = DateTime.Now,
			Hall = "Main Hall",
			ImageUrl = "https://example.com/open_door.jpg",
			Price = 100,
			PublishedOn = new DateTime(1960, 1, 1),
			Type = BookType.Fiction,
			Publisher = "Publishing House",
		},
		new Book
		{
			Id = 8,
			Title = "The Book of Khalid",
			Description = "A novel that blends Eastern and Western philosophies.",
			AuthorId = 7, // Assuming Ameen Rihani is the author
            CreatedByUserId = 1,
			CreationTime = DateTime.Now,
			Hall = "Main Hall",
			ImageUrl = "https://example.com/book_of_khalid.jpg",
			Price = 85,
			PublishedOn = new DateTime(1911, 1, 1),
			Type = BookType.Fiction,
			Publisher = "Publishing House",
		},
		new Book
		{
			Id = 9,
			Title = "The Return of the Spirit",
			Description = "An exploration of spirituality and identity.",
			AuthorId = 8, // Assuming Taha Hussien is the author
            CreatedByUserId = 1,
			CreationTime = DateTime.Now,
			Hall = "Main Hall",
			ImageUrl = "https://example.com/return_of_the_spirit.jpg",
			Price = 125,
			PublishedOn = new DateTime(1933, 1, 1),
			Type = BookType.Fiction,
			Publisher = "Publishing House",
		},
		new Book
		{
			Id = 10,
			Title = "My Name is Red",
			Description = "A novel set in the Ottoman Empire, blending art and politics.",
			AuthorId = 9, // Assuming Orhan Pamuk is the author
            CreatedByUserId = 1,
			CreationTime = DateTime.Now,
			Hall = "Main Hall",
			ImageUrl = "https://example.com/my_name_is_red.jpg",
			Price = 135,
			PublishedOn = new DateTime(1998, 1, 1),
			Type = BookType.Fiction,
			Publisher = "Publishing House",
			}
		};
		}

		public static IEnumerable<BookCopy> LoadCopies()
		{
			return new List<BookCopy>
	        {
		       new BookCopy { Id = 1, BookId = 1, CreationTime = DateTime.Now.AddDays(-100), EditionNumber = 1, IsAvailableForRental = true },
		       new BookCopy { Id = 2, BookId = 1, CreationTime = DateTime.Now.AddDays(-200), EditionNumber = 2, IsAvailableForRental = false },
		       new BookCopy { Id = 3, BookId = 2, CreationTime = DateTime.Now.AddDays(-50), EditionNumber = 1, IsAvailableForRental = true },
		       new BookCopy { Id = 4, BookId = 2, CreationTime = DateTime.Now.AddDays(-150), EditionNumber = 2, IsAvailableForRental = false },
		       new BookCopy { Id = 5, BookId = 3, CreationTime = DateTime.Now.AddDays(-10), EditionNumber = 1, IsAvailableForRental = true },
		       new BookCopy { Id = 6, BookId = 3, CreationTime = DateTime.Now.AddDays(-30), EditionNumber = 2, IsAvailableForRental = true },
		       new BookCopy { Id = 7, BookId = 4, CreationTime = DateTime.Now.AddDays(-60), EditionNumber = 1, IsAvailableForRental = false },
		       new BookCopy { Id = 8, BookId = 4, CreationTime = DateTime.Now.AddDays(-90), EditionNumber = 2, IsAvailableForRental = true },
		       new BookCopy { Id = 9, BookId = 5, CreationTime = DateTime.Now.AddDays(-5), EditionNumber = 1, IsAvailableForRental = true },
		       new BookCopy { Id = 10, BookId = 5, CreationTime = DateTime.Now.AddDays(-25), EditionNumber = 2, IsAvailableForRental = false },
		       new BookCopy { Id = 11, BookId = 6, CreationTime = DateTime.Now.AddDays(-35), EditionNumber = 1, IsAvailableForRental = true },
		       new BookCopy { Id = 12, BookId = 6, CreationTime = DateTime.Now.AddDays(-75), EditionNumber = 2, IsAvailableForRental = true },
		       new BookCopy { Id = 13, BookId = 7, CreationTime = DateTime.Now.AddDays(-120), EditionNumber = 1, IsAvailableForRental = false },
		       new BookCopy { Id = 14, BookId = 7, CreationTime = DateTime.Now.AddDays(-180), EditionNumber = 2, IsAvailableForRental = true },
	 	       new BookCopy { Id = 15, BookId = 8, CreationTime = DateTime.Now.AddDays(-200), EditionNumber = 1, IsAvailableForRental = true },
	       };
		}

		public static IEnumerable<BookCategory> LoadBookCategory()
		{
	  		return new List<BookCategory>
	        {
		       new BookCategory { BookId = 1, CategoryId = 1 }, // The Cairo Trilogy - Drama
               new BookCategory { BookId = 2, CategoryId = 1 }, // Palace Walk - Drama
               new BookCategory { BookId = 3, CategoryId = 2 }, // Season of Migration to the North - Fiction
               new BookCategory { BookId = 4, CategoryId = 3 }, // The Prophet - Poetry
               new BookCategory { BookId = 5, CategoryId = 2 }, // The Map of Love - Historical Fiction
               new BookCategory { BookId = 6, CategoryId = 2 }, // The Yacoubian Building - Fiction
               new BookCategory { BookId = 7, CategoryId = 2 }, // The Open Door - Fiction
               new BookCategory { BookId = 8, CategoryId = 2 }, // The Book of Khalid - Fiction
               new BookCategory { BookId = 9, CategoryId = 2 }, // The Return of the Spirit - Fiction
               new BookCategory { BookId = 10, CategoryId = 2 } // My Name is Red - Fiction
            };
		}

        public static IEnumerable<Subscriber> LoadSubscribers()
        {
            return new List<Subscriber>
            {
               new Subscriber
               {
                   Id = 1,
                   FirstName = "John",
                   LastName = "Doe",
                   Phone = "123-456-7890",
                   Email = "john.doe@example.com",
                   Gender = "Male",
                   DateOfBirth = new DateTime(1990, 5, 15),
                   NationalId = "12345678901234",
                   HasWhatsApp = true,
                   ImageUrl = "https://example.com/johndoe.jpg",
                   AreaId = 1,
                   GovernorateId = 1,
                   Address = "123 Elm St Apt 4B",
                   IsBlackListed = false
               },
               new Subscriber
               {
                   Id = 2,
                   FirstName = "Jane",
                   LastName = "Smith",
                   Phone = "987-654-3210",
                   Email = "jane.smith@example.com",
                   Gender = "Female",
                   DateOfBirth = new DateTime(1985, 10, 20),
                   NationalId = "23456789012345",
                   HasWhatsApp = false,
                   ImageUrl = "https://example.com/janesmith.jpg",
                   AreaId = 2,
                   GovernorateId = 1,
                   Address = "456 Oak St Unit 12",
                   IsBlackListed = false
               },
               new Subscriber
               {
                   Id = 3,
                   FirstName = "Alice",
                   LastName = "Johnson",
                   Phone = "555-555-5555",
                   Email = "alice.j@example.com",
                   Gender = "Female",
                   DateOfBirth = new DateTime(1992, 2, 28),
                   NationalId = "34567890123456",
                   HasWhatsApp = true,
                   ImageUrl = "https://example.com/alicejohnson.jpg",
                   AreaId = 1,
                   GovernorateId = 2,
                   Address = "789 Pine St House 10",
                   IsBlackListed = true
               },
               new Subscriber
               {
                   Id = 4,
                   FirstName = "Bob",
                   LastName = "Brown",
                   Phone = "444-444-4444",
                   Email = "bob.brown@example.com",
                   Gender = "Male",
                   DateOfBirth = new DateTime(1980, 11, 11),
                   NationalId = "45678901234567",
                   HasWhatsApp = false,
                   ImageUrl = "https://example.com/bobbrown.jpg",
                   AreaId = 3,
                   GovernorateId = 2,
                   Address = "321 Maple St Villa 3",
                   IsBlackListed = false
               },
               new Subscriber
               {
                   Id = 5,
                   FirstName = "Charlie",
                   LastName = "Davis",
                   Phone = "222-222-2222",
                   Email = "charlie.d@example.com",
                   Gender = "Male",
                   DateOfBirth = new DateTime(1995, 7, 7),
                   NationalId = "56789012345678",
                   HasWhatsApp = true,
                   ImageUrl = "https://example.com/charliedavis.jpg",
                   AreaId = 2,
                   GovernorateId = 3,
                   Address = "321 Maple St Villa 4",
                   IsBlackListed = false
               }
            };
        }

		public static IEnumerable<Area> LoadAreas()
		{
			return new List<Area>
			{
				new Area
				{
					Id = 1,
					Name = "Area 1",
					GovernorateId = 1,
				},
				new Area
				{
					Id = 2,
					Name = "Area 2",
					GovernorateId = 2,
				},
				new Area
				{
					Id = 3,
					Name = "Area 3",
					GovernorateId = 3,
				},
			};
		}

		public static IEnumerable<Governorate> LoadGovernorates()
		{
			return new List<Governorate>
			{
				new Governorate
				{
					Id = 1,
					Name = "Cairo",
				},
				new Governorate
				{
					Id = 2,
					Name = "Giza",
				},
				new Governorate
				{
					Id = 3,
					Name = "Beni Suef",
				},
			};
		}
    }
}
