
using PolygonPerimetr;

List <int> lst = new List<int>() { 1, 2, 3};
int [] arr = new int [] { 1, 2, 3 };


/*
for (int i = 0; i < lst.Count; i++)
{ 
    int res = lst[i] - lst[i-1];
    Console.WriteLine(res);

}
*/
for (int i = 0; i < arr.Length; i++)
{
    int res = lst[i-1];
    Console.WriteLine(res);
}
