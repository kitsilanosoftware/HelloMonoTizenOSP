
using System;

namespace Tizen.App
{
	public class UiApp : App
	{
		public /*result*/ void AddFrame(Tizen.Ui.Controls.Frame frame)
		{
		}

		public virtual void OnForeground()
		{
		}

		public virtual void OnBackground()
		{
		}

		public static int Execute(Func<UiApp> createInstance, string[] args)
		{
			return Constants.E_SUCCESS;
		}
	}
}

