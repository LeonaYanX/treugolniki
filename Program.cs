
System.Console.WriteLine("Enter the heigth of triangle");
int heigth = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the width of triangle");
int width = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i<= heigth ; i++)
{
//*
//**
//***
//****
//*****
    for( int j = 1; j<=i ; j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
for (int i = 1; i<= heigth ; i++)
{
// *****
// ****
// ***
// **
// *

    for( int j = 0; j<=width -i ; j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

for (int i = 1; i<= heigth ; i++)
{
//      *
//     **
//    ***
//   ****
//  *****


    for( int j = 0; j<=width -i ; j++)
    {
        System.Console.Write(" ");

    }
    for(int k=1 ; k<=i ; k++)
    {
System.Console.Write("*");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

for (int i = 1; i<= heigth ; i++)
{
//  *****
//   ****
//    ***
//     **
//      *

    for( int j = 1; j<=i ; j++)
    {
        System.Console.Write(" ");
    }
    for(int k = 0;k<=width-i ;k++)
    {
System.Console.Write("*");
    }
    System.Console.WriteLine();
}




