

public class HelloTizenMainForm : Tizen.UI.Controls.Form,
                                  Tizen.UI.IActionEventListener,
                                  Tizen.UI.Controls.IFormBackEventListener,
                                  Tizen.UI.Scenes.ISceneEventListener
{
	static const int ID_BUTTON_OK = 101;

	bool Initialize()
	{
		Construct(IDF_FORM);
		return true;
	}

	ulong OnInitializing()
	{
		result r = E_SUCCESS;

		// TODO:
		// Add your initialization code here

		// Setup back event listener
		SetFormBackEventListener(this);

		// Get a button via resource ID
		Tizen::Ui::Controls::Button *pButtonOk = static_cast<Button*>(GetControl(IDC_BUTTON_OK));
		if (pButtonOk != null)
		{
			pButtonOk->SetActionId(ID_BUTTON_OK);
			pButtonOk->AddActionEventListener(*this);
		}

		return r;
	}

	ulong OnTerminating(void)
	{
		result r = E_SUCCESS;

		// TODO:
		// Add your termination code here
		return r;
	}

	void OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
	{
		SceneManager* pSceneManager = SceneManager::GetInstance();
		AppAssert(pSceneManager);

		switch(actionId)
		{
		case ID_BUTTON_OK:
			AppLog("OK Button is clicked!");
			break;

		default:
			break;
		}
	}

	void OnFormBackRequested(Tizen::Ui::Controls::Form& source)
	{
		UiApp* pApp = UiApp::GetInstance();
		AppAssert(pApp);
		pApp->Terminate();
	}

	void OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId,
										  const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs)
	{
		// TODO:
		// Add your scene activate code here
		AppLog("OnSceneActivatedN");
	}

	void OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId,
										   const Tizen::Ui::Scenes::SceneId& nextSceneId)
	{
		// TODO:
		// Add your scene deactivate code here
		AppLog("OnSceneDeactivated");
	}
}
