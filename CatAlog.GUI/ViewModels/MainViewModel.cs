using CatAlog.Db.DbContexts;
using CatAlog.Db.Extensions;
using CatAlog.Db.Models.DtoModels.VideoModels;
using CatAlog.Db.Repositories;
using CatAlog.GUI.Infrastructure.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CatAlog.GUI.ViewModels
{
    public class MainViewModel : ModelBase
    {
        private SharedDataRepository _sharedDataRepository;

        private ObservableCollection<string> _recordsType;

        private ObservableCollection<SampleDataDto> _sampleDatas;

        private SampleDataDto _selectedRecord;

        private GeneralInfoDto _generalInfo;

        private SerialInfoDto _serialInfo;

        private AdditionallyInfoDto _additionalInfo;

        private MediaDto _mediaInfo;

        private ObservableCollection<VideoInfoDto> _videoInfo;

        private ObservableCollection<AudioInfoDto> _audioInfo;

        private ObservableCollection<SubtitleInfoDto> _subtitleInfo;


        public ObservableCollection<string> RecordsType
        {
            get => _recordsType; 
            set => _recordsType = value; 
        }

        public ObservableCollection<SampleDataDto> SampleDatas
        {
            get => _sampleDatas;
            set => _sampleDatas = value; 
        }        
        
        public SampleDataDto SelectedRecord
        {
            get => _selectedRecord; 
            set => SetProperty(ref _selectedRecord, value, "SelectedRecord"); 
        }

        public GeneralInfoDto GeneralInfo
        {
            get => _generalInfo; 
            set => SetProperty(ref _generalInfo, value, "GeneralInfo"); 
        }

        public SerialInfoDto SerialInfo
        {
            get => _serialInfo; 
            set => SetProperty(ref _serialInfo, value, "SerialInfo"); 
        }

        public AdditionallyInfoDto AdditionalInfo
        {
            get => _additionalInfo; 
            set => SetProperty(ref _additionalInfo, value, "AdditionalInfo"); 
        }

        public MediaDto MediaInfo
        {
            get => _mediaInfo; 
            set => SetProperty(ref _mediaInfo, value, "MediaDto"); 
        }

        public ObservableCollection<VideoInfoDto> VideoInfo
        {
            get => _videoInfo;
            set => _videoInfo = value; 
        }

        public ObservableCollection<AudioInfoDto> AudioInfo
        {
            get => _audioInfo;
            set => _audioInfo = value; 
        }

        public ObservableCollection<SubtitleInfoDto> SubtitleInfo
        {
            get => _subtitleInfo;
            set => _subtitleInfo = value; 
        }
               
        public MainViewModel()
        {
            _sharedDataRepository = new SharedDataRepository();
            _sampleDatas = new ObservableCollection<SampleDataDto>();
            _recordsType = new ObservableCollection<string>();
            _videoInfo = new ObservableCollection<VideoInfoDto>();
            _audioInfo = new ObservableCollection<AudioInfoDto>();
            _subtitleInfo = new ObservableCollection<SubtitleInfoDto>();
            GetTypes();
        }

        private RellayCommand _getSampleDataCommand;

        private RellayCommand _getAllDataCommand;


        public RellayCommand GetSampleDataCommand => 
            _getSampleDataCommand = new RellayCommand(GetSampleData);

        public RellayCommand GetAllDataCommand => 
            _getAllDataCommand = new RellayCommand(GetFullData, CanGetFullData);

        private void GetSampleData(object obj)
        {
            SampleDataRepository dataRepository = new SampleDataRepository();
            _sampleDatas.Clear();
            ClearObjects();
            string type = obj as string;
            var tempResultCollection = dataRepository.GetAll(type);
            tempResultCollection.ForEach(s => _sampleDatas.Add(s));
        }     

        private void GetFullData(object obj)
        {
            int id = _selectedRecord.Id;
            ClearObjects();
            GetGeneralInfo(new GeneralInfoRepository(), id);
            GetSerialInfo(new SerialInfoRepository(), id);
            GetAdditionalInfo(new AdditionallyInfoRepository(), id);
            GetMediaInfo(new MediaRepository(), id);
            GetVideoInfo(new VideoInfoRepository(), id);
            GetAudioInfo(new AudioInfoRepository(), id);
            GetSubtitleInfo(new SubtitleInfoRepository(), id);
        }

        private bool CanGetFullData(object obj) => _selectedRecord != null;

        private void GetTypes()
        {
            _recordsType.Clear();
           var resultTemp = _sharedDataRepository.GetAllTypes();
            resultTemp.ForEach(s => _recordsType.Add(s));
        }

        private void GetGeneralInfo(GeneralInfoRepository repository, int id) =>
            GeneralInfo = repository.GetEntityById(id);        

        private void GetSerialInfo(SerialInfoRepository repository, int id) =>
            SerialInfo = repository.GetGetEntityById(id);        

        private void GetAdditionalInfo(AdditionallyInfoRepository repository, int id) => 
            AdditionalInfo = repository.GetEntityById(id);        

        private void GetMediaInfo(MediaRepository repository, int id) =>
            MediaInfo = repository.GetEntityById(id);        

        private void GetVideoInfo(VideoInfoRepository repository, int id)
        {
            var tempResult = repository.GetEntityById(id);
            tempResult.ForEach(s => _videoInfo.Add(s));
        }   
        
        private void GetAudioInfo(AudioInfoRepository repository, int id)
        {
            var tempResult = repository.GetEntityById(id);
            tempResult.ForEach(s => _audioInfo.Add(s));
        }  
        
        private void GetSubtitleInfo(SubtitleInfoRepository repository, int id)
        {
            var tempResult = repository.GetEntityById(id);
            tempResult.ForEach(s => _subtitleInfo.Add(s));
        }
                                 
        private void ClearObjects()
        {       
            if (_generalInfo != null)
            {
                GeneralInfo = null; 
                SerialInfo = null;
                AdditionalInfo = null;
                MediaInfo = null;
                _videoInfo.Clear();
                _audioInfo.Clear();
                _subtitleInfo.Clear();
            }
        }
    }
}
