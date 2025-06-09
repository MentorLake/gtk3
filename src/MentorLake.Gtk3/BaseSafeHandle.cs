using Microsoft.Win32.SafeHandles;

namespace MentorLake.Gtk3;

public class BaseSafeHandle() : SafeHandleZeroOrMinusOneIsInvalid(true)
{
	private Action<object> _releaseAction;
	private object _state;
	private bool _released;

	protected override bool ReleaseHandle()
	{
		if (_released)
		{
			Console.WriteLine("WARNING: Released more than once! " + this.GetType().FullName);
			return true;
		}

		if (_state == null)
		{
			Console.WriteLine("State was null!!! " + this.GetType().FullName);
			return true;
		}

		_released = true;

		if (_releaseAction != null)
		{
			_releaseAction(_state);
		}

		SetHandle(IntPtr.Zero);
		return true;
	}

	public virtual void AddReleaseAction(Action<object> releaseAction, object state)
	{
		_state = state;
		_releaseAction = releaseAction;
	}

	public static bool operator ==(BaseSafeHandle left, BaseSafeHandle right)
	{
		if (ReferenceEquals(left, null) && ReferenceEquals(right, null))
			return true;
		if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
			return false;

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

	~BaseSafeHandle()
	{
		Dispose();
	}
}
