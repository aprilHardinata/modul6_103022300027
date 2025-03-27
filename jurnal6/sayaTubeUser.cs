using System;

public class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo> uploadVids;
	private string username;
    public SayaTubeUser(string username)
	{
		if (string.IsNullOrWhiteSpace(username) || username.Length > 100)
			throw new ArgumentOutOfRangeException("Username tidak boleh kosong atau " +
				"username tidak boleh memiliki karakter lebih dari 100");

		Random rand = new Random();
		this.id = rand.Next(1000, 9999);
		this.username = username;
		uploadVids = new List<SayaTubeVideo>();
    }

	public void AddVideo(SayaTubeVideo video)
	{
		//if (video == null) throw new ArgumentNullException("Video tidak boleh Kosong!!");
		uploadVids.Add(video);
	}

    public int GetTotalVideoPlayCount()
	{
		int totalPlayCount = 0;
        foreach (var video in uploadVids)
        {
			totalPlayCount += video.GetPlayCount();
        }
		return totalPlayCount;	
    }

	public void PrintAllVideoPlaycount()
	{
		Console.WriteLine($"User : {username}");
        for (int i = 0; i < uploadVids.Count ; i++)
        {
			Console.WriteLine($"VIdeo {i + 1} judul {uploadVids[i].GetPlayCount()}");
        }
    }

	public string getName()
	{
		return username;
	}
}
