namespace MentorLake.Gtk;

public class GtkAccessibleHandle : AtkObjectHandle
{
}

public static class GtkAccessibleHandleExtensions
{
	public static T ConnectWidgetDestroyed<T>(this T accessible) where T : GtkAccessibleHandle
	{
		GtkAccessibleHandleExterns.gtk_accessible_connect_widget_destroyed(accessible);
		return accessible;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetWidget(this MentorLake.Gtk.GtkAccessibleHandle accessible)
	{
		return GtkAccessibleHandleExterns.gtk_accessible_get_widget(accessible);
	}

	public static T SetWidget<T>(this T accessible, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkAccessibleHandle
	{
		GtkAccessibleHandleExterns.gtk_accessible_set_widget(accessible, widget);
		return accessible;
	}

}

internal class GtkAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accessible_connect_widget_destroyed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccessibleHandle>))] MentorLake.Gtk.GtkAccessibleHandle accessible);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_accessible_get_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccessibleHandle>))] MentorLake.Gtk.GtkAccessibleHandle accessible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accessible_set_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccessibleHandle>))] MentorLake.Gtk.GtkAccessibleHandle accessible, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

}
