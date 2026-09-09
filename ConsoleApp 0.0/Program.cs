double moms = 0.25;

string enhet1 = "Laptopsal 1";
string id1 = "D-100";
string status1 = "Aktiv";
int price1 = 250;
double brutto1 = price1 * (1 + moms);

string enhet2 = "Projektor 1";
string id2 = "D-200";
string status2 = "Service";
int price2 = 100;
double brutto2 = price2 * (1 + moms);

string id3 = "D-300";
string enhet3 = "Skärm 1";
string status3 = "Inaktiv";
int price3 = 800;
double brutto3 = price3 * (1 + moms);

// Det här är rad 2 i vårat register (ifall du undrar)
string row2 = "ID: " + id2 + " | Namn: " + enhet2 + " | " + "Status: " + status2 + " | Pris: " + price2 + " | Brutto: " + brutto2;

string row3 = $"ID:  {id3} | Namn: {enhet3} | Status: {status3} | Pris: {price3} | Brutto: {brutto3}";

Console.WriteLine("Enhetsregister");
Console.WriteLine();
Console.WriteLine("ID: " + id1 + " | Namn: " + enhet1 + " | Status: " + status1 + " | Pris: " + price1 + " | Brutto: " + brutto1);
Console.WriteLine(row2);
Console.WriteLine(row3);

Console.WriteLine("Ange ID: ");
string id4 = Console.ReadLine();

Console.WriteLine("Ange namn: ");
string enhet4 = Console.ReadLine();

Console.WriteLine("Ange status: ");
string status4 = Console.ReadLine();

Console.WriteLine("Ange pris: ");
int price4 = Convert.ToInt32(Console.ReadLine());

string row4 = $"ID: {id4} | Namn: {enhet4} | Status: {status4} | Pris: {price4} kr | Brutto: {price4 * (1 + moms)} kr";

Console.WriteLine();
Console.WriteLine("Ny enhet: ");
Console.WriteLine(row4);

int totalPrice = price1 + price2 + price3 + price4;
Console.WriteLine(totalPrice);