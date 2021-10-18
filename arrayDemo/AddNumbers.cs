using System;


//class sam
//{
//    private void calc(string[] args)
//    {
//        int Number1, Number2;
//        Console.WriteLine("please enter the Number1");
//        Number1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("please enter the Number2");
//        Number2 = Convert.ToInt32(Console.ReadLine());
//        check obj = new check();
//        obj.sum(Number1, Number2);
//        //obj.prime(Console.Read());


//    }



//}

public class check
{
    public void sum(int a, int b)
    {
        int Result;
        Result = a + b;
        Console.WriteLine("Sum of two Numbers:" + Result.ToString());
        Console.ReadLine();
    }


}


