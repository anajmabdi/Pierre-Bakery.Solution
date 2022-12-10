namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryAmount { get; set; }


    public Pastry(int pastryAmount)
    {
      PastryAmount = pastryAmount;
    }
    
    public int PastryTotal() {
      int price = (((PastryAmount - (PastryAmount % 3)) / 3) * 5) + ((PastryAmount % 3) * 2);
      return price;
    }
  }
}