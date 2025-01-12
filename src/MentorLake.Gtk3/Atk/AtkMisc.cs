namespace MentorLake.Gtk3.Atk;

public class AtkMiscHandle : GObjectHandle
{
	public static AtkMiscHandle GetInstance()
	{
		return AtkMiscExterns.atk_misc_get_instance();
	}

}

public static class AtkMiscHandleExtensions
{
	public static T ThreadsEnter<T>(this T misc) where T : AtkMiscHandle
	{
		AtkMiscExterns.atk_misc_threads_enter(misc);
		return misc;
	}

	public static T ThreadsLeave<T>(this T misc) where T : AtkMiscHandle
	{
		AtkMiscExterns.atk_misc_threads_leave(misc);
		return misc;
	}

}

internal class AtkMiscExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern void atk_misc_threads_enter(AtkMiscHandle misc);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_misc_threads_leave(AtkMiscHandle misc);

	[DllImport(Libraries.Atk)]
	internal static extern AtkMiscHandle atk_misc_get_instance();

}
