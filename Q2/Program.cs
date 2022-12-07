Console.WriteLine("Введите координаты точки 1");
int[] arrayA = fillarray(3);
Console.WriteLine("Введите координаты точки 2");
int[] arrayB = fillarray(3);

double[] arrayDif = new double[3];
for (int i = 0; i < 3;i++){
    arrayDif[i] = Math.Abs(arrayA[i] - arrayB[i]);
}
double intermed = Math.Sqrt(arrayDif[0]*arrayDif[0] + arrayDif[1]*arrayDif[1]);
double final = Math.Sqrt(intermed*intermed + arrayDif[2]*arrayDif[2]);
Console.WriteLine("Ответ " + final);

// Создать и заполнить пользователем массив размера size
int[] fillarray(int size){
    int[] array = new int[size];
    for (int i = 0; i < 3;i++){
        Console.WriteLine("Введите число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}