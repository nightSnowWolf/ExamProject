using CatAlog.Db.Models.DtoModels.VideoModels;
using CatAlog.Db.Repositories;
using CatAlog.GUI.Infrastructure.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CatAlog.GUI.ViewModels
{
    public class AudioInfoFillingPageViewModel : ModelBase
    {
        private AudioInfoRepository _repository;

        private ObservableCollection<AudioInfoDto> _audioInfo;

        private List<string> _audioFormat;

        private List<string> _channel;

        private float _frequency;

        private List<string> _language;

        private List<string> _author;

		public ObservableCollection<AudioInfoDto> AudioInfo
        {
			get => _audioInfo; 
			set => _audioInfo = value; 
		}

        public AudioInfoDto SelectedRecord { get; set; }

        public List<string> AudioFormat
        {
            get => _audioFormat; 
            set => _audioFormat = value; 
        }

        public List<string> Channel
        {
            get => _channel; 
            set => _channel = value; 
        }

        public float Frequency
        {
            get => _frequency; 
            set => _frequency = value; 
        }

        public List<string> Language
        {
            get => _language; 
            set => _language = value; 
        }

        public List<string> Author
        {
            get => _author; 
            set => _author = value; 
        }

        public AudioInfoFillingPageViewModel(ObservableCollection<AudioInfoDto> audioInfo)
		{
            _repository = new AudioInfoRepository();
            _audioInfo = audioInfo;
            _audioFormat = _repository.GetFormats();
            _channel = _repository.GetChanels();
            _language = _repository.GetLanguages();
            _author = _repository.GetAuthors();
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
                        AudioInfoDto item = new AudioInfoDto();
                        _audioInfo.Add(item);
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
                        _audioInfo.Remove(SelectedRecord);
                    },
                        (obj) => SelectedRecord != null)
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
                        _audioInfo.Clear();
                    },
                        (obj) => _audioInfo != null && _audioInfo.Count != 0)
                    );
            }
        }
    }
}
