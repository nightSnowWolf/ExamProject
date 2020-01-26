using CatAlog.Db.Models.DtoModels.VideoModels;
using System;
using System.Collections.Generic;

namespace CatAlog.GUI.ViewModels
{
    public class AdditionalInfoFillingPageViewModel : ModelBase
    {
		private AdditionallyInfoDto _additionalyInfo;

		public AdditionallyInfoDto AdditionalyInfo
		{
			get => _additionalyInfo; 
			set => SetProperty(ref _additionalyInfo, value, "AdditionalyInfo"); 
		}


		public AdditionalInfoFillingPageViewModel(AdditionallyInfoDto additionalyInfo)
		{
			_additionalyInfo = additionalyInfo;
		}
	}
}
