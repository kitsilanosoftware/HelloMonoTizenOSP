HelloTizen
==========

The "Hello World" app from the Tizen SDK, converted from C++ to C#.

    /HelloTizen                   The HelloTizen sample application from the Tizen SDK, converted by hand to C#
    /Tizen                        Mocked up managed assembly for the Tizen SDK.   Just the subset needed for HelloTizen.

Workspace setup

    Create workspace directory (mine is C:\SourceTreeProjects)
    Clone https://github.com/brighttwin/HelloTizen.git to C:\SourceTreeProjects\HelloTizen
    Clone https://github.com/brighttwin/clang.git to C:\SourceTreeProjects\clang
    Clone https://github.com/brighttwin/llvm.git to C:\SourceTreeProjects\llvm
    Clone https://github.com/brighttwin/CppSharp.git to C:\SourceTreeProjects\CppSharp
    Clone https://github.com/brighttwin/CppSharpTizen.git to C:\SourceTreeProjects\CppSharpTizen

    mklink /J C:\SourceTreeProjects\llvm\tools\clang C:\SourceTreeProjects\clang
    mklink /J C:\SourceTreeProjects\CppSharp\deps\llvm C:\SourceTreeProjects\llvm
    mklink /J C:\SourceTreeProjects\CppSharp\examples\Tizen C:\SourceTreeProjects\CppSharpTizen

How to build

    Download and install Visual Studio 2012 - TODO work out what specific version(s) are OK
    Download and install CMake - http://www.cmake.org/cmake/resources/software.html
    Download and install Python (2.7.x, NOT 3.x) - http://www.python.org/download/

    Read http://clang.llvm.org/get_started.html for instructions on building LLVM and Clang.
    We only need to build Clang, not the whole LLVM toolset.
    It has to be on Windows for the time being, because CppSharp requires a C++/CLI compiler.

    cd C:\SourceTreeProjects\llvm
    md build
    cd build
    cmake -G "Visual Studio 11" ..                       (this is slow, like maybe 10 mins)
    open llvm.sln
    build the clang project, in RelWithDebInfo config    (this is incredibly slow, maybe 2 hours)

    Only at that stage can this junction be set up (which should maybe be replaced by a build step?)
    mklink /J C:\SourceTreeProjects\CppSharp\build\vs2012\lib\lib C:\SourceTreeProjects\CppSharp\deps\llvm\build\bin\lib

    Switch to C:\SourceTreeProjects\CppSharp\build
    run GenerateProjects.bat
    choose [2] for VS2012 generation
    cd vs2012
    open CppSharp.sln

TODO

- Generate more complete Tizen assemblies using CppSharp
- Get the application running on the Tizen simulator
- Create a MonoDevelop plugin which can launch the simulator
