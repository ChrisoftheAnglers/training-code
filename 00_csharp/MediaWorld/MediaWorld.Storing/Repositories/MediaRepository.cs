using System.Collections.Generic;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Factories;
using MediaWorld.Domain.Models;
using MediaWorld.Storing.Connectors;

namespace MediaWorld.Storing.Repositories
{
    public class MediaRepository
    {
        private List<AMedia> _mediaLibrary;
        public List<AMedia> MediaLibrary {
          get
          {
            return _mediaLibrary;
          }
        }
        public MediaRepository()
        {
          Initialize();
        }

        private List<AMedia> Initialize()
        {
          // var audioFactory = new AudioFactory();
          // var videoFactory = new VideoFactory();
          if (_mediaLibrary == null)
          {
            _mediaLibrary = new List<AMedia>();
            _mediaLibrary.AddRange(new FileSystemConnector().ReadXml());
            // _mediaLibrary.AddRange(new AMedia[]
            // {
            //   audioFactory.Create<Audible>(),
            //   audioFactory.Create<Song>(),
            //   videoFactory.Create<Movie>(),
            //   videoFactory.Create<Photo>()
            // });
          }
          return _mediaLibrary;
        }
        public void Add(AMedia media)
        {
          _mediaLibrary.Add(media);
        }
        
        public void Update(AMedia media)
        {
          var mi = _mediaLibrary.Find(m => m.title == media.title);
          mi = media;
          Save();
        }
        public void Save()
        {
          var fs = new FileSystemConnector();
          fs.WriteXml(_mediaLibrary);
        }
    }
}