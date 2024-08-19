using AutoMapper;
using AutoMapper.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Mapper.AutoMapper
{
    public class Mapper : Application.Interfaces.AutoMapper.IMapper
    {
        public static List<TypePair> typePairs = new List<TypePair>();
        private IMapper _mapper;
        public TDestination Map<TDestination, TSource>(TSource source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);
            return _mapper.Map<TSource, TDestination>(source);
        }

        public IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);
            return _mapper.Map<IList<TSource>, IList<TDestination>>(source);
        }

        public TDestination Map<TDestination>(object source, string? ignore = null)
        {
            Config<TDestination, object>(5, ignore);
            return _mapper.Map<TDestination>(source);
        }

        public IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null)
        {
            Config<TDestination, IList<object>>(5, ignore);
            return _mapper.Map<IList<TDestination>>(source);
        }
        protected void Config<TDestination, TSource>(int depth = 5, string? ignore = null)
        {
            var typePair = new TypePair(typeof(TSource), typeof(TDestination));
            if (typePairs.Any(a => a.DestinationType == typePair.DestinationType && a.SourceType == typePair.SourceType) && ignore != null)
            {
                return;
            }
            typePairs.Add(typePair);

            var config = new MapperConfiguration(configuration =>
            {
                foreach (var item in typePairs)
                {
                    if (ignore != null)
                    {
                        configuration.CreateMap(item.SourceType, item.DestinationType)
                            .MaxDepth(depth).ForMember(ignore, x => x.Ignore()).ReverseMap();
                    }
                    else
                    {
                        configuration.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ReverseMap();
                    }
                }
            });
            _mapper = config.CreateMapper();
        }
    }
}
