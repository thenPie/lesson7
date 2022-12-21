Console.Clear();

int Random() {
    Random rnd = new Random();
    int num = rnd.Next(1, 10);
    return num;
}

int rows = 3, columns = 4;
int[,] twoDarray = new int[rows, columns];

for(int i = 0; i < rows; i++) {
    Console.Write("[");
    for(int o = 0; o < columns; o++) {
        twoDarray[i, o] = Random();
        if(o == columns - 1) {
            Console.WriteLine($"{twoDarray[i, o]}]");
        } else {
            Console.Write($"{twoDarray[i, o]}, ");
        }
    }
}

Console.WriteLine();
// int[] aver = new int[] {twoDarray[0, 0], twoDarray[1, 0], twoDarray[2, 0]};
// Console.WriteLine($"{aver[0]} {aver[1]} {aver[2]}");
// double avg = Queryable.Average(aver.AsQueryable());
// Console.WriteLine($"{avg}");

double smm = 0;
for(int o = 0; o < columns; o++) {
    for(int i = 0; i < rows; i++) {
        smm = smm + twoDarray[i, o];
        Console.Write($"{twoDarray[i, o]}, ");
    }
    Console.WriteLine(smm);
    Console.WriteLine(smm / rows);
    smm = 0;
}
// Console.WriteLine(smm);
// Console.WriteLine(smm / rows);

// for(int i = 0; i < rows; i++) {
//     for(int o = 0; o < columns; o++) {
//        int[] aver = new int[] {twoDarray[i, o], twoDarray[i, o + 1], twoDarray[i, o + 2]};
//        double avg = Queryable.Average(aver.AsQueryable());
//        Console.WriteLine("Average = {0} ", avg);
//     }
//     // int[] aver = new int[] {twoDarray[0, i], twoDarray[0, i + 1], twoDarray[0, i + 2]};
//     // double avg = Queryable.Average(aver.AsQueryable());
//     // Console.Write("Average = {0} ", avg);
// }

Console.WriteLine();
for(int i = 0; i < columns; i++) {
    for(int o = 0; o < rows; o++) {
        Console.Write($"{twoDarray[o, i]} ");
    }
}