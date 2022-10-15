
string Inversion (string x)
{
    if (x.Length<0) return x [x.Length-1];
    return Inversion + x[ x.Length-1]-1;
}
string x = "Hello";
Inversion(x);