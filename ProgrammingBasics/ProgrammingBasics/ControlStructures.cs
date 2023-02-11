// Elágazás

/*
int ammo = 10;
bool isInAir = false;

if (ammo > 0 && !isInAir)
{
    Console.WriteLine("BUMM");
    ammo--;
}

bool isGrounded = !isInAir;
bool haveAmmo = ammo > 0;
bool canShoot = haveAmmo && isGrounded;
if (canShoot)
{
    Console.WriteLine("BUMM");
}
else 
{
    Console.WriteLine("KLICK");
}
*/

// -------------------------------------

/*
Console.WriteLine("Írj be egy egész számot!");
string line = Console.ReadLine();
int number = int.Parse(line);

Console.WriteLine("A szám duplája:");
Console.WriteLine(number * 2);
*/

// -------------------------------------

/*
Console.WriteLine("Írj be egy egész számot!");
// Páros vagy Páratlan

string line = Console.ReadLine();
int number = int.Parse(line);

bool isEven = number % 2 == 0;
if (isEven)
    Console.WriteLine("Páros");
else
    Console.WriteLine("Páratlan");
*/

// -------------------------------------------

// Pozitív, Negatív

/*
Console.WriteLine("Írj be egy egész számot!");
string line = Console.ReadLine();
int number = int.Parse(line);

if (number > 0)
{
    Console.WriteLine("Positív");
}
else
{
    if (number < 0)
    {
        Console.WriteLine("Negatív");
    }
    else
    {
        Console.WriteLine("NULLA");
    }
}
// ---

if (number > 0)
{
    Console.WriteLine("Positív");
}
else if (number < 0)
{
    Console.WriteLine("Negatív");
}
else
{
    Console.WriteLine("NULLA");
}
*/

// ---------------------------

/*
// Kerek / Nem kerek

Console.WriteLine("Írj be egy egész számot!");
string line = Console.ReadLine();
int number = int.Parse(line);

string text = number % 10 == 0 ? "KEREK" : "NEM KEREK";
Console.WriteLine(text);
*/

// ---------- CIKLUSOK ------------

/*
int i = 1;

while (i <= 100) 
{
    Console.WriteLine(i);
    i++;
}

for (int j = 1; j <= 100; j++)
{
    Console.WriteLine(j);
}
*/

// ---------------------------------

/*
int num = 7;

for (int i = 1; i<= 10; i++) 
{
    Console.WriteLine(i * num);
}
*/

// ------------------------------------

// Első n olyan természetes szám, ami osztható öttel, de nem osztható 3-tel
/*
Console.WriteLine("Hány számot írjak ki?");
string line = Console.ReadLine();
int n = int.Parse(line);

int x = 5;
int count = 0;

for (int i = 1; count < n; i++)
{
    int numberToWrite = i * x;
    bool devisibleWith3 = numberToWrite % 3 == 0;

    if (!devisibleWith3)
    {
        Console.WriteLine(numberToWrite);
        count++;
    }
}
*/

//  -------------------------------

// 1 * 1 = 1
// 1 * 2 = 2
// ...
// 1 * 10 = 10
// 2 * 1 = 1
// ...
// 10 * 10 = 100

/*
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        int result = i * j;
        Console.WriteLine(j + " * " + i + " = " + result);
    }
}
*/

// -----------------------
// Metódusok
/*
double f1 = 12.5f;   // ez is floating point szám
double f2 = 3;

double power = Math.Pow(f1, f2);
double power2 = Math.Pow(45, 11.5);

double f3 = Math.Abs(f1);
double pi = Math.PI;
double f4 = Math.Sqrt(f2);
*/
// ------------------------