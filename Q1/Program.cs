// Работает и не для пятизначных. Не вставляю опять проверку на текст.
Console.WriteLine("Введите пятизначное число ");
int numbers = Convert.ToInt32(Console.ReadLine());
int length = lengthofint(numbers);
float middle = length/2;
bool isPoly = true;
for (int i = 1; i<middle; i++){
    int numberA = digitofint(numbers,i);
    int numberB = digitofint(numbers,length+1-i);
    if (numberA != numberB){
        isPoly = false;
    }
}
if (isPoly) {
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}

/// Успешно считает длину, но только положительных чисел
int lengthofint(int number){
    int counter = 1;
    while (number > 9){
        number = number/10;
        counter++;
    }
    return counter;
}

///Возвращает цифру на указанном месте числа
int digitofint(int number,int place){
    int step = 1;
    while (step<place){
        number = number/10;
        step++;
    }
    number = number%10;
    Console.WriteLine("Итог " + number);
    return number;
}