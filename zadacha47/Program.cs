int Random() {
    Random rnd = new Random();
    int num = rnd.Next(10, 100);
    return num;
}

Console.Write("Сначала введите количество строк и затем количество столбиков через пробел: ");
var input = Console.ReadLine();
var space = input.Split(" ");
int rows = int.Parse(space[0]);
int columns = int.Parse(space[1]);

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