using Microsoft.Win32.SafeHandles;

namespace MentorLake.Gtk3;

public class BaseSafeHandle() : SafeHandleZeroOrMinusOneIsInvalid(true)
{
	protected override bool ReleaseHandle()
	{
		SetHandle(IntPtr.Zero);
		return true;
	}

	public static bool operator ==(BaseSafeHandle left, BaseSafeHandle right)
	{
		if (ReferenceEquals(left, null) && ReferenceEquals(right, null))
			return true;
		if (!ReferenceEquals(left, null) && ReferenceEquals(right, null))
			return left.IsInvalid;
		if (ReferenceEquals(left, null) && !ReferenceEquals(right, null))
			return right.IsInvalid;

		return left.DangerousGetHandle() == right.DangerousGetHandle();
	}

	public static bool operator !=(BaseSafeHandle left, BaseSafeHandle right)
	{
		return !(left == right);
	}

	public override bool Equals(object obj)
	{
		if (obj is BaseSafeHandle other)
		{
			return this == other;
		}

		return false;
	}

	public override int GetHashCode()
	{
		return DangerousGetHandle().GetHashCode();
	}
}
