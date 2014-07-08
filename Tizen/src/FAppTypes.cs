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
        public enum AppState : uint
        {
            /// <summary>The application has been launched</summary>
            INITIALIZING = 0,
            /// <summary>The application has been initialized and is currently being executed</summary>
            RUNNING = 1,
            /// <summary>The application is about to exit and releases its resources and saves its preferences</summary>
            TERMINATING = 2,
            /// <summary>The application has been destroyed</summary>
            TERMINATED = 3
        }

        [Flags]
        public enum AppUiState : uint
        {
            /// <summary>The application is completely visible on foreground</summary>
            APP_UI_STATE_FOREGROUND = 0x1,
            /// <summary>The application is partially hidden by another window, such as a system pop-up</summary>
            APP_UI_STATE_PARTIAL_BACKGROUND = 0x2,
            /// <summary>The application is completely hidden by a full-screen window, usually by another application or an application control</summary>
            APP_UI_STATE_BACKGROUND = 0x4
        }

        [Flags]
        public enum AppCtrlResult : uint
        {
            /// <summary>The application operation is successful</summary>
            APP_CTRL_RESULT_SUCCEEDED = 0x0,
            /// <summary>The application operation has failed</summary>
            APP_CTRL_RESULT_FAILED = 0x1,
            /// <summary>The application operation is canceled by the callee application</summary>
            APP_CTRL_RESULT_CANCELED = 0x2,
            /// <summary>The callee application is terminated without sending the result</summary>
            APP_CTRL_RESULT_TERMINATED = 0x4,
            /// <summary>The application operation is aborted by the platform</summary>
            APP_CTRL_RESULT_ABORTED = 0x8
        }
    }
}