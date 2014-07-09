using Tizen;
using System;
using System.Text;

public class HelloTizenMainForm : Tizen.Ui.Controls.Form,
                                  Tizen.Ui.IActionEventListener,
                                  Tizen.Ui.Controls.IFormBackEventListener,
                                  Tizen.Ui.Scenes.ISceneEventListener
{
	public const int ID_BUTTON_OK = 101;

	int clicks = 0;

	public bool Initialize()
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
		SetFormBackEventListener(this);

		// Get a button via resource ID
		Tizen.Ui.Controls.Button buttonOk = (Tizen.Ui.Controls.Button)GetControl(new Tizen.Base.String(Constants.IDC_BUTTON_OK));
		if (buttonOk != null)
		{
			buttonOk.SetActionId(ID_BUTTON_OK);
			buttonOk.AddActionEventListener(this);
		}

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

			clicks++;

			var sb = new StringBuilder("Hello, Tizen");
			for (var i = 0; i < clicks; i++)
				sb.Append ("!");
			SetHeaderTitleText(sb.ToString());

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
