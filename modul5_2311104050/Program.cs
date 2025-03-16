class Program
{
    static void Main(string[] args)
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(10);
        db.AddNewData(40);
        db.AddNewData(50);
        db.PrintAllData();
    }
}
