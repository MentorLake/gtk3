namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDebugController` is an interface to expose control of debugging features and
/// debug output.
/// </para>
/// <para>
/// It is implemented on Linux using [class@Gio.DebugControllerDBus], which
/// exposes a D-Bus interface to allow authenticated peers to control debug
/// features in this process.
/// </para>
/// <para>
/// Whether debug output is enabled is exposed as
/// [property@Gio.DebugController:debug-enabled]. This controls
/// [func@GLib.log_set_debug_enabled] by default. Application code may
/// connect to the [signal@GObject.Object::notify] signal for it
/// to control other parts of its debug infrastructure as necessary.
/// </para>
/// <para>
/// If your application or service is using the default GLib log writer function,
/// creating one of the built-in implementations of `GDebugController` should be
/// all that’s needed to dynamically enable or disable debug output.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Get the value of #GDebugController:debug-enabled.
/// </para>
/// </summary>

/// <param name="self">
/// a #GDebugController
/// </param>
/// <return>
/// %TRUE if debug output should be exposed, %FALSE otherwise
/// </return>

	public static bool GetDebugEnabled(this MentorLake.Gio.GDebugControllerHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GDebugControllerHandle)");
		return GDebugControllerHandleExterns.g_debug_controller_get_debug_enabled(self);
	}

/// <summary>
/// <para>
/// Set the value of #GDebugController:debug-enabled.
/// </para>
/// </summary>

/// <param name="self">
/// a #GDebugController
/// </param>
/// <param name="debug_enabled">
/// %TRUE if debug output should be exposed, %FALSE otherwise
/// </param>

	public static T SetDebugEnabled<T>(this T self, bool debug_enabled) where T : GDebugControllerHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GDebugControllerHandle)");
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
