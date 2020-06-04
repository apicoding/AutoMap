using System.Collections.Generic;
using AutoMapper;
using AutoMapper.Configuration;

namespace AutoMap
{
    public class Program
    {
        public static void Main()
        {
            Props2DictMappingTest();
            PersonMappingTest();
        }


        public static void Props2DictMappingTest()
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

            var dict = mapper.Map<Props, Dictionary<string, object>>(props);
        }


        public static void PersonMappingTest()
        {
            var cfg = new MapperConfigurationExpression();

            cfg.CreateMap<PersonDTO, Person>();
            cfg.CreateMap<AddressDTO, Address>(); // nested mapping

            var config = new MapperConfiguration(cfg);
            var execPlan = config.BuildExecutionPlan(typeof(PersonDTO), typeof(Person));
            var mapper = new Mapper(config);

            var personDto = new PersonDTO();
            var person = mapper.Map<PersonDTO, Person>(personDto);
        }
    }
}
