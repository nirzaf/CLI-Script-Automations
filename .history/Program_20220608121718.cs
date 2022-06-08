using System.ComponentModel.DataAnnotations;
using CliWrap;
using CliWrap.Buffered;

namespace CLI_Script_Automations
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var v1 = new Vehicle();
            v1.VehicleNumber = "KA-01-AA-1234";
            v1.VehicleName = "Toyota";
            v1.VehicleType = "Car";
            v1.VehicleColor = "Red";
            v1.VehiclePrice = 100000;
            
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(v1);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.VehicleNumber);
                Console.WriteLine(vehicle.VehicleName);
                Console.WriteLine(vehicle.VehicleType);
                Console.WriteLine(vehicle.VehicleColor);
                Console.WriteLine(vehicle.VehiclePrice);
            }

            Console.WriteLine("---------------------------------------------");

            var v2 = new Vehicle();
            v2.VehicleNumber = "KA-01-AA-1235";
            v2.VehicleName = "Corolla";
            v2.VehicleType = "Van";
            v2.VehicleColor = "Black";
            v2.VehiclePrice = 250000;

            vehicles.Add(v2);


            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.VehicleNumber);
                Console.WriteLine(vehicle.VehicleName);
                Console.WriteLine(vehicle.VehicleType);
                Console.WriteLine(vehicle.VehicleColor);
                Console.WriteLine(vehicle.VehiclePrice);
            }

            var v = vehicles.Where()
            // ChildBang cb = new()
            // {
            //     Cost = 33,
            //     Amount = 12
            // };
            // Console.WriteLine(cb.Helper());

            //Bang bang = new()
            //{
            //    Name = "Fazrin",
            //    Description = "Description",
            //    Amount = 6,
            //    Cost = 15
            //};
            //Console.WriteLine(bang.Helper());
            // var currency = new Currency(34,34);
            // Console.WriteLine(currency.ToString());
            // Console.WriteLine(currency);

            // var resp = Math.Log(64, 2);
            // Console.WriteLine(resp);

            // var cliResponse = await Cli.Wrap("dotnet")
            //     .WithArguments( new[] {"--help" })
            //     .ExecuteBufferedAsync();
            // Console.WriteLine(cliResponse.StandardOutput);
            // Console.WriteLine(cliResponse.StandardError);

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
            return $"{VehicleNumber} {VehicleName} {VehicleType} {VehicleColor} {VehiclePrice}";
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