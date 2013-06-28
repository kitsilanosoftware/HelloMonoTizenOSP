
using Tizen;


class HelloTizenFrame : Tizen.Ui.Controls.Frame
{
	public void SetName(string name)
	{
	}

	ulong OnInitializing()
	{
		// Prepare Scene management.
		//SceneManager* pSceneManager = SceneManager::GetInstance();
		//static HelloTizenFormFactory formFactory;
		//static HelloTizenPanelFactory panelFactory;
		//pSceneManager->RegisterFormFactory(formFactory);
		//pSceneManager->RegisterPanelFactory(panelFactory);
		//pSceneManager->RegisterScene(L"workflow");

		// Go to the scene.
		ulong r = Tizen.Constants.E_FAILURE;
		//r = pSceneManager->GoForward(SceneTransitionId(ID_SCNT_MAINSCENE));

		// TODO: Add your initialization code here
		return r;
	}

	ulong OnTerminating()
	{
		ulong r = Tizen.Constants.E_SUCCESS;

		// TODO:
		// Add your termination code here
		return r;
	}

}
