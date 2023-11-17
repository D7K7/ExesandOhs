/*
 * Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

Examples input/output:

XO("ooxx") => true
XO("xooxx") => false
XO("ooxXm") => true
XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
XO("zzoo") => false
 */


string XO = "XXOO";

int numXs = 0;
int numOs = 0;

foreach (char t in XO)
    if (t == 'X' || t == 'x')
    {
        numXs++;
    }
    else if (t == 'O' || t == 'o')
    {
        numOs++;
    }

if (numXs == numOs)
{
    //return true;
    Console.WriteLine("True!");
}
else
{
    Console.WriteLine("False!");
}
