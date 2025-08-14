namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The GtkBox widget arranges child widgets into a single row or column,
/// depending upon the value of its #GtkOrientable:orientation property. Within
/// the other dimension, all children are allocated the same size. Of course,
/// the #GtkWidget:halign and #GtkWidget:valign properties can be used on
/// the children to influence their allocation.
/// </para>
/// <para>
/// GtkBox uses a notion of packing. Packing refers
/// to adding widgets with reference to a particular position in a
/// #GtkContainer. For a GtkBox, there are two reference positions: the
/// start and the end of the box.
/// For a vertical #GtkBox, the start is defined as the top of the box and
/// the end is defined as the bottom. For a horizontal #GtkBox the start
/// is defined as the left side and the end is defined as the right side.
/// </para>
/// <para>
/// Use repeated calls to gtk_box_pack_start() to pack widgets into a
/// GtkBox from start to end. Use gtk_box_pack_end() to add widgets from
/// end to start. You may intersperse these calls and add widgets from
/// both ends of the same GtkBox.
/// </para>
/// <para>
/// Because GtkBox is a #GtkContainer, you may also use gtk_container_add()
/// to insert widgets into the box, and they will be packed with the default
/// values for expand and fill child properties. Use gtk_container_remove()
/// to remove widgets from the GtkBox.
/// </para>
/// <para>
/// Use gtk_box_set_homogeneous() to specify whether or not all children
/// of the GtkBox are forced to get the same amount of space.
/// </para>
/// <para>
/// Use gtk_box_set_spacing() to determine how much space will be
/// minimally placed between all children in the GtkBox. Note that
/// spacing is added between the children, while
/// padding added by gtk_box_pack_start() or gtk_box_pack_end() is added
/// on either side of the widget it belongs to.
/// </para>
/// <para>
/// Use gtk_box_reorder_child() to move a GtkBox child to a different
/// place in the box.
/// </para>
/// <para>
/// Use gtk_box_set_child_packing() to reset the expand,
/// fill and padding child properties.
/// Use gtk_box_query_child_packing() to query these fields.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkBox uses a single CSS node with name box.
/// </para>
/// <para>
/// In horizontal orientation, the nodes of the children are always arranged
/// from left to right. So :first-child will always select the leftmost child,
/// regardless of text direction.
/// </para>
/// </summary>

public class GtkBoxHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkBox.
/// </para>
/// </summary>

/// <param name="orientation">
/// the box’s orientation.
/// </param>
/// <param name="spacing">
/// the number of pixels to place by default between children.
/// </param>
/// <return>
/// a new #GtkBox.
/// </return>

	public static MentorLake.Gtk.GtkBoxHandle New(MentorLake.Gtk.GtkOrientation orientation, int spacing)
	{
		return GtkBoxHandleExterns.gtk_box_new(orientation, spacing);
	}

}

public static class GtkBoxHandleExtensions
{
/// <summary>
/// <para>
/// Gets the value set by gtk_box_set_baseline_position().
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <return>
/// the baseline position
/// </return>

	public static MentorLake.Gtk.GtkBaselinePosition GetBaselinePosition(this MentorLake.Gtk.GtkBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		return GtkBoxHandleExterns.gtk_box_get_baseline_position(box);
	}

/// <summary>
/// <para>
/// Retrieves the center widget of the box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <return>
/// the center widget
///   or %NULL in case no center widget is set.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetCenterWidget(this MentorLake.Gtk.GtkBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		return GtkBoxHandleExterns.gtk_box_get_center_widget(box);
	}

/// <summary>
/// <para>
/// Returns whether the box is homogeneous (all children are the
/// same size). See gtk_box_set_homogeneous().
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <return>
/// %TRUE if the box is homogeneous.
/// </return>

	public static bool GetHomogeneous(this MentorLake.Gtk.GtkBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		return GtkBoxHandleExterns.gtk_box_get_homogeneous(box);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_box_set_spacing().
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <return>
/// spacing between children
/// </return>

	public static int GetSpacing(this MentorLake.Gtk.GtkBoxHandle box)
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		return GtkBoxHandleExterns.gtk_box_get_spacing(box);
	}

/// <summary>
/// <para>
/// Adds @child to @box, packed with reference to the end of @box.
/// The @child is packed after (away from end of) any other child
/// packed with reference to the end of @box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <param name="child">
/// the #GtkWidget to be added to @box
/// </param>
/// <param name="expand">
/// %TRUE if the new child is to be given extra space allocated
///   to @box. The extra space will be divided evenly between all children
///   of @box that use this option
/// </param>
/// <param name="fill">
/// %TRUE if space given to @child by the @expand option is
///   actually allocated to @child, rather than just padding it.  This
///   parameter has no effect if @expand is set to %FALSE.  A child is
///   always allocated the full height of a horizontal #GtkBox and the full width
///   of a vertical #GtkBox.  This option affects the other dimension
/// </param>
/// <param name="padding">
/// extra space in pixels to put between this child and its
///   neighbors, over and above the global amount specified by
///   #GtkBox:spacing property.  If @child is a widget at one of the
///   reference ends of @box, then @padding pixels are also put between
///   @child and the reference edge of @box
/// </param>

	public static T PackEnd<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child, bool expand, bool fill, uint padding) where T : GtkBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		GtkBoxHandleExterns.gtk_box_pack_end(box, child, expand, fill, padding);
		return box;
	}

/// <summary>
/// <para>
/// Adds @child to @box, packed with reference to the start of @box.
/// The @child is packed after any other child packed with reference
/// to the start of @box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <param name="child">
/// the #GtkWidget to be added to @box
/// </param>
/// <param name="expand">
/// %TRUE if the new child is to be given extra space allocated
///     to @box. The extra space will be divided evenly between all children
///     that use this option
/// </param>
/// <param name="fill">
/// %TRUE if space given to @child by the @expand option is
///     actually allocated to @child, rather than just padding it.  This
///     parameter has no effect if @expand is set to %FALSE.  A child is
///     always allocated the full height of a horizontal #GtkBox and the full width
///     of a vertical #GtkBox. This option affects the other dimension
/// </param>
/// <param name="padding">
/// extra space in pixels to put between this child and its
///   neighbors, over and above the global amount specified by
///   #GtkBox:spacing property.  If @child is a widget at one of the
///   reference ends of @box, then @padding pixels are also put between
///   @child and the reference edge of @box
/// </param>

	public static T PackStart<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child, bool expand, bool fill, uint padding) where T : GtkBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		GtkBoxHandleExterns.gtk_box_pack_start(box, child, expand, fill, padding);
		return box;
	}

/// <summary>
/// <para>
/// Obtains information about how @child is packed into @box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <param name="child">
/// the #GtkWidget of the child to query
/// </param>
/// <param name="expand">
/// pointer to return location for expand child
///     property
/// </param>
/// <param name="fill">
/// pointer to return location for fill child
///     property
/// </param>
/// <param name="padding">
/// pointer to return location for padding
///     child property
/// </param>
/// <param name="pack_type">
/// pointer to return location for pack-type
///     child property
/// </param>

	public static T QueryChildPacking<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child, out bool expand, out bool fill, out uint padding, out MentorLake.Gtk.GtkPackType pack_type) where T : GtkBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		GtkBoxHandleExterns.gtk_box_query_child_packing(box, child, out expand, out fill, out padding, out pack_type);
		return box;
	}

/// <summary>
/// <para>
/// Moves @child to a new @position in the list of @box children.
/// The list contains widgets packed #GTK_PACK_START
/// as well as widgets packed #GTK_PACK_END, in the order that these
/// widgets were added to @box.
/// </para>
/// <para>
/// A widget’s position in the @box children list determines where
/// the widget is packed into @box.  A child widget at some position
/// in the list will be packed just after all other widgets of the
/// same packing type that appear earlier in the list.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <param name="child">
/// the #GtkWidget to move
/// </param>
/// <param name="position">
/// the new position for @child in the list of children
///   of @box, starting from 0. If negative, indicates the end of
///   the list
/// </param>

	public static T ReorderChild<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child, int position) where T : GtkBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		GtkBoxHandleExterns.gtk_box_reorder_child(box, child, position);
		return box;
	}

/// <summary>
/// <para>
/// Sets the baseline position of a box. This affects
/// only horizontal boxes with at least one baseline aligned
/// child. If there is more vertical space available than requested,
/// and the baseline is not allocated by the parent then
/// @position is used to allocate the baseline wrt the
/// extra space available.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <param name="position">
/// a #GtkBaselinePosition
/// </param>

	public static T SetBaselinePosition<T>(this T box, MentorLake.Gtk.GtkBaselinePosition position) where T : GtkBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		GtkBoxHandleExterns.gtk_box_set_baseline_position(box, position);
		return box;
	}

/// <summary>
/// <para>
/// Sets a center widget; that is a child widget that will be
/// centered with respect to the full width of the box, even
/// if the children at either side take up different amounts
/// of space.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <param name="widget">
/// the widget to center
/// </param>

	public static T SetCenterWidget<T>(this T box, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		GtkBoxHandleExterns.gtk_box_set_center_widget(box, widget);
		return box;
	}

/// <summary>
/// <para>
/// Sets the way @child is packed into @box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <param name="child">
/// the #GtkWidget of the child to set
/// </param>
/// <param name="expand">
/// the new value of the expand child property
/// </param>
/// <param name="fill">
/// the new value of the fill child property
/// </param>
/// <param name="padding">
/// the new value of the padding child property
/// </param>
/// <param name="pack_type">
/// the new value of the pack-type child property
/// </param>

	public static T SetChildPacking<T>(this T box, MentorLake.Gtk.GtkWidgetHandle child, bool expand, bool fill, uint padding, MentorLake.Gtk.GtkPackType pack_type) where T : GtkBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		GtkBoxHandleExterns.gtk_box_set_child_packing(box, child, expand, fill, padding, pack_type);
		return box;
	}

/// <summary>
/// <para>
/// Sets the #GtkBox:homogeneous property of @box, controlling
/// whether or not all children of @box are given equal space
/// in the box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <param name="homogeneous">
/// a boolean value, %TRUE to create equal allotments,
///   %FALSE for variable allotments
/// </param>

	public static T SetHomogeneous<T>(this T box, bool homogeneous) where T : GtkBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		GtkBoxHandleExterns.gtk_box_set_homogeneous(box, homogeneous);
		return box;
	}

/// <summary>
/// <para>
/// Sets the #GtkBox:spacing property of @box, which is the
/// number of pixels to place between children of @box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkBox
/// </param>
/// <param name="spacing">
/// the number of pixels to put between children
/// </param>

	public static T SetSpacing<T>(this T box, int spacing) where T : GtkBoxHandle
	{
		if (box.IsInvalid) throw new Exception("Invalid handle (GtkBoxHandle)");
		GtkBoxHandleExterns.gtk_box_set_spacing(box, spacing);
		return box;
	}

}

internal class GtkBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkBoxHandle gtk_box_new(MentorLake.Gtk.GtkOrientation orientation, int spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBaselinePosition gtk_box_get_baseline_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBoxHandle>))] MentorLake.Gtk.GtkBoxHandle box);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
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
