// See https://aka.ms/new-console-template for more information
class SimpleDataBase<T>
{
    private List<T> storedData; 
    private List<DateTime> inputDates = new List<DateTime>();

    public SimpleDataBase() { 
        storedData = new List<T>();
    }
    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for (int i = 0; i < storedData.Count; i++) {
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }

}

class Utama
{
    public static void Main(string[] args)
    {
        SimpleDataBase<int> simple = new SimpleDataBase<int>();

        simple.addNewData(10);
        simple.addNewData(30);
        simple.addNewData(22);
        simple.printAllData();
    }
}
