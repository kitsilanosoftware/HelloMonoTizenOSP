#include <new>
#include "HelloTizenFrame.h"
#include "HelloTizenForm.h"

using namespace Tizen::Base;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;

HelloTizenFrame::HelloTizenFrame(void)
{
}

HelloTizenFrame::~HelloTizenFrame(void)
{
}

result
HelloTizenFrame::OnInitializing(void)
{
	result r = E_SUCCESS;

	// Create a form
	HelloTizenForm* pHelloTizenForm = new (std::nothrow) HelloTizenForm();
	TryReturn(pHelloTizenForm != null, false, "The memory is insufficient.");
	pHelloTizenForm->Initialize();

	// Add the form to the frame
	AddControl(pHelloTizenForm);

	// Set the current form
	SetCurrentForm(pHelloTizenForm);

	// Draw the form
	pHelloTizenForm->Invalidate(true);

	// TODO: Add your frame initialization code here.

	return r;
}

result
HelloTizenFrame::OnTerminating(void)
{
	result r = E_SUCCESS;

	// TODO: Add your frame termination code here.
	return r;
}


