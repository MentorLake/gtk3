using Microsoft.Win32.SafeHandles;

namespace MentorLake.Gtk3;

public class BaseSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	public BaseSafeHandle() : base(true) { }

	protected override bool ReleaseHandle() => true;
}
