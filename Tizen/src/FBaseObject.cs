//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Tizen
{
    namespace Base
    {
        public unsafe partial class Object : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 4)]
            public struct Internal
            {
                /// <summary>
                /// This is the default constructor for this class.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6ObjectC2Ev")]
                public static extern global::System.IntPtr Object0(global::System.IntPtr instance);

                /// <summary>
                /// Checks whether the value of the specified instance is
                /// equal to the value of the current instance of %Object.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6Object6EqualsERKS1_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                public static extern bool Equals0(global::System.IntPtr instance, global::System.IntPtr obj);

                /// <summary>
                /// Gets the hash value of the current instance of %Object.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6Object11GetHashCodeEv")]
                public static extern int GetHashCode0(global::System.IntPtr instance);
            }

            public global::System.IntPtr _Instance { get; protected set; }

            internal Object(Object.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal Object(Object.Internal native)
                : this(&native)
            {
            }

            internal Object(global::System.IntPtr native)
            {
                _Instance = native;
            }

            /// <summary>
            /// This is the default constructor for this class.
            /// </summary>
            public Object()
            {
                _Instance = Marshal.AllocHGlobal(4);
                Internal.Object0(_Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Marshal.FreeHGlobal(_Instance);
            }

            /// <summary>
            /// Checks whether the value of the specified instance is equal
            /// to the value of the current instance of %Object.
            /// </summary>
            public bool Equals(Object obj)
            {
                var arg0 = obj._Instance;
                var ret = Internal.Equals0(_Instance, arg0);
                return ret;
            }

            /// <summary>
            /// Gets the hash value of the current instance of %Object.
            /// </summary>
            public int GetHashCode()
            {
                var ret = Internal.GetHashCode0(_Instance);
                return ret;
            }
        }
    }
}
