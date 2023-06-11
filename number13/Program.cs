int InputNumber(){
    System.Console.Write("Введите трехзначное число : ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a <=99){
        Console.Write("третьей цифры нет");
        System.Environment.Exit(0);
    }
    return a ;    
}
int ThirdNumber(int a ){
    while (a>999){
       a = a/10;
    }
    return a%10 ; 
}
System.Console.Write("Третья цифра введенного числа -> " + ThirdNumber(InputNumber()));