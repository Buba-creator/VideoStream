using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using MediaManager;
using VideoStream.Commands;
using VideoStream.Models;
using Xamarin.Forms;

namespace VideoStream.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public PlayVideo PlayVideoCommand { get; set; }
        public Tab1Selector Tab1Selector { get; set; }
        public Tab2Selector Tab2Selector { get; set; }
        public Minimize MinimizeCommand { get; set; }
        public Maximize MaximizeCommand { get; set; }
        public RefreshHistoryCommand RefreshCommand { get; set; }
        public TabSelect tabSelect;
        public MainPageViewModel()
        {
            this.PlayVideoCommand = new PlayVideo(this);
            this.Tab1Selector = new Tab1Selector(this);
            this.Tab2Selector = new Tab2Selector(this);
            this.MinimizeCommand = new Minimize(this);
            this.MaximizeCommand = new Maximize(this);
            this.RefreshCommand = new RefreshHistoryCommand(this);
            this.IsSecondShowing = true;
            this.IsMaximized = true;
            AddHistory();
        }

        public List<Video> List1 { get; set; } = new List<Video>
        {
          new Video
          {
              Title="Video Title",
              NumberOfView="15M Views",
              User="Someone",
              WhenViewed="3 days ago",
              VideoLink="http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4",
              VideoThumbNailLink="RandomThumbnail1.jpg"
          },
            new Video
          {
              Title="Video Title",
              NumberOfView="15M Views",
              User="Someone",
              WhenViewed="3 days ago",
              VideoLink="http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4",
              VideoThumbNailLink="RandomThumbnail3.jpg"
          },
            new Video
          {
              Title="Video Title",
              NumberOfView="15M Views",
              User="Someone",
              WhenViewed="3 days ago",
              VideoLink="http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerFun.mp4",
              VideoThumbNailLink="RandomThumbnail3.jpg"
          },
             new Video
          {
              Title="Video Title",
              NumberOfView="15M Views",
              User="Someone",
              WhenViewed="3 days ago",
              VideoLink="http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerJoyrides.mp4",
              VideoThumbNailLink="RandomThumbnail3.jpg"
          },
             new Video
          {
              Title="Video Title",
              NumberOfView="15M Views",
              User="Someone",
              WhenViewed="3 days ago",
              VideoLink="http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/TearsOfSteel.mp4",
              VideoThumbNailLink="RandomThumbnail1.jpg"
          },
            new Video
          {
              Title="Video Title",
              NumberOfView="15M Views",
              User="Someone",
              WhenViewed="3 days ago",
              VideoLink="http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/VolkswagenGTIReview.mp4",
              VideoThumbNailLink="RandomThumbnail1.jpg"
          }
        };
        public List<Video> History { get; set; }
        public List<Video> List2 { get; set; } = new List<Video>
        {
          new Video
          {
              Title="Video Title",
              NumberOfView="15M Views",
              User="Someone",
              WhenViewed="3 days ago",
              VideoLink="http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4",
              VideoThumbNailLink="RandomThumbnail1.jpg"
          },
            new Video
          {
              Title="Video Title",
              NumberOfView="15M Views",
              User="Someone",
              WhenViewed="3 days ago",
              VideoLink="http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4",
              VideoThumbNailLink="RandomThumbnail1.jpg"
          },
            new Video
          {
              Title="Video Title",
              NumberOfView="15M Views",
              User="Someone",
              WhenViewed="3 days ago",
              VideoLink="http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4",
              VideoThumbNailLink="RandomThumbnail1.jpg"
          },
             new Video
          {
              Title="Video Title",
              NumberOfView="15M Views",
              User="Someone",
              WhenViewed="3 days ago",
              VideoLink="http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4",
              VideoThumbNailLink="RandomThumbnail1.jpg"
          },
             new Video
          {
              Title="Video Title",
              NumberOfView="15M Views",
              User="Someone",
              WhenViewed="3 days ago",
              VideoLink="http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4",
              VideoThumbNailLink="RandomThumbnail1.jpg"
          },
            new Video
          {
              Title="Video Title",
              NumberOfView="15M Views",
              User="Someone",
              WhenViewed="3 days ago",
              VideoLink="http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4",
              VideoThumbNailLink="RandomThumbnail1.jpg"
          }
        };

        private bool _isPlaying;
        public bool IsPlaying
        {
            get { return _isPlaying; }
            set { SetProperty(ref _isPlaying, value); }
        }

        private bool _isSecondShowing;
        public bool IsSecondShowing
        {
            get { return _isSecondShowing; }
            set { SetProperty(ref _isSecondShowing, value); }
        }
        private bool _isFirstShowing;
        public bool IsFirstShowing
        {
            get { return _isFirstShowing; }
            set { SetProperty(ref _isFirstShowing, value); }
        }
        private bool _isMultiTasking = true;
        public bool IsMultiTasking
        {
            get { return _isMultiTasking; }
            set { SetProperty(ref _isMultiTasking, value); }
        }
        private bool _isMaximized;
        public bool IsMaximized
        {
            get { return _isMaximized; }
            set { SetProperty(ref _isMaximized, value); }
        }

        private Video _currentVideo;
        public Video CurrentVideo
        {
            get { return _currentVideo; }
            set { SetProperty(ref _currentVideo, value); }
        }

        private int _playerYTranslation;
        public int PlayerYTranslation
        {
            get { return _playerYTranslation; }
            set { SetProperty(ref _playerYTranslation, value); }
        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set { SetProperty(ref _isRefreshing, value); }

        }
        private async Task AddHistory()
        {
            this.History = await App.Database.GetAllVideos();
        }
    }
}
