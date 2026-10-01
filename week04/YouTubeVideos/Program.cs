using System;

class Program
{
    public static List<Video> _videos = new List<Video>(); 

    static void Main(string[] args)
    {
        Video video1 = new Video("Wiring Tutorial" ,"EletricDave", 1142);
        Comment comment1 = new Comment("Marie152", "Worked here, thanks");
        Comment comment7 = new Comment("LucasTech", "Very helpful tutorial");
        Comment comment8 = new Comment("AnaDev", "This solved my problem");
        video1.AddComment(comment1); 
        video1.AddComment(comment7);
        video1.AddComment(comment8);
        
        Video video2 = new Video("Blue Jay Sing" ,"NatureDaily", 580);
        Comment comment2 = new Comment("HaryStevenB", "Beautifull");
        Comment comment3 = new Comment("RuanB98", "Music to my ears");
        Comment comment9 = new Comment("BirdWatcher22", "Amazing sound");
        Comment comment10 = new Comment("NatureFan", "I could listen to this all day");
        video2.AddComment(comment2);
        video2.AddComment(comment3);
        video2.AddComment(comment9);
        video2.AddComment(comment10);

        Video video3 = new Video("best games of the week" ,"ZoePlays", 1250);
        Comment comment4 = new Comment("AmeliaCl", "Great Video");
        Comment comment5 = new Comment("OliviaC24", "I disagree but thanks");
        Comment comment6 = new Comment("JuFran560", "Excellent list");
        Comment comment11 = new Comment("GamerMike", "Loved the recommendations");
        video3.AddComment(comment4);
        video3.AddComment(comment5);
        video3.AddComment(comment6);
        video3.AddComment(comment11);

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        foreach (Video video in _videos){
            string title = video._title;
            string author = video._author;
            int length = video._length;
            int number = video2.GetNumberOfComments(video);    
            Console.WriteLine($"Title: {title}, Author: {author},Length: {length} seconds, Comments: {number}");
            foreach (Comment comment in video._comments){
                string name = comment.GetName();
                string text = comment.GetText();
                Console.WriteLine($"{name}: {text}");
            }
            Console.WriteLine();

        }
  
    }
}