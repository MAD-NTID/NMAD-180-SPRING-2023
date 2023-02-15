/**
Name: Kemoy Campbell
Description: This is a program that performs wings of heaven sale receipts
Date:2/15/2023
**/

const string BUSINESS_NAME = "Wings Heaven";

//prices constants
const double BONE_LESS = 7.99;
const double TRADITION = 9.99;
const double BOTH_WINGS = 17.98;

const double NY_TAX = 0.08;
const double WINGS_DISCOUNT = .18;

const double BUFFALO_SAUCE = 0.29;
const double MILD_SAUCE = 0.39;
const double BBQ_SAUCE = 0.29;
const double PLAIN_SAUCE = 0;

const double FRIES = 3.49;
const double RINGS = 2.49;
const double BOTH_SIDES = 5.98;
const double NO_SIDES = 0;

const string OPTION_ONE = "1";
const string OPTION_TWO = "2";
const string OPTION_THREE = "3";
const string OPTION_FOUR = "4";

double  total = 0;
string order = "";

Console.WriteLine("Type of Wings:");
Console.WriteLine($"\t1.Boneless {BONE_LESS:C}");
Console.WriteLine($"\t2. Tradational {TRADITION:C}");
Console.WriteLine($"\t3. Both {BOTH_WINGS:C}");

Console.Write("Selection:");

switch(Console.ReadLine())
{
    case OPTION_ONE:
        total+=BONE_LESS;
        order+=$"Boneless Wing {BONE_LESS:C}\n";
        break;
    case OPTION_TWO:
        total+=TRADITION;
        order+=$"Traditional Wings {TRADITION:C}\n";
        break;
    case OPTION_THREE:
        double discount = BOTH_WINGS * WINGS_DISCOUNT;
        total+= BOTH_WINGS - discount;
        order+=$"Both wings {BOTH_WINGS:C}\nDiscount:{discount:C}\n";
        break;


}

Console.WriteLine("Type of Sauces");
Console.WriteLine($"\t1.Buffalo {BUFFALO_SAUCE:C}");
Console.WriteLine($"\t2.Mild {MILD_SAUCE:C}");
Console.WriteLine($"\t3.BBQ {BBQ_SAUCE:C}");
Console.WriteLine($"\tPlain {PLAIN_SAUCE:C}");

Console.Write("Selection:");
switch(Console.ReadLine())
{
    case OPTION_ONE:
        order+=$"Buffalo Sauce {BUFFALO_SAUCE:C}\n";
        total+=BUFFALO_SAUCE;
        break;
    case OPTION_TWO:
        order+=$"Mild Sauce {MILD_SAUCE:C}\n";
        total+=MILD_SAUCE;
        break;
    case OPTION_THREE:
        order+=$"BBQ Sauce {BBQ_SAUCE:C}\n";
        total+=BBQ_SAUCE;
        break;
    
    case OPTION_FOUR:
        order+=$"Plain No Charge";
        break;
}


//sides
Console.WriteLine("Type of Sides");
Console.WriteLine($"\t1.Waffle Fries {FRIES:C}");
Console.WriteLine($"\t2.Onion Rings {RINGS:C}");
Console.WriteLine($"\t3.Both {BOTH_SIDES:C}");
Console.WriteLine($"\tNone {NO_SIDES:C}");

Console.Write("Selection:");
switch(Console.ReadLine())
{
    case OPTION_ONE:
        //Console.WriteLine($"Waffle Fries {FRIES:C}"); -- you can also do this
        order+=$"Waffle Fries {FRIES:C}\n";
        total+=FRIES;
        break;
    case OPTION_TWO:
        order+=$"Onion Rings {RINGS:C}\n";
        total+=RINGS;
        break;
    case OPTION_THREE:
        order+=$"Both Sides {BOTH_SIDES:C}\n";
        total+=BOTH_SIDES;
        break;
    
    case OPTION_FOUR:
        order+=$"No Sides No Charge";
        break;
}
Console.WriteLine();
Console.WriteLine(BUSINESS_NAME);
Console.WriteLine(order);
Console.WriteLine($"Subtotal:{total:C}");
double tax = total * NY_TAX;
Console.WriteLine($"NY State Tax:{tax:C}");
total+=tax;
Console.WriteLine($"Total:{total:C}");
