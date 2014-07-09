using System;
using System.Runtime.InteropServices;

namespace Tizen.Ui.Controls
{
	public class Form : Container
	{
		private IntPtr formHandle;

		[DllImport ("__Internal",
			    EntryPoint="HelloTizenFormSetHeaderTitleText")]
		static extern void _SetHeaderTitleText(IntPtr formHandle, string text);

		public void SetNativeHandle (IntPtr formHandle)
		{
			this.formHandle = formHandle;
		}

		public void SetFormBackEventListener(IFormBackEventListener formBackEventListener)
		{
		}

		public void SetHeaderTitleText (string text)
		{
			_SetHeaderTitleText (formHandle, text);
		}
	}
}
