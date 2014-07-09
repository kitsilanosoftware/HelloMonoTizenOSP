#ifndef _HELLO_TIZEN_FRAME_H_
#define _HELLO_TIZEN_FRAME_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class HelloTizenFrame
	: public Tizen::Ui::Controls::Frame
{
public:
	HelloTizenFrame(void);
	virtual ~HelloTizenFrame(void);

private:
	virtual result OnInitializing(void);
	virtual result OnTerminating(void);
};

#endif	//_HELLO_TIZENFRAME_H_
