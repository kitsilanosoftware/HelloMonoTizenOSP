//
// This file contains the Tizen application entry point.
//


//
// The entry function of Tizen application called by the operating system.
//

using Tizen;


public class EntryPoint
{
	static int Main(string[] args)
	{
		Utilities.AppLog("Application started.");

		int r = Tizen.App.UiApp.Execute(HelloTizenApp.CreateInstance, args);
		Utilities.TryLog(r == Tizen.Constants.E_SUCCESS, "[%s] Application execution failed", Utilities.GetErrorMessage(r));

		Utilities.AppLog("Application finished.");

		return r;
	}
}