namespace Do;
public record Customer(int id, string name, string adress, int phon, bool isclob)
{
    public Customer() : this(0, "", "", 0, false) { }
}