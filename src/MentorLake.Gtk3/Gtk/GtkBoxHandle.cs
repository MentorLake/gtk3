namespace MentorLake.Gtk;

public class GtkBoxHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkBoxHandle New(MentorLake.Gtk.GtkOrientation orientation, int spacing)
	{
		return GtkBoxHandleExterns.gtk_box_new(orientation, spacing);
	}

}

public static class GtkBoxHandleExtensions
{
	public static MentorLake.Gtk.GtkBaselinePosition GetBaselinePosition(this MentorLake.Gtk.GtkBoxHandle box)
	{
		return GtkBoxHandleExterns.gtk_box_get_baseline_position(box);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetCenterWidget(this MentorLake.Gtk.GtkBoxHandle box)
	{
		return GtkBoxHandleExterns.gtk_box_get_center_widget(box);
	}

	public static bool GetHomogeneous(this MentorLake.Gtk.GtkBoxHandle box)
	{
		return GtkBoxHandleExterns.gtk_box_get_homogeneous(box);
	}

	public static int GetSpacing(this MentorLake.Gtk.GtkBoxHandle box)
	{
		return GtkBoxHandleExterns.gtk_box_get_spacing(box);
	}

	public static T PackEnd<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child, bool expand, bool fill, uint padding) where T : GtkBoxHandle
	{
		GtkBoxHandleExterns.gtk_box_pack_end(box, child, expand, fill, padding);
		return box;
	}

	public static T PackStart<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child, bool expand, bool fill, uint padding) where T : GtkBoxHandle
	{
		GtkBoxHandleExterns.gtk_box_pack_start(box, child, expand, fill, padding);
		return box;
	}

	public static T QueryChildPacking<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child, out bool expand, out bool fill, out uint padding, out MentorLake.Gtk.GtkPackType pack_type) where T : GtkBoxHandle
	{
		GtkBoxHandleExterns.gtk_box_query_child_packing(box, child, out expand, out fill, out padding, out pack_type);
		return box;
	}

	public static T ReorderChild<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child, int position) where T : GtkBoxHandle
	{
		GtkBoxHandleExterns.gtk_box_reorder_child(box, child, position);
		return box;
	}

	public static T SetBaselinePosition<T>(this T box, MentorLake.Gtk.GtkBaselinePosition position) where T : GtkBoxHandle
	{
		GtkBoxHandleExterns.gtk_box_set_baseline_position(box, position);
		return box;
	}

	public static T SetCenterWidget<T>(this T box, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkBoxHandle
	{
		GtkBoxHandleExterns.gtk_box_set_center_widget(box, widget);
		return box;
	}

	public static T SetChildPacking<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child, bool expand, bool fill, uint padding, MentorLake.Gtk.GtkPackType pack_type) where T : GtkBoxHandle
	{
		GtkBoxHandleExterns.gtk_box_set_child_packing(box, child, expand, fill, padding, pack_type);
		return box;
	}

	public static T SetHomogeneous<T>(this T box, bool homogeneous) where T : GtkBoxHandle
	{
		GtkBoxHandleExterns.gtk_box_set_homogeneous(box, homogeneous);
		return box;
	}

	public static T SetSpacing<T>(this T box, int spacing) where T : GtkBoxHandle
	{
		GtkBoxHandleExterns.gtk_box_set_spacing(box, spacing);
		return box;
	}

}

internal class GtkBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBoxHandle gtk_box_new(MentorLake.Gtk.GtkOrientation orientation, int spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBaselinePosition gtk_box_get_baseline_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_box_get_center_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_box_get_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_box_get_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_box_pack_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool expand, bool fill, uint padding);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_box_pack_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool expand, bool fill, uint padding);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_box_query_child_packing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, out bool expand, out bool fill, out uint padding, out MentorLake.Gtk.GtkPackType pack_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_box_reorder_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_box_set_baseline_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box, MentorLake.Gtk.GtkBaselinePosition position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_box_set_center_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_box_set_child_packing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool expand, bool fill, uint padding, MentorLake.Gtk.GtkPackType pack_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_box_set_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box, bool homogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_box_set_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box, int spacing);

}
