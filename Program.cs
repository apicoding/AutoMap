using System.Collections.Generic;
using AutoMapper;
using AutoMapper.Configuration;

namespace MappingPrj
{
    public class Program
    {
        public static void Main()
        {
            var props = new Props();

            var cfg = new MapperConfigurationExpression();
            var count = cfg.Mappers.Count;
            var test = cfg.Mappers[26];

            cfg.CreateMap<Item, Dictionary<string, object>>();

            //cfg.CreateMap<Props, Dictionary<string, object>>().ReverseMap(); // IMappingExpression

            var config = new MapperConfiguration(cfg);
            var execPlan1 = config.BuildExecutionPlan(typeof(Props), typeof(Dictionary<string, object>));
            var execPlan2 = config.BuildExecutionPlan(typeof(Item), typeof(Dictionary<string, object>));
            var mapper = new Mapper(config);

            var obj = mapper.Map<Props, Dictionary<string, object>>(props);
        }
    }
}
