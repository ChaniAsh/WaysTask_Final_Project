using AutoMapper;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class Customers_Counts_Dto
    {
        public string id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string countNumber { get; set; }
        public string balance { get; set; }
        public string negativeBalance { get; set; }

        public Customers_Counts DtoToDal()
        {
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<Customers_Counts_Dto, Customers_Counts>()
                );
            var mapper = new Mapper(config);
            return mapper.Map<Customers_Counts>(this);
        }
        public static Customers_Counts_Dto DalToDto(Customers_Counts c)
        {
            var config = new MapperConfiguration(cfg =>
                     cfg.CreateMap<Customers_Counts, Customers_Counts_Dto>()vc 
                 );
            var mapper = new Mapper(config);
            return mapper.Map<Customers_Counts_Dto>(c);

        }
    }
}
