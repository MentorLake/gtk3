namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkCellAreaBox renders cell renderers into a row or a column
/// depending on its #GtkOrientation.
/// </para>
/// <para>
/// GtkCellAreaBox uses a notion of packing. Packing
/// refers to adding cell renderers with reference to a particular position
/// in a #GtkCellAreaBox. There are two reference positions: the
/// start and the end of the box.
/// When the #GtkCellAreaBox is oriented in the %GTK_ORIENTATION_VERTICAL
/// orientation, the start is defined as the top of the box and the end is
/// defined as the bottom. In the %GTK_ORIENTATION_HORIZONTAL orientation
/// start is defined as the left side and the end is defined as the right
/// side.
/// </para>
/// <para>
/// Alignments of #GtkCellRenderers rendered in adjacent rows can be
/// configured by configuring the #GtkCellAreaBox align child cell property
/// with gtk_cell_area_cell_set_property() or by specifying the &quot;align&quot;
/// argument to gtk_cell_area_box_pack_start() and gtk_cell_area_box_pack_end().
/// </para>
/// </summary>

public class GtkCellAreaBoxHandle : GtkCellAreaHandle, GtkBuildableHandle, GtkCellLayoutHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkCellAreaBox.
/// </para>
/// </summary>

/// <return>
/// a newly created #GtkCellAreaBox
/// </return>

	public static MentorLake.Gtk.GtkCellAreaBoxHandle New()
	{
		return GtkCellAreaBoxHandleExterns.gtk_cell_area_box_new();
	}

}

public static class GtkCellAreaBoxHandleExtensions
{
/// <summary>
/// <para>
/// Gets the spacing added between cell renderers.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkCellAreaBox
/// </param>
/// <return>
/// the space added between cell renderers in @box.
/// </return>

	public static int GetSpacing(this MentorLake.Gtk.GtkCellAreaBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaBoxHandle)");
		return GtkCellAreaBoxHandleExterns.gtk_cell_area_box_get_spacing(box);
	}

/// <summary>
/// <para>
/// Adds @renderer to @box, packed with reference to the end of @box.
/// </para>
/// <para>
/// The @renderer is packed after (away from end of) any other
/// #GtkCellRenderer packed with reference to the end of @box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkCellAreaBox
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer to add
/// </param>
/// <param name="expand">
/// whether @renderer should receive extra space when the area receives
/// more than its natural size
/// </param>
/// <param name="align">
/// whether @renderer should be aligned in adjacent rows
/// </param>
/// <param name="@fixed">
/// whether @renderer should have the same size in all rows
/// </param>

	public static T PackEnd<T>(this T box, MentorLake.Gtk.GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed) where T : GtkCellAreaBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaBoxHandle)");
		GtkCellAreaBoxHandleExterns.gtk_cell_area_box_pack_end(box, renderer, expand, align, @fixed);
		return box;
	}

/// <summary>
/// <para>
/// Adds @renderer to @box, packed with reference to the start of @box.
/// </para>
/// <para>
/// The @renderer is packed after any other #GtkCellRenderer packed
/// with reference to the start of @box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkCellAreaBox
/// </param>
/// <param name="renderer">
/// the #GtkCellRenderer to add
/// </param>
/// <param name="expand">
/// whether @renderer should receive extra space when the area receives
/// more than its natural size
/// </param>
/// <param name="align">
/// whether @renderer should be aligned in adjacent rows
/// </param>
/// <param name="@fixed">
/// whether @renderer should have the same size in all rows
/// </param>

	public static T PackStart<T>(this T box, MentorLake.Gtk.GtkCellRendererHandle renderer, bool expand, bool align, bool @fixed) where T : GtkCellAreaBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaBoxHandle)");
		GtkCellAreaBoxHandleExterns.gtk_cell_area_box_pack_start(box, renderer, expand, align, @fixed);
		return box;
	}

/// <summary>
/// <para>
/// Sets the spacing to add between cell renderers in @box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkCellAreaBox
/// </param>
/// <param name="spacing">
/// the space to add between #GtkCellRenderers
/// </param>

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
