// List<string> names = new List<string>();

// string[] namesArray = new string[2];

// //adding an element in the list. The element will be added at the end
// names.Add("Erik");

// //adding an element to the begining of the list, all other elements will be shifted to the right
// names.Insert(0, "Kemoy");

// Console.WriteLine($"The name at index 0 is :{names[0]}");
// Console.WriteLine($"The name at index 1 is :{names[1]}");

// //adding an element at the same index location in an array will replace the existing value
// namesArray[0] = "Erik";
// namesArray[0] = "Kemoy";

// Console.WriteLine($"The name at index 0 is :{namesArray[0]}");

// //removing an element from the list will reduce the size
// names.Remove("Erik");
// names.RemoveAt(0);

// Console.WriteLine(names.Count);

// List<string> items = new List<string>();
// items.Add("Osman");
// items.Add("Erik");
// Console.WriteLine("Calling list before clear");
// ShowInfo(items);

// //show elements using foreach
// foreach(string item in items)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine("Calling list after clear");
// items.Clear();
// ShowInfo(items);




// void ShowInfo(List<string> stuffs)
// {
//     for(int i = 0; i < stuffs.Count; i++)
//         Console.WriteLine($"index:{i} value:{stuffs[i]}");
// }


List<Pokemon> pokemons = new List<Pokemon>();
Pokemon pokemon = new Pokemon("Pikchau", "Yellow", "Ash", 100);
pokemons.Add(pokemon);


foreach(Pokemon pok in pokemons)
{
    if(pok.Name == "Pikchau"){
        pokemons.Remove(pok);
    }
}
