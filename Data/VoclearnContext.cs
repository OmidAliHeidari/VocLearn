using Microsoft.EntityFrameworkCore;
using VocabCard.Models;

namespace VocabCard.Data;
public class VoclearnContext : DbContext
{
    public VoclearnContext(DbContextOptions<VoclearnContext> options) : base(options)
    {
    }

    public DbSet<Card> Card { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Card>().HasData(
            new Card { CardId = 1, Word = "Serendipity", Example = "Finding the keys was pure serendipity.", Mean = "An unexpected pleasant discovery.", UploadTime = new DateTime(2023, 10, 1) },
            new Card { CardId = 2, Word = "Ephemeral", Example = "The ephemeral beauty of autumn leaves.", Mean = "Lasting for a very short time.", UploadTime = new DateTime(2023, 9, 25) },
            new Card { CardId = 3, Word = "Petrichor", Example = "The petrichor after the rain was refreshing.", Mean = "The pleasant smell after rain.", UploadTime = new DateTime(2023, 9, 18) },
            new Card { CardId = 4, Word = "Euphoria", Example = "Winning the game filled him with euphoria.", Mean = "A feeling of intense excitement and happiness.", UploadTime = new DateTime(2023, 9, 10) },
            new Card { CardId = 5, Word = "Melancholy", Example = "He spoke with a hint of melancholy in his voice.", Mean = "A deep, long-lasting sadness.", UploadTime = new DateTime(2023, 9, 5) },
            new Card { CardId = 6, Word = "Ineffable", Example = "The beauty of the sunset was ineffable.", Mean = "Too great or extreme to be expressed in words.", UploadTime = new DateTime(2023, 8, 30) },
            new Card { CardId = 7, Word = "Limerence", Example = "She experienced limerence for the first time.", Mean = "The state of being infatuated or obsessed with another person.", UploadTime = new DateTime(2023, 8, 25) },
            new Card { CardId = 8, Word = "Quintessential", Example = "He was the quintessential gentleman.", Mean = "Representing the most perfect or typical example of something.", UploadTime = new DateTime(2023, 8, 18) },
            new Card { CardId = 9, Word = "Solitude", Example = "He enjoyed the solitude of the mountains.", Mean = "The state of being alone without feeling lonely.", UploadTime = new DateTime(2023, 8, 10) },
            new Card { CardId = 10, Word = "Labyrinth", Example = "Navigating the city was like moving through a labyrinth.", Mean = "A complex maze.", UploadTime = new DateTime(2023, 8, 1) }
        );
    }
}