namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadAmount { get; set; }


    public Bread(int breadAmount)
    {
      BreadAmount = breadAmount;
    }
    public int BreadTotal()
    {
      if (BreadAmount <= 2)
      {
        int price = BreadAmount * 5;
        return price;
      }
      else
      {
        return 3;
      }
    }
  }
}