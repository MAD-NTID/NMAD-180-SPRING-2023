using System.Collections.Generic;

// Dictionary<string,string> students = new Dictionary<string, string>();
// students.Add("Erik", "Erik Menchaca, 1st year, 2.5 GPA");
// students.Add("Osman", "Osman Mohamed");


// Console.WriteLine(students["Erik"]);
// //c# throws an exception if the key doesnt exist;
// //Console.WriteLine(students["nobodyKnowsMe"]);

// students.Remove("Erik");
// //Console.WriteLine(students["Erik"]);

// foreach(KeyValuePair<string, string> item in students)
// {
//     Console.WriteLine($"Key:{item.Key} Value: {item.Value}");
// }


Dictionary<string, Pokemon> pokemons = new Dictionary<string, Pokemon>();

pokemons.Add("Pikachu", new Pokemon("Pikachu", "Yellow", "Ash", 545544754));
pokemons.Add("Foo", null);
pokemons.Add("Rambo", new Pokemon("Rambo", "Pinky", "Ash", 4754));

Console.WriteLine(pokemons.Count);

Console.WriteLine(pokemons["Pikachu"]);

if(pokemons.ContainsKey("Foo1")){
    //valid logic goes here
} else {
    Console.WriteLine("Foo doesnt exist");
}


if(pokemons.TryGetValue("Foo", out Pokemon p) && p is not null){
    Console.WriteLine("The value of the pokemon for foo is not null");
} else {
    Console.WriteLine("The value of the pokemon for foo is null");
}

Pokemon pokemon = pokemons["Rambo"];

Console.WriteLine(pokemon);

foreach(KeyValuePair<string, Pokemon> item in pokemons)
{
    Console.WriteLine($"Key:{item.Key} Value: {item.Value}");
}
