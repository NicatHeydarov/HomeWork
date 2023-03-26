

namespace _26._03._2023.core
{
    internal class Book : IEntity
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string PageCount { get; set; }
        public bool IsDeleted { get; set; }

        public Book(string name, string authorName, string pageCount, bool isDeleted, string Id) 

        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            IsDeleted = isDeleted;
        }
        
    }

}
