using CatAlog.Db.Models.DtoModels.VideoModels;
using CatAlog.Db.Repositories;
using CatAlog.GUI.Infrastructure.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CatAlog.GUI.ViewModels
{
    public class SubtitleInfoFillingPageViewModel : ModelBase
    {
        private SubtitleInfoRepository _repository;

        private ObservableCollection<SubtitleInfoDto> _subtitleInfo;

		private SubtitleInfoDto _selectedRecord;

		private List<string> _language;

		private List<string> _author;

		private List<string> _subtitleFormat;

		public ObservableCollection<SubtitleInfoDto> SubtitleInfo
		{
			get { return _subtitleInfo; }
			set { _subtitleInfo = value; }
		}

        public SubtitleInfoDto SelectedRecord
        {
            get { return _selectedRecord; }
            set { _selectedRecord = value; }
        }

        public List<string> Language
        {
            get { return _language; }
            set { _language = value; }
        }

        public List<string> Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public List<string> SubtitleFormat
        {
            get { return _subtitleFormat; }
            set { _subtitleFormat = value; }
        }

        public SubtitleInfoFillingPageViewModel(ObservableCollection<SubtitleInfoDto> subtitleInfo)
		{
			_subtitleInfo = subtitleInfo;
            _repository = new SubtitleInfoRepository();


            //_language = _repository.GetLanguages();
            //_author = _repository.GetAuthors();
            //_subtitleFormat = _repository.GetSubtitlesFormat();
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
                        SubtitleInfoDto item = new SubtitleInfoDto();
                        _subtitleInfo.Add(item);
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
                        _subtitleInfo.Remove(_selectedRecord);
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
                        _subtitleInfo.Clear();
                    },
                        (obj) => _subtitleInfo != null && _subtitleInfo.Count != 0)
                    );
            }
        }
    }
}
