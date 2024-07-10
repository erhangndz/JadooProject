using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Queries;
using JadooProject.Features.CQRS.Results;

namespace JadooProject.Features.CQRS.Handlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly IRepository<Destination> _repository;

        public GetDestinationByIdQueryHandler(IRepository<Destination> repository)
        {
            _repository = repository;
        }


        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var value = _repository.GetById(query.Id);
            
            GetDestinationByIdQueryResult result = new GetDestinationByIdQueryResult();

            result.Duration = value.Duration;
            result.DestinationId = value.DestinationId;
            result.ImageUrl = value.ImageUrl;
            result.City = value.City;
            result.Price= value.Price;
            return result;
         
        }

    }
}
