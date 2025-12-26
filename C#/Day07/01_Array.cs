using System;

class Array1 {
    public static void ArrayM()
    {
        int[] num = new int[5];
        int[] num1 = {1,2,3,4,5};

        Console.WriteLine(num1[1]);

        for(int i=0; i<num1.Length; i++)
        {
            Console.Write(num1[i] + " ");
        }

        Console.WriteLine();

        foreach(int nu in num1) {
            Console.Write(nu + " ");
        }
        
        // Multi array
        // int[,] matrix = new int[2,3];

        int[,] matrix =
        {
            {1,2,5},
            {3,4,8},
        };
        Console.WriteLine("\n"+matrix[1,1]);

        for(int i=0; i<matrix.GetLength(0); i++)
        {
            for(int j=0; j<matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }

        // Jagged Array
        int[][] jagged = new int[2][];
        jagged[0] = new int[] {1,2};
        jagged[1] = new int[] {3,4,5};

        Console.WriteLine(jagged[1][2]);

        for(int i=0; i<jagged.Length; i++)
        {
            for(int j=0; j<jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j] + " ");
            }
            Console.WriteLine();
        }


        int[] marks = {4,1,8,7};
        Array.Sort(marks);
        Console.WriteLine(string.Join(" ", marks));



        int[] data = {12,20,30};
        Array.Clear(data, 0, data.Length);
        Console.WriteLine(string.Join(" ", data));
        


        int[] src = {1,2,3};
        int[] des = new int[3];

        Array.Copy(src, des, 2);
        Console.WriteLine(string.Join(" ", des));


        int[] num2 = {1,2};
        Array.Resize(ref num2, 2);
        Console.WriteLine(string.Join(" ", num2));

        int[] num3 = {1,2};
        Array.Resize(ref num3, 1);
        Console.WriteLine(string.Join(" ", num3));


        // Array exit
        // int[] num4 = {25,12,30,35};
        int[] num4 = {15};
        bool found = Array.Exists(num4, x=>x>25);
        Console.WriteLine(found);

    }
}