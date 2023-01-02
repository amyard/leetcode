namespace LeetCode;

public static class SomeTesting
{

    public static void SomeTesting2()
    {
        List<int> asd = new(10);

        Console.WriteLine(asd.Capacity);
        Console.WriteLine(asd.Count);
        
        asd.AddRange(new int[] {1,2,3,4});
        
        Console.WriteLine(asd.Capacity);
        Console.WriteLine(asd.Count);


        asd.AddRange(new int[] {1,2,3,4, 4,5,6,7,7});
        
        Console.WriteLine(asd.Capacity);
        Console.WriteLine(asd.Count);
        
    }
//     public static void  SomeTesting2()
//     {
//
//         int i = 0;
//         var enumerator = Fill(i);
//         enumerator.MoveNext();
//         enumerator.MoveNext();
//         enumerator.MoveNext();
//
//         Console.WriteLine(enumerator.Current);
//
//         var asd = "aaa";
//
//         /*
//         // Employee emp = new Employee();
//         // emp.ExecMessage();
//         //
//         //
//         // Employee man = new Manager();
//         // man.ExecMessage();
//         //
//         // Manager man1 = new Manager();
//         // man1.ExecMessage();
//         //
//         //
//         // Employee a1 = new Unemployee();
//         // a1.ExecMessage();
//         //
//         // Manager a2 = new Unemployee();
//         // a2.ExecMessage();
//         //
//         // Unemployee a3 = new Unemployee();
//         // a3.ExecMessage();
//         //
//
//         Empl empl = new Empl();
//         empl.Message1();
//         empl.Message2();
//
//         public interface IC1
//         {
//             public void Message1();
//         }
//
//         public interface IC2
//         {
//             public void Message2();
//         }
//
//         public class Empl : IC1, IC2
//         {
//             public int Id { get; set; }
//             public void Message1() => Console.WriteLine("aaaa");
//
//             public void Message2() => Console.WriteLine("bbb");
//         }
//
//
//
//         public class Employee
//         {
//             public int Id { get; set; }
//             public virtual void ExecMessage() => Console.WriteLine("Employee: ExecMessage");
//         }
//
//         public class Manager : Employee
//         {
//             public override void ExecMessage() => Console.WriteLine("Manager: ExecMessage");
//         }
//
//
//         public class Unemployee : Manager
//         {
//             public override void ExecMessage() => Console.WriteLine("Unemployee: ExecMessage");
//         }
//
//
//         class Some1
//         {
//             public int Id { get; set; }
//
//             public int A1() => 1;
//             public int A1(int i) => 1;
//             public decimal A1(int i, int y) => 1;
//         }
//
//
//         interface Inter
//         {
//             public void SomeShit();
//             public static int asd = 111;
//             public static int SomeCl() => 111;
//             public int SomeVal { get; set; }
//         }
//
//
//         public abstract class SpmeC
//         {
//             public abstract  int Id { get; set; }
//         }
//
//         public abstract class S1 : SpmeC
//         {
//             public abstract int B2 { get; set; }
//         }
//
//
//
//         // ref if you want to modify
//         // out if you want to get a new value
//
//         //int a;
//         int b = 2;
//
//         Console.WriteLine($"a - 0. b - {b}.");
//
//         SomeMethod(out int a, out b);
//
//         Console.WriteLine($"a - {a}. b - {b}.");
//
//
//
//         void SomeMethod(out int a, out int b)
//         {
//             a = 10;
//             b = 20;
//         }
//
//         */
//
//     }

    private static IEnumerator<int> Fill(int i)
    {
        if(i % 2 != 0)
            yield break;

        if (i < 3)
        {
            i++;
            yield return i;
        }
    }
}