// Программа показывает по заданному номеру четверти 
//диапазон координат точек в этой четверти (x и y).
// 

string GetRange(int quarter) 
{
    if (quarter == 1) return (x > 0 && y > 0);
        
    if (quarter == 2) return (x < 0 && y > 0);
        

    if (quarter == 3) return (x < 0 && y > 0);
        

    if (quarter == 4) return (x > 0 && y < 0);
    return "unknown quarter ";
}        
    
    

Console.WriteLine("Enter the Quarter number: ");
int quarterNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetRange(quarterNumber));
