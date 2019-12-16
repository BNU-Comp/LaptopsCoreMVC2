using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopsCoreMVC.Models
{
    public class Laptops
    {
        public int LaptopID { get; set; }

        [Required, StringLength(20), DisplayName("Price")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [Required, StringLength(20), DisplayName("Ram Size")]
        public int RamSize { get; set; }

        [Required, StringLength(20), DisplayName("Memory Size")]
        public int MemorySize { get; set; }

        [Required, StringLength(20), DisplayName("Laptop Dimensions")]
        public int LaptopDimensions { get; set; }

        [Required, StringLength(20), DisplayName("Operating System")]
        [DataType(DataType.Text)]
        public string OperatingSystem { get; set; }

        [Required, StringLength(20), DisplayName("Model")]
        [DataType(DataType.Text)]
        public string Model { get; set; }

        [Required, StringLength(20), DisplayName("Resolution")]
        public string Resolution { get; set; }

        [Required, StringLength(20), DisplayName("Processor")]
        [DataType(DataType.Text)]
        public string Processor { get; set; }

        [Required, StringLength(20), DisplayName("Battery")]
        public int BatteryLife { get; set; }

        [Required, StringLength(20), DisplayName("Colour")]
        [DataType(DataType.Text)]
        public string colour { get; set; }
        
        [Required, StringLength(20), DisplayName("Description")]
        [DataType(DataType.Text)]
        public string Description { get; set; }
    }
}
