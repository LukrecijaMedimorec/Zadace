using System;
using System.Collections.Generic;
using System.Text;

public class Class1
{
	public class Episode()
	{
	
	int ViewerCount;
	double AverageRating { get; set; }
	double MaxRating { get; set; }


	public Episode()
	{
		ViewerCount = 0;
		AverageRating = 0;
		MaxRating = 0;

	} 
	public Episode(int viewerCount, double averageRating, double maxRating)
    {
		ViewerCount = viewerCount;
		AverageRating = averageRating;
		MaxRating = maxRating;
    }
	int GetViewerCount()
    {
		return ViewerCount;
    }
	double GetAverageScore()
    {
		return AverageRating / ViewerCount;
    }
	double GetMaxScore()
    {
		return MaxRating;
    }
	void AddView(double EpisodeRating)
    {
		AverageRating += EpisodeRating;
        if (EpisodeRating > MaxRating)
        {
			MaxRating = EpisodeRating;
        }
		ViewerCount++;
    }

}


