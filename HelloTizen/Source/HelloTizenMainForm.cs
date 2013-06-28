
using Tizen;


public class HelloTizenMainForm : Tizen.Ui.Controls.Form,
                                  Tizen.Ui.IActionEventListener,
                                  Tizen.Ui.Controls.IFormBackEventListener,
                                  Tizen.Ui.Scenes.ISceneEventListener
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

	void OnActionPerformed(Tizen.Ui.Control source, int actionId)
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

	void OnFormBackRequested(Tizen.Ui.Controls.Form source)
	{
		//Tizen.App.UiApp app = UiApp::GetInstance();
		//Utilities.AppAssert(app != null);
		//app.Terminate();
	}

	void OnSceneActivatedN(Tizen.Ui.Scenes.SceneId previousSceneId,
						   Tizen.Ui.Scenes.SceneId currentSceneId,
	                       Tizen.Base.Collection.IList args)
	{
		// TODO:
		// Add your scene activate code here
		Utilities.AppLog("OnSceneActivatedN");
	}

	void OnSceneDeactivated(Tizen.Ui.Scenes.SceneId currentSceneId,
										   Tizen.Ui.Scenes.SceneId nextSceneId)
	{
		// TODO:
		// Add your scene deactivate code here
		Utilities.AppLog("OnSceneDeactivated");
	}
}
