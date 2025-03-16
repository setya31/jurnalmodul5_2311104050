class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Penjumlahan.JumlahTigaAngka(10, 40, 50));
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(10);
        db.AddNewData(40);
        db.AddNewData(50);
        db.PrintAllData();
    }
}
