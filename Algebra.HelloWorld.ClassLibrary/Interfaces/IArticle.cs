using Algebra.HelloWorld.ClassLibrary.Enumerations;

namespace Algebra.HelloWorld.ClassLibrary.Interfaces
{
    public interface IArticle
    {
        string Name { get; }

        string Description { get; }

        ClothType ClothType { get; }
    }
}
