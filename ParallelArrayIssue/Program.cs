//parallel array to keep track of student's name, gpa and major

string[] names = {"Erik", "Eric", "Osman"};  //new string[10];
double[] gpas =  {3.5, 3.4,0};//new double[10];
string[] majors ={"MAD", "ITS", "Food cooking"}; //new string[10];

PrintRecords();
Array.Sort(names, gpas);


Console.WriteLine();

PrintRecords();


void PrintRecords()
{
    for(int i = 0; i < 3; i++) {
        Console.WriteLine($"{names[i]} {gpas[i]} {majors[i]}");
    }
}



