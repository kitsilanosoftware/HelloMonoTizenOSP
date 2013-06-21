#ifndef _HELLOTIZEN_PANEL_FACTORY_H_
#define _HELLOTIZEN_PANEL_FACTORY_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class HelloTizenPanelFactory
	: public Tizen::Ui::Scenes::IPanelFactory
{
public:
	HelloTizenPanelFactory(void);
	virtual ~HelloTizenPanelFactory(void);

	virtual Tizen::Ui::Controls::Panel* CreatePanelN(const Tizen::Base::String& panelId, const Tizen::Ui::Scenes::SceneId& sceneId);
};

#endif // _HELLOTIZEN_PANEL_FACTORY_H_
