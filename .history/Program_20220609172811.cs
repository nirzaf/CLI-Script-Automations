using System.ComponentModel.DataAnnotations;
using CliWrap;
using CliWrap.Buffered;

namespace CLI_Script_Automations
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var result = await Cli.Wrap("dotnet")
                        .WithArguments("--version")
                        .ExecuteBufferedAsync();

            var version = result.StandardOutput.Trim();
            Print($"dotnet version: {version}");
                
            var pal = GetPal();
            Print(pal.ToString());
            Read();
        }
        static void Read() => Console.ReadLine();
        static bool GetPal() => Demo.IsPalindrome("ACCA");
        static void Print(string? input) => Console.WriteLine(input);

        static bool IsWordPalindrome(string word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            return word.Length < 2 || IsPalindrome(0, word.Length - 1);

            bool IsPalindrome(int lo, int hi)
            {
                if (lo >= hi)
                    return true;

                return char.ToUpperInvariant(word[lo]) == char.ToUpperInvariant(word[hi]) && IsPalindrome(lo + 1, hi - 1);
            }
        }
    }

    public abstract record Bang
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public long Amount { get; set; }
        public long Cost { get; set; }
        public virtual long Helper()
        {
            return Amount * Cost;
        }
    }

    public struct Vehicle
    {
        [Key]
        public string VehicleNumber { get; set; }
        public string? VehicleName { get; set; }
        public string? VehicleType { get; set; }
        public string? VehicleColor { get; set; }
        public long VehiclePrice { get; set; }

        public override string ToString()
        {
            return $"Vehicle Number: {VehicleNumber}, Vehicle Name: {VehicleName} Vehicle Type: {VehicleType} Vehicle Color: {VehicleColor} Vehicle Price: {VehiclePrice}";
        }
    }


    public record ChildBang : Bang
    {
        public long Dollars { get; init; }

        public override long Helper()
        {
            return Amount * Amount * Cost * Cost;
        }
    }

    struct Currency
    {
         public uint Dollars;
         public ushort Cents;
         public Currency(uint dollars, ushort cents)
         {
             Dollars = dollars;
             Cents = cents;
         }
         public override string ToString() => $"${Dollars}.{Cents,2:00}";
         public static string GetCurrencyUnit() => "Dollar";
         public static explicit operator Currency (float value)
         {
             checked
             {
                uint dollars = Convert.ToUInt16(value);
                ushort cents = (ushort)((ushort)value - ((ushort)dollars *100));
                return new Currency(dollars, cents);
             }
         }

         public static implicit operator float (Currency value) => value.Dollars + (value.Cents / 100.0f);
         public static implicit operator Currency (uint value) => new(value, 0);
         public static implicit operator uint (Currency value) => value.Dollars;
    }
}