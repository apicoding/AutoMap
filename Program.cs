using System.Collections.Generic;
using AutoMapper;

namespace Mapper
{
    struct Item
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Dictionary<string, object>, Class2Dict>().ForMember(a => a.MyItem, b => b.MapFrom(d => d)));
            //var userPlan = defConfig.BuildExecutionPlan(typeof(Class2Dict), typeof(Dictionary<string, object>));

            var mapper = config.CreateMapper();
            var class2dict = new Class2Dict();

            class2dict.Foo = "123";
            class2dict.Bar = 456;
            class2dict.MyItem = new Item { Name = "Name", Value = "Value" };

            var obj1 = mapper.Map<Class2Dict, Dictionary<string, object>>(class2dict);
            var obj = mapper.Map<Dictionary<string, object>>(class2dict);
        }
    }


    class Class2Dict
    {
        public string Foo { get; set; }
        public int Bar { get; set; }
        public Item MyItem { get; set; }
    }



}
