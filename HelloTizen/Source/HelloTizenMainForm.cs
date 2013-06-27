
using Tizen;


public class HelloTizenMainForm : Tizen.UI.Controls.Form,
                                  Tizen.UI.IActionEventListener,
                                  Tizen.UI.Controls.IFormBackEventListener,
                                  Tizen.UI.Scenes.ISceneEventListener
{
	public const int ID_BUTTON_OK = 101;

	bool Initialize()
	{
		//Construct(IDF_FORM);
		return true;
	}

	ulong OnInitializing()
	{
		ulong r = Tizen.Constants.E_SUCCESS;

		// TODO:
		// Add your initialization code here

		// Setup back event listener
		//SetFormBackEventListener(this);

		// Get a button via resource ID
		//Tizen.UI.Controls.Button buttonOk = (Tizen.UI.Controls.Button)GetControl(IDC_BUTTON_OK);
		//if (buttonOk != null)
		//{
		//	buttonOk.SetActionId(ID_BUTTON_OK);
		//	buttonOk.AddActionEventListener(this);
		//}

		return r;
	}

	ulong OnTerminating()
	{
		ulong r = Tizen.Constants.E_SUCCESS;

		// TODO:
		// Add your termination code here
		return r;
	}

	void OnActionPerformed(Tizen.UI.Control source, int actionId)
	{
		//SceneManager sceneManager = SceneManager::GetInstance();
		//Utilities.AppAssert(pSceneManager);

		switch(actionId)
		{
		case ID_BUTTON_OK:
			Utilities.AppLog("OK Button is clicked!");
			break;

		default:
			break;
		}
	}

	void OnFormBackRequested(Tizen.UI.Controls.Form source)
	{
		//Tizen.App.UiApp app = UiApp::GetInstance();
		//Utilities.AppAssert(app != null);
		//app.Terminate();
	}

	void OnSceneActivatedN(Tizen.UI.Scenes.SceneId previousSceneId,
						   Tizen.UI.Scenes.SceneId currentSceneId,
	                       Tizen.Base.Collection.IList args)
	{
		// TODO:
		// Add your scene activate code here
		Utilities.AppLog("OnSceneActivatedN");
	}

	void OnSceneDeactivated(Tizen.UI.Scenes.SceneId currentSceneId,
										   Tizen.UI.Scenes.SceneId nextSceneId)
	{
		// TODO:
		// Add your scene deactivate code here
		Utilities.AppLog("OnSceneDeactivated");
	}
}
