namespace MentorLake.Gtk;

public class GtkCellAreaBoxHandle : GtkCellAreaHandle, GtkBuildableHandle, GtkCellLayoutHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkCellAreaBoxHandle New()
	{
		return GtkCellAreaBoxHandleExterns.gtk_cell_area_box_new();
	}

}

public static class GtkCellAreaBoxHandleExtensions
{
	public static int GetSpacing(this MentorLake.Gtk.GtkCellAreaBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaBoxHandle)");
		return GtkCellAreaBoxHandleExterns.gtk_cell_area_box_get_spacing(box);
	}

	public static T PackEnd<T>(this T box, MentorLake.Gtk.GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed) where T : GtkCellAreaBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaBoxHandle)");
		GtkCellAreaBoxHandleExterns.gtk_cell_area_box_pack_end(box, renderer, expand, align, @fixed);
		return box;
	}

	public static T PackStart<T>(this T box, MentorLake.Gtk.GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed) where T : GtkCellAreaBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaBoxHandle)");
		GtkCellAreaBoxHandleExterns.gtk_cell_area_box_pack_start(box, renderer, expand, align, @fixed);
		return box;
	}

	public static T SetSpacing<T>(this T box, int spacing) where T : GtkCellAreaBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaBoxHandle)");
		GtkCellAreaBoxHandleExterns.gtk_cell_area_box_set_spacing(box, spacing);
		return box;
	}

}

internal class GtkCellAreaBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkCellAreaBoxHandle gtk_cell_area_box_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_cell_area_box_get_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaBoxHandle>))] MentorLake.Gtk.GtkCellAreaBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_box_pack_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaBoxHandle>))] MentorLake.Gtk.GtkCellAreaBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_box_pack_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaBoxHandle>))] MentorLake.Gtk.GtkCellAreaBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_box_set_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaBoxHandle>))] MentorLake.Gtk.GtkCellAreaBoxHandle box, int spacing);

}
