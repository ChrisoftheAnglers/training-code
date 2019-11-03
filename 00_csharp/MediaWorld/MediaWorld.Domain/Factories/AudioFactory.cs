using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;
namespace MediaWorld.Domain.Factories
{
    public class AudioFactory : IFactory
    {
        public AMedia Create<T>() where T : AMedia, new()
        {
          return new T();
          // switch(type)
          // {
          //   case "audible":
          //     return new Audible();
          //   case "song":
          //     return new Song();
          //   default:
          //     return null;
          // }
        }
    }
}