
using Tizen;
using Tizen.System;


/**
 * [HelloTizenApp] UiApp must inherit from UiApp class
 * which provides basic features necessary to define an UiApp.
 */
public class HelloTizenApp : Tizen.App.UiApp, Tizen.System.IScreenEventListener
{
	public static Tizen.App.UiApp CreateInstance()
	{
		return new HelloTizenApp();
	}

	// Called when the UiApp is initializing.
	public override bool OnAppInitializing(Tizen.App.AppRegistry appRegistry)
	{
		// TODO:
		// Initialize Frame and App specific data.
		// The App's permanent data and context can be obtained from the appRegistry.
		//
		// If this method is successful, return true; otherwise, return false.
		// If this method returns false, the App will be terminated.

		// Uncomment the following statement to listen to the screen on/off events.
		//PowerManager.SetScreenEventListener(this);

		// TODO:
		// Add your initialization code here
		return true;
	}

	// Called when the UiApp initializing is finished. 
	public override bool OnAppInitialized()
	{
		// TODO:
		// Comment.

		// Create a Frame
		HelloTizenFrame helloTizenFrame = new HelloTizenFrame();
		helloTizenFrame.Construct();
		helloTizenFrame.SetName("HelloTizen");
		AddFrame(helloTizenFrame);

		return true;
	}
	
	// Called when the UiApp is requested to terminate. 
	public override bool OnAppWillTerminate()
	{
		// TODO:
		// Comment.
		return true;
	}
	
	// Called when the UiApp is terminating.
	public override bool OnAppTerminating(Tizen.App.AppRegistry appRegistry, bool forcedTermination = false)
	{
		// TODO:
		// Deallocate resources allocated by this App for termination.
		// The App's permanent data and context can be saved via appRegistry.
		return true;
	}

	// Called when the UiApp's frame moves to the top of the screen.
	public override void OnForeground()
	{
		// TODO:
		// Start or resume drawing when the application is moved to the foreground.
	}

	// Called when this UiApp's frame is moved from top of the screen to the background.
	public override void OnBackground()
	{
		// TODO:
		// Stop drawing when the application is moved to the background.
	}

	// Called when the system memory is not sufficient to run the UiApp any further.
	public override void OnLowMemory()
	{
		// TODO:
		// Free unused resources or close the application.
	}

	// Called when the battery level changes.
	public override void OnBatteryLevelChanged(Tizen.System.BatteryLevel batteryLevel)
	{
		// TODO:
		// Handle any changes in battery level here.
		// Stop using multimedia features(camera, mp3 etc.) if the battery level is CRITICAL.
	}


	// Called when the screen turns on.
	public void OnScreenOn()
    {
		// TODO:
		// Get the released resources or resume the operations that were paused or stopped in OnScreenOff().
    }

	// Called when the screen turns off.
	public void OnScreenOff()
	{
		// TODO:
		// Unless there is a strong reason to do otherwise, release resources (such as 3D, media, and sensors) to allow the device
		// to enter the sleep mode to save the battery.
		// Invoking a lengthy asynchronous method within this listener method can be risky, because it is not guaranteed to invoke a
		// callback before the device enters the sleep mode.
		// Similarly, do not perform lengthy operations in this listener method. Any operation must be a quick one.
	}
}
