int InputNumber(){
    Console.Write("Введите цифру дня недели : ");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a <=0 || a>=8){
        Console.Write("В неделе 7 дней , введите цифру от 1 до 7 : ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;    
}
void WeekendChecker(int a ){
    if (a>=6){
        Console.Write("да");
    }else{
        Console.Write("нет");
    } 
}
WeekendChecker(InputNumber());