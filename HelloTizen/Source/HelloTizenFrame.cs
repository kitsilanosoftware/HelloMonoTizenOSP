
using Tizen;
using Tizen.Base;
using Tizen.Ui.Scenes;


class HelloTizenFrame : Tizen.Ui.Controls.Frame
{
	public void SetName(string name)
	{
	}

	ulong OnInitializing()
	{
		// Prepare Scene management.
		SceneManager sceneManager = SceneManager.GetInstance();
		sceneManager.RegisterFormFactory(new HelloTizenFormFactory());
		sceneManager.RegisterPanelFactory(new HelloTizenPanelFactory());
		sceneManager.RegisterScene(new Tizen.Base.String("workflow"));

		// Go to the scene.
		ulong r = Tizen.Constants.E_FAILURE;
		r = sceneManager.GoForward(new Tizen.Base.String(Constants.ID_SCNT_MAINSCENE));

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
