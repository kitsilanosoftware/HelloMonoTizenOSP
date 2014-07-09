#include "HelloTizenForm.h"
#include "AppResourceId.h"

extern "C"
{
#include <mono/metadata/appdomain.h>
#include <mono/metadata/environment.h>
#include <mono/metadata/assembly.h>
#include <mono/metadata/object.h>
#include <mono/metadata/debug-helpers.h>

MonoAssembly *mono_tizen_get_main_assembly();
}

using namespace Tizen::Base;
using namespace Tizen::App;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;

HelloTizenForm::HelloTizenForm(void)
{
	MonoDomain *domain = mono_domain_get ();
	MonoAssembly *assembly = mono_tizen_get_main_assembly();
	MonoImage *image = mono_assembly_get_image(assembly);
	MonoClass *klass = mono_class_from_name (image, "", "HelloTizenMainForm");

	MonoObject *instance = mono_object_new(domain, klass);
	/* execute the default argument-less constructor */
	mono_runtime_object_init(instance);

	handle_ = mono_gchandle_new(instance, false);
}

HelloTizenForm::~HelloTizenForm(void)
{
        mono_gchandle_free (handle_);
}

bool
HelloTizenForm::Initialize(void)
{
	result r = Construct(IDL_FORM);
	TryReturn(r == E_SUCCESS, false, "Failed to construct form");

	return true;
}
result
HelloTizenForm::OnInitializing(void)
{
	result r = E_SUCCESS;

	// TODO: Add your initialization code here

	// Setup back event listener
	SetFormBackEventListener(this);

	// Get a button via resource ID
	Tizen::Ui::Controls::Button* pButtonOk = static_cast< Button* >(GetControl(IDC_BUTTON_OK));
	if (pButtonOk != null)
	{
		pButtonOk->SetActionId(IDA_BUTTON_OK);
		pButtonOk->AddActionEventListener(*this);
	}

	return r;
}

result
HelloTizenForm::OnTerminating(void)
{
	result r = E_SUCCESS;

	// TODO: Add your termination code here

	return r;
}

void
HelloTizenForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	static MonoMethod* method;
	MonoObject *obj = mono_gchandle_get_target (handle_);

	if (!method) {
		MonoMethodDesc* desc = mono_method_desc_new(
			"HelloTizenMainForm:OnActionPerformed", false);
		MonoClass *klass = mono_object_get_class(obj);

		method = mono_method_desc_search_in_class(desc, klass);
	}

	void *args[2];

	args[0] = NULL;
	args[1] = &actionId;

	mono_runtime_invoke(method, obj, args, NULL);
}

void
HelloTizenForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	UiApp* pApp = UiApp::GetInstance();
	AppAssert(pApp);
	pApp->Terminate();
}


