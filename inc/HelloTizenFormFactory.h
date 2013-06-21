#ifndef _HELLOTIZEN_FORM_FACTORY_H_
#define _HELLOTIZEN_FORM_FACTORY_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class HelloTizenFormFactory
	: public Tizen::Ui::Scenes::IFormFactory
{
public:
	HelloTizenFormFactory(void);
	virtual ~HelloTizenFormFactory(void);

	virtual Tizen::Ui::Controls::Form* CreateFormN(const Tizen::Base::String& formId, const Tizen::Ui::Scenes::SceneId& sceneId);
};

#endif // _HELLOTIZEN_FORM_FACTORY_H_
