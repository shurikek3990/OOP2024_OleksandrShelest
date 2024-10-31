using OOPLab2.Constructions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Constructions
{
    internal class Construction
    {
        public Construction()
        {
            Height = 70;
            Width = 133;
            Entrances = 6;
            HumanCapacity = 28;
            BuildMaterial = "Asbestos";
        }

        public Construction(CreateConstructionDTO construction)
        {
            Height = construction.Height;
            Width = construction.Width;
            Entrances = construction.Entrances;
            HumanCapacity = 28;
            BuildMaterial = construction.BuildMaterial;
        }

        public Construction(float height, float width, int entrances, int humanCapacity, string buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial
        {
            get
            {
                return _buildMaterial;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Value cannot be Null");
                }
                _buildMaterial = value;
            }
        }
        private string _buildMaterial { get; set; }
    }
}
