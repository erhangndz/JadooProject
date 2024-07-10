namespace JadooProject.Features.CQRS.Queries
{
    public class GetDestinationByIdQuery
    {

        public int Id { get; set; }

        public GetDestinationByIdQuery(int id)
        {
            Id = id;
        }
    }
}
