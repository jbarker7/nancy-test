using System.Collections.Generic;
using System.Linq;
using Nancy;

namespace NancyApplication
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hello World. This is pretty cool!");
            Get("/test/{name}", args => {
                var list = new List<Person>();
                list.Add(new Person() { Name = args.name });
                list.Add(new Person() { Name = "Billy Bob" });
                list.Add(new Person() { Name = "James Earl Jones" });
                return Response.AsJson(list.Where(p => p.Name.StartsWith("James")));
            });
        }
    }

    public class TestModule : NancyModule
    {
        public TestModule()
        {
            Get("/no", args => {
                return "Test";
            });
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
