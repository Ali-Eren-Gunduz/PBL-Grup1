using System.ComponentModel.Design;
using System.Net;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

int a1 = 0;
int a2 = 0;
int a3 = 0;
int b1 = 0;
int b2 = 0;
int b3 = 0;
int c1 = 0;
int c2 = 0;
int c3 = 0;
int score = 0;

Random rand = new Random();
a1 = rand.Next(1, 10);
a2 = rand.Next(1, 10);
a3 = rand.Next(1, 10);
b1 = rand.Next(1, 10);
b2 = rand.Next(1, 10);
b3 = rand.Next(1, 10);
c1 = rand.Next(1, 10);
c2 = rand.Next(1, 10);
c3 = rand.Next(1, 10);


// Tablonun İlk 3 Satırı
Console.WriteLine("     1    2    3  ");
Console.WriteLine("  +---------------+");
Console.WriteLine("  |               |");


// Tablonun 4. satırı, a1 den a3'e kadar atanmış değerleri harf ve renge dönüştürüyor
if (a1 == 1)
{
    Console.Write("a |  ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("D");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a1 == 2)
{
 
    Console.Write("a |  ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("E");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a1 == 3)
{
    Console.Write("a |  ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("U");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a1 == 4)
{
    Console.Write("a |  ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("D");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a1 == 5)
{
    Console.Write("a |  ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("E");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a1 == 6)
{
    Console.Write("a |  ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("U");
    Console.ResetColor();
    Console.Write("  ");

}
else if (a1 == 7)
{
    Console.Write("a |  ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("D");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a1 == 8)
{
    Console.Write("a |  ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("E");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a1 == 9)
{
    Console.Write("a |  ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("U");
    Console.ResetColor();
    Console.Write("  ");
}

if (a2 == 1)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("  " + "D");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a2 == 2)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("  " + "E");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a2 == 3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("  " + "U");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a2 == 4)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("  " + "D");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a2 == 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("  " + "E");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a2 == 6)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("  " + "U");
    Console.ResetColor();
    Console.Write("  ");

}
else if (a2 == 7)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("  " + "D");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a2 == 8)       
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("  " + "E");
    Console.ResetColor();
    Console.Write("  ");
}
else if (a2 == 9)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("  " + "U");
    Console.ResetColor();
    Console.Write("  ");
}

if (a3 == 1)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("  " + "D");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (a3 == 2)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("  " + "E");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (a3 == 3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("  " + "U");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (a3 == 4)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("  " + "D");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (a3 == 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("  " + "E");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (a3 == 6)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("  " + "U");
    Console.ResetColor();
    Console.WriteLine("  |");

}
else if (a3 == 7)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("  " + "D");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (a3 == 8)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("  " + "E");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (a3 == 9)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("  " + "U");
    Console.ResetColor();
    Console.WriteLine("  |");
}


// Tablonun 5. satırı
Console.WriteLine("  |               |");


// Tablonun 6. satırı , b1 den b3'e kadar atanmış sayıları harf ve renge dönüştürüyor
if (b1 == 1)
{

    Console.Write("b |  ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("D" + "    ");
    Console.ResetColor();
}
else if (b1 == 2)
{
    Console.Write("b |  ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("E" + "    ");
    Console.ResetColor();
}
else if (b1 == 3)
{
    Console.Write("b |  ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("U" + "    ");
    Console.ResetColor();
}
else if (b1 == 4)
{
    Console.Write("b |  ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("D" + "    ");
    Console.ResetColor();
}
else if (b1 == 5)
{
    Console.Write("b |  ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("E" + "    ");
    Console.ResetColor();
}
else if (b1 == 6)
{
    Console.Write("b |  ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("U" + "    ");
    Console.ResetColor();

}
else if (b1 == 7)
{
    Console.Write("b |  ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("D" + "    ");
    Console.ResetColor();
}
else if (b1 == 8)
{
    Console.Write("b |  ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("E" + "    ");
    Console.ResetColor();
}
else if (b1 == 9)
{
    Console.Write("b |  ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("U" + "    ");
    Console.ResetColor();
}


if (b2 == 1)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("D" + "    ");
    Console.ResetColor();
}
else if (b2 == 2)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("E" + "    ");
    Console.ResetColor();
}
else if (b2 == 3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("U" + "    ");
    Console.ResetColor();
}
else if (b2 == 4)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("D" + "    ");
    Console.ResetColor();
}
else if (b2 == 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("E" + "    ");
    Console.ResetColor();
}
else if (b2 == 6)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("U" + "    ");
    Console.ResetColor();

}
else if (b2 == 7)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("D" + "    ");
    Console.ResetColor();
}
else if (b2 == 8)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("E" + "    ");
    Console.ResetColor();
}
else if (b2 == 9)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("U" + "    ");
    Console.ResetColor();
}


if (b3 == 1)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("D");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (b3 == 2)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("E");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (b3 == 3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("U");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (b3 == 4)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("D");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (b3 == 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("E");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (b3 == 6)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("U");
    Console.ResetColor();
    Console.WriteLine("  |");

}
else if (b3 == 7)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("D");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (b3 == 8)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("E");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (b3 == 9)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("U");
    Console.ResetColor();
    Console.WriteLine("  |");
}


// Tablonun 7. satırı
Console.WriteLine("  |               |");


// Tablonun 8. satırı , c1 den c3'e kadar atanmış sayıları harf ve renge dönüştürüyor
if (c1 == 1)
{
    Console.Write("c |  ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("D" + "    ");
    Console.ResetColor();
}
else if (c1 == 2)
{
    Console.Write("c |  ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("E" + "    ");
    Console.ResetColor();
}
else if (c1 == 3)
{
    Console.Write("c |  ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("U" + "    ");
    Console.ResetColor();
}
else if (c1 == 4)
{
    Console.Write("c |  ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("D" + "    ");
    Console.ResetColor();
}
else if (c1 == 5)
{
    Console.Write("c |  ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("E" + "    ");
    Console.ResetColor();
}
else if (c1 == 6)
{
    Console.Write("c |  ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("U" + "    ");
    Console.ResetColor();
}
else if (c1 == 7)
{
    Console.Write("c |  ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("D" + "    ");
    Console.ResetColor();
}
else if (c1 == 8)
{
    Console.Write("c |  ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("E" + "    ");
    Console.ResetColor();
}
else if (c1 == 9)
{
    Console.Write("c |  ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("U" + "    ");
    Console.ResetColor();
}

if (c2 == 1)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("D" + "    ");
    Console.ResetColor();


}
else if (c2 == 2)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("E" + "    ");
    Console.ResetColor();
}
else if (c2 == 3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("U" + "    ");
    Console.ResetColor();
}
else if (c2 == 4)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("D" + "    ");
    Console.ResetColor();
}
else if (c2 == 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("E" + "    ");
    Console.ResetColor();
}
else if (c2 == 6)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("U" + "    ");
    Console.ResetColor();
}
else if (c2 == 7)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("D" + "    ");
    Console.ResetColor();
}
else if (c2 == 8)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("E" + "    ");
    Console.ResetColor();
}
else if (c2 == 9)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("U" + "    ");
    Console.ResetColor();
}

if (c3 == 1)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("D");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (c3 == 2)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("E");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (c3 == 3)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("U");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (c3 == 4)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("D");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (c3 == 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("E");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (c3 == 6)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("U");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (c3 == 7)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("D");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (c3 == 8)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("E");
    Console.ResetColor();
    Console.WriteLine("  |");
}
else if (c3 == 9)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("U");
    Console.ResetColor();
    Console.WriteLine("  |");
}


// Tablonun son 2 satırı
Console.WriteLine("  |               |");
Console.WriteLine("  +---------------+");

int score1,score2,score3,score4,score5,score6,score7,score8;


//İlk satırın harflerinin hesaplanması
if ((a1 == 1 || a1 == 4 || a1 == 7) && (a2 == 2 || a2 == 5 || a2 == 8) && (a3 == 3 || a3 == 6 || a3 == 9)) // D E U
{ score += 100; }
else if ((a1 == 3 || a1 == 6 || a1 == 9) && (a2 == 2 || a2 == 5 || a2 == 8) && (a3 == 1 || a3 == 4 || a3 == 7)) // U E D
{ score += 100; }
else if ((a1 == 2 || a1 == 5 || a1 == 8) && (a2 == 1 || a2 == 4 || a2 == 7) && (a3 == 3 || a3 == 6 || a3 == 9)) // E D U
{ score += 70; }
else if ((a1 == 2 || a1 == 5 || a1 == 8) && (a2 == 3 || a2 == 6 || a2 == 9) && (a3 == 1 || a3 == 4 || a3 == 7)) // E U D
{ score += 70; }
else if ((a1 == 1 || a1 == 4 || a1 == 7) && (a2 == 3 || a2 == 6 || a2 == 9) && (a3 == 2 || a3 == 5 || a3 == 8)) // D U E
{ score += 70; }
else if ((a1 == 3 || a1 == 6 || a1 == 9) && (a2 == 1 || a2 == 4 || a2 == 7) && (a3 == 2 || a3 == 5 || a3 == 8)) // U D E            
{ score += 70; }
else if ((a1 == 1 || a1 == 4 || a1 == 7) && (a2 == 1 || a2 == 4 || a2 == 7) && (a3 == 1 || a3 == 4 || a3 == 7)) // D D D
{ score += 40; }
else if ((a1 == 2 || a1 == 5 || a1 == 8) && (a2 == 2 || a2 == 5 || a2 == 8) && (a3 == 2 || a3 == 5 || a3 == 8)) // E E E
{ score += 40; }
else if ((a1 == 3 || a1 == 6 || a1 == 9) && (a2 == 3 || a2 == 6 || a2 == 9) && (a3 == 3 || a3 == 6 || a3 == 9)) // U U U
{ score += 40; }
score1 = score;

//İkinci satırın harflerinin hesaplanması
if ((b1 == 1 || b1 == 4 || b1 == 7) && (b2 == 2 || b2 == 5 || b2 == 8) && (b3 == 3 || b3 == 6 || b3 == 9)) // D E U
{ score += 100; }
else if ((b1 == 3 || b1 == 6 || b1 == 9) && (b2 == 2 || b2 == 5 || b2 == 8) && (b3 == 1 || b3 == 4 || b3 == 7)) // U E D
{ score += 100; }
else if ((b1 == 2 || b1 == 5 || b1 == 8) && (b2 == 1 || b2 == 4 || b2 == 7) && (b3 == 3 || b3 == 6 || b3 == 9)) // E D U
{ score += 70; }
else if ((b1 == 2 || b1 == 5 || b1 == 8) && (b2 == 3 || b2 == 6 || b2 == 9) && (b3 == 1 || b3 == 4 || b3 == 7)) // E U D
{ score += 70; }
else if ((b1 == 1 || b1 == 4 || b1 == 7) && (b2 == 3 || b2 == 6 || b2 == 9) && (b3 == 2 || b3 == 5 || b3 == 8)) // D U E
{ score += 70; }
else if ((b1 == 3 || b1 == 6 || b1 == 9) && (b2 == 1 || b2 == 4 || b2 == 7) && (b3 == 2 || b3 == 5 || b3 == 8)) // U D E              
{ score += 70; }
else if ((b1 == 1 || b1 == 4 || b1 == 7) && (b2 == 1 || b2 == 4 || b2 == 7) && (b3 == 1 || b3 == 4 || b3 == 7)) // D D D
{ score += 40; }
else if ((b1 == 2 || b1 == 5 || b1 == 8) && (b2 == 2 || b2 == 5 || b2 == 8) && (b3 == 2 || b3 == 5 || b3 == 8)) // E E E
{ score += 40; }
else if ((b1 == 3 || b1 == 6 || b1 == 9) && (b2 == 3 || b2 == 6 || b2 == 9) && (b3 == 3 || b3 == 6 || b3 == 9)) // U U U
{ score += 40; }
score2 = score - score1;

// Üçüncü satırın harflerinin hesaplanması
if ((c1 == 1 || c1 == 4 || c1 == 7) && (c2 == 2 || c2 == 5 || c2 == 8) && (c3 == 3 || c3 == 6 || c3 == 9)) // D E U
{ score += 100; }
else if ((c1 == 3 || c1 == 6 || c1 == 9) && (c2 == 2 || c2 == 5 || c2 == 8) && (c3 == 1 || c3 == 4 || c3 == 7)) // U E D
{ score += 100; }
else if ((c1 == 2 || c1 == 5 || c1 == 8) && (c2 == 1 || c2 == 4 || c2 == 7) && (c3 == 3 || c3 == 6 || c3 == 9)) // E D U
{ score += 70; }
else if ((c1 == 2 || c1 == 5 || c1 == 8) && (c2 == 3 || c2 == 6 || c2 == 9) && (c3 == 1 || c3 == 4 || c3 == 7)) // E U D
{ score += 70; }
else if ((c1 == 1 || c1 == 4 || c1 == 7) && (c2 == 3 || c2 == 6 || c2 == 9) && (c3 == 2 || c3 == 5 || c3 == 8)) // D U E
{ score += 70; }
else if ((c1 == 3 || c1 == 6 || c1 == 9) && (c2 == 1 || c2 == 4 || c2 == 7) && (c3 == 2 || c3 == 5 || c3 == 8)) // U D E
{ score += 70; }
else if ((c1 == 1 || c1 == 4 || c1 == 7) && (c2 == 1 || c2 == 4 || c2 == 7) && (c3 == 1 || c3 == 4 || c3 == 7)) // D D D
{ score += 40; }
else if ((c1 == 2 || c1 == 5 || c1 == 8) && (c2 == 2 || c2 == 5 || c2 == 8) && (c3 == 2 || c3 == 5 || c3 == 8)) // E E E
{ score += 40; }
else if ((c1 == 3 || c1 == 6 || c1 == 9) && (c2 == 3 || c2 == 6 || c2 == 9) && (c3 == 3 || c3 == 6 || c3 == 9)) // U U U
{ score += 40; }
score3 = score - score2 - score1;

//İlk satırın harflerinin hesaplanması
if ((a1 == 1 || a1 == 4 || a1 == 7) && (b1 == 2 || b1 == 5 || b1 == 8) && (c1 == 3 || c1 == 6 || c1 == 9)) // D E U
{ score += 100; }
else if ((a1 == 3 || a1 == 6 || a1 == 9) && (b1 == 2 || b1 == 5 || b1 == 8) && (c1 == 1 || c1 == 4 || c1 == 7)) // U E D
{ score += 100; }
else if ((a1 == 2 || a1 == 5 || a1 == 8) && (b1 == 1 || b1 == 4 || b1 == 7) && (c1 == 3 || c1 == 6 || c1 == 9)) // E D U
{ score += 70; }
else if ((a1 == 2 || a1 == 5 || a1 == 8) && (b1 == 3 || b1 == 6 || b1 == 9) && (c1 == 1 || c1 == 4 || c1 == 7)) // E U D
{ score += 70; }
else if ((a1 == 1 || a1 == 4 || a1 == 7) && (b1 == 3 || b1 == 6 || b1 == 9) && (c1 == 2 || c1 == 5 || c1 == 8)) // D U E
{ score += 70; }
else if ((a1 == 3 || a1 == 6 || a1 == 9) && (b1 == 1 || b1 == 4 || b1 == 7) && (c1 == 2 || c1 == 5 || c1 == 8)) // U D E
{ score += 70; }
else if ((a1 == 1 || a1 == 4 || a1 == 7) && (b1 == 1 || b1 == 4 || b1 == 7) && (c1 == 1 || c1 == 4 || c1 == 7)) // D D D
{ score += 40; }
else if ((a1 == 2 || a1 == 5 || a1 == 8) && (b1 == 2 || b1 == 5 || b1 == 8) && (c1 == 2 || c1 == 5 || c1 == 8)) // E E E
{ score += 40; }
else if ((a1 == 3 || a1 == 6 || a1 == 9) && (b1 == 3 || b1 == 6 || b1 == 9) && (c1 == 3 || c1 == 6 || c1 == 9)) // U U U
{ score += 40; }
score4 = score - score3 - score2 - score1;

//İkinci satırın harflerinin hesaplanması
if ((a2 == 1 || a2 == 4 || a2 == 7) && (b2 == 2 || b2 == 5 || b2 == 8) && (c2 == 3 || c2 == 6 || c2 == 9)) // D E U
{ score += 100; }
else if ((a2 == 3 || a2 == 6 || a2 == 9) && (b2 == 2 || b2 == 5 || b2 == 8) && (c2 == 1 || c2 == 4 || c2 == 7)) // U E D
{ score += 100; }
else if ((a2 == 2 || a2 == 5 || a2 == 8) && (b2 == 1 || b2 == 4 || b2 == 7) && (c2 == 3 || c2 == 6 || c2 == 9)) // E D U
{ score += 70; }
else if ((a2 == 2 || a2 == 5 || a2 == 8) && (b2 == 3 || b2 == 6 || b2 == 9) && (c2 == 1 || c2 == 4 || c2 == 7)) // E U D
{ score += 70; }
else if ((a2 == 1 || a2 == 4 || a2 == 7) && (b2 == 3 || b2 == 6 || b2 == 9) && (c2 == 2 || c2 == 5 || c2 == 8)) // D U E
{ score += 70; }
else if ((a2 == 3 || a2 == 6 || a2 == 9) && (b2 == 1 || b2 == 4 || b2 == 7) && (c2 == 2 || c2 == 5 || c2 == 8)) // U D E
{ score += 70; }
else if ((a2 == 1 || a2 == 4 || a2 == 7) && (b2 == 1 || b2 == 4 || b2 == 7) && (c2 == 1 || c2 == 4 || c2 == 7)) // D D D
{ score += 40; }
else if ((a2 == 2 || a2 == 5 || a2 == 8) && (b2 == 2 || b2 == 5 || b2 == 8) && (c2 == 2 || c2 == 5 || c2 == 8)) // E E E
{ score += 40; }
else if ((a2 == 3 || a2 == 6 || a2 == 9) && (b2 == 3 || b2 == 6 || b2 == 9) && (c2 == 3 || c2 == 6 || c2 == 9)) // U U U
{ score += 40; }
score5 = score - score4 - score3 - score2 - score1;

//Üçüncü satırın harflerinin hesaplanması
if ((a3 == 1 || a3 == 4 || a3 == 7) && (b3 == 2 || b3 == 5 || b3 == 8) && (c3 == 3 || c3 == 6 || c3 == 9)) // D E U
{ score += 100; }
else if ((a3 == 3 || a3 == 6 || a3 == 9) && (b3 == 2 || b3 == 5 || b3 == 8) && (c3 == 1 || c3 == 4 || c3 == 7)) // U E D
{ score += 100; }
else if ((a3 == 2 || a3 == 5 || a3 == 8) && (b3 == 1 || b3 == 4 || b3 == 7) && (c3 == 3 || c3 == 6 || c3 == 9)) // E D U
{ score += 70; }
else if ((a3 == 2 || a3 == 5 || a3 == 8) && (b3 == 3 || b3 == 6 || b3 == 9) && (c3 == 1 || c3 == 4 || c3 == 7)) // E U D
{ score += 70; }
else if ((a3 == 1 || a3 == 4 || a3 == 7) && (b3 == 3 || b3 == 6 || b3 == 9) && (c3 == 2 || c3 == 5 || c3 == 8)) // D U E
{ score += 70; }
else if ((a3 == 3 || a3 == 6 || a3 == 9) && (b3 == 1 || b3 == 4 || b3 == 7) && (c3 == 2 || c3 == 5 || c3 == 8)) // U D E
{ score += 70; }
else if ((a3 == 1 || a3 == 4 || a3 == 7) && (b3 == 1 || b3 == 4 || b3 == 7) && (c3 == 1 || c3 == 4 || c3 == 7)) // D D D
{ score += 40; }
else if ((a3 == 2 || a3 == 5 || a3 == 8) && (b3 == 2 || b3 == 5 || b3 == 8) && (c3 == 2 || c3 == 5 || c3 == 8)) // E E E
{ score += 40; }
else if ((a3 == 3 || a3 == 6 || a3 == 9) && (b3 == 3 || b3 == 6 || b3 == 9) && (c3 == 3 || c3 == 6 || c3 == 9)) // U U U
{ score += 40; }
score6 = score - score5 - score4 - score3 - score2 - score1;

//ilk çaprazın harflerinin hesaplanması
if ((a1 == 1 || a1 == 4 || a1 == 7) && (b2 == 2 || b2 == 5 || b2 == 8) && (c3 == 3 || c3 == 6 || c3 == 9)) // D E U
{ score += 100; }
else if ((a1 == 3 || a1 == 6 || a1 == 9) && (b2 == 2 || b2 == 5 || b2 == 8) && (c3 == 1 || c3 == 4 || c3 == 7)) // U E D
{ score += 100; }
else if ((a1 == 2 || a1 == 5 || a1 == 8) && (b2 == 1 || b2 == 4 || b2 == 7) && (c3 == 3 || c3 == 6 || c3 == 9)) // E D U
{ score += 70; }
else if ((a1 == 2 || a1 == 5 || a1 == 8) && (b2 == 3 || b2 == 6 || b2 == 9) && (c3 == 1 || c3 == 4 || c3 == 7)) // E U D
{ score += 70; }
else if ((a1 == 1 || a1 == 4 || a1 == 7) && (b2 == 3 || b2 == 6 || b2 == 9) && (c3 == 2 || c3 == 5 || c3 == 8)) // D U E
{ score += 70; }
else if ((a1 == 3 || a1 == 6 || a1 == 9) && (b2 == 1 || b2 == 4 || b2 == 7) && (c3 == 2 || c3 == 5 || c3 == 8)) // U D E
{ score += 70; }
else if ((a1 == 1 || a1 == 4 || a1 == 7) && (b2 == 1 || b2 == 4 || b2 == 7) && (c3 == 1 || c3 == 4 || c3 == 7)) // D D D
{ score += 40; }
else if ((a1 == 2 || a1 == 5 || a1 == 8) && (b2 == 2 || b2 == 5 || b2 == 8) && (c3 == 2 || c3 == 5 || c3 == 8)) // E E E
{ score += 40; }
else if ((a1 == 3 || a1 == 6 || a1 == 9) && (b2 == 3 || b2 == 6 || b2 == 9) && (c3 == 3 || c3 == 6 || c3 == 9)) // U U U
{ score += 40; }
score7 = score - score6 - score5 - score4 - score3 - score2 - score1;

//İkinci çaprazın harflerinin hesaplanması
if ((a3 == 1 || a3 == 4 || a3 == 7) && (b2 == 2 || b2 == 5 || b2 == 8) && (c1 == 3 || c1 == 6 || c1 == 9)) // D E U
{ score += 100; }
else if ((a3 == 3 || a3 == 6 || a3 == 9) && (b2 == 2 || b2 == 5 || b2 == 8) && (c1 == 1 || c1 == 4 || c1 == 7)) // U E D
{ score += 100; }
else if ((a3 == 2 || a3 == 5 || a3 == 8) && (b2 == 1 || b2 == 4 || b2 == 7) && (c1 == 3 || c1 == 6 || c1 == 9)) // E D U
{ score += 70; }
else if ((a3 == 2 || a3 == 5 || a3 == 8) && (b2 == 3 || b2 == 6 || b2 == 9) && (c1 == 1 || c1 == 4 || c1 == 7)) // E U D
{ score += 70; }
else if ((a3 == 1 || a3 == 4 || a3 == 7) && (b2 == 3 || b2 == 6 || b2 == 9) && (c1 == 2 || c1 == 5 || c1 == 8)) // D U E
{ score += 70; }
else if ((a3 == 3 || a3 == 6 || a3 == 9) && (b2 == 1 || b2 == 4 || b2 == 7) && (c1 == 2 || c1 == 5 || c1 == 8)) // U D E
{ score += 70; }
else if ((a3 == 1 || a3 == 4 || a3 == 7) && (b2 == 1 || b2 == 4 || b2 == 7) && (c1 == 1 || c1 == 4 || c1 == 7)) // D D D
{ score += 40; }
else if ((a3 == 2 || a3 == 5 || a3 == 8) && (b2 == 2 || b2 == 5 || b2 == 8) && (c1 == 2 || c1 == 5 || c1 == 8)) // E E E
{ score += 40; }
else if ((a3 == 3 || a3 == 6 || a3 == 9) && (b2 == 3 || b2 == 6 || b2 == 9) && (c1 == 3 || c1 == 6 || c1 == 9)) // U U U
{ score += 40; }
score8 = score - score7 - score6 - score5 - score4 - score3 - score2 - score1;



// İlk satırın renklerinin hesaplanması
if ((a1 == 1 || a1 == 2 || a1 == 3) && (a2 == 1 || a2 == 2 || a2 == 3) && (a3 == 1 || a3 == 2 || a3 == 3)) // G G G
{
    if (score1 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a1 == 4 || a1 == 5 || a1 == 6) && (a2 == 4 || a2 == 5 || a2 == 6) && (a3 == 4 || a3 == 5 || a3 == 6)) // R R R
{
    if (score1 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a1 == 7 || a1 == 8 || a1 == 9) && (a2 == 7 || a2 == 8 || a2 == 9) && (a3 == 7 || a3 == 8 || a3 == 9)) // B B B
{
    if (score1 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a1 == 1 || a1 == 2 || a1 == 3) && (a2 == 7 || a2 == 8 || a2 == 9) && (a3 == 4 || a3 == 5 || a3 == 6)) // G B R
{
    if (score1 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 1 || a1 == 2 || a1 == 3) && (a2 == 4 || a2 == 5 || a2 == 6) && (a3 == 7 || a3 == 8 || a3 == 9)) // G R B
{
    if (score1 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 4 || a1 == 5 || a1 == 6) && (a2 == 1 || a2 == 2 || a2 == 3) && (a3 == 7 || a3 == 8 || a3 == 9)) // R G B
{
    if (score1 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 4 || a1 == 5 || a1 == 6) && (a2 == 7 || a2 == 8 || a2 == 9) && (a3 == 1 || a3 == 2 || a3 == 3)) // R B G
{
    if (score1 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 7 || a1 == 8 || a1 == 9) && (a2 == 1 || a2 == 2 || a2 == 3) && (a3 == 4 || a3 == 5 || a3 == 6)) // B G R
{
    if (score1 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 7 || a1 == 8 || a1 == 9) && (a2 == 4 || a2 == 5 || a2 == 6) && (a3 == 1 || a3 == 2 || a3 == 3)) // B R G
{
    if (score1 == 0)
    { score += 20; }
    else
    { score += 10; }
}

//İkinci satırın renklerinin hesaplanması
if ((b1 == 1 || b1 == 2 || b1 == 3) && (b2 == 1 || b2 == 2 || b2 == 3) && (b3 == 1 || b3 == 2 || b3 == 3)) // G G G
{
    if (score2 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((b1 == 4 || b1 == 5 || b1 == 6) && (b2 == 4 || b2 == 5 || b2 == 6) && (b3 == 4 || b3 == 5 || b3 == 6)) // R R R
{
    if (score2 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((b1 == 7 || b1 == 8 || b1 == 9) && (b2 == 7 || b2 == 8 || b2 == 9) && (b3 == 7 || b3 == 8 || b3 == 9)) // B B B
{
    if (score2 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((b1 == 1 || b1 == 2 || b1 == 3) && (b2 == 7 || b2 == 8 || b2 == 9) && (b3 == 4 || b3 == 5 || b3 == 6)) // G B R
{
    if (score2 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((b1 == 1 || b1 == 2 || b1 == 3) && (b2 == 4 || b2 == 5 || b2 == 6) && (b3 == 7 || b3 == 8 || b3 == 9)) // G R B
{
    if (score2 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((b1 == 4 || b1 == 5 || b1 == 6) && (b2 == 1 || b2 == 2 || b2 == 3) && (b3 == 7 || b3 == 8 || b3 == 9)) // R G B
{
    if (score2 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((b1 == 4 || b1 == 5 || b1 == 6) && (b2 == 7 || b2 == 8 || b2 == 9) && (b3 == 1 || b3 == 2 || b3 == 3)) // R B G
{
    if (score2 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((b1 == 7 || b1 == 8 || b1 == 9) && (b2 == 1 || b2 == 2 || b2 == 3) && (b3 == 4 || b3 == 5 || b3 == 6)) // B G R
{
    if (score2 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((b1 == 7 || b1 == 8 || b1 == 9) && (b2 == 4 || b2 == 5 || b2 == 6) && (b3 == 1 || b3 == 2 || b3 == 3)) // B R G
{
    if (score2 == 0)
    { score += 20; }
    else
    { score += 10; }
}

//Üçüncü satırın renklerinin hesaplanması
if ((c1 == 1 || c1 == 2 || c1 == 3) && (c2 == 1 || c2 == 2 || c2 == 3) && (c3 == 1 || c3 == 2 || c3 == 3)) // G G G
{
    if (score3 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((c1 == 4 || c1 == 5 || c1 == 6) && (c2 == 4 || c2 == 5 || c2 == 6) && (c3 == 4 || c3 == 5 || c3 == 6)) // R R R
{
    if (score3 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((c1 == 7 || c1 == 8 || c1 == 9) && (c2 == 7 || c2 == 8 || c2 == 9) && (c3 == 7 || c3 == 8 || c3 == 9)) // B B B
{
    if (score3 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((c1 == 1 || c1 == 2 || c1 == 3) && (c2 == 7 || c2 == 8 || c2 == 9) && (c3 == 4 || c3 == 5 || c3 == 6)) // G B R
{
    if (score3 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((c1 == 1 || c1 == 2 || c1 == 3) && (c2 == 4 || c2 == 5 || c2 == 6) && (c3 == 7 || c3 == 8 || c3 == 9)) // G R B
{
    if (score3 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((c1 == 4 || c1 == 5 || c1 == 6) && (c2 == 1 || c2 == 2 || c2 == 3) && (c3 == 7 || c3 == 8 || c3 == 9)) // R G B
{
    if (score3 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((c1 == 4 || c1 == 5 || c1 == 6) && (c2 == 7 || c2 == 8 || c2 == 9) && (c3 == 1 || c3 == 2 || c3 == 3)) // R B G
{
    if (score3 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((c1 == 7 || c1 == 8 || c1 == 9) && (c2 == 1 || c2 == 2 || c2 == 3) && (c3 == 4 || c3 == 5 || c3 == 6)) // B G R
{
    if (score3 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((c1 == 7 || c1 == 8 || c1 == 9) && (c2 == 4 || c2 == 5 || c2 == 6) && (c3 == 1 || c3 == 2 || c3 == 3)) // B R G
{
    if (score3 == 0)
    { score += 20; }
    else
    { score += 10; }
}

//İlk sütunun renklerinin hesaplanması
if ((a1 == 1 || a1 == 2 || a1 == 3) && (b1 == 1 || b1 == 2 || b1 == 3) && (c1 == 1 || c1 == 2 || c1 == 3)) // G G G
{
    if (score4 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a1 == 4 || a1 == 5 || a1 == 6) && (b1 == 4 || b1 == 5 || b1 == 6) && (c1 == 4 || c1 == 5 || c1 == 6)) // R R R
{
    if (score4 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a1 == 7 || a1 == 8 || a1 == 9) && (b1 == 7 || b1 == 8 || b1 == 9) && (c1 == 7 || c1 == 8 || c1 == 9)) // B B B
{
    if (score4 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a1 == 1 || a1 == 2 || a1 == 3) && (b1 == 7 || b1 == 8 || b1 == 9) && (c1 == 4 || c1 == 5 || c1 == 6)) // G B R
{
    if (score4 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 1 || a1 == 2 || a1 == 3) && (b1 == 4 || b1 == 5 || b1 == 6) && (c1 == 7 || c1 == 8 || c1 == 9)) // G R B
{
    if (score4 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 4 || a1 == 5 || a1 == 6) && (b1 == 1 || b1 == 2 || b1 == 3) && (c1 == 7 || c1 == 8 || c1 == 9)) // R G B
{
    if (score4 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 4 || a1 == 5 || a1 == 6) && (b1 == 7 || b1 == 8 || b1 == 9) && (c1 == 1 || c1 == 2 || c1 == 3)) // R B G
{
    if (score4 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 7 || a1 == 8 || a1 == 9) && (b1 == 1 || b1 == 2 || b1 == 3) && (c1 == 4 || c1 == 5 || c1 == 6)) // B G R
{
    if (score4 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 7 || a1 == 8 || a1 == 9) && (b1 == 4 || b1 == 5 || b1 == 6) && (c1 == 1 || c1 == 2 || c1 == 3)) // B R G
{
    if (score4 == 0)
    { score += 20; }
    else
    { score += 10; }
}

//İkinci sütunun renklerinin hesaplanması
if ((a2 == 1 || a2 == 2 || a2 == 3) && (b2 == 1 || b2 == 2 || b2 == 3) && (c2 == 1 || c2 == 2 || c2 == 3)) // G G G
{
    if (score5 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a2 == 4 || a2 == 5 || a2 == 6) && (b2 == 4 || b2 == 5 || b2 == 6) && (c2 == 4 || c2 == 5 || c2 == 6)) // R R R
{
    if (score5 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a2 == 7 || a2 == 8 || a2 == 9) && (b2 == 7 || b2 == 8 || b2 == 9) && (c2 == 7 || c2 == 8 || c2 == 9)) // B B B
{
    if (score5 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a2 == 1 || a2 == 2 || a2 == 3) && (b2 == 7 || b2 == 8 || b2 == 9) && (c2 == 4 || c2 == 5 || c2 == 6)) // G B R
{
    if (score5 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a2 == 1 || a2 == 2 || a2 == 3) && (b2 == 4 || b2 == 5 || b2 == 6) && (c2 == 7 || c2 == 8 || c2 == 9)) // G R B
{
    if (score5 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a2 == 4 || a2 == 5 || a2 == 6) && (b2 == 1 || b2 == 2 || b2 == 3) && (c2 == 7 || c2 == 8 || c2 == 9)) // R G B
{
    if (score5 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a2 == 4 || a2 == 5 || a2 == 6) && (b2 == 7 || b2 == 8 || b2 == 9) && (c2 == 1 || c2 == 2 || c2 == 3)) // R B G
{
    if (score5 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a2 == 7 || a2 == 8 || a2 == 9) && (b2 == 1 || b2 == 2 || b2 == 3) && (c2 == 4 || c2 == 5 || c2 == 6)) // B G R
{
    if (score5 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a2 == 7 || a2 == 8 || a2 == 9) && (b2 == 4 || b2 == 5 || b2 == 6) && (c2 == 1 || c2 == 2 || c2 == 3)) // B R G
{
    if (score5 == 0)
    { score += 20; }
    else
    { score += 10; }
}

//Üçüncü sütunun renklerinin hesaplanması
if ((a3 == 1 || a3 == 2 || a3 == 3) && (b3 == 1 || b3 == 2 || b3 == 3) && (c3 == 1 || c3 == 2 || c3 == 3)) // G G G
{
    if (score6 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a3 == 4 || a3 == 5 || a3 == 6) && (b3 == 4 || b3 == 5 || b3 == 6) && (c3 == 4 || c3 == 5 || c3 == 6)) // R R R
{
    if (score6 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a3 == 7 || a3 == 8 || a3 == 9) && (b3 == 7 || b3 == 8 || b3 == 9) && (c3 == 7 || c3 == 8 || c3 == 9)) // B B B
{
    if (score6 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a3 == 1 || a3 == 2 || a3 == 3) && (b3 == 7 || b3 == 8 || b3 == 9) && (c3 == 4 || c3 == 5 || c3 == 6)) // G B R
{
    if (score6 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a3 == 1 || a3 == 2 || a3 == 3) && (b3 == 4 || b3 == 5 || b3 == 6) && (c3 == 7 || c3 == 8 || c3 == 9)) // G R B
{
    if (score6 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a3 == 4 || a3 == 5 || a3 == 6) && (b3 == 1 || b3 == 2 || b3 == 3) && (c3 == 7 || c3 == 8 || c3 == 9)) // R G B
{
    if (score6 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a3 == 4 || a3 == 5 || a3 == 6) && (b3 == 7 || b3 == 8 || b3 == 9) && (c3 == 1 || c3 == 2 || c3 == 3)) // R B G
{
    if (score6 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a3 == 7 || a3 == 8 || a3 == 9) && (b3 == 1 || b3 == 2 || b3 == 3) && (c3 == 4 || c3 == 5 || c3 == 6)) // B G R
{
    if (score6 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a3 == 7 || a3 == 8 || a3 == 9) && (b3 == 4 || b3 == 5 || b3 == 6) && (c3 == 1 || c3 == 2 || c3 == 3)) // B R G
{
    if (score6 == 0)
    { score += 20; }
    else
    { score += 10; }
}

//İlk çaprazın renklerinin hesaplanması
if ((a1 == 1 || a1 == 2 || a1 == 3) && (b2 == 1 || b2 == 2 || b2 == 3) && (c3 == 1 || c3 == 2 || c3 == 3)) // G G G
{
    if (score7 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a1 == 4 || a1 == 5 || a1 == 6) && (b2 == 4 || b2 == 5 || b2 == 6) && (c3 == 4 || c3 == 5 || c3 == 6)) // R R R
{
    if (score7 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a1 == 7 || a1 == 8 || a1 == 9) && (b2 == 7 || b2 == 8 || b2 == 9) && (c3 == 7 || c3 == 8 || c3 == 9)) // B B B
{
    if (score7 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a1 == 1 || a1 == 2 || a1 == 3) && (b2 == 7 || b2 == 8 || b2 == 9) && (c3 == 4 || c3 == 5 || c3 == 6)) // G B R
{
    if (score7 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 1 || a1 == 2 || a1 == 3) && (b2 == 4 || b2 == 5 || b2 == 6) && (c3 == 7 || c3 == 8 || c3 == 9)) // G R B
{
    if (score7 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 4 || a1 == 5 || a1 == 6) && (b2 == 1 || b2 == 2 || b2 == 3) && (c3 == 7 || c3 == 8 || c3 == 9)) // R G B
{
    if (score7 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 4 || a1 == 5 || a1 == 6) && (b2 == 7 || b2 == 8 || b2 == 9) && (c3 == 1 || c3 == 2 || c3 == 3)) // R B G
{
    if (score7 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 7 || a1 == 8 || a1 == 9) && (b2 == 1 || b2 == 2 || b2 == 3) && (c3 == 4 || c3 == 5 || c3 == 6)) // B G R
{
    if (score7 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a1 == 7 || a1 == 8 || a1 == 9) && (b2 == 4 || b2 == 5 || b2 == 6) && (c3 == 1 || c3 == 2 || c3 == 3)) // B R G
{
    if (score7 == 0)
    { score += 20; }
    else
    { score += 10; }
}

//İkinci çarazın renklerinin hesaplanması
if ((a3 == 1 || a3 == 2 || a3 == 3) && (b2 == 1 || b2 == 2 || b2 == 3) && (c1 == 1 || c1 == 2 || c1 == 3)) // G G G
{
    if (score8 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a3 == 4 || a3 == 5 || a3 == 6) && (b2 == 4 || b2 == 5 || b2 == 6) && (c1 == 4 || c1 == 5 || c1 == 6)) // R R R
{
    if (score8 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a3 == 7 || a3 == 8 || a3 == 9) && (b2 == 7 || b2 == 8 || b2 == 9) && (c1 == 7 || c1 == 8 || c1 == 9)) // B B B
{
    if (score8 == 0)
    { score += 30; }
    else
    { score += 20; }
}
else if ((a3 == 1 || a3 == 2 || a3 == 3) && (b2 == 7 || b2 == 8 || b2 == 9) && (c1 == 4 || c1 == 5 || c1 == 6)) // G B R
{
    if (score8 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a3 == 1 || a3 == 2 || a3 == 3) && (b2 == 4 || b2 == 5 || b2 == 6) && (c1 == 7 || c1 == 8 || c1 == 9)) // G R B
{
    if (score8 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a3 == 4 || a3 == 5 || a3 == 6) && (b2 == 1 || b2 == 2 || b2 == 3) && (c1 == 7 || c1 == 8 || c1 == 9)) // R G B
{
    if (score8 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a3 == 4 || a3 == 5 || a3 == 6) && (b2 == 7 || b2 == 8 || b2 == 9) && (c1 == 1 || c1 == 2 || c1 == 3)) // R B G
{
    if (score8 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a3 == 7 || a3 == 8 || a3 == 9) && (b2 == 1 || b2 == 2 || b2 == 3) && (c1 == 4 || c1 == 5 || c1 == 6)) // B G R
{
    if (score8 == 0)
    { score += 20; }
    else
    { score += 10; }
}
else if ((a3 == 7 || a3 == 8 || a3 == 9) && (b2 == 4 || b2 == 5 || b2 == 6) && (c1 == 1 || c1 == 2 || c1 == 3)) // B R G
{
    if (score8 == 0)
    { score += 20; }
    else
    { score += 10; }
}


Console.WriteLine("board score = " + score);