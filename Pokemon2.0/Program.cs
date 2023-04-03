// Pokemon test1 = new Pokemon();

// Console.WriteLine(test1.ToString());

// Pokemon test2 = new Pokemon("Pikachu", "Yellow", "Ash OG", 48);
// Console.WriteLine(test2.ToString());

Pokemon[] pokemons = new Pokemon[15];

while (true)
{
    Console.WriteLine("1. Add new pokemon");
    Console.WriteLine("2. Check if a pokemon is in the array");
    Console.WriteLine("3. Remove a Pokemon");
    Console.WriteLine("4. Show all Pokemons");
    Console.WriteLine("5. Add Power to Pokemon");
    Console.WriteLine("6. Exit - Data will be Lost");

    Console.Write("Selection:");
    string selection = Console.ReadLine();

    switch (selection)
    {
        case "1":
            //collect inputs from user
            Console.Write("Name of pokemon:");
            string name = Console.ReadLine();

            Console.Write("Pokemon color:");
            string color = Console.ReadLine();

            Console.Write("Pokemon level:");
            int level = int.Parse(Console.ReadLine());

            Console.Write("Pokemon Owner:");
            string owner = Console.ReadLine();

            bool powers = false;
            while (true)
            {
                Console.Write("Do you want to add the powers for this Pokemon now (y/n)?");
                string powersAdd = Console.ReadLine();

                if (!string.IsNullOrEmpty(powersAdd) && powersAdd.Equals("y", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    powers = true;
                    break;
                }
                else if (powersAdd.Equals("n", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    powers = false;
                    break;
                }
                else
                    Console.WriteLine("Invalid Choice");
            }

            //create a new pokemon object and assign the values from the user
            Pokemon pokemon = new Pokemon(name, color, owner, level);

            //find a empty location and put it there
            for (int i = 0; i < pokemons.Length; i++)
            {
                //if the current location is null then it is available
                if (pokemons[i] == null)
                {
                    //add the pokemon object to the array of pokemons
                    pokemons[i] = pokemon;
                    break;
                }
            }

            break;
        case "2":
            Console.Write("Enter the name of the pokemon to search:");
            name = Console.ReadLine();

            bool found = false;
            foreach (Pokemon poke in pokemons)
            {
                if (poke is not null)
                {
                    if (poke.Name.ToLower() == name.ToLower())
                    {
                        found = true;
                        Console.WriteLine($"{poke.Name} is in the array");
                        break;

                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"{name} is not in the array");

            }
            break;
        case "3":
            Console.Write("Enter the name of the pokemon to remove:");
            name = Console.ReadLine();
            for (int i = 0; i < pokemons.Length; i++)
            {
                if (pokemons[i] != null)
                    //we find the target to remove 
                    if (pokemons[i].Name.ToLower() == name.ToLower())
                    {
                        //we set the object to null
                        pokemons[i] = null;// 
                        break;
                    }
            }
            break;
        case "4":
            foreach (Pokemon poke in pokemons)
            {
                if (poke is not null)
                    Console.WriteLine(poke);
                //Console.WriteLine(poke.ToString());
            }
            break;

        case "5":
            //  First we prompt for which Pokemon we want to add powers to
            Console.Write("Enter the name of the pokemon to search:");
            name = Console.ReadLine();
            Pokemon pokemonFound = null;

            foreach (Pokemon poke in pokemons)
            {
                if (poke is not null)
                {
                    if (poke.Name.ToLower() == name.ToLower())
                    {
                        //  Since we found the pokemon, we need the object to add Powers
                        pokemonFound = poke;
                        break;

                    }
                }
            }

            if (pokemonFound == null)
            {
                Console.WriteLine($"{name} is not was not found");
            }
            else
            {
                //  Check if Pokemon has space for new Powers to be added
                if (pokemonFound.HasSpaceForPower())
                {
                    Console.WriteLine("Pokemon found!");

                    Console.Write("What is the name of the Power to add for this Pokemon? ");
                    string powerName = Console.ReadLine();

                    Console.Write($"What is the type of Power for '{powerName}'? ");
                    string powerType = Console.ReadLine();

                    //  We finally have the Power Object, now How do we add it to the pokemon?
                    Power power = new Power(powerName, powerType);

                    pokemonFound.AddPower(power);
                }
                else
                {
                    Console.WriteLine($"{pokemonFound.Name} does not have space for new Powers to be added");
                }

                Console.WriteLine(pokemonFound.ToString());
            }
            break;
        case "6":
            Console.WriteLine("Good bye!");
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid selection!");
            break;
    }

    Console.WriteLine();
}