namespace VocabCard.Models;
public class Card
{
    public int CardId { get; set; }
    public string Word { get; set; }
    public string Example { get; set; }
    public string Mean { get; set; }
    public DateTime UploadTime { get; set; }
}