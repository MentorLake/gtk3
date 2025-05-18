namespace MentorLake.Gtk;

public class GtkSizeGroupHandle : GObjectHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkSizeGroupHandle New(MentorLake.Gtk.GtkSizeGroupMode mode)
	{
		return GtkSizeGroupHandleExterns.gtk_size_group_new(mode);
	}

}

public static class GtkSizeGroupHandleExtensions
{
	public static T AddWidget<T>(this T size_group, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkSizeGroupHandle
	{
		if (size_group.IsInvalid) throw new Exception("Invalid handle (GtkSizeGroupHandle)");
		GtkSizeGroupHandleExterns.gtk_size_group_add_widget(size_group, widget);
		return size_group;
	}

	public static bool GetIgnoreHidden(this MentorLake.Gtk.GtkSizeGroupHandle size_group)
	{
		if (size_group.IsInvalid) throw new Exception("Invalid handle (GtkSizeGroupHandle)");
		return GtkSizeGroupHandleExterns.gtk_size_group_get_ignore_hidden(size_group);
	}

	public static MentorLake.Gtk.GtkSizeGroupMode GetMode(this MentorLake.Gtk.GtkSizeGroupHandle size_group)
	{
		if (size_group.IsInvalid) throw new Exception("Invalid handle (GtkSizeGroupHandle)");
		return GtkSizeGroupHandleExterns.gtk_size_group_get_mode(size_group);
	}

	public static MentorLake.GLib.GSListHandle GetWidgets(this MentorLake.Gtk.GtkSizeGroupHandle size_group)
	{
		if (size_group.IsInvalid) throw new Exception("Invalid handle (GtkSizeGroupHandle)");
		return GtkSizeGroupHandleExterns.gtk_size_group_get_widgets(size_group);
	}

	public static T RemoveWidget<T>(this T size_group, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkSizeGroupHandle
	{
		if (size_group.IsInvalid) throw new Exception("Invalid handle (GtkSizeGroupHandle)");
		GtkSizeGroupHandleExterns.gtk_size_group_remove_widget(size_group, widget);
		return size_group;
	}

	public static T SetIgnoreHidden<T>(this T size_group, bool ignore_hidden) where T : GtkSizeGroupHandle
	{
		if (size_group.IsInvalid) throw new Exception("Invalid handle (GtkSizeGroupHandle)");
		GtkSizeGroupHandleExterns.gtk_size_group_set_ignore_hidden(size_group, ignore_hidden);
		return size_group;
	}

	public static T SetMode<T>(this T size_group, MentorLake.Gtk.GtkSizeGroupMode mode) where T : GtkSizeGroupHandle
	{
		if (size_group.IsInvalid) throw new Exception("Invalid handle (GtkSizeGroupHandle)");
		GtkSizeGroupHandleExterns.gtk_size_group_set_mode(size_group, mode);
		return size_group;
	}

}

internal class GtkSizeGroupHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkSizeGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkSizeGroupHandle gtk_size_group_new(MentorLake.Gtk.GtkSizeGroupMode mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_size_group_add_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSizeGroupHandle>))] MentorLake.Gtk.GtkSizeGroupHandle size_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_size_group_get_ignore_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSizeGroupHandle>))] MentorLake.Gtk.GtkSizeGroupHandle size_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSizeGroupMode gtk_size_group_get_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSizeGroupHandle>))] MentorLake.Gtk.GtkSizeGroupHandle size_group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_size_group_get_widgets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSizeGroupHandle>))] MentorLake.Gtk.GtkSizeGroupHandle size_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_size_group_remove_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSizeGroupHandle>))] MentorLake.Gtk.GtkSizeGroupHandle size_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_size_group_set_ignore_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSizeGroupHandle>))] MentorLake.Gtk.GtkSizeGroupHandle size_group, bool ignore_hidden);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_size_group_set_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSizeGroupHandle>))] MentorLake.Gtk.GtkSizeGroupHandle size_group, MentorLake.Gtk.GtkSizeGroupMode mode);

}
