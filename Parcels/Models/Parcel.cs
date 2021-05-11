namespace Parcels.Models
{
  public class Parcel
  {
    private int _volume { get; set; }
    private int _weight { get; set; }

    private double _price { get; set; }
    public Parcel()
    {

    }

    public void SetVolumeWith(int length, int width, int height)
    {
      _volume = length * width * height;
    }

    public void SetWeight(int weight)
    {
      _weight = weight;
    }

    public void GetPrice()
    {
      _price = PricePerPound() + PricePerVolume();
    }

    private double PricePerPound()
    {
      return _weight / 2;
    }

    private double PricePerVolume()
    {
      return _volume * 0.15;

    }
  }

}
