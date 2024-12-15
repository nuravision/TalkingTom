namespace ConsoleApp2
{
	internal class Program
	{
		public class Animal
		{

			public string Nickname { get; set; }
			public int Age { get; set; }
			public string Gender { get; set; }
			public decimal Energy { get; set; }
			public decimal Price { get; set; }
			public int MealQuantity { get; set; }
			public Animal(string nickname, int age, string gender, decimal energy, decimal price, int mealQuantity)
			{
				Nickname = nickname;
				Age = age;
				Gender = gender;
				Energy = energy;
				Price = price;
				MealQuantity = mealQuantity;
			}
			public override string ToString()
			{
				return $"Nickname:{Nickname} \nAge:{Age}\nGender:{Gender}\nEnergy:{Energy}\nMealQuantity:{MealQuantity}\n---------\n";
			}
			public void Eat()
			{
				MealQuantity++;
				Energy += 20;
				Price += 10;
				Console.WriteLine($"{Nickname} yemek yedi,enerjisi ve qiymeti artdi. Enerji: {Energy} Price:{Price}");
			}
			public void Sleep()
			{
				Energy += 20;
				Console.WriteLine($"{Nickname} yatdi. Enerjisi artdi. Enerji: {Energy}");
			}
			public void Play()
			{
				if (Energy <= 0)
				{
					Console.WriteLine($"{Nickname} Enerjisi tukendi yatacaq.");
					Sleep();
				}
				else
				{
					Energy -= 10;
					Console.WriteLine($"{Nickname} oynadi,enerjisi azaldi. Qalan enerji: {Energy}");
				}
			}

		}
		public class Cat : Animal
		{
			public Cat(string nickname, int age, string gender, decimal energy, decimal price, int mealQuantity)
				: base(nickname, age, gender, energy, price, mealQuantity)
			{
			}
			public override string ToString()
			{
				return base.ToString();
			}
		}
		public class Dog : Animal
		{
			public Dog(string nickname, int age, string gender, decimal energy, decimal price, int mealQuantity)
				: base(nickname, age, gender, energy, price, mealQuantity)
			{

			}
			public override string ToString()
			{
				return base.ToString();
			}
		}
		public class Bird : Animal
		{
			public Bird(string nickname, int age, string gender, decimal energy, decimal price, int mealQuantity)
				: base(nickname, age, gender, energy, price, mealQuantity)
			{

			}
			public override string ToString()
			{
				return base.ToString();
			}
		}
		public class Fish : Animal
		{
			public Fish(string nickname, int age, string gender, decimal energy, decimal price, int mealQuantity)
				: base(nickname, age, gender, energy, price, mealQuantity)
			{

			}
			public override string ToString()
			{
				return base.ToString();
			}
		}
		public class PetShop
		{


			public List<Cat> Cats { get; set; }
			public List<Dog> Dogs { get; set; }
			public List<Bird> Birds { get; set; }
			public List<Fish> Fishes { get; set; }



			public PetShop()
			{
				Cats = new List<Cat>();
				Dogs = new List<Dog>();
				Birds = new List<Bird>();
				Fishes = new List<Fish>();
			}

			public void RemoveByNickname(string nickname, string animalType)
			{
				bool found = false;
				switch (animalType.ToLower())
				{
					case "cat":
						for (int i = 0; i < Cats.Count; i++)
						{
							if (Cats[i].Nickname == nickname)
							{
								Cats.RemoveAt(i);
								found = true;
								Console.WriteLine($"Cat-{nickname} magazadan silindi!");
								break;
							}
						}
						if (!found) Console.WriteLine("Bele adli pisik tapilmadi!");
						break;
					case "dog":
						for (int i = 0; i < Dogs.Count; i++)
						{
							if (Dogs[i].Nickname == nickname)
							{
								Dogs.RemoveAt(i);
								found = true;
								Console.WriteLine($"Dog-{nickname} magazadan silindi!");
								break;
							}
						}
						if (!found) Console.WriteLine("Bele adli it tapilmadi!");
						break;
					case "bird":
						for (int i = 0; i < Birds.Count; i++)
						{
							if (Birds[i].Nickname == nickname)
							{
								Birds.RemoveAt(i);
								found = true;
								Console.WriteLine($"Bird-{nickname} magazadan silindi!");
								break;
							}
						}
						if (!found) Console.WriteLine("Bele adli qus tapilmadi!");
						break;
					case "fish":
						for (int i = 0; i < Fishes.Count; i++)
						{
							if (Fishes[i].Nickname == nickname)
							{
								Fishes.RemoveAt(i);
								found = true;
								Console.WriteLine($"Fish-{nickname} magazadan silindi!");
								break;
							}
						}
						if (!found) Console.WriteLine("Bele adli baliq tapilmadi!");
						break;
					default:
						Console.WriteLine($"{animalType} heyvan novu tapilmadi!");
						break;
				}
			}
			public void DisplayAllAnimals()
			{
				Console.WriteLine("===========All Animals===========");
				Console.WriteLine("\t\tCats\n");
				if (Cats.Count > 0)
				{
					for (int i = 0; i < Cats.Count; i++)
					{
						Console.WriteLine(Cats[i]);
					}
				}
				else
				{
					Console.WriteLine("Cat not found!");
				}
				Console.WriteLine("\t\tDogs\n");
				if (Dogs.Count > 0)
				{
					for (int i = 0; i < Dogs.Count; i++)
					{
						Console.WriteLine(Dogs[i]);
					}
				}
				else
				{
					Console.WriteLine("Dog not found!");
				}
				Console.WriteLine("\t\tBirds\n");
				if (Birds.Count > 0)
				{
					for (int i = 0; i < Birds.Count; i++)
					{
						Console.WriteLine(Birds[i]);
					}
				}
				else
				{
					Console.WriteLine("Bird not found!");
				}
				Console.WriteLine("\t\tFishes\n");
				if (Fishes.Count > 0)
				{
					for (int i = 0; i < Fishes.Count; i++)
					{
						Console.WriteLine(Fishes[i]);
					}
				}
				else
				{
					Console.WriteLine("Fish not found!");
				}

			}

			public void AnimalTotalPrice(string animalType)
			{
				decimal totalPrice = 0;
				switch (animalType.ToLower())
				{
					case "cat":
						totalPrice = Cats.Sum(cat => cat.Price);
						Console.WriteLine($"Pisiklerin umumi qiymeti: {totalPrice} AZN");
						break;
					case "dog":
						totalPrice = Dogs.Sum(dog => dog.Price);
						Console.WriteLine($"Itlerin umumi qiymeti: {totalPrice} AZN");
						break;
					default:
						Console.WriteLine($"{animalType} tapilmadi.");
						break;
				}
			}
			public decimal AnimalsTotalPrice()
			{
				decimal totalPrice = 0;

				for (int i = 0; i < Cats.Count; i++)
				{
					totalPrice += Cats[i].Price;
				}
				for (int i = 0; i < Dogs.Count; i++)
				{
					totalPrice += Dogs[i].Price;
				}
				for (int i = 0; i < Birds.Count; i++)
				{
					totalPrice += Birds[i].Price;
				}
				for (int i = 0; i < Fishes.Count; i++)
				{
					totalPrice += Fishes[i].Price;
				}
				return totalPrice;
			}
			public decimal GetTotalMeals()
			{
				decimal totalMeals = 0;

				for (int i = 0; i < Cats.Count; i++)
				{
					totalMeals += Cats[i].MealQuantity;
				}
				for (int i = 0; i < Dogs.Count; i++)
				{
					totalMeals += Dogs[i].MealQuantity;
				}
				for (int i = 0; i < Birds.Count; i++)
				{
					totalMeals += Birds[i].MealQuantity;
				}
				for (int i = 0; i < Fishes.Count; i++)
				{
					totalMeals += Fishes[i].MealQuantity;
				}
				return totalMeals;
			}
		}
		static void Main(string[] args)
		{
			PetShop petShop = new PetShop();


			//Console.WriteLine(cat1);

			Cat cat1 = new Cat("Tom", 2, "Male", 50, 100, 100);
			cat1.Eat();
			Cat cat2 = new Cat("Garfield", 10, "Female", 100, 80, 90);
			cat2.Eat();
			Dog dog1 = new Dog("Alabash", 8, "Female", 300, 200, 20);
			dog1.Sleep();
			Dog dog2 = new Dog("Qarabash", 3, "Male", 20, 40, 30);
			dog2.Play();
			Bird bird1 = new Bird("Con", 3, "Female", 20, 10, 20);
			bird1.Sleep();
			Bird bird2 = new Bird("Jenny", 2, "Female", 10, 15, 22);
			bird2.Sleep();
			Fish fish1 = new Fish("Deni", 4, "Female", 25, 17, 32);
			fish1.Eat();
			Fish fish2 = new Fish("Mely", 6, "Male", 23, 10, 29);
			fish2.Play();
			petShop.Cats.Add(cat1);
			petShop.Cats.Add(cat2);
			petShop.Dogs.Add(dog1);
			petShop.Dogs.Add(dog2);
			petShop.Birds.Add(bird1);
			petShop.Birds.Add(bird2);
			petShop.Fishes.Add(fish1);
			petShop.Fishes.Add(fish2);
			//petShop.DisplayAllAnimals();

			Console.WriteLine($"Heyvanlarin total qiymeti:{petShop.AnimalsTotalPrice()}");

			petShop.AnimalTotalPrice("cat");


			Console.WriteLine($"Total meals: {petShop.GetTotalMeals()}");			
		}
	}
}
