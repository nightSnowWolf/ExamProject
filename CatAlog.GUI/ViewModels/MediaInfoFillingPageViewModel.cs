using CatAlog.Db.Models.DtoModels.VideoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatAlog.GUI.ViewModels
{
    public class MediaInfoFillingPageViewModel : ModelBase
    {
		private MediaDto _mediaInfo;

		public MediaDto MediaInfo
		{
			get { return _mediaInfo; }
			set { _mediaInfo = value; }
		}

		public MediaInfoFillingPageViewModel(MediaDto mediaInfo)
		{
			_mediaInfo = mediaInfo;
		}
	}
}
