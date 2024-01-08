using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeviyImporter.Model
{
    public class Part
    {
        [Key]
        //主キー
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Model { get; set; }
        public string? Material { get; set; }
        public string? SurfaceProcessing { get; set; }
        public string? HeatTreatment { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }


    }
}
