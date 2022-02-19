using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public static class HotelServiceFake
    {
       
        public static List<Hotel> MockSamples() => new()
        {
            new Hotel()
            {
                Id= new Guid("a50e83e0-f374-48ee-ac02-c95d2dfe6311"),
                Name = "Hotel2",
                //PhoneNumber = "0585199391",
                //Email = "email@gmail.com",
                //Address = "Dubai",
                //Description = "good hotel",
            },
            new Hotel()
            {
                Name = "Hotel",
                //PhoneNumber = "0584875391",
                //Email = "m@gmail.com",
                //Address = "address",
                //Description = " hotel",
            }
        };
        
    }
}
