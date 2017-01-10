namespace ElegantFibo.Factories {
  using System;

  public sealed class Num {
    public Num(int value) {
      if (value < ushort.MinValue || value > ushort.MaxValue)
        throw new ArgumentException(
          $"Num must be between {ushort.MinValue} and {ushort.MaxValue} inclusive",
          nameof(value));

      this.Value = (ushort)value;
    }

    public ushort Value { get; }
  }
}