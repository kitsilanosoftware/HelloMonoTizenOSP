#include "HelloTizenPanelFactory.h"

using namespace Tizen::Ui::Scenes;


HelloTizenPanelFactory::HelloTizenPanelFactory(void)
{
}

HelloTizenPanelFactory::~HelloTizenPanelFactory(void)
{
}

Tizen::Ui::Controls::Panel*
HelloTizenPanelFactory::CreatePanelN(const Tizen::Base::String& panelId, const Tizen::Ui::Scenes::SceneId& sceneId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	Tizen::Ui::Controls::Panel* pNewPanel = null;

	// TODO:
	// Add your panel creation code here
	return pNewPanel;
}
