HelloTizen
==========

"Hello World" app for Tizen, to be converted to C#

/HelloTizen                   The HelloTizen sample application from the Tizen SDK, converted by hand to C#
/Tizen                        Mocked up managed assembly for the Tizen SDK.   Just the subset needed for HelloTizen.

/ConsoleApp                   Default console application, for diffing the CSPROJ files against.
/Library                      Default library project, for diffing the CSPROJ files against.
/PortableClassLibrary         Default PCL, for diffing the CSPROJ files against.

HelloTizen is nearly fully converted as of 28th June 2013.

There are still some decisions to be made on how to map typedefs and other language features which don't cleanly map.
Also, the proxy Tizen assembly still doesn't have any implementation.
The first pass on that will be to write P/Invoke code by hand, and then to try to get that running.
The second pass will be to switch to CppSharp, and automatically generate that assembly.
