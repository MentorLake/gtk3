namespace MentorLake.Gtk;

public interface GtkActivatableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkActivatableHandleImpl : BaseSafeHandle, GtkActivatableHandle
{
}

public static class GtkActivatableHandleExtensions
{
	public static T DoSetRelatedAction<T>(this T activatable, MentorLake.Gtk.GtkActionHandle action) where T : GtkActivatableHandle
	{
		if (activatable.IsInvalid || activatable.IsClosed) throw new Exception("Invalid or closed handle (GtkActivatableHandle)");
		GtkActivatableHandleExterns.gtk_activatable_do_set_related_action(activatable, action);
		return activatable;
	}

	public static MentorLake.Gtk.GtkActionHandle GetRelatedAction(this MentorLake.Gtk.GtkActivatableHandle activatable)
	{
		if (activatable.IsInvalid || activatable.IsClosed) throw new Exception("Invalid or closed handle (GtkActivatableHandle)");
		return GtkActivatableHandleExterns.gtk_activatable_get_related_action(activatable);
	}

	public static bool GetUseActionAppearance(this MentorLake.Gtk.GtkActivatableHandle activatable)
	{
		if (activatable.IsInvalid || activatable.IsClosed) throw new Exception("Invalid or closed handle (GtkActivatableHandle)");
		return GtkActivatableHandleExterns.gtk_activatable_get_use_action_appearance(activatable);
	}

	public static T SetRelatedAction<T>(this T activatable, MentorLake.Gtk.GtkActionHandle action) where T : GtkActivatableHandle
	{
		if (activatable.IsInvalid || activatable.IsClosed) throw new Exception("Invalid or closed handle (GtkActivatableHandle)");
		GtkActivatableHandleExterns.gtk_activatable_set_related_action(activatable, action);
		return activatable;
	}

	public static T SetUseActionAppearance<T>(this T activatable, bool use_appearance) where T : GtkActivatableHandle
	{
		if (activatable.IsInvalid || activatable.IsClosed) throw new Exception("Invalid or closed handle (GtkActivatableHandle)");
		GtkActivatableHandleExterns.gtk_activatable_set_use_action_appearance(activatable, use_appearance);
		return activatable;
	}

	public static T SyncActionProperties<T>(this T activatable, MentorLake.Gtk.GtkActionHandle action) where T : GtkActivatableHandle
	{
		if (activatable.IsInvalid || activatable.IsClosed) throw new Exception("Invalid or closed handle (GtkActivatableHandle)");
		GtkActivatableHandleExterns.gtk_activatable_sync_action_properties(activatable, action);
		return activatable;
	}

}

internal class GtkActivatableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_activatable_do_set_related_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActivatableHandleImpl>))] MentorLake.Gtk.GtkActivatableHandle activatable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkActionHandle gtk_activatable_get_related_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActivatableHandleImpl>))] MentorLake.Gtk.GtkActivatableHandle activatable);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_activatable_get_use_action_appearance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActivatableHandleImpl>))] MentorLake.Gtk.GtkActivatableHandle activatable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_activatable_set_related_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActivatableHandleImpl>))] MentorLake.Gtk.GtkActivatableHandle activatable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_activatable_set_use_action_appearance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActivatableHandleImpl>))] MentorLake.Gtk.GtkActivatableHandle activatable, bool use_appearance);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_activatable_sync_action_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActivatableHandleImpl>))] MentorLake.Gtk.GtkActivatableHandle activatable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

}
