using CatAlog.Db.Models.DtoModels.VideoModels;
using CatAlog.GUI.Infrastructure.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CatAlog.GUI.ViewModels
{
    public class CreatingNewRecordsViewModel : ModelBase
    {
        private GeneralInfoDto _generalInfo;

        private AdditionallyInfoDto _additionalyInfo;

        private SerialInfoDto _seriesInfo;

        private MediaDto _mediaInfo;

        private ObservableCollection<VideoInfoDto> _videoInfo;

        private ObservableCollection<AudioInfoDto> _audioInfo;

        private ObservableCollection<SubtitleInfoDto> _subtitleInfo;

        private Dictionary<string, object> _viewControls;

        private object _currentViewControl;

        public Dictionary<string, object> ViewControls
        {
            get => _viewControls;
        }

        public object CurrentViewControl
        {
            get => _currentViewControl;
            set
            {
                if (value is KeyValuePair<string, object> page)
                {
                    SetProperty(ref _currentViewControl, page.Value, "CurrentViewControl");
                }
            }
        }



        public CreatingNewRecordsViewModel()
        {
            InitialModels();
            InitialPages();

        }

        private void InitialModels()
        {
            _generalInfo = new GeneralInfoDto();
            _additionalyInfo = new AdditionallyInfoDto();
            _seriesInfo = new SerialInfoDto();
            _mediaInfo = new MediaDto();
            _videoInfo = new ObservableCollection<VideoInfoDto>();
            _audioInfo = new ObservableCollection<AudioInfoDto>();
            _subtitleInfo = new ObservableCollection<SubtitleInfoDto>();
        }

        private void InitialPages()
        {
            _viewControls = new Dictionary<string, object>()
            {
                ["General Information"] = new GeneralInfoFillingPageViewModel(_generalInfo),
                ["Additional Information"] = new AdditionalInfoFillingPageViewModel(_additionalyInfo),
                ["Serial Information"] = new SeriesInfoFillingPageViewModel(_seriesInfo),
                ["Media Information"] = new MediaInfoFillingPageViewModel(_mediaInfo),
                ["Video Information"] = new VideoInfoFillingPageViewModel(_videoInfo),
                ["Sound Information"] = new AudioInfoFillingPageViewModel(_audioInfo),
                ["Subtitle Information"] = new SubtitleInfoFillingPageViewModel(_subtitleInfo)
            };

            _currentViewControl = _viewControls["General Information"];
        }

        private RellayCommand _saveCommand;

        private RellayCommand _closeWindowCommand;

        public RellayCommand SaveCommand
        {
            get
            {
                return _saveCommand ??
                    (_saveCommand = new RellayCommand(obj =>
                    {

                    }));
            }
        }

        public RellayCommand CloseWindowCommand =>
            _closeWindowCommand = new RellayCommand((s) => Close());
    }
}
