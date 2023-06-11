int InputNumber(){
    System.Console.Write("Введите трехзначное число : ");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a <=99 || a>=1000){
        Console.Write("Ошибка ввода! Введите ТРЕХзначное число : ");
        a = Convert.ToInt32(Console.ReadLine());    
    
    }
    return a ;    
}
int SecondNumber(int a ){
    int sn = (a/10)%10;
    return sn ; 
}
System.Console.Write("Вторая цифра введенного числа -> " + SecondNumber(InputNumber()));