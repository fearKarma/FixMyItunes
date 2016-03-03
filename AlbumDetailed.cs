using System;

public class AlbumDetailed : Album
{
    private string trackTitle;

    public string TrackTitle
    {
        get { return trackTitle; }
        set { trackTitle = value; }
    }

    private string sortArtist;

    public string SortArtist
    {
        get { return sortArtist; }
        set { sortArtist = value; }
    }

    private string sortAlbum;

    public string SortAlbum
    {
        get { return sortAlbum; }
        set { sortAlbum = value; }
    }

    private string year;

    public string Year
    {
        get { return year; }
        set { year = value; }
    }

    private int discNumber;

    public int DiscNumber
    {
        get { return discNumber; }
        set { discNumber = value; }
    }



    public AlbumDetailed() 
	{
	}
}
