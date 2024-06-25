using Algebra.HelloWorld.ClassLibrary.Enumerations;
using Algebra.HelloWorld.ClassLibrary.Interfaces;

namespace Algebra.HelloWorld.ClassLibrary.Models
{
    public abstract class Article : IArticle
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ClothType ClothType { get; set; }
    }
}
