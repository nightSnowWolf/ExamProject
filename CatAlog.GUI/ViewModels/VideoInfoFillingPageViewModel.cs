using CatAlog.Db.Models.DtoModels.VideoModels;
using CatAlog.Db.Repositories;
using CatAlog.GUI.Infrastructure.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CatAlog.GUI.ViewModels
{
    public class VideoInfoFillingPageViewModel : ModelBase
    {
		private ObservableCollection<VideoInfoDto> _videoInfo;

		private VideoInfoRepository _repository;

        private VideoInfoDto _selectedRecord;

        private List<string> _quality;

        private List<string> _relation;

        private List<int> _resolutionWidth;

        private List<int> _resolutionHeigth;

        private List<string> _videoFormats;

        private int _bitrate;

        private float _frameRate;

        public ObservableCollection<VideoInfoDto> VideoInfo
        {
            get => _videoInfo; 
            set => _videoInfo = value; 
        }

        public VideoInfoDto SelectedRecord
        {
            get => _selectedRecord; 
            set => _selectedRecord = value; 
        }

        public List<string> Quality
        {
            get => _quality; 
            set => _quality = value; 
        }

        public List<string> Relation
        {
            get => _relation; 
            set => _relation = value; 
        }

        public List<int> ResolutionWidth
        {
            get => _resolutionWidth; 
            set => _resolutionWidth = value; 
        }

        public List<int> ResolutionHeigth
        {
            get => _resolutionHeigth; 
            set => _resolutionHeigth = value; 
        }

        public List<string> VideoFormats
        {
            get => _videoFormats; 
            set => _videoFormats = value; 
        }

        public int Bitrate
        {
            get => _bitrate; 
            set => _bitrate = value; 
        }

        public float FrameRate
        {
            get => _frameRate; 
            set => _frameRate = value; 
        }

		public VideoInfoFillingPageViewModel(ObservableCollection<VideoInfoDto> videoInfo)
		{
			_videoInfo = videoInfo;
			_repository = new VideoInfoRepository();
            _quality = _repository.GetQualityList();
            _relation = _repository.GetRelationList();
            _resolutionWidth = _repository.GetWidth();
            _resolutionHeigth = _repository.GetHeight();
            _videoFormats = _repository.GetVideoFormats();
        }

        private RellayCommand _addNewRecordCommand;

        private RellayCommand _removieCommand;

        private RellayCommand _clearCommand;

        public RellayCommand AddNewRecordCommand
        {
            get
            {
                return _addNewRecordCommand ??
                    (_addNewRecordCommand = new RellayCommand(obj =>
                    {
                        VideoInfoDto item = new VideoInfoDto();
                        _videoInfo.Add(item);
                    }));
            }
        }

        public RellayCommand RemovieCommand
        {
            get
            {
                return _removieCommand ??
                    (_removieCommand = new RellayCommand(obj =>
                    {
                        _videoInfo.Remove(_selectedRecord);
                    },
                        (obj) => _selectedRecord != null)
                    );
            }
        }

        public RellayCommand ClearCommand
        {
            get
            {
                return _clearCommand ??
                    (_clearCommand = new RellayCommand(obj =>
                    {
                        _videoInfo.Clear();
                    },
                        (obj) => _videoInfo != null && _videoInfo.Count != 0)
                    );
            }
        }
    }
}
