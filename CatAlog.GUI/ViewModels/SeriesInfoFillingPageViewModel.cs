using CatAlog.Db.Models.DtoModels.VideoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatAlog.GUI.ViewModels
{
    public class SeriesInfoFillingPageViewModel : ModelBase
    {
        private SerialInfoDto _serialInfo;

        public SerialInfoDto SerialInfo
        {
            get { return _serialInfo; }
            set { _serialInfo = value; }
        }


        public SeriesInfoFillingPageViewModel(SerialInfoDto serialInfo)
        {
            _serialInfo = serialInfo;
        }
    }
}
