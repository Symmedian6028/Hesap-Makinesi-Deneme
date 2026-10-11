var hesap = new Calculator();
try
{
    Console.WriteLine(hesap.Hesapla(5, 0, "/"));
}
catch (Exception ex)
{
    Console.WriteLine("Hata: " + ex.Message);
}