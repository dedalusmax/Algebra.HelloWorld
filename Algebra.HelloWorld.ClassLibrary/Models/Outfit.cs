using Algebra.HelloWorld.ClassLibrary.Interfaces;
using System.Collections.Generic;

namespace Algebra.HelloWorld.ClassLibrary.Models
{
    public class Outfit
    {
        List<IArticle> Parts { get; set; }

        public Outfit()
        {
            Parts = new List<IArticle>();
        }

        public void AddPart(IArticle part)
        {
            Parts.Add(part);
        }

        public void CancelOrder()
        { 
            Parts.Clear();
        }
    }
}
