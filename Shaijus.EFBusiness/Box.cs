using System;

namespace Shaijus.EFBusiness
{
    public class Box
    {
        public int Id { get; set; }

        public int Length { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
