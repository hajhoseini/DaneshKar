using LibraryManagementSystem.Models.Enums;

namespace LibraryManagementSystem.Models
{
    public class Publisher
    {
        public string Name { get; set; }
        public PublisherActivityEnum publisherActivity { get; set; }
    }
}
