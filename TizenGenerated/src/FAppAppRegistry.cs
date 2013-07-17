//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Tizen
{
    namespace App
    {
        public unsafe partial class AppRegistry : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public struct Internal
            {
                /// <summary>
                /// This default constructor is intentionally declared as private to implement the %Singleton semantic.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.ThisCall,
                    EntryPoint="??0AppRegistry@App@Tizen@@AAE@XZ")]
                public static extern System.IntPtr AppRegistry0(System.IntPtr instance);

                /// <summary>
                /// Adds a string value along with the specified key.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.ThisCall,
                    EntryPoint="?Add@AppRegistry@App@Tizen@@QAEKABVString@Base@3@0@Z")]
                public static extern uint Add0(System.IntPtr instance, System.IntPtr key, System.IntPtr value);

                /// <summary>
                /// Adds an integer value along with the specified key.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.ThisCall,
                    EntryPoint="?Add@AppRegistry@App@Tizen@@QAEKABVString@Base@3@H@Z")]
                public static extern uint Add1(System.IntPtr instance, System.IntPtr key, int value);

                /// <summary>
                /// Adds a floating point value along with the specified key.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.ThisCall,
                    EntryPoint="?Add@AppRegistry@App@Tizen@@QAEKABVString@Base@3@N@Z")]
                public static extern uint Add2(System.IntPtr instance, System.IntPtr key, double value);

                /// <summary>
                /// Sets a string value associated with the specified key.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.ThisCall,
                    EntryPoint="?Set@AppRegistry@App@Tizen@@QAEKABVString@Base@3@0@Z")]
                public static extern uint Set0(System.IntPtr instance, System.IntPtr key, System.IntPtr value);

                /// <summary>
                /// Sets an integer value associated with the specified key.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.ThisCall,
                    EntryPoint="?Set@AppRegistry@App@Tizen@@QAEKABVString@Base@3@H@Z")]
                public static extern uint Set1(System.IntPtr instance, System.IntPtr key, int value);

                /// <summary>
                /// Sets a floating point value associated with the specified key.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.ThisCall,
                    EntryPoint="?Set@AppRegistry@App@Tizen@@QAEKABVString@Base@3@N@Z")]
                public static extern uint Set2(System.IntPtr instance, System.IntPtr key, double value);

                /// <summary>
                /// Saves the values temporarily in the persistent storage. The %Save() method is invoked internally when the instance of this class is deleted.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.ThisCall,
                    EntryPoint="?Save@AppRegistry@App@Tizen@@QAEKXZ")]
                public static extern uint Save0(System.IntPtr instance);

                /// <summary>
                /// Removes a preference associated with the specified key.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.ThisCall,
                    EntryPoint="?Remove@AppRegistry@App@Tizen@@QAEKABVString@Base@3@@Z")]
                public static extern uint Remove0(System.IntPtr instance, System.IntPtr key);

                /// <summary>
                /// Gets a string value associated with the specified key.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.ThisCall,
                    EntryPoint="?Get@AppRegistry@App@Tizen@@QBEKABVString@Base@3@AAV453@@Z")]
                public static extern uint Get0(System.IntPtr instance, System.IntPtr key, System.IntPtr value);

                /// <summary>
                /// Gets an integer value associated with the specified key.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.ThisCall,
                    EntryPoint="?Get@AppRegistry@App@Tizen@@QBEKABVString@Base@3@AAH@Z")]
                public static extern uint Get00(System.IntPtr instance, System.IntPtr key, System.IntPtr value);

                /// <summary>
                /// Gets a floating point value associated with the specified key.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.ThisCall,
                    EntryPoint="?Get@AppRegistry@App@Tizen@@QBEKABVString@Base@3@AAN@Z")]
                public static extern uint Get1(System.IntPtr instance, System.IntPtr key, System.IntPtr value);

                /// <summary>
                /// Gets the %AppRegistry instance pointer.
                /// </summary>
                [SuppressUnmanagedCodeSecurity]
                [DllImport("SymbolNotFound", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="?GetInstance@AppRegistry@App@Tizen@@SAPAV123@XZ")]
                public static extern System.IntPtr GetInstance0();
            }

            public System.IntPtr _Instance { get; protected set; }

            internal AppRegistry(AppRegistry.Internal* native)
                : this(new System.IntPtr(native))
            {
            }

            internal AppRegistry(AppRegistry.Internal native)
                : this(&native)
            {
            }

            internal AppRegistry(System.IntPtr native)
            {
                _Instance = native;
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
            /// Adds a string value along with the specified key.
            /// </summary>
            public uint Add(String key, String value)
            {
                var arg0 = new Std.String();
                var arg1 = new Std.String();
                var ret = Internal.Add0(_Instance, arg0, arg1);
                return ret;
            }

            /// <summary>
            /// Adds an integer value along with the specified key.
            /// </summary>
            public uint Add(String key, int value)
            {
                var arg0 = new Std.String();
                var ret = Internal.Add1(_Instance, arg0, value);
                return ret;
            }

            /// <summary>
            /// Adds a floating point value along with the specified key.
            /// </summary>
            public uint Add(String key, double value)
            {
                var arg0 = new Std.String();
                var ret = Internal.Add2(_Instance, arg0, value);
                return ret;
            }

            /// <summary>
            /// Sets a string value associated with the specified key.
            /// </summary>
            public uint Set(String key, String value)
            {
                var arg0 = new Std.String();
                var arg1 = new Std.String();
                var ret = Internal.Set0(_Instance, arg0, arg1);
                return ret;
            }

            /// <summary>
            /// Sets an integer value associated with the specified key.
            /// </summary>
            public uint Set(String key, int value)
            {
                var arg0 = new Std.String();
                var ret = Internal.Set1(_Instance, arg0, value);
                return ret;
            }

            /// <summary>
            /// Sets a floating point value associated with the specified key.
            /// </summary>
            public uint Set(String key, double value)
            {
                var arg0 = new Std.String();
                var ret = Internal.Set2(_Instance, arg0, value);
                return ret;
            }

            /// <summary>
            /// Saves the values temporarily in the persistent storage. The %Save() method is invoked internally when the instance of this class is deleted.
            /// </summary>
            public uint Save()
            {
                var ret = Internal.Save0(_Instance);
                return ret;
            }

            /// <summary>
            /// Removes a preference associated with the specified key.
            /// </summary>
            public uint Remove(String key)
            {
                var arg0 = new Std.String();
                var ret = Internal.Remove0(_Instance, arg0);
                return ret;
            }

            /// <summary>
            /// Gets a string value associated with the specified key.
            /// </summary>
            public uint Get(String key, String value)
            {
                var arg0 = new Std.String();
                var arg1 = new Std.String();
                var ret = Internal.Get0(_Instance, arg0, arg1);
                return ret;
            }

            /// <summary>
            /// Gets an integer value associated with the specified key.
            /// </summary>
            public uint Get0(String key, System.IntPtr value)
            {
                var arg0 = new Std.String();
                var arg1 = value;
                var ret = Internal.Get00(_Instance, arg0, arg1);
                return ret;
            }

            /// <summary>
            /// Gets a floating point value associated with the specified key.
            /// </summary>
            public uint Get(String key, System.IntPtr value)
            {
                var arg0 = new Std.String();
                var arg1 = value;
                var ret = Internal.Get1(_Instance, arg0, arg1);
                return ret;
            }

            /// <summary>
            /// Gets the %AppRegistry instance pointer.
            /// </summary>
            public static AppRegistry GetInstance()
            {
                var ret = Internal.GetInstance0();
                return new Tizen.App.AppRegistry(ret);
            }
        }
    }
}
