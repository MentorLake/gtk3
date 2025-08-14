namespace MentorLake.Atk;

/// <summary>
/// <para>
/// A set of ATK utility functions for thread locking
/// </para>
/// <para>
/// A set of utility functions for thread locking. This interface and
/// all his related methods are deprecated since 2.12.
/// </para>
/// </summary>

public class AtkMiscHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Obtain the singleton instance of AtkMisc for this application.
/// </para>
/// </summary>

/// <return>
/// The singleton instance of AtkMisc for this application.
/// </return>

	public static MentorLake.Atk.AtkMiscHandle GetInstance()
	{
		return AtkMiscHandleExterns.atk_misc_get_instance();
	}

}

public static class AtkMiscHandleExtensions
{
/// <summary>
/// <para>
/// Take the thread mutex for the GUI toolkit,
/// if one exists.
/// (This method is implemented by the toolkit ATK implementation layer;
///  for instance, for GTK+, GAIL implements this via GDK_THREADS_ENTER).
/// </para>
/// </summary>

/// <param name="misc">
/// an AtkMisc instance for this application.
/// </param>

	public static T ThreadsEnter<T>(this T misc) where T : AtkMiscHandle
	{
		if (misc.IsInvalid) throw new Exception("Invalid handle (AtkMiscHandle)");
		AtkMiscHandleExterns.atk_misc_threads_enter(misc);
		return misc;
	}

/// <summary>
/// <para>
/// Release the thread mutex for the GUI toolkit,
/// if one exists. This method, and atk_misc_threads_enter,
/// are needed in some situations by threaded application code which
/// services ATK requests, since fulfilling ATK requests often
/// requires calling into the GUI toolkit.  If a long-running or
/// potentially blocking call takes place inside such a block, it should
/// be bracketed by atk_misc_threads_leave/atk_misc_threads_enter calls.
/// (This method is implemented by the toolkit ATK implementation layer;
///  for instance, for GTK+, GAIL implements this via GDK_THREADS_LEAVE).
/// </para>
/// </summary>

/// <param name="misc">
/// an AtkMisc instance for this application.
/// </param>

	public static T ThreadsLeave<T>(this T misc) where T : AtkMiscHandle
	{
		if (misc.IsInvalid) throw new Exception("Invalid handle (AtkMiscHandle)");
		AtkMiscHandleExterns.atk_misc_threads_leave(misc);
		return misc;
	}

}

internal class AtkMiscHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_misc_threads_enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkMiscHandle>))] MentorLake.Atk.AtkMiscHandle misc);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_misc_threads_leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkMiscHandle>))] MentorLake.Atk.AtkMiscHandle misc);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkMiscHandle>))]
	internal static extern MentorLake.Atk.AtkMiscHandle atk_misc_get_instance();

}
