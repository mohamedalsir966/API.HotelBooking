using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Features.CustomerFeatures.Queries
{
    //public class GetAllCustomerQuery : IRequest<IEnumerable<Customer>>
    //{
    //    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, IEnumerable<Customer>>
    //    {
    //        private readonly IApplicationDbContext _context;
    //        public GetAllCustomerQueryHandler(IApplicationDbContext context)
    //        {
    //            _context = context;
    //        }
    //        public async Task<IEnumerable<Customer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
    //        {
    //            var customerList = await _context.Customers.ToListAsync(cancellationToken: cancellationToken);
    //            if (customerList == null)
    //            {
    //                return null;
    //            }
    //            return customerList.AsReadOnly();
    //        }
    //    }
    //}
}
