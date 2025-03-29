namespace MentorLake.Gio;

public interface GDebugControllerHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GDebugControllerHandleImpl : BaseSafeHandle, GDebugControllerHandle
{
}

public static class GDebugControllerHandleExtensions
{
	public static bool GetDebugEnabled(this MentorLake.Gio.GDebugControllerHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GDebugControllerHandle)");
		return GDebugControllerHandleExterns.g_debug_controller_get_debug_enabled(self);
	}

	public static T SetDebugEnabled<T>(this T self, bool debug_enabled) where T : GDebugControllerHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GDebugControllerHandle)");
		GDebugControllerHandleExterns.g_debug_controller_set_debug_enabled(self, debug_enabled);
		return self;
	}

}

internal class GDebugControllerHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_debug_controller_get_debug_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDebugControllerHandleImpl>))] MentorLake.Gio.GDebugControllerHandle self);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_debug_controller_set_debug_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDebugControllerHandleImpl>))] MentorLake.Gio.GDebugControllerHandle self, bool debug_enabled);

}
