using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class MainCarousel:IEntity
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public int Order { get; set; }
    }
}
