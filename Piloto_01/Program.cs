using System.Transactions;
class Program
{
    static void Main()
    {
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

        var result = Divide(10, 0);
        Console.WriteLine(result);
    }

    private static void CurrentDomain_UnhandledException (object sender, UnhandledExceptionEventArgs e)
    {
        Console.WriteLine($"Situaçao inesperada, codigo vai continuar sua excução. \n {e.ExceptionObject}");
    }

    static int? Divide(int a, int b)
    {
        try
        {
            if (b == 0)
            {
                throw new Exception("Não posso efetuar operação por zero");
            }
            return a / b;
        }
        catch (InvalidOperationException invalidEx)
        {
            Console.WriteLine (invalidEx.ToString());
            return -1;
        }
        catch (DivideByZeroException divideByZeroEx)
        {
            Console.WriteLine(divideByZeroEx.ToString());
            return -2;
        }
        catch (Exception ex) 
        {
            Console.WriteLine (ex.ToString ());
            return null;
        }
        finally
        {
            Console.WriteLine("Serei Executado");
        }
    }
}