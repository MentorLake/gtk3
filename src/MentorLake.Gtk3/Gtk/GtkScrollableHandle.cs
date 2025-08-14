namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkScrollable is an interface that is implemented by widgets with native
/// scrolling ability.
/// </para>
/// <para>
/// To implement this interface you should override the
/// #GtkScrollable:hadjustment and #GtkScrollable:vadjustment properties.
/// </para>
/// <para>
/// ## Creating a scrollable widget
/// </para>
/// <para>
/// All scrollable widgets should do the following.
/// </para>
/// <para>
/// - When a parent widget sets the scrollable child widget’s adjustments,
///   the widget should populate the adjustments’
///   #GtkAdjustment:lower, #GtkAdjustment:upper,
///   #GtkAdjustment:step-increment, #GtkAdjustment:page-increment and
///   #GtkAdjustment:page-size properties and connect to the
///   #GtkAdjustment::value-changed signal.
/// </para>
/// <para>
/// - Because its preferred size is the size for a fully expanded widget,
///   the scrollable widget must be able to cope with underallocations.
///   This means that it must accept any value passed to its
///   #GtkWidgetClass.size_allocate() function.
/// </para>
/// <para>
/// - When the parent allocates space to the scrollable child widget,
///   the widget should update the adjustments’ properties with new values.
/// </para>
/// <para>
/// - When any of the adjustments emits the #GtkAdjustment::value-changed signal,
///   the scrollable widget should scroll its contents.
/// </para>
/// </summary>

public interface GtkScrollableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkScrollableHandleImpl : BaseSafeHandle, GtkScrollableHandle
{
}

public static class GtkScrollableHandleExtensions
{
/// <summary>
/// <para>
/// Returns the size of a non-scrolling border around the
/// outside of the scrollable. An example for this would
/// be treeview headers. GTK+ can use this information to
/// display overlayed graphics, like the overshoot indication,
/// at the right position.
/// </para>
/// </summary>

/// <param name="scrollable">
/// a #GtkScrollable
/// </param>
/// <param name="border">
/// return location for the results
/// </param>
/// <return>
/// %TRUE if @border has been set
/// </return>

	public static bool GetBorder(this MentorLake.Gtk.GtkScrollableHandle scrollable, out MentorLake.Gtk.GtkBorder border)
	{
		if (scrollable.IsInvalid) throw new Exception("Invalid handle (GtkScrollableHandle)");
		return GtkScrollableHandleExterns.gtk_scrollable_get_border(scrollable, out border);
	}

/// <summary>
/// <para>
/// Retrieves the #GtkAdjustment used for horizontal scrolling.
/// </para>
/// </summary>

/// <param name="scrollable">
/// a #GtkScrollable
/// </param>
/// <return>
/// horizontal #GtkAdjustment.
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkScrollableHandle scrollable)
	{
		if (scrollable.IsInvalid) throw new Exception("Invalid handle (GtkScrollableHandle)");
		return GtkScrollableHandleExterns.gtk_scrollable_get_hadjustment(scrollable);
	}

/// <summary>
/// <para>
/// Gets the horizontal #GtkScrollablePolicy.
/// </para>
/// </summary>

/// <param name="scrollable">
/// a #GtkScrollable
/// </param>
/// <return>
/// The horizontal #GtkScrollablePolicy.
/// </return>

	public static MentorLake.Gtk.GtkScrollablePolicy GetHscrollPolicy(this MentorLake.Gtk.GtkScrollableHandle scrollable)
	{
		if (scrollable.IsInvalid) throw new Exception("Invalid handle (GtkScrollableHandle)");
		return GtkScrollableHandleExterns.gtk_scrollable_get_hscroll_policy(scrollable);
	}

/// <summary>
/// <para>
/// Retrieves the #GtkAdjustment used for vertical scrolling.
/// </para>
/// </summary>

/// <param name="scrollable">
/// a #GtkScrollable
/// </param>
/// <return>
/// vertical #GtkAdjustment.
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkScrollableHandle scrollable)
	{
		if (scrollable.IsInvalid) throw new Exception("Invalid handle (GtkScrollableHandle)");
		return GtkScrollableHandleExterns.gtk_scrollable_get_vadjustment(scrollable);
	}

/// <summary>
/// <para>
/// Gets the vertical #GtkScrollablePolicy.
/// </para>
/// </summary>

/// <param name="scrollable">
/// a #GtkScrollable
/// </param>
/// <return>
/// The vertical #GtkScrollablePolicy.
/// </return>

	public static MentorLake.Gtk.GtkScrollablePolicy GetVscrollPolicy(this MentorLake.Gtk.GtkScrollableHandle scrollable)
	{
		if (scrollable.IsInvalid) throw new Exception("Invalid handle (GtkScrollableHandle)");
		return GtkScrollableHandleExterns.gtk_scrollable_get_vscroll_policy(scrollable);
	}

/// <summary>
/// <para>
/// Sets the horizontal adjustment of the #GtkScrollable.
/// </para>
/// </summary>

/// <param name="scrollable">
/// a #GtkScrollable
/// </param>
/// <param name="hadjustment">
/// a #GtkAdjustment
/// </param>

	public static T SetHadjustment<T>(this T scrollable, MentorLake.Gtk.GtkAdjustmentHandle hadjustment) where T : GtkScrollableHandle
	{
		if (scrollable.IsInvalid) throw new Exception("Invalid handle (GtkScrollableHandle)");
		GtkScrollableHandleExterns.gtk_scrollable_set_hadjustment(scrollable, hadjustment);
		return scrollable;
	}

/// <summary>
/// <para>
/// Sets the #GtkScrollablePolicy to determine whether
/// horizontal scrolling should start below the minimum width or
/// below the natural width.
/// </para>
/// </summary>

/// <param name="scrollable">
/// a #GtkScrollable
/// </param>
/// <param name="policy">
/// the horizontal #GtkScrollablePolicy
/// </param>

	public static T SetHscrollPolicy<T>(this T scrollable, MentorLake.Gtk.GtkScrollablePolicy policy) where T : GtkScrollableHandle
	{
		if (scrollable.IsInvalid) throw new Exception("Invalid handle (GtkScrollableHandle)");
		GtkScrollableHandleExterns.gtk_scrollable_set_hscroll_policy(scrollable, policy);
		return scrollable;
	}

/// <summary>
/// <para>
/// Sets the vertical adjustment of the #GtkScrollable.
/// </para>
/// </summary>

/// <param name="scrollable">
/// a #GtkScrollable
/// </param>
/// <param name="vadjustment">
/// a #GtkAdjustment
/// </param>

	public static T SetVadjustment<T>(this T scrollable, MentorLake.Gtk.GtkAdjustmentHandle vadjustment) where T : GtkScrollableHandle
	{
		if (scrollable.IsInvalid) throw new Exception("Invalid handle (GtkScrollableHandle)");
		GtkScrollableHandleExterns.gtk_scrollable_set_vadjustment(scrollable, vadjustment);
		return scrollable;
	}

/// <summary>
/// <para>
/// Sets the #GtkScrollablePolicy to determine whether
/// vertical scrolling should start below the minimum height or
/// below the natural height.
/// </para>
/// </summary>

/// <param name="scrollable">
/// a #GtkScrollable
/// </param>
/// <param name="policy">
/// the vertical #GtkScrollablePolicy
/// </param>

	public static T SetVscrollPolicy<T>(this T scrollable, MentorLake.Gtk.GtkScrollablePolicy policy) where T : GtkScrollableHandle
	{
		if (scrollable.IsInvalid) throw new Exception("Invalid handle (GtkScrollableHandle)");
		GtkScrollableHandleExterns.gtk_scrollable_set_vscroll_policy(scrollable, policy);
		return scrollable;
	}

}

internal class GtkScrollableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scrollable_get_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable, out MentorLake.Gtk.GtkBorder border);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_scrollable_get_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkScrollablePolicy gtk_scrollable_get_hscroll_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_scrollable_get_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkScrollablePolicy gtk_scrollable_get_vscroll_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrollable_set_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle hadjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrollable_set_hscroll_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable, MentorLake.Gtk.GtkScrollablePolicy policy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrollable_set_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle vadjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrollable_set_vscroll_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable, MentorLake.Gtk.GtkScrollablePolicy policy);

}
