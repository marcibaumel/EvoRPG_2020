using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace EvoRPGDemo.Classes.Items
{
    class Item
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public BitmapImage Image { get; set; }

        public Item(string name, double weight, int level, string description, BitmapImage image)
        {
            Name = name;
            Weight = weight;
            Description = description;
            Level = level;
            Image = image;
        }
        public override string ToString()
        {
            return $"{Name}, {Weight} kg, level: {Level}\n{Description}";
        }
    }
}
