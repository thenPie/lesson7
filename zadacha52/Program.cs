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
double smm = 0;
for(int o = 0; o < columns; o++) {
    for(int i = 0; i < rows; i++) {
        smm = smm + twoDarray[i, o];
    }
    Console.WriteLine($"{smm / rows} —> среднее колонки №{o + 1}");
    smm = 0;
}