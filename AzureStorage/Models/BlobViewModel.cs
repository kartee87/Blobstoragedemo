using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AzureStorage.Models
{
	public class BlobViewModel
	{
		public String BlobContainerName { get; set; }
		public String StorageUri { get; set; }
		public String ActualFileName { get; set; }
		public String PrimaryUri { get; set; }
		public String fileExtension { get; set; }

		public String fileNameWithoutExt
		{
			// making change for automatic CI
			get
			{
				return Path.GetFileNameWithoutExtension(ActualFileName);
			}
		}

		public String fileNameExtensionOnly
		{
			get
			{
				return System.IO.Path.GetExtension(ActualFileName).Substring(1);
			}
		}
	}
}
