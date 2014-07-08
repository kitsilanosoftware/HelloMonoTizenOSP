
using Tizen;


namespace Tizen.Ui.Scenes
{
	public class SceneManager
	{
		public static SceneManager GetInstance()
		{
			return new SceneManager();
		}

		public void AddSceneEventListener(SceneId sceneId, ISceneEventListener sceneEventListener)
		{
		}

		public ulong GoForward(Base.String transitionId, Base.Collection.IList args=null)
		{
			return Constants.E_SUCCESS;
		}

		public ulong RegisterFormFactory(IFormFactory factory)
		{
			return Constants.E_SUCCESS;
		}

		public ulong RegisterPanelFactory(IPanelFactory factory)
		{
			return Constants.E_SUCCESS;
		}

		public ulong RegisterScene(Base.String resourceId)
		{
			return Constants.E_SUCCESS;
		}
	}
}

