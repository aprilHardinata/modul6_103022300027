using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(!string.IsNullOrEmpty(title), "Judul tidak boleh null atau kosong.");
        Debug.Assert(title.Length <= 100, "Judul tidak boleh lebih dari 100 karakter.");

        Random random = new Random();

        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void increasePlayCount(int jumlah)
    {
        try
        {
            if (jumlah <= 0 || jumlah > 10000000)
            {
                throw new ArgumentOutOfRangeException("Jumlah play count harus antara 1 hingga 10.000.000.");
            }

            checked
            {
                playCount += jumlah;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Terjadi overflow pada play count!");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}