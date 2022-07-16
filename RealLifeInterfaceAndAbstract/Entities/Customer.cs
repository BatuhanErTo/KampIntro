using RealLifeInterfaceAndAbstract.Abstract;
namespace RealLifeInterfaceAndAbstract.Entities // Note: actual namespace depends on the project name.
{
        internal class Customer : IEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string NationalityId { get; set; }
        }   
}