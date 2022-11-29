using Microsoft.AspNetCore.Identity;
using Project_SLAY.DAL;
using Project_SLAY.Models;
using Project_SLAY.Utilities;
using System.Text;

namespace Project_SLAY.Seeding
{
	public static class SeedUsers
	{
		public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
		{
		//Create a new list for all of the users
		List<AddUserModel> AllUsers = new List<AddUserModel>();
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "t.jacobs@longhornbank.neet",
				Email = "t.jacobs@longhornbank.neet",
				FirstName = "Todd",
				MI = "L",
				LastName = "Jacobs",
				Address = "4564 Elm St.",
				City = "Houston",
				State = "TX",
				ZipCode = "77003",
				PhoneNumber = "8176593544",
				DOB = new DateTime(1900, 1, 1),
				IsActive = IsActive.Active
			},
			Password = "society",
			RoleName = "Employee",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "e.rice@longhornbank.neet",
				Email = "e.rice@longhornbank.neet",
				FirstName = "Eryn",
				MI = "M",
				LastName = "Rice",
				Address = "3405 Rio Grande",
				City = "Dallas",
				State = "TX",
				ZipCode = "75261",
				PhoneNumber = "2148475583",
				DOB = new DateTime(1900, 1, 1),
				IsActive = IsActive.Active
			},
			Password = "ricearoni",
			RoleName = "Employee",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "b.ingram@longhornbank.neet",
				Email = "b.ingram@longhornbank.neet",
				FirstName = "Brad",
				MI = "S",
				LastName = "Ingram",
				Address = "6548 La Posada Ct.",
				City = "Austin",
				State = "TX",
				ZipCode = "78705",
				PhoneNumber = "5126978613",
				DOB = new DateTime(1900, 1, 1),
                IsActive = IsActive.Active
            },
			Password = "ingram45",
			RoleName = "Employee",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "a.taylor@longhornbank.neet",
				Email = "a.taylor@longhornbank.neet",
				FirstName = "Allison",
				MI = "R",
				LastName = "Taylor",
				Address = "467 Nueces St.",
				City = "Dallas",
				State = "TX",
				ZipCode = "75237",
				PhoneNumber = "2148965621",
                IsActive = IsActive.Active,
                DOB = new DateTime(1900, 1, 1)
			},
			Password = "nostalgic",
			RoleName = "Admin",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "g.martinez@longhornbank.neet",
				Email = "g.martinez@longhornbank.neet",
				FirstName = "Gregory",
				MI = "R",
				LastName = "Martinez",
				Address = "8295 Sunset Blvd.",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78239",
                IsActive = IsActive.Active,
                PhoneNumber = "2105788965",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "fungus",
			RoleName = "Employee",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "m.sheffield@longhornbank.neet",
				Email = "m.sheffield@longhornbank.neet",
				FirstName = "Martin",
				MI = "J",
				LastName = "Sheffield",
				Address = "3886 Avenue A",
                IsActive = IsActive.Active,
                City = "Austin",
				State = "TX",
				ZipCode = "78736",
				PhoneNumber = "5124678821",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "longhorns",
			RoleName = "Admin",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "j.macleod@longhornbank.neet",
				Email = "j.macleod@longhornbank.neet",
				FirstName = "Jennifer",
				MI = "D",
				LastName = "MacLeod",
				Address = "2504 Far West Blvd.",
				City = "Austin",
				State = "TX",
                IsActive = IsActive.Active,
                ZipCode = "78731",
				PhoneNumber = "5124653365",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "smitty",
			RoleName = "Admin",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "j.tanner@longhornbank.neet",
				Email = "j.tanner@longhornbank.neet",
				FirstName = "Jeremy",
				MI = "S",
				LastName = "Tanner",
				Address = "4347 Almstead",
				City = "Austin",
                IsActive = IsActive.Active,
                State = "TX",
				ZipCode = "78761",
				PhoneNumber = "5129457399",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "tanman",
			RoleName = "Employee",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "m.rhodes@longhornbank.neet",
				Email = "m.rhodes@longhornbank.neet",
				FirstName = "Megan",
				MI = "C",
				LastName = "Rhodes",
                IsActive = IsActive.Active,
                Address = "4587 Enfield Rd.",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78293",
				PhoneNumber = "2102449976",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "countryrhodes",
			RoleName = "Admin",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "e.stuart@longhornbank.neet",
				Email = "e.stuart@longhornbank.neet",
				FirstName = "Eric",
				MI = "F",
                IsActive = IsActive.Active,
                LastName = "Stuart",
				Address = "5576 Toro Ring",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78279",
				PhoneNumber = "2105344627",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "stewboy",
			RoleName = "Admin",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "l.chung@longhornbank.neet",
				Email = "l.chung@longhornbank.neet",
				FirstName = "Lisa",
				MI = "N",
				LastName = "Chung",
                IsActive = IsActive.Active,
                Address = "234 RR 12",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78268",
				PhoneNumber = "2106983548",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "lisssa",
			RoleName = "Employee",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "l.swanson@longhornbank.neet",
				Email = "l.swanson@longhornbank.neet",
				FirstName = "Leon",
				MI = "",
                IsActive = IsActive.Active,
                LastName = "Swanson",
				Address = "245 River Rd",
				City = "Austin",
				State = "TX",
				ZipCode = "78731",
				PhoneNumber = "5124748138",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "swansong",
			RoleName = "Admin",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "w.loter@longhornbank.neet",
				Email = "w.loter@longhornbank.neet",
				FirstName = "Wanda",
				MI = "K",
                IsActive = IsActive.Active,
                LastName = "Loter",
				Address = "3453 RR 3235",
				City = "Austin",
				State = "TX",
				ZipCode = "78732",
				PhoneNumber = "5124579845",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "lottery",
			RoleName = "Employee",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "j.white@longhornbank.neet",
				Email = "j.white@longhornbank.neet",
				FirstName = "Jason",
				MI = "M",
                IsActive = IsActive.Active,
                LastName = "White",
				Address = "12 Valley View",
				City = "Houston",
				State = "TX",
				ZipCode = "77045",
				PhoneNumber = "8174955201",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "evanescent",
			RoleName = "Admin",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "w.montgomery@longhornbank.neet",
				Email = "w.montgomery@longhornbank.neet",
				FirstName = "Wilda",
				MI = "K",
				LastName = "Montgomery",
				Address = "210 Blanco Dr",
				City = "Houston",
				State = "TX",
                IsActive = IsActive.Active,
                ZipCode = "77030",
				PhoneNumber = "8178746718",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "monty3",
			RoleName = "Admin",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "h.morales@longhornbank.neet",
				Email = "h.morales@longhornbank.neet",
				FirstName = "Hector",
				MI = "N",
				LastName = "Morales",
				Address = "4501 RR 140",
				City = "Houston",
				State = "TX",
				ZipCode = "77031",
                IsActive = IsActive.Active,
                PhoneNumber = "8177458615",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "hecktour",
			RoleName = "Employee",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "m.rankin@longhornbank.neet",
				Email = "m.rankin@longhornbank.neet",
				FirstName = "Mary",
				MI = "T",
                IsActive = IsActive.Active,
                LastName = "Rankin",
				Address = "340 Second St",
				City = "Austin",
				State = "TX",
				ZipCode = "78703",
				PhoneNumber = "5122926966",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "rankmary",
			RoleName = "Employee",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "l.walker@longhornbank.neet",
				Email = "l.walker@longhornbank.neet",
				FirstName = "Larry",
				MI = "G",
                IsActive = IsActive.Active,
                LastName = "Walker",
				Address = "9 Bison Circle",
				City = "Dallas",
				State = "TX",
				ZipCode = "75238",
				PhoneNumber = "2143125897",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "walkamile",
			RoleName = "Admin",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "g.chang@longhornbank.neet",
				Email = "g.chang@longhornbank.neet",
				FirstName = "George",
				MI = "M",
                IsActive = IsActive.Active,
                LastName = "Chang",
				Address = "9003 Joshua St",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78260",
				PhoneNumber = "2103450925",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "changalang",
			RoleName = "Admin",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "g.gonzalez@longhornbank.neet",
				Email = "g.gonzalez@longhornbank.neet",
				FirstName = "Gwen",
				MI = "J",
                IsActive = IsActive.Active,
                LastName = "Gonzalez",
				Address = "103 Manor Rd",
				City = "Dallas",
				State = "TX",
				ZipCode = "75260",
				PhoneNumber = "2142345566",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "offbeat",
			RoleName = "Employee",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "dman@longhornbank.neet",
				Email = "dman@longhornbank.neet",
				FirstName = "Derek",
                IsActive = IsActive.Active,
                MI = "",
				LastName = "Dreibrodt",
				Address = "423 Brentwood Dr",
				City = "Austin",
				State = "TX",
				ZipCode = "78705",
				PhoneNumber = "5556409287",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "nasus123",
			RoleName = "Admin",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "jman@longhornbank.neet",
				Email = "jman@longhornbank.neet",
				FirstName = "Jacob",
				MI = "",
                IsActive = IsActive.Active,
                LastName = "Foster",
				Address = "700 Fancy St",
				City = "Austin",
				State = "TX",
				ZipCode = "78705",
				PhoneNumber = "5558471234",
				DOB = new DateTime(1900, 1, 1)
			},
			Password = "pres4baseball",
			RoleName = "Admin",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "cbaker@freezing.co.uk",
				Email = "cbaker@freezing.co.uk",
				FirstName = "Christopher",
				MI = "L",
				LastName = "Baker",
				Address = "1245 Lake Austin Blvd.",
                IsActive = IsActive.Active,
                City = "Austin",
				State = "TX",
				ZipCode = "78733",
				PhoneNumber = "5125571146",
				DOB = new DateTime(1991, 10, 7)
			},
			Password = "gazing",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "mb@aool.com",
				Email = "mb@aool.com",
				FirstName = "Michelle",
                IsActive = IsActive.Active,
                MI = "",
				LastName = "Banks",
				Address = "1300 Tall Pine Lane",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78261",
				PhoneNumber = "2102678873",
				DOB = new DateTime(1990, 8, 23)
			},
			Password = "banquet",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "fd@aool.com",
				Email = "fd@aool.com",
				FirstName = "Franco",
				MI = "V",
                IsActive = IsActive.Active,
                LastName = "Broccolo",
				Address = "62 Browning Rd",
				City = "Houston",
				State = "TX",
				ZipCode = "77019",
				PhoneNumber = "8175659699",
				DOB = new DateTime(1986, 4, 6)
			},
			Password = "666666",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "wendy@ggmail.com",
				Email = "wendy@ggmail.com",
				FirstName = "Wendy",
				MI = "L",
				LastName = "Chang",
				Address = "202 Bellmont Hall",
				City = "Austin",
				State = "TX",
                IsActive = IsActive.Active,
                ZipCode = "78713",
				PhoneNumber = "5125943222",
				DOB = new DateTime(1964, 1, 21)
			},
			Password = "clover",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "limchou@yaho.com",
				Email = "limchou@yaho.com",
				FirstName = "Lim",
				MI = "",
                IsActive = IsActive.Active,
                LastName = "Chou",
				Address = "1600 Teresa Lane",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78266",
				PhoneNumber = "2107724599",
				DOB = new DateTime(1950, 10, 14)
			},
			Password = "austin",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "Dixon@aool.com",
				Email = "Dixon@aool.com",
				FirstName = "Shan",
				MI = "D",
				LastName = "Dixon",
				Address = "234 Holston Circle",
                IsActive = IsActive.Active,
                City = "Dallas",
				State = "TX",
				ZipCode = "75208",
				PhoneNumber = "2142643255",
				DOB = new DateTime(1930, 7, 9)
			},
			Password = "mailbox",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "louann@ggmail.com",
				Email = "louann@ggmail.com",
				FirstName = "Lou Ann",
				MI = "K",
				LastName = "Feeley",
				Address = "600 S 8th Street W",
                IsActive = IsActive.Active,
                City = "Houston",
				State = "TX",
				ZipCode = "77010",
				PhoneNumber = "8172556749",
				DOB = new DateTime(1930, 7, 24)
			},
			Password = "aggies",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "tfreeley@minntonka.ci.state.mn.us",
				Email = "tfreeley@minntonka.ci.state.mn.us",
				FirstName = "Tesa",
				MI = "P",
				LastName = "Freeley",
				Address = "4448 Fairview Ave.",
				City = "Houston",
				State = "TX",
				ZipCode = "77009",
                IsActive = IsActive.Active,
                PhoneNumber = "8173255687",
				DOB = new DateTime(1935, 1, 1)
			},
			Password = "raiders",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "mgar@aool.com",
				Email = "mgar@aool.com",
				FirstName = "Margaret",
				MI = "L",
                IsActive = IsActive.Active,
                LastName = "Garcia",
				Address = "594 Longview",
				City = "Houston",
				State = "TX",
				ZipCode = "77003",
				PhoneNumber = "8176593544",
				DOB = new DateTime(1990, 1, 3)
			},
			Password = "mustangs",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "chaley@thug.com",
				Email = "chaley@thug.com",
				FirstName = "Charles",
				MI = "E",
                IsActive = IsActive.Active,
                LastName = "Haley",
				Address = "One Cowboy Pkwy",
				City = "Dallas",
				State = "TX",
				ZipCode = "75261",
				PhoneNumber = "2148475583",
				DOB = new DateTime(1985, 3, 17)
			},
			Password = "region",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "jeff@ggmail.com",
				Email = "jeff@ggmail.com",
				FirstName = "Jeffrey",
				MI = "T",
                IsActive = IsActive.Active,
                LastName = "Hampton",
				Address = "337 38th St.",
				City = "Austin",
				State = "TX",
				ZipCode = "78705",
				PhoneNumber = "5126978613",
				DOB = new DateTime(1995, 8, 23)
			},
			Password = "hungry",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "wjhearniii@umch.edu",
				Email = "wjhearniii@umch.edu",
				FirstName = "John",
				MI = "B",
                IsActive = IsActive.Active,
                LastName = "Hearn",
				Address = "4225 North First",
				City = "Dallas",
				State = "TX",
				ZipCode = "75237",
				PhoneNumber = "2148965621",
				DOB = new DateTime(1994, 8, 8)
			},
			Password = "logicon",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "hicks43@ggmail.com",
				Email = "hicks43@ggmail.com",
				FirstName = "Anthony",
				MI = "J",
                IsActive = IsActive.Active,
                LastName = "Hicks",
				Address = "32 NE Garden Ln., Ste 910",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78239",
				PhoneNumber = "2105788965",
				DOB = new DateTime(1990, 8, 6)
			},
			Password = "doofus",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "bradsingram@mall.utexas.edu",
				Email = "bradsingram@mall.utexas.edu",
				FirstName = "Brad",
				MI = "S",
                IsActive = IsActive.Active,
                LastName = "Ingram",
				Address = "6548 La Posada Ct.",
				City = "Austin",
				State = "TX",
				ZipCode = "78736",
				PhoneNumber = "5124678821",
				DOB = new DateTime(1984, 8, 12)
			},
			Password = "mother",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "mother.Ingram@aool.com",
				Email = "mother.Ingram@aool.com",
				FirstName = "Todd",
				MI = "L",
				LastName = "Jacobs",
				Address = "4564 Elm St.",
                IsActive = IsActive.Active,
                City = "Austin",
				State = "TX",
				ZipCode = "78731",
				PhoneNumber = "5124653365",
				DOB = new DateTime(1983, 7, 4)
			},
			Password = "whimsical",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "victoria@aool.com",
				Email = "victoria@aool.com",
				FirstName = "Victoria",
				MI = "M",
                IsActive = IsActive.Active,
                LastName = "Lawrence",
				Address = "6639 Butterfly Ln.",
				City = "Austin",
				State = "TX",
				ZipCode = "78761",
				PhoneNumber = "5129457399",
				DOB = new DateTime(1961, 10, 3)
			},
			Password = "nothing",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "lineback@flush.net",
				Email = "lineback@flush.net",
				FirstName = "Erik",
				MI = "W",
                IsActive = IsActive.Active,
                LastName = "Lineback",
				Address = "1300 Netherland St",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78293",
				PhoneNumber = "2102449976",
				DOB = new DateTime(1946, 4, 3)
			},
			Password = "GoodFellow",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "elowe@netscrape.net",
				Email = "elowe@netscrape.net",
				FirstName = "Ernest",
                IsActive = IsActive.Active,
                MI = "S",
				LastName = "Lowe",
				Address = "3201 Pine Drive",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78279",
				PhoneNumber = "2105344627",
				DOB = new DateTime(1992, 11, 7)
			},
			Password = "impede",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "luce_chuck@ggmail.com",
				Email = "luce_chuck@ggmail.com",
				FirstName = "Chuck",
				MI = "B",
				LastName = "Luce",
                IsActive = IsActive.Active,
                Address = "2345 Rolling Clouds",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78268",
				PhoneNumber = "2106983548",
				DOB = new DateTime(1942, 10, 25)
			},
			Password = "LuceyDucey",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "mackcloud@pimpdaddy.com",
				Email = "mackcloud@pimpdaddy.com",
				FirstName = "Jennifer",
				MI = "D",
                IsActive = IsActive.Active,
                LastName = "MacLeod",
				Address = "2504 Far West Blvd.",
				City = "Austin",
				State = "TX",
				ZipCode = "78731",
				PhoneNumber = "5124748138",
				DOB = new DateTime(1965, 9, 6)
			},
			Password = "cloudyday",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "liz@ggmail.com",
				Email = "liz@ggmail.com",
				FirstName = "Elizabeth",
				MI = "P",
				LastName = "Markham",
                IsActive = IsActive.Active,
                Address = "7861 Chevy Chase",
				City = "Austin",
				State = "TX",
				ZipCode = "78732",
				PhoneNumber = "5124579845",
				DOB = new DateTime(1959, 12, 13)
			},
			Password = "emarkbark",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "mclarence@aool.com",
				Email = "mclarence@aool.com",
				FirstName = "Clarence",
				MI = "A",
                IsActive = IsActive.Active,
                LastName = "Martin",
				Address = "87 Alcedo St.",
				City = "Houston",
				State = "TX",
				ZipCode = "77045",
				PhoneNumber = "8174955201",
				DOB = new DateTime(1990, 8, 6)
			},
			Password = "smartinmartin",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "smartinmartin.Martin@aool.com",
				Email = "smartinmartin.Martin@aool.com",
				FirstName = "Gregory",
				MI = "R",
				LastName = "Martinez",
                IsActive = IsActive.Active,
                Address = "8295 Sunset Blvd.",
				City = "Houston",
				State = "TX",
				ZipCode = "77030",
				PhoneNumber = "8178746718",
				DOB = new DateTime(1987, 5, 9)
			},
			Password = "looter",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "cmiller@mapster.com",
				Email = "cmiller@mapster.com",
				FirstName = "Charles",
				MI = "R",
				LastName = "Miller",
				Address = "8962 Main St.",
                IsActive = IsActive.Active,
                City = "Houston",
				State = "TX",
				ZipCode = "77031",
				PhoneNumber = "8177458615",
				DOB = new DateTime(1984, 1, 21)
			},
			Password = "chucky33",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "nelson.Kelly@aool.com",
				Email = "nelson.Kelly@aool.com",
				FirstName = "Kelly",
				MI = "T",
				LastName = "Nelson",
                IsActive = IsActive.Active,
                Address = "2601 Red River",
				City = "Austin",
				State = "TX",
				ZipCode = "78703",
				PhoneNumber = "5122926966",
				DOB = new DateTime(1956, 7, 4)
			},
			Password = "orange",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "jojoe@ggmail.com",
				Email = "jojoe@ggmail.com",
				FirstName = "Joe",
				MI = "C",
				LastName = "Nguyen",
                IsActive = IsActive.Active,
                Address = "1249 4th SW St.",
				City = "Dallas",
				State = "TX",
				ZipCode = "75238",
				PhoneNumber = "2143125897",
				DOB = new DateTime(1963, 4, 29)
			},
			Password = "victorious",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "orielly@foxnets.com",
				Email = "orielly@foxnets.com",
				FirstName = "Bill",
				MI = "T",
				LastName = "O'Reilly",
                IsActive = IsActive.Active,
                Address = "8800 Gringo Drive",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78260",
				PhoneNumber = "2103450925",
				DOB = new DateTime(1983, 5, 7)
			},
			Password = "billyboy",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "or@aool.com",
				Email = "or@aool.com",
				FirstName = "Anka",
				MI = "L",
				LastName = "Radkovich",
				Address = "1300 Elliott Pl",
				City = "Dallas",
                IsActive = IsActive.Active,
                State = "TX",
				ZipCode = "75260",
				PhoneNumber = "2142345566",
				DOB = new DateTime(1980, 10, 31)
			},
			Password = "radicalone",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "megrhodes@freezing.co.uk",
				Email = "megrhodes@freezing.co.uk",
				FirstName = "Megan",
				MI = "C",
				LastName = "Rhodes",
				Address = "4587 Enfield Rd.",
                IsActive = IsActive.Active,
                City = "Austin",
				State = "TX",
				ZipCode = "78707",
				PhoneNumber = "5123744746",
				DOB = new DateTime(1944, 10, 12)
			},
			Password = "gohorns",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "erynrice@aool.com",
				Email = "erynrice@aool.com",
				FirstName = "Eryn",
				MI = "M",
				LastName = "Rice",
                IsActive = IsActive.Active,
                Address = "3405 Rio Grande",
				City = "Austin",
				State = "TX",
				ZipCode = "78705",
				PhoneNumber = "5123876657",
				DOB = new DateTime(1934, 5, 2)
			},
			Password = "iloveme",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "jorge@hootmail.com",
				Email = "jorge@hootmail.com",
				FirstName = "Jorge",
				MI = "",
				LastName = "Rodriguez",
				Address = "6788 Cotter Street",
                IsActive = IsActive.Active,
                City = "Houston",
				State = "TX",
				ZipCode = "77057",
				PhoneNumber = "8178904374",
				DOB = new DateTime(1989, 4, 11)
			},
			Password = "greedy",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "ra@aoo.com",
				Email = "ra@aoo.com",
				FirstName = "Allen",
                IsActive = IsActive.Active,
                MI = "B",
				LastName = "Rogers",
				Address = "4965 Oak Hill",
				City = "Austin",
				State = "TX",
				ZipCode = "78732",
				PhoneNumber = "5128752943",
				DOB = new DateTime(1967, 1, 27)
			},
			Password = "familiar",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "st-jean@home.com",
				Email = "st-jean@home.com",
				FirstName = "Olivier",
				MI = "M",
				LastName = "Saint-Jean",
				Address = "255 Toncray Dr.",
				City = "San Antonio",
                IsActive = IsActive.Active,
                State = "TX",
				ZipCode = "78292",
				PhoneNumber = "2104145678",
				DOB = new DateTime(1950, 9, 8)
			},
			Password = "historical",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "ss34@ggmail.com",
				Email = "ss34@ggmail.com",
				FirstName = "Sarah",
				MI = "J",
				LastName = "Saunders",
				Address = "332 Avenue C",
                IsActive = IsActive.Active,
                City = "Austin",
				State = "TX",
				ZipCode = "78705",
				PhoneNumber = "5123497810",
				DOB = new DateTime(1977, 1, 29)
			},
			Password = "guiltless",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "willsheff@email.com",
				Email = "willsheff@email.com",
				FirstName = "William",
				MI = "T",
				LastName = "Sewell",
                IsActive = IsActive.Active,
                Address = "2365 51st St.",
				City = "Austin",
				State = "TX",
				ZipCode = "78709",
				PhoneNumber = "5124510084",
				DOB = new DateTime(1941, 1, 21)
			},
			Password = "frequent",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "sheff44@ggmail.com",
				Email = "sheff44@ggmail.com",
				FirstName = "Martin",
				MI = "J",
				LastName = "Sheffield",
                IsActive = IsActive.Active,
                Address = "3886 Avenue A",
				City = "Austin",
				State = "TX",
				ZipCode = "78705",
				PhoneNumber = "5125479167",
				DOB = new DateTime(1937, 1, 10)
			},
			Password = "history",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "johnsmith187@aool.com",
				Email = "johnsmith187@aool.com",
				FirstName = "John",
				MI = "A",
				LastName = "Smith",
                IsActive = IsActive.Active,
                Address = "23 Hidden Forge Dr.",
				City = "San Antonio",
				State = "TX",
				ZipCode = "78280",
				PhoneNumber = "2108321888",
				DOB = new DateTime(1954, 1, 26)
			},
			Password = "squirrel",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "dustroud@mail.com",
				Email = "dustroud@mail.com",
				FirstName = "Dustin",
                IsActive = IsActive.Active,
                MI = "P",
				LastName = "Stroud",
				Address = "1212 Rita Rd",
				City = "Dallas",
				State = "TX",
				ZipCode = "75221",
				PhoneNumber = "2142346667",
				DOB = new DateTime(1932, 1, 1)
			},
			Password = "snakes",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "ericstuart@aool.com",
				Email = "ericstuart@aool.com",
				FirstName = "Eric",
				MI = "D",
                IsActive = IsActive.Active,
                LastName = "Stuart",
				Address = "5576 Toro Ring",
				City = "Austin",
				State = "TX",
				ZipCode = "78746",
				PhoneNumber = "5128178335",
				DOB = new DateTime(1930, 1, 28)
			},
			Password = "landus",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "peterstump@hootmail.com",
				Email = "peterstump@hootmail.com",
				FirstName = "Peter",
				MI = "L",
				LastName = "Stump",
                IsActive = IsActive.Active,
                Address = "1300 Kellen Circle",
				City = "Houston",
				State = "TX",
				ZipCode = "77018",
				PhoneNumber = "8174560903",
				DOB = new DateTime(1989, 1, 13)
			},
			Password = "rhythm",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "tanner@ggmail.com",
				Email = "tanner@ggmail.com",
				FirstName = "Jeremy",
				MI = "S",
                IsActive = IsActive.Active,
                LastName = "Tanner",
				Address = "4347 Almstead",
				City = "Houston",
				State = "TX",
				ZipCode = "77044",
				PhoneNumber = "8174590929",
				DOB = new DateTime(1982, 1, 21)
			},
			Password = "kindly",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "taylordjay@aool.com",
				Email = "taylordjay@aool.com",
				FirstName = "Allison",
                IsActive = IsActive.Active,
                MI = "R",
				LastName = "Taylor",
				Address = "467 Nueces St.",
				City = "Austin",
				State = "TX",
				ZipCode = "78705",
				PhoneNumber = "5124748452",
				DOB = new DateTime(1960, 1, 8)
			},
			Password = "instrument",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "TayTaylor@aool.com",
				Email = "TayTaylor@aool.com",
				FirstName = "Rachel",
				MI = "K",
                IsActive = IsActive.Active,
                LastName = "Taylor",
				Address = "345 Longview Dr.",
				City = "Austin",
				State = "TX",
				ZipCode = "78705",
				PhoneNumber = "5124512631",
				DOB = new DateTime(1975, 1, 27)
			},
			Password = "arched",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "teefrank@hootmail.com",
				Email = "teefrank@hootmail.com",
				FirstName = "Frank",
				MI = "J",
				LastName = "Tee",
                IsActive = IsActive.Active,
                Address = "5590 Lavell Dr",
				City = "Houston",
				State = "TX",
				ZipCode = "77004",
				PhoneNumber = "8178765543",
				DOB = new DateTime(1968, 1, 6)
			},
			Password = "median",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "tuck33@ggmail.com",
				Email = "tuck33@ggmail.com",
				FirstName = "Clent",
				MI = "J",
				LastName = "Tucker",
				Address = "312 Main St.",
				City = "Dallas",
                IsActive = IsActive.Active,
                State = "TX",
				ZipCode = "75315",
				PhoneNumber = "2148471154",
				DOB = new DateTime(1978, 1, 19)
			},
			Password = "approval",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "avelasco@yaho.com",
				Email = "avelasco@yaho.com",
				FirstName = "Allen",
				MI = "G",
                IsActive = IsActive.Active,
                LastName = "Velasco",
				Address = "679 W. 4th",
				City = "Dallas",
				State = "TX",
				ZipCode = "75207",
				PhoneNumber = "2143985638",
				DOB = new DateTime(1963, 1, 6)
			},
			Password = "decorate",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "westj@pioneer.net",
				Email = "westj@pioneer.net",
				FirstName = "Jake",
				MI = "T",
                IsActive = IsActive.Active,
                LastName = "West",
				Address = "RR 3287",
				City = "Dallas",
				State = "TX",
				ZipCode = "75323",
				PhoneNumber = "2148475244",
				DOB = new DateTime(1993, 1, 14)
			},
			Password = "grover",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "louielouie@aool.com",
				Email = "louielouie@aool.com",
				FirstName = "Louis",
				MI = "L",
                IsActive = IsActive.Active,
                LastName = "Winthorpe",
				Address = "2500 Padre Blvd",
				City = "Dallas",
				State = "TX",
				ZipCode = "75220",
				PhoneNumber = "2145650098",
				DOB = new DateTime(1952, 1, 31)
			},
			Password = "sturdy",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "rwood@voyager.net",
				Email = "rwood@voyager.net",
				FirstName = "Reagan",
				MI = "B",
                IsActive = IsActive.Active,
                LastName = "Wood",
				Address = "447 Westlake Dr.",
				City = "Austin",
				State = "TX",
				ZipCode = "78746",
				PhoneNumber = "5124545242",
				DOB = new DateTime(1992, 1, 24)
			},
			Password = "decorous",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "dman@wdwebsolutions.com",
				Email = "dman@wdwebsolutions.com",
				FirstName = "Derek",
				MI = "",
                IsActive = IsActive.Active,
                LastName = "Dreibrodt",
				Address = "423 Brentwood Dr",
				City = "Austin",
				State = "TX",
				ZipCode = "78705",
				PhoneNumber = "5556409287",
				DOB = new DateTime(2001, 1, 1)
			},
			Password = "nasus123",
			RoleName = "Customer",
		}
		);
		AllUsers.Add(new AddUserModel()
		{
			User = new AppUser()
			{
				//populate the user properties that are from the 
				//identityUser Base class
				UserName = "jman@outlook.com",
				Email = "jman@outlook.com",
				FirstName = "Jacob",
                IsActive = IsActive.Active,
                MI = "",
				LastName = "Foster",
				Address = "700 Fancy St",
				City = "Austin",
				State = "TX",
				ZipCode = "78705",
				PhoneNumber = "5558471234",
				DOB = new DateTime(2000, 1, 1)
			},
			Password = "pres4baseball",
			RoleName = "Customer",
		}
		);
		String errorFlag = "Start";
		IdentityResult result = new IdentityResult();
		try
		{
			foreach (AddUserModel aum in AllUsers)
			{
				errorFlag = aum.User.Email;
				result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
			}
		}
		catch (Exception ex)
		{
			throw new Exception("There was a problem adding the user with email: "
			+ errorFlag, ex);
		}
			return result;
	}
}
}
