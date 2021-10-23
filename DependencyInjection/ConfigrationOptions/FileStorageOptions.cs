﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTG.CovidTestsGenerator.DependencyInjection.ConfigrationOptions
{
	public class FileStorageOptions
	{
		public const string FileStorageOptionsKey = "AppSettings:FileStorage";

		public string PathOrContainerName { get; set; }
	}
}
