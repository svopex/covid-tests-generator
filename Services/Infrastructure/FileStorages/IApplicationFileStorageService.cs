﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Services.FileStorage;

namespace CTG.CovidTestsGenerator.Services.Infrastructure.FileStorages
{
	public interface IApplicationFileStorageService : IFileStorageService<ApplicationFileStorage>
	{
	}
}
