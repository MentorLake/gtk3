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
	public static AtkMiscHandle ThreadsEnter(this AtkMiscHandle misc)
	{
		AtkMiscExterns.atk_misc_threads_enter(misc);
		return misc;
	}

	public static AtkMiscHandle ThreadsLeave(this AtkMiscHandle misc)
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
