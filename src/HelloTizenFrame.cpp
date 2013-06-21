#include "HelloTizenFrame.h"
#include "HelloTizenFormFactory.h"
#include "HelloTizenPanelFactory.h"
#include "AppResourceId.h"

using namespace Tizen::Base;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Ui::Scenes;

HelloTizenFrame::HelloTizenFrame(void)
{
}

HelloTizenFrame::~HelloTizenFrame(void)
{
}

result
HelloTizenFrame::OnInitializing(void)
{
	// Prepare Scene management.
	SceneManager* pSceneManager = SceneManager::GetInstance();
	static HelloTizenFormFactory formFactory;
	static HelloTizenPanelFactory panelFactory;
	pSceneManager->RegisterFormFactory(formFactory);
	pSceneManager->RegisterPanelFactory(panelFactory);
	pSceneManager->RegisterScene(L"workflow");

	// Go to the scene.
	result r = E_FAILURE;
	r = pSceneManager->GoForward(SceneTransitionId(ID_SCNT_MAINSCENE));

	// TODO: Add your initialization code here
	return r;
}

result
HelloTizenFrame::OnTerminating(void)
{
	result r = E_SUCCESS;

	// TODO:
	// Add your termination code here
	return r;
}
