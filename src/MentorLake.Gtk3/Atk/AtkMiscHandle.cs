namespace MentorLake.Atk;

public class AtkMiscHandle : GObjectHandle
{
	public static MentorLake.Atk.AtkMiscHandle GetInstance()
	{
		return AtkMiscHandleExterns.atk_misc_get_instance();
	}

}

public static class AtkMiscHandleExtensions
{
	public static T ThreadsEnter<T>(this T misc) where T : AtkMiscHandle
	{
		AtkMiscHandleExterns.atk_misc_threads_enter(misc);
		return misc;
	}

	public static T ThreadsLeave<T>(this T misc) where T : AtkMiscHandle
	{
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
	internal static extern MentorLake.Atk.AtkMiscHandle atk_misc_get_instance();

}
