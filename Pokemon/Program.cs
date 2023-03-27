// Pokemon test1 = new Pokemon();

// Console.WriteLine(test1.ToString());

// Pokemon test2 = new Pokemon("Pikachu", "Yellow", "Ash OG", 48);
// Console.WriteLine(test2.ToString());

Pokemon[] pokemons = new Pokemon[15];


while(true)
{
    Console.WriteLine("1. Add new pokemon");
    Console.WriteLine("2. Check if a pokemon is in the array");
    Console.WriteLine("3. Remove a Pokemon");
    Console.WriteLine("4. Show all Pokemons");

    Console.Write("Selection:");
    string selection = Console.ReadLine();

    switch(selection)
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

            //create a new pokemon object and assign the values from the user
            Pokemon pokemon = new Pokemon(name, color,owner,level);

            //find a empty location and put it there
            for(int i = 0; i < pokemons.Length; i++) {
                //if the current location is null then it is available
                if(pokemons[i] == null) {
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
            foreach(Pokemon poke in pokemons)
            {
                if(poke is not null){
                    if(poke.Name.ToLower() == name.ToLower())
                    {
                        found = true;
                        Console.WriteLine($"{poke.Name} is in the array");
                        break;

                    }
                }
            }

            if(!found)
            {
                Console.WriteLine($"{name} is not in the array");

            }
        break;
        case "3":
            Console.Write("Enter the name of the pokemon to remove:");
            name = Console.ReadLine();
            for(int i = 0; i< pokemons.Length; i++)
            {
                if(pokemons[i]!=null)
                    //we find the target to remove 
                    if(pokemons[i].Name.ToLower() == name.ToLower()){
                        //we set the object to null
                        pokemons[i] = null;// 
                        break;
                    }
            }
        break;
        case "4":
            foreach(Pokemon poke in pokemons)
            {
                if(poke is not null)
                    Console.WriteLine(poke);
                //Console.WriteLine(poke.ToString());
            }
        break;
        default:
            Console.WriteLine("Invalid selection!");
            break;
    }
}
