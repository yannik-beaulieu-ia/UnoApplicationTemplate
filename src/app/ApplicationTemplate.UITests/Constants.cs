﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.UITest.Helpers.Queries;

namespace ApplicationTemplate.UITests
{
	public static class Constants
	{
		public const string WebAssemblyDefaultUri = "http://localhost:51669/";
		public const string iOSAppName = "com.nventive.apptemplate";
		public const string AndroidAppName = "com.nventive.applicationtemplate";
		public const string iOSDeviceNameOrId = "00008030-000865912E90802E";

		public static Platform PlatformUnderTest = Platform.Android;
	}
}
