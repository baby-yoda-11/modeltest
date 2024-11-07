using AutoMapper;
using modeltest.Models;
using Newtonsoft.Json.Linq;

namespace modeltest.Profiles
{
    public class mapProfiles : Profile
    {
        public mapProfiles()
        {
            CreateMap<JObject, connectionModel>();
        }
    }
}
