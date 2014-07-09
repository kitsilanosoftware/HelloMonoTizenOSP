HelloTizen
==========

The "Hello World" app from the Tizen SDK, converted from C++ to C#.   These instructions assume a PC host machine.

    /HelloMonoTizenOSP            The HelloTizen sample application from the Tizen SDK, converted by hand to C#
    /TizenSDK                     Mocked up managed assembly for the Tizen SDK.   Just the subset needed for HelloTizen.

Workspace setup

    Create workspace directory (mine is C:\SourceTreeProjects) and make it your current directory
    
    git clone https://github.com/kitsilanosoftware/HelloMonoTizenOSP.git
    git clone https://github.com/kitsilanosoftware/clang.git
    git clone https://github.com/kitsilanosoftware/llvm.git
    git clone https://github.com/kitsilanosoftware/CppSharp.git
    git clone https://github.com/kitsilanosoftware/CppSharpTizen.git

    mklink /J llvm\tools\clang clang
    mklink /J CppSharp\deps\llvm llvm
    mklink /J CppSharp\examples\Tizen CppSharpTizen

How to build

    Download and install Visual Studio 2012 - TODO work out what specific version(s) are OK
    Download and install CMake - http://www.cmake.org/cmake/resources/software.html
    Download and install Python (2.7.x, NOT 3.x) - http://www.python.org/download/

    Read http://clang.llvm.org/get_started.html for instructions on building LLVM and Clang.
    We only need to build Clang, not the whole LLVM toolset.
    It has to be on Windows for the time being, because CppSharp requires a C++/CLI compiler.

    cd llvm
    md build
    cd build
    cmake -G "Visual Studio 11" ..                       (this is slow, like maybe 10 mins)
    open llvm.sln
    build the clang project, in RelWithDebInfo config    (this is incredibly slow, maybe 2 hours)

    Only at that stage can this junction be set up (which should maybe be replaced by a build step?)
    cd ..
    mklink /J CppSharp\build\vs2012\lib\lib CppSharp\deps\llvm\build\bin\lib

    cd CppSharp
    cd build
    call GenerateProjects.bat
    choose [2] for VS2012 generation
    cd vs2012
    open CppSharp.sln

TODO

- Generate more complete Tizen assemblies using CppSharp
- Get the application running on the Tizen simulator
- Create a MonoDevelop plugin which can launch the simulator
