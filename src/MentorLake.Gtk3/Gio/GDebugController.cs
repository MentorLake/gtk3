namespace MentorLake.Gtk3.Gio;

public interface GDebugControllerHandle
{
}

internal class GDebugControllerHandleImpl : BaseSafeHandle, GDebugControllerHandle
{
}

public static class GDebugControllerHandleExtensions
{
	public static bool GetDebugEnabled(this GDebugControllerHandle self)
	{
		return GDebugControllerExterns.g_debug_controller_get_debug_enabled(self);
	}

	public static T SetDebugEnabled<T>(this T self, bool debug_enabled) where T : GDebugControllerHandle
	{
		GDebugControllerExterns.g_debug_controller_set_debug_enabled(self, debug_enabled);
		return self;
	}

}

internal class GDebugControllerExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_debug_controller_get_debug_enabled(GDebugControllerHandle self);

	[DllImport(Libraries.Gio)]
	internal static extern void g_debug_controller_set_debug_enabled(GDebugControllerHandle self, bool debug_enabled);

}
