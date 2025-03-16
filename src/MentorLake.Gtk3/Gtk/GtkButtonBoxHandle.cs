namespace MentorLake.Gtk;

public class GtkButtonBoxHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkButtonBoxHandle New(MentorLake.Gtk.GtkOrientation orientation)
	{
		return GtkButtonBoxHandleExterns.gtk_button_box_new(orientation);
	}

}

public static class GtkButtonBoxHandleExtensions
{
	public static bool GetChildNonHomogeneous(this MentorLake.Gtk.GtkButtonBoxHandle widget, MentorLake.Gtk.GtkWidgetHandle child)
	{
		return GtkButtonBoxHandleExterns.gtk_button_box_get_child_non_homogeneous(widget, child);
	}

	public static bool GetChildSecondary(this MentorLake.Gtk.GtkButtonBoxHandle widget, MentorLake.Gtk.GtkWidgetHandle child)
	{
		return GtkButtonBoxHandleExterns.gtk_button_box_get_child_secondary(widget, child);
	}

	public static MentorLake.Gtk.GtkButtonBoxStyle GetLayout(this MentorLake.Gtk.GtkButtonBoxHandle widget)
	{
		return GtkButtonBoxHandleExterns.gtk_button_box_get_layout(widget);
	}

	public static T SetChildNonHomogeneous<T>(this T widget, MentorLake.Gtk.GtkWidgetHandle child, bool non_homogeneous) where T : GtkButtonBoxHandle
	{
		GtkButtonBoxHandleExterns.gtk_button_box_set_child_non_homogeneous(widget, child, non_homogeneous);
		return widget;
	}

	public static T SetChildSecondary<T>(this T widget, MentorLake.Gtk.GtkWidgetHandle child, bool is_secondary) where T : GtkButtonBoxHandle
	{
		GtkButtonBoxHandleExterns.gtk_button_box_set_child_secondary(widget, child, is_secondary);
		return widget;
	}

	public static T SetLayout<T>(this T widget, MentorLake.Gtk.GtkButtonBoxStyle layout_style) where T : GtkButtonBoxHandle
	{
		GtkButtonBoxHandleExterns.gtk_button_box_set_layout(widget, layout_style);
		return widget;
	}

}

internal class GtkButtonBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkButtonBoxHandle gtk_button_box_new(MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_button_box_get_child_non_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))] MentorLake.Gtk.GtkButtonBoxHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_button_box_get_child_secondary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))] MentorLake.Gtk.GtkButtonBoxHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkButtonBoxStyle gtk_button_box_get_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))] MentorLake.Gtk.GtkButtonBoxHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_box_set_child_non_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))] MentorLake.Gtk.GtkButtonBoxHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool non_homogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_box_set_child_secondary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))] MentorLake.Gtk.GtkButtonBoxHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool is_secondary);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_box_set_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonBoxHandle>))] MentorLake.Gtk.GtkButtonBoxHandle widget, MentorLake.Gtk.GtkButtonBoxStyle layout_style);

}
