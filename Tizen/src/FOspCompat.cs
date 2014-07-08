//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

public delegate int funread(global::System.IntPtr _cookie, global::System.IntPtr _buf, int _n);

public delegate int funwrite(global::System.IntPtr _cookie, string _buf, int _n);

public delegate int funclose(global::System.IntPtr _cookie);

public partial class TizenFOspCompat
{
    public struct Internal
    {
        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="strlwr")]
        public static extern global::System.IntPtr strlwr0(global::System.IntPtr pcStr);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="strupr")]
        public static extern global::System.IntPtr strupr0(global::System.IntPtr pcStr);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="wcslcat")]
        public static extern uint wcslcat0(global::System.IntPtr wcDst, global::System.IntPtr wcSrc, uint siz);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="wcslcpy")]
        public static extern uint wcslcpy0(global::System.IntPtr wcDst, global::System.IntPtr wcSrc, uint siz);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="atoff")]
        public static extern float atoff0(global::System.IntPtr pstr);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="ecvtf")]
        public static extern global::System.IntPtr ecvtf0(float fval, int ndigit, global::System.IntPtr decpt, global::System.IntPtr sign);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="ecvtbuf")]
        public static extern global::System.IntPtr ecvtbuf0(double invalue, int ndigit, global::System.IntPtr decpt, global::System.IntPtr sign, global::System.IntPtr ecvt_buf);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="fcvtf")]
        public static extern global::System.IntPtr fcvtf0(float fval, int ndigit, global::System.IntPtr decpt, global::System.IntPtr sign);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="fcvtbuf")]
        public static extern global::System.IntPtr fcvtbuf0(double invalue, int ndigit, global::System.IntPtr decpt, global::System.IntPtr sign, global::System.IntPtr fcvt_buf);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="gcvtf")]
        public static extern global::System.IntPtr gcvtf0(float fval, int ndigit, global::System.IntPtr buf);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="reallocf")]
        public static extern global::System.IntPtr reallocf0(global::System.IntPtr pstr, uint size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="asnprintf")]
        public static extern global::System.IntPtr asnprintf0(global::System.IntPtr buf, global::System.IntPtr lenp, global::System.IntPtr format);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="asiprintf")]
        public static extern int asiprintf0(global::System.IntPtr strp, global::System.IntPtr fmt0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="asniprintf")]
        public static extern global::System.IntPtr asniprintf0(global::System.IntPtr buf, global::System.IntPtr lenp, global::System.IntPtr fmt0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="iprintf")]
        public static extern int iprintf0(global::System.IntPtr fmt0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="fiprintf")]
        public static extern int fiprintf0(_IO_FILE.Internal fp, global::System.IntPtr fmt0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="siprintf")]
        public static extern int siprintf0(global::System.IntPtr str, global::System.IntPtr fmt0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="sniprintf")]
        public static extern int sniprintf0(global::System.IntPtr str, uint size, global::System.IntPtr fmt0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="diprintf")]
        public static extern int diprintf0(int fd, global::System.IntPtr fmt0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="siscanf")]
        public static extern int siscanf0(global::System.IntPtr str, global::System.IntPtr fmt0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="fiscanf")]
        public static extern int fiscanf0(_IO_FILE.Internal fp, global::System.IntPtr fmt0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="fropen")]
        public static extern _IO_FILE.Internal fropen0(global::System.IntPtr cookie, global::System.IntPtr readfn);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("libosp-appfw.so.1.2.1", CallingConvention = CallingConvention.Cdecl,
            EntryPoint="fwopen")]
        public static extern _IO_FILE.Internal fwopen0(global::System.IntPtr cookie, global::System.IntPtr writefn);
    }

    public static global::System.IntPtr strlwr(global::System.IntPtr pcStr)
    {
        var arg0 = Marshal.StringToHGlobalAnsi(pcStr);
        var ret = Internal.strlwr0(arg0);
        Marshal.FreeHGlobal(arg0);
        return ret;
    }

    public static global::System.IntPtr strupr(global::System.IntPtr pcStr)
    {
        var arg0 = Marshal.StringToHGlobalAnsi(pcStr);
        var ret = Internal.strupr0(arg0);
        Marshal.FreeHGlobal(arg0);
        return ret;
    }

    public static uint wcslcat(global::System.IntPtr wcDst, global::System.IntPtr wcSrc, uint siz)
    {
        var arg0 = Marshal.StringToHGlobalAnsi(wcDst);
        var arg1 = Marshal.StringToHGlobalAnsi(wcSrc);
        var arg2 = siz;
        var ret = Internal.wcslcat0(arg0, arg1, arg2);
        Marshal.FreeHGlobal(arg0);
        Marshal.FreeHGlobal(arg1);
        return ret;
    }

    public static uint wcslcpy(global::System.IntPtr wcDst, global::System.IntPtr wcSrc, uint siz)
    {
        var arg0 = Marshal.StringToHGlobalAnsi(wcDst);
        var arg1 = Marshal.StringToHGlobalAnsi(wcSrc);
        var arg2 = siz;
        var ret = Internal.wcslcpy0(arg0, arg1, arg2);
        Marshal.FreeHGlobal(arg0);
        Marshal.FreeHGlobal(arg1);
        return ret;
    }

    public static float atoff(string pstr)
    {
        var arg0 = Marshal.StringToHGlobalAnsi(pstr);
        var ret = Internal.atoff0(arg0);
        Marshal.FreeHGlobal(arg0);
        return ret;
    }

    public static global::System.IntPtr ecvtf(float fval, int ndigit, global::System.IntPtr decpt, global::System.IntPtr sign)
    {
        var arg2 = decpt;
        var arg3 = sign;
        var ret = Internal.ecvtf0(fval, ndigit, arg2, arg3);
        return ret;
    }

    public static global::System.IntPtr ecvtbuf(double invalue, int ndigit, global::System.IntPtr decpt, global::System.IntPtr sign, global::System.IntPtr ecvt_buf)
    {
        var arg2 = decpt;
        var arg3 = sign;
        var arg4 = Marshal.StringToHGlobalAnsi(ecvt_buf);
        var ret = Internal.ecvtbuf0(invalue, ndigit, arg2, arg3, arg4);
        Marshal.FreeHGlobal(arg4);
        return ret;
    }

    public static global::System.IntPtr fcvtf(float fval, int ndigit, global::System.IntPtr decpt, global::System.IntPtr sign)
    {
        var arg2 = decpt;
        var arg3 = sign;
        var ret = Internal.fcvtf0(fval, ndigit, arg2, arg3);
        return ret;
    }

    public static global::System.IntPtr fcvtbuf(double invalue, int ndigit, global::System.IntPtr decpt, global::System.IntPtr sign, global::System.IntPtr fcvt_buf)
    {
        var arg2 = decpt;
        var arg3 = sign;
        var arg4 = Marshal.StringToHGlobalAnsi(fcvt_buf);
        var ret = Internal.fcvtbuf0(invalue, ndigit, arg2, arg3, arg4);
        Marshal.FreeHGlobal(arg4);
        return ret;
    }

    public static global::System.IntPtr gcvtf(float fval, int ndigit, global::System.IntPtr buf)
    {
        var arg2 = Marshal.StringToHGlobalAnsi(buf);
        var ret = Internal.gcvtf0(fval, ndigit, arg2);
        Marshal.FreeHGlobal(arg2);
        return ret;
    }

    public static global::System.IntPtr reallocf(global::System.IntPtr pstr, uint size)
    {
        var arg0 = pstr;
        var ret = Internal.reallocf0(arg0, size);
        return ret;
    }

    public static global::System.IntPtr asnprintf(global::System.IntPtr buf, global::System.IntPtr lenp, string format)
    {
        var arg0 = Marshal.StringToHGlobalAnsi(buf);
        var arg1 = lenp;
        var arg2 = Marshal.StringToHGlobalAnsi(format);
        var ret = Internal.asnprintf0(arg0, arg1, arg2);
        Marshal.FreeHGlobal(arg0);
        Marshal.FreeHGlobal(arg2);
        return ret;
    }

    public static int asiprintf(global::System.IntPtr strp, string fmt0)
    {
        var arg0 = Marshal.StringToHGlobalAnsi(strp);
        var arg1 = Marshal.StringToHGlobalAnsi(fmt0);
        var ret = Internal.asiprintf0(arg0, arg1);
        Marshal.FreeHGlobal(arg0);
        Marshal.FreeHGlobal(arg1);
        return ret;
    }

    public static global::System.IntPtr asniprintf(global::System.IntPtr buf, global::System.IntPtr lenp, string fmt0)
    {
        var arg0 = Marshal.StringToHGlobalAnsi(buf);
        var arg1 = lenp;
        var arg2 = Marshal.StringToHGlobalAnsi(fmt0);
        var ret = Internal.asniprintf0(arg0, arg1, arg2);
        Marshal.FreeHGlobal(arg0);
        Marshal.FreeHGlobal(arg2);
        return ret;
    }

    public static int iprintf(string fmt0)
    {
        var arg0 = Marshal.StringToHGlobalAnsi(fmt0);
        var ret = Internal.iprintf0(arg0);
        Marshal.FreeHGlobal(arg0);
        return ret;
    }

    public static int fiprintf(_IO_FILE fp, string fmt0)
    {
        var arg0 = fp._Instance;
        var arg1 = Marshal.StringToHGlobalAnsi(fmt0);
        var ret = Internal.fiprintf0(arg0, arg1);
        Marshal.FreeHGlobal(arg1);
        return ret;
    }

    public static int siprintf(global::System.IntPtr str, string fmt0)
    {
        var arg0 = Marshal.StringToHGlobalAnsi(str);
        var arg1 = Marshal.StringToHGlobalAnsi(fmt0);
        var ret = Internal.siprintf0(arg0, arg1);
        Marshal.FreeHGlobal(arg0);
        Marshal.FreeHGlobal(arg1);
        return ret;
    }

    public static int sniprintf(global::System.IntPtr str, uint size, string fmt0)
    {
        var arg0 = Marshal.StringToHGlobalAnsi(str);
        var arg1 = size;
        var arg2 = Marshal.StringToHGlobalAnsi(fmt0);
        var ret = Internal.sniprintf0(arg0, arg1, arg2);
        Marshal.FreeHGlobal(arg0);
        Marshal.FreeHGlobal(arg2);
        return ret;
    }

    public static int diprintf(int fd, string fmt0)
    {
        var arg1 = Marshal.StringToHGlobalAnsi(fmt0);
        var ret = Internal.diprintf0(fd, arg1);
        Marshal.FreeHGlobal(arg1);
        return ret;
    }

    public static int siscanf(string str, string fmt0)
    {
        var arg0 = Marshal.StringToHGlobalAnsi(str);
        var arg1 = Marshal.StringToHGlobalAnsi(fmt0);
        var ret = Internal.siscanf0(arg0, arg1);
        Marshal.FreeHGlobal(arg0);
        Marshal.FreeHGlobal(arg1);
        return ret;
    }

    public static int fiscanf(_IO_FILE fp, string fmt0)
    {
        var arg0 = fp._Instance;
        var arg1 = Marshal.StringToHGlobalAnsi(fmt0);
        var ret = Internal.fiscanf0(arg0, arg1);
        Marshal.FreeHGlobal(arg1);
        return ret;
    }

    public static _IO_FILE fropen(global::System.IntPtr cookie, funread readfn)
    {
        var arg0 = cookie;
        var arg1 = Marshal.GetFunctionPointerForDelegate(readfn);
        var ret = Internal.fropen0(arg0, arg1);
        return new _IO_FILE(ret);
    }

    public static _IO_FILE fwopen(global::System.IntPtr cookie, funwrite writefn)
    {
        var arg0 = cookie;
        var arg1 = Marshal.GetFunctionPointerForDelegate(writefn);
        var ret = Internal.fwopen0(arg0, arg1);
        return new _IO_FILE(ret);
    }
}

namespace Tizen
{
    namespace Base
    {
    }

    namespace Net
    {
        namespace Sockets
        {
        }

        namespace Wifi
        {
        }
    }
}