﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTG.CovidTestsGenerator.Web.Client
{
	public static class Routes
	{
		public const string Home = "/";

		public static class Administration
		{
			public const string Index = "/admin/";
		}

		public static class UserAdministration
		{
			public const string PageName = "/admin/user/page-name";
		}

		public static class Diagnostics
		{
			public const string Info = "/diag/info";
		}
	}
}
