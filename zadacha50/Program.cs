Console.Clear();

int Random() {
    Random rnd = new Random();
    int num = rnd.Next(1, 10);
    return num;
}

Console.Write("Введите однозначное число для поиска в двумерном массиве: ");
int find = int.Parse(Console.ReadLine());
int[,] findCoords = new int[1, 2];
int orig = -1;
findCoords[0, 0] = orig;
findCoords[0, 1] = orig;

int rows = 4, columns = 4;
int[,] twoDarray = new int[rows, columns];

for(int i = 0; i < rows; i++) {
    Console.Write("[");
    for(int o = 0; o < columns; o++) {
        twoDarray[i, o] = Random();

        if(find == twoDarray[i, o]) {
            findCoords[0, 0] = i;
            findCoords[0, 1] = o;
        }

        if(o == columns - 1) {
            Console.WriteLine($"{twoDarray[i, o]}]");
        } else {
            Console.Write($"{twoDarray[i, o]}, ");
        }
    }
}

Console.WriteLine();
if(findCoords[0, 0] == orig && findCoords[0, 1] == orig) {
    Console.Write("Не обнаружено данного числа в данном массиве");
} else {
    Console.Write($"Координаты числа {find} в двумерном массиве: [{findCoords[0, 0]}, {findCoords[0, 1]}]");
}