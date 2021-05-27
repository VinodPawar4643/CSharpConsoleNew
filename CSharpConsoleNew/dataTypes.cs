using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleNew
{
	class dataTypes
	{
    public int number = 0;
    public static int staicVariable = 0;
    public string name = "";

    public static void calllStaticMethod()
    {
      Console.WriteLine("Calling static method :" + staicVariable);
      staicVariable = 9000;
    }

    public void callNonSaticMethod()
    {
      Console.WriteLine("Enter any numeric value : ");
      number = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(number);
      Console.WriteLine("Enter any name : ");
      name = Console.ReadLine();
    }
  }
}
