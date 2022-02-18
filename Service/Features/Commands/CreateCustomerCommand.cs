using MediatR;
using Domain.Entities;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Features.Commands
{
    //public class CreateCustomerCommand : IRequest<int>
    //{
    //    public string CustomerName { get; set; }
    //    public string ContactName { get; set; }
    //    public string ContactTitle { get; set; }
    //    public string Address { get; set; }
    //    public string City { get; set; }
    //    public string Region { get; set; }
    //    public string PostalCode { get; set; }
    //    public string Country { get; set; }
    //    public string Phone { get; set; }
    //    public string Fax { get; set; }
    //    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, int>
    //    {
    //        private readonly IApplicationDbContext _context;
    //        public CreateCustomerCommandHandler(IApplicationDbContext context)
    //        {
    //            _context = context;
    //        }
    //        public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    //        {
    //            var customer = new Customer
    //            {
    //                CustomerName = request.CustomerName,
    //                ContactName = request.ContactName
    //            };

    //           // _context.Customers.Add(customer);
    //            await _context.SaveChangesAsync();
    //            //return customer.Id;
    //            return 1;
    //        }
    //    }
    //}
}
