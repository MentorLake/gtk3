namespace MentorLake.Gtk;

public interface GtkActionableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkActionableHandleImpl : BaseSafeHandle, GtkActionableHandle
{
}

public static class GtkActionableHandleExtensions
{
	public static string GetActionName(this MentorLake.Gtk.GtkActionableHandle actionable)
	{
		if (actionable.IsInvalid) throw new Exception("Invalid handle (GtkActionableHandle)");
		return GtkActionableHandleExterns.gtk_actionable_get_action_name(actionable);
	}

	public static MentorLake.GLib.GVariantHandle GetActionTargetValue(this MentorLake.Gtk.GtkActionableHandle actionable)
	{
		if (actionable.IsInvalid) throw new Exception("Invalid handle (GtkActionableHandle)");
		return GtkActionableHandleExterns.gtk_actionable_get_action_target_value(actionable);
	}

	public static T SetActionName<T>(this T actionable, string action_name) where T : GtkActionableHandle
	{
		if (actionable.IsInvalid) throw new Exception("Invalid handle (GtkActionableHandle)");
		GtkActionableHandleExterns.gtk_actionable_set_action_name(actionable, action_name);
		return actionable;
	}

	public static T SetActionTarget<T>(this T actionable, string format_string, IntPtr @__arglist) where T : GtkActionableHandle
	{
		if (actionable.IsInvalid) throw new Exception("Invalid handle (GtkActionableHandle)");
		GtkActionableHandleExterns.gtk_actionable_set_action_target(actionable, format_string, @__arglist);
		return actionable;
	}

	public static T SetActionTargetValue<T>(this T actionable, MentorLake.GLib.GVariantHandle target_value) where T : GtkActionableHandle
	{
		if (actionable.IsInvalid) throw new Exception("Invalid handle (GtkActionableHandle)");
		GtkActionableHandleExterns.gtk_actionable_set_action_target_value(actionable, target_value);
		return actionable;
	}

	public static T SetDetailedActionName<T>(this T actionable, string detailed_action_name) where T : GtkActionableHandle
	{
		if (actionable.IsInvalid) throw new Exception("Invalid handle (GtkActionableHandle)");
		GtkActionableHandleExterns.gtk_actionable_set_detailed_action_name(actionable, detailed_action_name);
		return actionable;
	}

}

internal class GtkActionableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_actionable_get_action_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionableHandleImpl>))] MentorLake.Gtk.GtkActionableHandle actionable);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle gtk_actionable_get_action_target_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionableHandleImpl>))] MentorLake.Gtk.GtkActionableHandle actionable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_actionable_set_action_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionableHandleImpl>))] MentorLake.Gtk.GtkActionableHandle actionable, string action_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_actionable_set_action_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionableHandleImpl>))] MentorLake.Gtk.GtkActionableHandle actionable, string format_string, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_actionable_set_action_target_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionableHandleImpl>))] MentorLake.Gtk.GtkActionableHandle actionable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle target_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_actionable_set_detailed_action_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionableHandleImpl>))] MentorLake.Gtk.GtkActionableHandle actionable, string detailed_action_name);

}
