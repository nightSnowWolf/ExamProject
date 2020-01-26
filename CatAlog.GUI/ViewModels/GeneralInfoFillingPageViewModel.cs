using CatAlog.Db.Models.DtoModels.VideoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatAlog.GUI.ViewModels
{
    public class GeneralInfoFillingPageViewModel : ModelBase
    {
        private GeneralInfoDto _generalInfo;

        public GeneralInfoDto GeneralInfo
        {
            get => _generalInfo; 
            set => SetProperty(ref _generalInfo, value, "GeneralInfo"); 
        }
               
        public GeneralInfoFillingPageViewModel(GeneralInfoDto generalInfo)
        {
            _generalInfo = generalInfo;
        }
    }
}
