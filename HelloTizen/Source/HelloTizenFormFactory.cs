
using Tizen;
using Tizen.UI.Scenes;


public class HelloTizenFormFactory : Tizen.UI.Scenes.IFormFactory
{
	public Tizen.UI.Controls.Form CreateFormN (Tizen.Base.String formId, Tizen.UI.Scenes.SceneId sceneId)
	{
		SceneManager sceneManager = SceneManager.GetInstance();
		Utilities.AppAssert(sceneManager != null);
		Tizen.UI.Controls.Form newForm = null;

		if (formId.Equals(Constants.IDF_FORM))
		{
			//HelloTizenMainForm form = new HelloTizenMainForm();
			//form.Initialize();
			//sceneManager.AddSceneEventListener(sceneId, form);
			//newForm = form;
		}
		// TODO:
		// Add your form creation code here

		return newForm;
	}
}
