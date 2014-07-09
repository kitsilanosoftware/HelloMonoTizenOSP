
using System.Runtime.InteropServices;

namespace Tizen
{
	public class Utilities
	{
		[DllImport ("__Internal", EntryPoint="MonoTizenAppLogInternal")]
		static extern void MonoTizenAppLogInternal (string function, int lineNumber, string message);

		public static void AppAssert(bool condition)
		{	
		}

		public static void AppLog(string format, params object[] args)
		{
			var s = string.Format(format, args);
			MonoTizenAppLogInternal("?", 0, s);
		}

		public static void TryLog(bool condition, string format, params object[] args)
		{
		}

		public static string GetErrorMessage(int error)
		{
			return "Unknown error";
		}

	}
}
