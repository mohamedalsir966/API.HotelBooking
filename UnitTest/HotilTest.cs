using API.HotelBooking.Controllers;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Service.HotelFeatures.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Service.HotelFeatures.Queries.GetAllHotelQuery;
using static Service.HotelFeatures.Queries.GetHotelByIdQuery;

namespace UnitTest
{
   public class HotilTest
   {
        //private readonly GetAllHotelQueryHandler handler ;

        [Fact]
        public async void Get_WhenCalled_ReturnsOkResult()
        {
            using var context = new ApplicationDbContext();
            var okResult = new GetAllHotelQueryHandler(context);
            var Ogrtallhotel = new GetAllHotelQuery();
            var ant = await okResult.Handle(Ogrtallhotel, CancellationToken.None);
            // Assert
            var items1 = Assert.IsType<List<Hotel>>(ant).ToList();
            Assert.Equal(1, items1.Count);           
        }
        //[Fact]
        //public async void GetById_UnknownGuidPassed_ReturnsNullResult()
        //{
        //    // Act
        //    using var context = new ApplicationDbContext();
        //    var okResult = new GetHotelByIdQueryHandler(context);
        //    var obj = new GetHotelByIdQuery();
        //     var notFoundResult = await okResult.Handle(obj, CancellationToken.None);

        //    // Assert
        //    Assert.IsType<Hotel>(notFoundResult.Name=null);
        //}

    }
    
}
