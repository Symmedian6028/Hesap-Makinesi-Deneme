public class Calculator
{
  public double Hesapla(double a, double b, string islem)
    {
        switch (islem)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                if (b == 0)
                    throw new DivideByZeroException(HataMesajlari.SifiraBolme);
                   
                    return a / b;
                
                case "%":
                if (b != 0)
                {
                    return a % b;
                }
                else
                {
                    throw new DivideByZeroException(HataMesajlari.SifiraBolme);
                }
                case "^":
                return GecerliSonuc(Math.Pow(a, b));
                case "sqrt":
                if (a >= 0)
                {
                    return Math.Sqrt(a);
                }
                else
                {
                    throw new ArgumentException(HataMesajlari.NegatifKarekok);
                }
                case "log":
                if (a > 0 && b > 0 && b != 1)
                {
                    return Math.Log(a, b);
                }
                else
                {
                    throw new ArgumentException(HataMesajlari.GecersizLogaritma);
                }
                case "sin":
                return Math.Sin(a);
                case "cos":
                return Math.Cos(a);
                case "tan":
                return Math.Tan(a);
                case "cot":
                if (Math.Abs(Math.Tan(a)) < 0.0000001)
                {
                    throw new ArgumentException(HataMesajlari.CotanjantSifir);
                }
                else
                {
                   return 1 / Math.Tan(a);
                }
                case "factorial":
                if (a < 0 || a != Math.Floor(a))
                    throw new ArgumentException(HataMesajlari.GecersizFaktoriyel);
                if (a > 170)
                    throw new ArgumentException(HataMesajlari.FaktoriyelCokBuyuk);
                return Factorial((int)a);
                case "log10":
                if (a > 0)
                {
                    return Math.Log10(a);
                }
                else
                {
                    throw new ArgumentException(HataMesajlari.PozitifSayiGerekli);
                }
                case "ln":
                if (a > 0)
                {
                    return Math.Log(a);
                }
                else
                {
                    throw new ArgumentException(HataMesajlari.PozitifSayiGerekli);
                }
                case "acosh":
                if (a >= 1)
                {
                    return Math.Acosh(a);
                }
                else
                {
                    throw new ArgumentException(HataMesajlari.AcoshAraligi);
                }
                case "atanh":
                if (a > -1 && a < 1)
                {
                    return Math.Atanh(a);
                }
                else
                {
                    throw new ArgumentException(HataMesajlari.AtanhAraligi);
                }
                case "cbrt":
                return Math.Cbrt(a);
            default:
                throw new ArgumentException(HataMesajlari.GecersizIslem);
        }
    }
private static double GecerliSonuc(double sonuc)
    {
        if (double.IsNaN(sonuc) || double.IsInfinity(sonuc))
            throw new ArgumentException(HataMesajlari.GecersizSonuc);
        return sonuc;
    }
     private static double Factorial(int n)
    {
        double sonuc = 1;
        for (int i = 2; i <= n; i++)
            sonuc *= i;
        return sonuc;
    }
}