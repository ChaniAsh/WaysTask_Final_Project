using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class Position_Dto
    {
        public int idPosition { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Radius { get; set; }

        //public virtual Position Position { get; set; }
        //public Position DtoToDal()
        //{
        //    var config = new MapperConfiguration(cfg => cfg.CreateMap<Position_Dto, Position>());
        //    var mapper = new Mapper(config);
        //    return mapper.Map<Position>(this);
        //}
        //public static Position_Dto DaltoDto(Position transport)
        //{
        //    var config = new MapperConfiguration(cfg => cfg.CreateMap<Position_Dto, Position>());
        //    var mapper = new Mapper(config);
        //    return mapper.Map<Position_Dto>(transport);
        //}
    }
}
