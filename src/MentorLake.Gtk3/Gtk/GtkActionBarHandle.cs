namespace MentorLake.Gtk;

public class GtkActionBarHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkActionBarHandle New()
	{
		return GtkActionBarHandleExterns.gtk_action_bar_new();
	}

}

public static class GtkActionBarHandleExtensions
{
	public static MentorLake.Gtk.GtkWidgetHandle GetCenterWidget(this MentorLake.Gtk.GtkActionBarHandle action_bar)
	{
		if (action_bar.IsInvalid) throw new Exception("Invalid handle (GtkActionBarHandle)");
		return GtkActionBarHandleExterns.gtk_action_bar_get_center_widget(action_bar);
	}

	public static T PackEnd<T>(this T action_bar, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkActionBarHandle
	{
		if (action_bar.IsInvalid) throw new Exception("Invalid handle (GtkActionBarHandle)");
		GtkActionBarHandleExterns.gtk_action_bar_pack_end(action_bar, child);
		return action_bar;
	}

	public static T PackStart<T>(this T action_bar, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkActionBarHandle
	{
		if (action_bar.IsInvalid) throw new Exception("Invalid handle (GtkActionBarHandle)");
		GtkActionBarHandleExterns.gtk_action_bar_pack_start(action_bar, child);
		return action_bar;
	}

	public static T SetCenterWidget<T>(this T action_bar, MentorLake.Gtk.GtkWidgetHandle center_widget) where T : GtkActionBarHandle
	{
		if (action_bar.IsInvalid) throw new Exception("Invalid handle (GtkActionBarHandle)");
		GtkActionBarHandleExterns.gtk_action_bar_set_center_widget(action_bar, center_widget);
		return action_bar;
	}

}

internal class GtkActionBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkActionBarHandle>))]
	internal static extern MentorLake.Gtk.GtkActionBarHandle gtk_action_bar_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_action_bar_get_center_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionBarHandle>))] MentorLake.Gtk.GtkActionBarHandle action_bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_bar_pack_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionBarHandle>))] MentorLake.Gtk.GtkActionBarHandle action_bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_bar_pack_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionBarHandle>))] MentorLake.Gtk.GtkActionBarHandle action_bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_bar_set_center_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionBarHandle>))] MentorLake.Gtk.GtkActionBarHandle action_bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle center_widget);

}
