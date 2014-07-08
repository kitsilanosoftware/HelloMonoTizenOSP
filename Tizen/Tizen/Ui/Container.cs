
using Tizen;


namespace Tizen.Ui
{
	public class Container : Control
	{
		public override ulong Construct()
		{
			return Tizen.Constants.E_SUCCESS;
		}

		public Control GetControl(int index)
		{
			return null;
		}

		public Control GetControl(Base.String name, bool recursive=false)
		{
			return null;
		}
	}
}

