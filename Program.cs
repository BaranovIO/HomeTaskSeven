/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
        
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j], 2) + "\t");  

        Console.WriteLine();
    }

    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/






/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(minValue, maxValue +1);
        
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");  

        Console.WriteLine();
    }

    Console.WriteLine();
}


void SearchOfElement (int[,] array)
{
    Console.Write("Input index i: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input index j: ");
    int j = Convert.ToInt32(Console.ReadLine());

    if(i < array.GetLength(0) && j < array.GetLength(1))
        Console.WriteLine($"The element with index ({i}; {j}) is {array[i,j]}");
    
    else Console.WriteLine($"The is no element with index ({i}; {j})");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
SearchOfElement(myArray);
*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(minValue, maxValue +1);
        
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");  

        Console.WriteLine();
    }

    Console.WriteLine();
}

double[] AverageSumOfColumn(int[,] array)
{
    double[] arrayOfAverageSum = new double[array.GetLength(0)];
    
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {    
            sum += array[i,j];
        }
        
        arrayOfAverageSum[j] = sum / array.GetLength(1);
        
    }

    return arrayOfAverageSum;
} 

void ShowDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i] + " ");
    }
    
    Console.WriteLine();	
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ShowDoubleArray(AverageSumOfColumn(myArray));




