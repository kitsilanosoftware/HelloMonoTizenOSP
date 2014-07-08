//
// This file contains the Tizen application entry point.
//


//
// The entry function of Tizen application called by the operating system.
//

using System.Runtime.InteropServices;

using Tizen;

public class EntryPoint
{
	[DllImport ("__Internal", EntryPoint="MonoTizenExecuteApp")]
	static extern int MonoTizenExecuteApp (int argc, System.IntPtr argv);

	static int Main(string[] args)
	{
		// TODO: Main loop from C#.

		// Utilities.AppLog("Application started.");

		// int r = Tizen.App.UiApp.Execute(HelloTizenApp.CreateInstance, args);
		// Utilities.TryLog(r == Tizen.Constants.E_SUCCESS, "[%s] Application execution failed", Utilities.GetErrorMessage(r));

		// Utilities.AppLog("Application finished.");

		return MonoTizenExecuteApp (0, System.IntPtr.Zero);
	}
}