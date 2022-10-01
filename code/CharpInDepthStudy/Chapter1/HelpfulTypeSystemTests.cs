using System.Collections;
using Shouldly;

namespace CharpInDepthStudy.Chapter1;

public class HelpfulTypeSystemTests
{
    [Fact]
    public void Casting_happens_when_IEnumerable_holds_object()
    {
        var objects = new List<object> { new Book("CsharpInDepth")};
        var book = (Book)objects.First();
        
        book.ShouldBeOfType<Book>();
    }
}