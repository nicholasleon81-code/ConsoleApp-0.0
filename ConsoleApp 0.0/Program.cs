string enhet1 = "Laptopsal 1";
string id1 = "D-100";
string status1 = "Aktiv";
int price1 = 250;

string enhet2 = "Projektor 1";
string id2 = "D-200";
string status2 = "Service";
int price2 = 100;

string id3 = "D-300";
string enhet3 = "Skärm 1";
string status3 = "Inaktiv";
int price3 = 800;

double moms = 0.25;

// Det här är rad 2 i vårat register (ifall du undrar)
string row2 = "ID: " + id2 + " | Namn: " + enhet2 + " | " + "Status: " + status2 + " | Pris (Brutto): " + price2.ToString();

string row3 = $"ID:  {id3} | Namn: {enhet3} | Status: {status3}";

Console.WriteLine("Enhetsregister");
Console.WriteLine();
Console.WriteLine("ID: " + id1 + " | Namn: " + enhet1 + " | Status: " + status1 + " | Pris(brutto): " + price1);
Console.WriteLine(row2);
Console.WriteLine(row3);
