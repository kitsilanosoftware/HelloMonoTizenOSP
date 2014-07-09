
using Tizen;
using Tizen.Ui.Scenes;


public class HelloTizenFormFactory : Tizen.Ui.Scenes.IFormFactory
{
	public Tizen.Ui.Controls.Form CreateFormN (Tizen.Base.String formId, Tizen.Ui.Scenes.SceneId sceneId)
	{
		SceneManager sceneManager = SceneManager.GetInstance();
		Utilities.AppAssert(sceneManager != null);
		Tizen.Ui.Controls.Form newForm = null;

		if (formId.Equals(Constants.IDF_FORM))
		{
			HelloTizenMainForm form = new HelloTizenMainForm();
			form.Initialize();
			sceneManager.AddSceneEventListener(sceneId, form);
			newForm = form;
		}
		// TODO:
		// Add your form creation code here

		return newForm;
	}
}
