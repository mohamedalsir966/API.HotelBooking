using Domain.Entities;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Service.Features.CustomerFeatures.Queries
{
    public class GetHotelByIdQuery : IRequest<Hotel>
    {
        public Guid hotelId { get; set; }

        public class Response : BaseResponse
        {

        }
        public class GetHotelByIdQueryHandler : IRequestHandler<GetHotelByIdQuery, Hotel>
        {
            private readonly IApplicationDbContext _context;
            public GetHotelByIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<Hotel> Handle(GetHotelByIdQuery request, CancellationToken cancellationToken)
            {
                var hotel =  _context.Hotel.Where(a => a.Id == request.hotelId).FirstOrDefault();
                if (hotel == null) return null;
                return hotel;
            }
        }
    }
}
