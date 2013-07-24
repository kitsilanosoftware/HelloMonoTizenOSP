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
        public unsafe partial class String : Tizen.Base.Object, IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 28)]
            public new struct Internal
            {
                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6StringC2Ev")]
                public static extern global::System.IntPtr String0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6StringC2Ei")]
                public static extern global::System.IntPtr String1(global::System.IntPtr instance, int capacity);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6StringC2Ew")]
                public static extern global::System.IntPtr String2(global::System.IntPtr instance, char ch);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6StringC2EPKw")]
                public static extern global::System.IntPtr String3(global::System.IntPtr instance, global::System.IntPtr pValue);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6StringC2EPKc")]
                public static extern global::System.IntPtr String4(global::System.IntPtr instance, global::System.IntPtr pValue);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6StringeqERKS1_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                public static extern bool OperatorEqualEqual0(global::System.IntPtr instance, global::System.IntPtr rhs);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6StringneERKS1_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                public static extern bool OperatorExclaimEqual0(global::System.IntPtr instance, global::System.IntPtr rhs);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String7IsEmptyEv")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                public static extern bool IsEmpty0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6AppendEw")]
                public static extern uint Append0(global::System.IntPtr instance, char ch);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6AppendEc")]
                public static extern uint Append1(global::System.IntPtr instance, sbyte ch);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6AppendEi")]
                public static extern uint Append00(global::System.IntPtr instance, int i);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6AppendEs")]
                public static extern uint Append2(global::System.IntPtr instance, short s);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6AppendEl")]
                public static extern uint Append3(global::System.IntPtr instance, int l);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6AppendEx")]
                public static extern uint Append4(global::System.IntPtr instance, long ll);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6AppendEf")]
                public static extern uint Append5(global::System.IntPtr instance, float f);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6AppendEd")]
                public static extern uint Append6(global::System.IntPtr instance, double d);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6AppendEPKw")]
                public static extern uint Append7(global::System.IntPtr instance, global::System.IntPtr p);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6AppendERKS1_")]
                public static extern uint Append8(global::System.IntPtr instance, global::System.IntPtr str);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String5ClearEv")]
                public static extern void Clear0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String7CompareERKS1_S3_")]
                public static extern int Compare0(global::System.IntPtr str0, global::System.IntPtr str1);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String9CompareToERKS1_")]
                public static extern int CompareTo0(global::System.IntPtr instance, global::System.IntPtr str);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String14EnsureCapacityEi")]
                public static extern uint EnsureCapacity0(global::System.IntPtr instance, int minLength);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String6EqualsERKNS0_6ObjectE")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                public static extern bool Equals0(global::System.IntPtr instance, global::System.IntPtr obj);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String6EqualsERKS1_b")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                public static extern bool Equals1(global::System.IntPtr instance, global::System.IntPtr str, bool caseSensitive);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6FormatEiPKwz")]
                public static extern uint Format0(global::System.IntPtr instance, int length, global::System.IntPtr pFormat);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String11GetHashCodeEv")]
                public static extern int GetHashCode0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String9GetCharAtEiRw")]
                public static extern uint GetCharAt0(global::System.IntPtr instance, int indexAt, global::System.IntPtr ch);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String7IndexOfEwiRi")]
                public static extern uint IndexOf0(global::System.IntPtr instance, char ch, int startIndex, global::System.IntPtr indexOf);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String7IndexOfERKS1_iRi")]
                public static extern uint IndexOf1(global::System.IntPtr instance, global::System.IntPtr str, int startIndex, global::System.IntPtr indexOf);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6InsertEwi")]
                public static extern uint Insert0(global::System.IntPtr instance, char ch, int indexAt);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6InsertEci")]
                public static extern uint Insert1(global::System.IntPtr instance, sbyte ch, int indexAt);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6InsertEsi")]
                public static extern uint Insert2(global::System.IntPtr instance, short s, int indexAt);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6InsertEii")]
                public static extern uint Insert00(global::System.IntPtr instance, int i, int indexAt);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6InsertEli")]
                public static extern uint Insert3(global::System.IntPtr instance, int l, int indexAt);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6InsertExi")]
                public static extern uint Insert4(global::System.IntPtr instance, long ll, int indexAt);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6InsertEfi")]
                public static extern uint Insert5(global::System.IntPtr instance, float f, int indexAt);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6InsertEdi")]
                public static extern uint Insert6(global::System.IntPtr instance, double d, int indexAt);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6InsertEPKwi")]
                public static extern uint Insert7(global::System.IntPtr instance, global::System.IntPtr p, int indexAt);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6InsertERKS1_i")]
                public static extern uint Insert8(global::System.IntPtr instance, global::System.IntPtr str, int indexAt);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String11LastIndexOfEwiRi")]
                public static extern uint LastIndexOf0(global::System.IntPtr instance, char ch, int startIndex, global::System.IntPtr indexOf);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String11LastIndexOfERKS1_iRi")]
                public static extern uint LastIndexOf1(global::System.IntPtr instance, global::System.IntPtr str, int startIndex, global::System.IntPtr indexOf);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String6RemoveEii")]
                public static extern uint Remove0(global::System.IntPtr instance, int startIndex, int length);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String7ReplaceEww")]
                public static extern void Replace0(global::System.IntPtr instance, char original, char replace);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String7ReplaceERKS1_S3_")]
                public static extern uint Replace1(global::System.IntPtr instance, global::System.IntPtr original, global::System.IntPtr replace);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String7ReplaceERKS1_S3_i")]
                public static extern uint Replace2(global::System.IntPtr instance, global::System.IntPtr original, global::System.IntPtr replace, int startIndex);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String7ReverseEv")]
                public static extern void Reverse0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String11SetCapacityEi")]
                public static extern uint SetCapacity0(global::System.IntPtr instance, int newCapacity);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String9SetCharAtEwi")]
                public static extern uint SetCharAt0(global::System.IntPtr instance, char ch, int indexAt);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String9SetLengthEi")]
                public static extern uint SetLength0(global::System.IntPtr instance, int newLength);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String9SubStringEiRS1_")]
                public static extern uint SubString0(global::System.IntPtr instance, int startIndex, global::System.IntPtr @out);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String9SubStringEiiRS1_")]
                public static extern uint SubString1(global::System.IntPtr instance, int startIndex, int length, global::System.IntPtr @out);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String10StartsWithERKS1_i")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                public static extern bool StartsWith0(global::System.IntPtr instance, global::System.IntPtr str, int startIndex);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String8EndsWithERKS1_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                public static extern bool EndsWith0(global::System.IntPtr instance, global::System.IntPtr str);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String7ToLowerERS1_")]
                public static extern uint ToLower0(global::System.IntPtr instance, global::System.IntPtr @out);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String11ToLowerCaseERS1_")]
                public static extern uint ToLowerCase0(global::System.IntPtr instance, global::System.IntPtr @out);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String7ToUpperERS1_")]
                public static extern uint ToUpper0(global::System.IntPtr instance, global::System.IntPtr @out);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String11ToUpperCaseERS1_")]
                public static extern uint ToUpperCase0(global::System.IntPtr instance, global::System.IntPtr @out);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String7ToLowerEv")]
                public static extern void ToLower1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String11ToLowerCaseEv")]
                public static extern void ToLowerCase1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String7ToUpperEv")]
                public static extern void ToUpper1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String11ToUpperCaseEv")]
                public static extern void ToUpperCase1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZN5Tizen4Base6String4TrimEv")]
                public static extern void Trim0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String11GetCapacityEv")]
                public static extern int GetCapacity0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String9GetLengthEv")]
                public static extern int GetLength0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String10GetPointerEv")]
                public static extern global::System.IntPtr GetPointer0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
                    EntryPoint="_ZNK5Tizen4Base6String8ContainsERKS1_")]
                [return: MarshalAsAttribute(UnmanagedType.I1)]
                public static extern bool Contains0(global::System.IntPtr instance, global::System.IntPtr str);
            }

            internal String(String.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal String(String.Internal native)
                : this(&native)
            {
            }

            internal String(global::System.IntPtr native)
                : base(native)
            {
            }

            public String()
                : this(IntPtr.Zero)
            {
                _Instance = Marshal.AllocHGlobal(28);
                Internal.String0(_Instance);
            }

            public String(int capacity)
                : this(IntPtr.Zero)
            {
                _Instance = Marshal.AllocHGlobal(28);
                Internal.String1(_Instance, capacity);
            }

            public String(char ch)
                : this(IntPtr.Zero)
            {
                _Instance = Marshal.AllocHGlobal(28);
                Internal.String2(_Instance, ch);
            }

            public String(global::System.IntPtr pValue)
                : this(IntPtr.Zero)
            {
                var arg0 = Marshal.StringToHGlobalAnsi(pValue);
                _Instance = Marshal.AllocHGlobal(28);
                Internal.String3(_Instance, arg0);
            }

            public String(string pValue)
                : this(IntPtr.Zero)
            {
                var arg0 = Marshal.StringToHGlobalAnsi(pValue);
                _Instance = Marshal.AllocHGlobal(28);
                Internal.String4(_Instance, arg0);
            }

            protected override void Dispose(bool disposing)
            {
                base.Dispose(disposing);
            }

            public static bool operator ==(Tizen.Base.String _op, Tizen.Base.String rhs)
            {
                var arg0 = _op._Instance;
                var arg1 = rhs._Instance;
                var ret = Internal.OperatorEqualEqual0(arg0, arg1);
                return ret;
            }

            public static bool operator !=(Tizen.Base.String _op, Tizen.Base.String rhs)
            {
                var arg0 = _op._Instance;
                var arg1 = rhs._Instance;
                var ret = Internal.OperatorExclaimEqual0(arg0, arg1);
                return ret;
            }

            public bool IsEmpty()
            {
                var ret = Internal.IsEmpty0(_Instance);
                return ret;
            }

            public uint Append(char ch)
            {
                var ret = Internal.Append0(_Instance, ch);
                return ret;
            }

            public uint Append(sbyte ch)
            {
                var ret = Internal.Append1(_Instance, ch);
                return ret;
            }

            public uint Append0(int i)
            {
                var ret = Internal.Append00(_Instance, i);
                return ret;
            }

            public uint Append(short s)
            {
                var ret = Internal.Append2(_Instance, s);
                return ret;
            }

            public uint Append(int l)
            {
                var ret = Internal.Append3(_Instance, l);
                return ret;
            }

            public uint Append(long ll)
            {
                var ret = Internal.Append4(_Instance, ll);
                return ret;
            }

            public uint Append(float f)
            {
                var ret = Internal.Append5(_Instance, f);
                return ret;
            }

            public uint Append(double d)
            {
                var ret = Internal.Append6(_Instance, d);
                return ret;
            }

            public uint Append(global::System.IntPtr p)
            {
                var arg0 = Marshal.StringToHGlobalAnsi(p);
                var ret = Internal.Append7(_Instance, arg0);
                Marshal.FreeHGlobal(arg0);
                return ret;
            }

            public uint Append(Tizen.Base.String str)
            {
                var arg0 = str._Instance;
                var ret = Internal.Append8(_Instance, arg0);
                return ret;
            }

            public void Clear()
            {
                Internal.Clear0(_Instance);
            }

            public int CompareTo(Tizen.Base.String str)
            {
                var arg0 = str._Instance;
                var ret = Internal.CompareTo0(_Instance, arg0);
                return ret;
            }

            public uint EnsureCapacity(int minLength)
            {
                var ret = Internal.EnsureCapacity0(_Instance, minLength);
                return ret;
            }

            public bool Equals(Tizen.Base.Object obj)
            {
                var arg0 = obj._Instance;
                var ret = Internal.Equals0(_Instance, arg0);
                return ret;
            }

            public bool Equals(Tizen.Base.String str, bool caseSensitive)
            {
                var arg0 = str._Instance;
                var ret = Internal.Equals1(_Instance, arg0, caseSensitive);
                return ret;
            }

            public uint Format(int length, global::System.IntPtr pFormat)
            {
                var arg1 = Marshal.StringToHGlobalAnsi(pFormat);
                var ret = Internal.Format0(_Instance, length, arg1);
                Marshal.FreeHGlobal(arg1);
                return ret;
            }

            public int GetHashCode()
            {
                var ret = Internal.GetHashCode0(_Instance);
                return ret;
            }

            public uint GetCharAt(int indexAt, global::System.IntPtr ch)
            {
                var arg1 = Marshal.StringToHGlobalAnsi(ch);
                var ret = Internal.GetCharAt0(_Instance, indexAt, arg1);
                Marshal.FreeHGlobal(arg1);
                return ret;
            }

            public uint IndexOf(char ch, int startIndex, global::System.IntPtr indexOf)
            {
                var arg2 = indexOf;
                var ret = Internal.IndexOf0(_Instance, ch, startIndex, arg2);
                return ret;
            }

            public uint IndexOf(Tizen.Base.String str, int startIndex, global::System.IntPtr indexOf)
            {
                var arg0 = str._Instance;
                var arg2 = indexOf;
                var ret = Internal.IndexOf1(_Instance, arg0, startIndex, arg2);
                return ret;
            }

            public uint Insert(char ch, int indexAt)
            {
                var ret = Internal.Insert0(_Instance, ch, indexAt);
                return ret;
            }

            public uint Insert(sbyte ch, int indexAt)
            {
                var ret = Internal.Insert1(_Instance, ch, indexAt);
                return ret;
            }

            public uint Insert(short s, int indexAt)
            {
                var ret = Internal.Insert2(_Instance, s, indexAt);
                return ret;
            }

            public uint Insert0(int i, int indexAt)
            {
                var ret = Internal.Insert00(_Instance, i, indexAt);
                return ret;
            }

            public uint Insert(int l, int indexAt)
            {
                var ret = Internal.Insert3(_Instance, l, indexAt);
                return ret;
            }

            public uint Insert(long ll, int indexAt)
            {
                var ret = Internal.Insert4(_Instance, ll, indexAt);
                return ret;
            }

            public uint Insert(float f, int indexAt)
            {
                var ret = Internal.Insert5(_Instance, f, indexAt);
                return ret;
            }

            public uint Insert(double d, int indexAt)
            {
                var ret = Internal.Insert6(_Instance, d, indexAt);
                return ret;
            }

            public uint Insert(global::System.IntPtr p, int indexAt)
            {
                var arg0 = Marshal.StringToHGlobalAnsi(p);
                var ret = Internal.Insert7(_Instance, arg0, indexAt);
                Marshal.FreeHGlobal(arg0);
                return ret;
            }

            public uint Insert(Tizen.Base.String str, int indexAt)
            {
                var arg0 = str._Instance;
                var ret = Internal.Insert8(_Instance, arg0, indexAt);
                return ret;
            }

            public uint LastIndexOf(char ch, int startIndex, global::System.IntPtr indexOf)
            {
                var arg2 = indexOf;
                var ret = Internal.LastIndexOf0(_Instance, ch, startIndex, arg2);
                return ret;
            }

            public uint LastIndexOf(Tizen.Base.String str, int startIndex, global::System.IntPtr indexOf)
            {
                var arg0 = str._Instance;
                var arg2 = indexOf;
                var ret = Internal.LastIndexOf1(_Instance, arg0, startIndex, arg2);
                return ret;
            }

            public uint Remove(int startIndex, int length)
            {
                var ret = Internal.Remove0(_Instance, startIndex, length);
                return ret;
            }

            public void Replace(char original, char replace)
            {
                Internal.Replace0(_Instance, original, replace);
            }

            public uint Replace(Tizen.Base.String original, Tizen.Base.String replace)
            {
                var arg0 = original._Instance;
                var arg1 = replace._Instance;
                var ret = Internal.Replace1(_Instance, arg0, arg1);
                return ret;
            }

            public uint Replace(Tizen.Base.String original, Tizen.Base.String replace, int startIndex)
            {
                var arg0 = original._Instance;
                var arg1 = replace._Instance;
                var ret = Internal.Replace2(_Instance, arg0, arg1, startIndex);
                return ret;
            }

            public void Reverse()
            {
                Internal.Reverse0(_Instance);
            }

            public uint SetCapacity(int newCapacity)
            {
                var ret = Internal.SetCapacity0(_Instance, newCapacity);
                return ret;
            }

            public uint SetCharAt(char ch, int indexAt)
            {
                var ret = Internal.SetCharAt0(_Instance, ch, indexAt);
                return ret;
            }

            public uint SetLength(int newLength)
            {
                var ret = Internal.SetLength0(_Instance, newLength);
                return ret;
            }

            public uint SubString(int startIndex, Tizen.Base.String @out)
            {
                var arg1 = @out._Instance;
                var ret = Internal.SubString0(_Instance, startIndex, arg1);
                return ret;
            }

            public uint SubString(int startIndex, int length, Tizen.Base.String @out)
            {
                var arg2 = @out._Instance;
                var ret = Internal.SubString1(_Instance, startIndex, length, arg2);
                return ret;
            }

            public bool StartsWith(Tizen.Base.String str, int startIndex)
            {
                var arg0 = str._Instance;
                var ret = Internal.StartsWith0(_Instance, arg0, startIndex);
                return ret;
            }

            public bool EndsWith(Tizen.Base.String str)
            {
                var arg0 = str._Instance;
                var ret = Internal.EndsWith0(_Instance, arg0);
                return ret;
            }

            public uint ToLower(Tizen.Base.String @out)
            {
                var arg0 = @out._Instance;
                var ret = Internal.ToLower0(_Instance, arg0);
                return ret;
            }

            public uint ToLowerCase(Tizen.Base.String @out)
            {
                var arg0 = @out._Instance;
                var ret = Internal.ToLowerCase0(_Instance, arg0);
                return ret;
            }

            public uint ToUpper(Tizen.Base.String @out)
            {
                var arg0 = @out._Instance;
                var ret = Internal.ToUpper0(_Instance, arg0);
                return ret;
            }

            public uint ToUpperCase(Tizen.Base.String @out)
            {
                var arg0 = @out._Instance;
                var ret = Internal.ToUpperCase0(_Instance, arg0);
                return ret;
            }

            public void ToLower()
            {
                Internal.ToLower1(_Instance);
            }

            public void ToLowerCase()
            {
                Internal.ToLowerCase1(_Instance);
            }

            public void ToUpper()
            {
                Internal.ToUpper1(_Instance);
            }

            public void ToUpperCase()
            {
                Internal.ToUpperCase1(_Instance);
            }

            public void Trim()
            {
                Internal.Trim0(_Instance);
            }

            public int GetCapacity()
            {
                var ret = Internal.GetCapacity0(_Instance);
                return ret;
            }

            public int GetLength()
            {
                var ret = Internal.GetLength0(_Instance);
                return ret;
            }

            public global::System.IntPtr GetPointer()
            {
                var ret = Internal.GetPointer0(_Instance);
                return ret;
            }

            public bool Contains(Tizen.Base.String str)
            {
                var arg0 = str._Instance;
                var ret = Internal.Contains0(_Instance, arg0);
                return ret;
            }

            public static int Compare(Tizen.Base.String str0, Tizen.Base.String str1)
            {
                var arg0 = str0._Instance;
                var arg1 = str1._Instance;
                var ret = Internal.Compare0(arg0, arg1);
                return ret;
            }

            public static uint DEFAULT_CAPACITY
            {
                get
                {
                    var _ptr = (uint*)CppSharp.SymbolResolver.ResolveSymbol("", "");
                    return *_ptr;
                }
            }
        }
    }
}