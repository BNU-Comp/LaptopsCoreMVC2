using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopsCoreMVC.Models
{
    public class Laptop
    {
        public int LaptopID { get; set; }

        [Required, StringLength(20), DisplayName("Price (£)")]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required, Range(2,32), DisplayName("Ram Size GB")]
        public int RamSize { get; set; }

        [Required, Range(500,2000), DisplayName("HDD Size (GB)")]
        public int MemorySize { get; set; }

        [Required, StringLength(20), DisplayName("Laptop Dimensions (inches)")]
        public string LaptopDimensions { get; set; }

        [Required, StringLength(20), DisplayName("Operating System")]
        [DataType(DataType.Text)]
        public string OperatingSystem { get; set; }

        [Required, StringLength(20), DisplayName("Model")]
        [DataType(DataType.Text)]
        public string Model { get; set; }

        [Required, StringLength(20), DisplayName("Resolution (Pixels)")]
        public string Resolution { get; set; }

        [Required, StringLength(20), DisplayName("Processor")]
        [DataType(DataType.Text)]
        public string Processor { get; set; }

        [Required, StringLength(20), DisplayName("Battery (hr)")]
        public int BatteryLife { get; set; }

        [Required, StringLength(20), DisplayName("Colour")]
        public Colours Colour { get; set; }
        
        [Required, StringLength(2000), DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [StringLength(120), DisplayName("Picture URL")]
        [DataType(DataType.ImageUrl)]
        public string Picture { get; set; }


    }

    public enum Colours 
    {
        Silver,
        Gold, 
        Grey,
        Black,
        red
    }
}
