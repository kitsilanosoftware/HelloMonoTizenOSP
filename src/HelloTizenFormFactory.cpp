#include "HelloTizenFormFactory.h"
#include "HelloTizenMainForm.h"
#include "AppResourceId.h"

using namespace Tizen::Ui::Scenes;


HelloTizenFormFactory::HelloTizenFormFactory(void)
{
}

HelloTizenFormFactory::~HelloTizenFormFactory(void)
{
}

Tizen::Ui::Controls::Form*
HelloTizenFormFactory::CreateFormN(const Tizen::Base::String& formId, const Tizen::Ui::Scenes::SceneId& sceneId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	Tizen::Ui::Controls::Form* pNewForm = null;

	if (formId == IDF_FORM)
	{
		HelloTizenMainForm* pForm = new HelloTizenMainForm();
		pForm->Initialize();
		pSceneManager->AddSceneEventListener(sceneId, *pForm);
		pNewForm = pForm;
	}
	// TODO:
	// Add your form creation code here

	return pNewForm;
}
