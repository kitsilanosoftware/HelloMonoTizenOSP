#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>

#include <new>
#include "HelloTizenApp.h"

using namespace Tizen::Base;
using namespace Tizen::Base::Collection;

#ifdef __cplusplus
extern "C"
{
#endif // __cplusplus

#include <mono/jit/jit.h>
#include <mono/metadata/environment.h>
#include <mono/metadata/mono-config.h>
#include <mono/metadata/assembly.h>
#include <stdlib.h>

#define STRINGIFY(x) #x
#define TOSTRING(x) STRINGIFY(x)

static void
mono_tizen_jit_exec_main (MonoDomain *domain, const char *file, int argc, char** argv)
{
	MonoAssembly *assembly;

	assembly = mono_domain_assembly_open (domain, file);
	if (!assembly)
		exit (2);
	/*
	 * mono_jit_exec() will run the Main() method in the assembly.
	 * The return value needs to be looked up from
	 * System.Environment.ExitCode.
	 */
	mono_jit_exec (domain, assembly, argc, argv);
}

int
mono_tizen_main(int argc, char* argv[]) {
	MonoDomain *domain;
	const char *exe_paths[] = {
		"/opt/apps/" TOSTRING(MONO_TIZEN_APPID) "/bin/Release/HelloTizen.exe",
		"/opt/apps/" TOSTRING(MONO_TIZEN_APPID) "/bin/Debug/HelloTizen.exe",
		NULL
	};
	const char *exe_path = NULL;
	int i, retval;

	for (i = 0; exe_paths[i]; i++) {
		if (access (exe_paths[i], R_OK) == 0) {
			exe_path = exe_paths[i];
			break;
		}
	}

	if (! exe_path) {
		printf ("Start assembly %s not found", exe_paths [0]);
		exit (1);
	}

	/*
	 * Here's where we are going to look up our assemblies.
	 */
	mono_set_assemblies_path ("/opt/apps/" TOSTRING(MONO_TIZEN_APPID) "/lib/mono");

	/*
	 * mono_jit_init() creates a domain: each assembly is
	 * loaded and run in a MonoDomain.
	 */
	domain = mono_jit_init (exe_path);

	mono_tizen_jit_exec_main (domain, exe_path, argc, argv);

	retval = mono_environment_exitcode_get ();

	mono_jit_cleanup (domain);
	return retval;
}

//
// The framework calls this method as the entry method of the Tizen application.
//
_EXPORT_ int
OspMain(int argc, char* pArgv[])
{
	AppLog("Application started.");
	ArrayList args(SingleObjectDeleter);
	args.Construct();
	for (int i = 0; i < argc; i++)
	{
		args.Add(new (std::nothrow) String(pArgv[i]));
	}

	result r = Tizen::App::UiApp::Execute(HelloTizenApp::CreateInstance, &args);
	TryLog(r == E_SUCCESS, "[%s] Application execution failed.", GetErrorMessage(r));
	AppLog("Application finished.");

	return static_cast< int >(r);
}
#ifdef __cplusplus
}
#endif // __cplusplus
