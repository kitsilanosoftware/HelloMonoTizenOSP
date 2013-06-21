#ifndef _HELLOTIZEN_FRAME_H_
#define _HELLOTIZEN_FRAME_H_

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

public:
	virtual result OnInitializing(void);
	virtual result OnTerminating(void);
};

#endif	//_HELLOTIZEN_FRAME_H_
