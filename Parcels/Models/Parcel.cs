using System.Collections.Generic;
using System;

namespace Parcels.Models
{
  public class Parcel
  {
    private int _volume { get; set; }
    private int _weight { get; set; }

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

    public double CostToShip()
    {
      return PricePerPound() + PriceMultiplierPerVolume();
    }

    private double PricePerPound()
    {
      return _weight / 2;
    }

    private double PriceMultiplierPerVolume()
    {
      int volume = _volume;
      switch (volume)
      {
        case >= 1000:
          return 1.50;
        case >= 850:
          return 1.25;
        case >= 700:
          return 1.00;
        case >= 500:
          return 0.75;
        default:
          return 0.50;

      }

    }
  }

}
