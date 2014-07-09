#include <new>
#include "HelloTizenFrame.h"
#include "HelloTizenForm.h"

extern "C"
{
#include <mono/metadata/environment.h>
#include <mono/metadata/assembly.h>
#include <mono/metadata/debug-helpers.h>
#include <mono/metadata/object.h>

MonoAssembly *mono_tizen_get_main_assembly();
}

using namespace Tizen::Base;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;

static const char *title_text_from_mono()
{
	static MonoMethod* method;

	if (!method) {
		MonoAssembly* assembly = mono_tizen_get_main_assembly();
		MonoImage *image = mono_assembly_get_image(assembly);
		MonoMethodDesc* desc = mono_method_desc_new("HelloTizenApp:GetHeaderTitleText()", false);

		method = mono_method_desc_search_in_image(desc, image);
	}

	MonoObject *name_obj = mono_runtime_invoke(method, NULL, NULL, NULL);

	return mono_string_to_utf8((MonoString*)name_obj);
}

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

	Header *pHeader = pHelloTizenForm->GetHeader();
	const char *titleText = title_text_from_mono();
	pHeader->SetTitleText(titleText);
	free((void*)titleText);

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


