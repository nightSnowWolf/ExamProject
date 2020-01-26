using CatAlog.Db.Repositories;
using CatAlog.GUI.Infrastructure.Commands;
using System.Collections.Generic;

namespace CatAlog.GUI.ViewModels
{
	public class NewEntryPageViewModel : ModelBase
	{
		public delegate void NotifyDelegate();
		public event NotifyDelegate CloseHandler;

		private List<string> _templates;

		private List<string> _generalTypes;

		private string _selectedTemplate;

		private string _selectedGeneralType;

		private string _newGeneralType;

		public List<string> Templates
		{
			get => _templates;
			set => _templates = value;
		}

		public List<string> GeneralTypes
		{
			get => _generalTypes;
			set => _generalTypes = value;
		}

		public string SelectedTemplate
		{
			get => _selectedTemplate;
			set => _selectedTemplate = value;
		}

		public string SelectedGeneralType
		{
			get => _selectedGeneralType;
			set => _selectedGeneralType = value;
		}

		public string NewGeneralType
		{
			get => _newGeneralType;
			set => _newGeneralType = value;
		}

		public NewEntryPageViewModel()
		{
			SharedDataRepository repository = new SharedDataRepository();
			Templates = repository.GetAllTemplates();
			GeneralTypes = repository.GetAllTypes();
			GeneralTypes.Add("-- New record type --");
		}

		private RellayCommand _okCommand;

		private RellayCommand _closeCommand;

		public RellayCommand OkCommand =>
			_okCommand = new RellayCommand(OpenPageNewRecord, CanOpenPage);

		public RellayCommand CloseCommand =>
			_closeCommand = new RellayCommand(c => CloseHandler?.Invoke());

		private void OpenPageNewRecord(object obj)
		{
			var newTemplate = !string.IsNullOrEmpty(_newGeneralType) ? _newGeneralType : _selectedGeneralType;
			
			CloseCommand.Execute(null);

			if (_selectedTemplate == "Video")
			{
				var videoCreatingNewRecords = new CreatingNewRecordsViewModel()
				{
					Title = "Fill new video record",
					Package = new string[] { _selectedTemplate, _newGeneralType }
				};
				ShowAdditionalWindow(videoCreatingNewRecords);

			}
			else if (_selectedTemplate == "Game")
			{

			}			
		}

		private bool CanOpenPage(object obj)
		{
			if (!string.IsNullOrEmpty(_selectedTemplate))
			{
				if (!string.IsNullOrEmpty(_selectedGeneralType) && _selectedGeneralType != "-- New record type --")
				{
					return true;
				}
				else if (!string.IsNullOrEmpty(_selectedGeneralType) && _selectedGeneralType == "-- New record type --")
				{
					if (!string.IsNullOrEmpty(_newGeneralType))
					{
						return true;
					}
				}
				else
				{
					return false;
				}				
			}
			return false;
		}
	}
}
