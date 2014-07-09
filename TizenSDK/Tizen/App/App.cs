
namespace Tizen.App
{
	public class App
	{
		public virtual bool OnAppInitializing(AppRegistry appRegistry)
		{
			return true;
		}

		public virtual bool OnAppInitialized()
		{
			return true;
		}

		public virtual bool OnAppWillTerminate()
		{
			return true;
		}

		public virtual bool OnAppTerminating(Tizen.App.AppRegistry appRegistry, bool forcedTermination = false)
		{
			return true;
		}

		public virtual void OnLowMemory()
		{
		}

		public virtual void OnBatteryLevelChanged(Tizen.System.BatteryLevel batteryLevel)
		{
		}
	}
}

