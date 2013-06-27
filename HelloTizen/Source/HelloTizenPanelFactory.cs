
using Tizen;
using Tizen.UI.Scenes;


public class HelloTizenPanelFactory : Tizen.UI.Scenes.IPanelFactory
{
	public /*override*/ Tizen.UI.Controls.Panel CreatePanelN(Tizen.Base.String panelId, Tizen.UI.Scenes.SceneId sceneId)
	{
		SceneManager sceneManager = SceneManager.GetInstance();
		Utilities.AppAssert(sceneManager != null);

		Tizen.UI.Controls.Panel newPanel = null;

		// TODO:
		// Add your panel creation code here
		return newPanel;
	}
}
