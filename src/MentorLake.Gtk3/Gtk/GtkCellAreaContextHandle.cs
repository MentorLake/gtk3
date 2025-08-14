namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkCellAreaContext object is created by a given #GtkCellArea
/// implementation via its #GtkCellAreaClass.create_context() virtual
/// method and is used to store cell sizes and alignments for a series of
/// #GtkTreeModel rows that are requested and rendered in the same context.
/// </para>
/// <para>
/// #GtkCellLayout widgets can create any number of contexts in which to
/// request and render groups of data rows. However, it’s important that the
/// same context which was used to request sizes for a given #GtkTreeModel
/// row also be used for the same row when calling other #GtkCellArea APIs
/// such as gtk_cell_area_render() and gtk_cell_area_event().
/// </para>
/// </summary>

public class GtkCellAreaContextHandle : GObjectHandle
{
}

public static class GtkCellAreaContextHandleExtensions
{
/// <summary>
/// <para>
/// Allocates a width and/or a height for all rows which are to be
/// rendered with @context.
/// </para>
/// <para>
/// Usually allocation is performed only horizontally or sometimes
/// vertically since a group of rows are usually rendered side by
/// side vertically or horizontally and share either the same width
/// or the same height. Sometimes they are allocated in both horizontal
/// and vertical orientations producing a homogeneous effect of the
/// rows. This is generally the case for #GtkTreeView when
/// #GtkTreeView:fixed-height-mode is enabled.
/// </para>
/// <para>
/// Since 3.0
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkCellAreaContext
/// </param>
/// <param name="width">
/// the allocated width for all #GtkTreeModel rows rendered
///     with @context, or -1.
/// </param>
/// <param name="height">
/// the allocated height for all #GtkTreeModel rows rendered
///     with @context, or -1.
/// </param>

	public static T Allocate<T>(this T context, int width, int height) where T : GtkCellAreaContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaContextHandle)");
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_allocate(context, width, height);
		return context;
	}

/// <summary>
/// <para>
/// Fetches the current allocation size for @context.
/// </para>
/// <para>
/// If the context was not allocated in width or height, or if the
/// context was recently reset with gtk_cell_area_context_reset(),
/// the returned value will be -1.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkCellAreaContext
/// </param>
/// <param name="width">
/// location to store the allocated width, or %NULL
/// </param>
/// <param name="height">
/// location to store the allocated height, or %NULL
/// </param>

	public static T GetAllocation<T>(this T context, out int width, out int height) where T : GtkCellAreaContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaContextHandle)");
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_get_allocation(context, out width, out height);
		return context;
	}

/// <summary>
/// <para>
/// Fetches the #GtkCellArea this @context was created by.
/// </para>
/// <para>
/// This is generally unneeded by layouting widgets; however,
/// it is important for the context implementation itself to
/// fetch information about the area it is being used for.
/// </para>
/// <para>
/// For instance at #GtkCellAreaContextClass.allocate() time
/// it’s important to know details about any cell spacing
/// that the #GtkCellArea is configured with in order to
/// compute a proper allocation.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkCellAreaContext
/// </param>
/// <return>
/// the #GtkCellArea this context was created by.
/// </return>

	public static MentorLake.Gtk.GtkCellAreaHandle GetArea(this MentorLake.Gtk.GtkCellAreaContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaContextHandle)");
		return GtkCellAreaContextHandleExterns.gtk_cell_area_context_get_area(context);
	}

/// <summary>
/// <para>
/// Gets the accumulative preferred height for all rows which have been
/// requested with this context.
/// </para>
/// <para>
/// After gtk_cell_area_context_reset() is called and/or before ever
/// requesting the size of a #GtkCellArea, the returned values are 0.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkCellAreaContext
/// </param>
/// <param name="minimum_height">
/// location to store the minimum height,
///     or %NULL
/// </param>
/// <param name="natural_height">
/// location to store the natural height,
///     or %NULL
/// </param>

	public static T GetPreferredHeight<T>(this T context, out int minimum_height, out int natural_height) where T : GtkCellAreaContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaContextHandle)");
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_get_preferred_height(context, out minimum_height, out natural_height);
		return context;
	}

/// <summary>
/// <para>
/// Gets the accumulative preferred height for @width for all rows
/// which have been requested for the same said @width with this context.
/// </para>
/// <para>
/// After gtk_cell_area_context_reset() is called and/or before ever
/// requesting the size of a #GtkCellArea, the returned values are -1.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkCellAreaContext
/// </param>
/// <param name="width">
/// a proposed width for allocation
/// </param>
/// <param name="minimum_height">
/// location to store the minimum height,
///     or %NULL
/// </param>
/// <param name="natural_height">
/// location to store the natural height,
///     or %NULL
/// </param>

	public static T GetPreferredHeightForWidth<T>(this T context, int width, out int minimum_height, out int natural_height) where T : GtkCellAreaContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaContextHandle)");
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_get_preferred_height_for_width(context, width, out minimum_height, out natural_height);
		return context;
	}

/// <summary>
/// <para>
/// Gets the accumulative preferred width for all rows which have been
/// requested with this context.
/// </para>
/// <para>
/// After gtk_cell_area_context_reset() is called and/or before ever
/// requesting the size of a #GtkCellArea, the returned values are 0.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkCellAreaContext
/// </param>
/// <param name="minimum_width">
/// location to store the minimum width,
///     or %NULL
/// </param>
/// <param name="natural_width">
/// location to store the natural width,
///     or %NULL
/// </param>

	public static T GetPreferredWidth<T>(this T context, out int minimum_width, out int natural_width) where T : GtkCellAreaContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaContextHandle)");
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_get_preferred_width(context, out minimum_width, out natural_width);
		return context;
	}

/// <summary>
/// <para>
/// Gets the accumulative preferred width for @height for all rows which
/// have been requested for the same said @height with this context.
/// </para>
/// <para>
/// After gtk_cell_area_context_reset() is called and/or before ever
/// requesting the size of a #GtkCellArea, the returned values are -1.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkCellAreaContext
/// </param>
/// <param name="height">
/// a proposed height for allocation
/// </param>
/// <param name="minimum_width">
/// location to store the minimum width,
///     or %NULL
/// </param>
/// <param name="natural_width">
/// location to store the natural width,
///     or %NULL
/// </param>

	public static T GetPreferredWidthForHeight<T>(this T context, int height, out int minimum_width, out int natural_width) where T : GtkCellAreaContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaContextHandle)");
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_get_preferred_width_for_height(context, height, out minimum_width, out natural_width);
		return context;
	}

/// <summary>
/// <para>
/// Causes the minimum and/or natural height to grow if the new
/// proposed sizes exceed the current minimum and natural height.
/// </para>
/// <para>
/// This is used by #GtkCellAreaContext implementations during
/// the request process over a series of #GtkTreeModel rows to
/// progressively push the requested height over a series of
/// gtk_cell_area_get_preferred_height() requests.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkCellAreaContext
/// </param>
/// <param name="minimum_height">
/// the proposed new minimum height for @context
/// </param>
/// <param name="natural_height">
/// the proposed new natural height for @context
/// </param>

	public static T PushPreferredHeight<T>(this T context, int minimum_height, int natural_height) where T : GtkCellAreaContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaContextHandle)");
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_push_preferred_height(context, minimum_height, natural_height);
		return context;
	}

/// <summary>
/// <para>
/// Causes the minimum and/or natural width to grow if the new
/// proposed sizes exceed the current minimum and natural width.
/// </para>
/// <para>
/// This is used by #GtkCellAreaContext implementations during
/// the request process over a series of #GtkTreeModel rows to
/// progressively push the requested width over a series of
/// gtk_cell_area_get_preferred_width() requests.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkCellAreaContext
/// </param>
/// <param name="minimum_width">
/// the proposed new minimum width for @context
/// </param>
/// <param name="natural_width">
/// the proposed new natural width for @context
/// </param>

	public static T PushPreferredWidth<T>(this T context, int minimum_width, int natural_width) where T : GtkCellAreaContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaContextHandle)");
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_push_preferred_width(context, minimum_width, natural_width);
		return context;
	}

/// <summary>
/// <para>
/// Resets any previously cached request and allocation
/// data.
/// </para>
/// <para>
/// When underlying #GtkTreeModel data changes its
/// important to reset the context if the content
/// size is allowed to shrink. If the content size
/// is only allowed to grow (this is usually an option
/// for views rendering large data stores as a measure
/// of optimization), then only the row that changed
/// or was inserted needs to be (re)requested with
/// gtk_cell_area_get_preferred_width().
/// </para>
/// <para>
/// When the new overall size of the context requires
/// that the allocated size changes (or whenever this
/// allocation changes at all), the variable row
/// sizes need to be re-requested for every row.
/// </para>
/// <para>
/// For instance, if the rows are displayed all with
/// the same width from top to bottom then a change
/// in the allocated width necessitates a recalculation
/// of all the displayed row heights using
/// gtk_cell_area_get_preferred_height_for_width().
/// </para>
/// <para>
/// Since 3.0
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkCellAreaContext
/// </param>

	public static T Reset<T>(this T context) where T : GtkCellAreaContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkCellAreaContextHandle)");
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_reset(context);
		return context;
	}

}

internal class GtkCellAreaContextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_get_allocation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))]
	internal static extern MentorLake.Gtk.GtkCellAreaHandle gtk_cell_area_context_get_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_get_preferred_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, out int minimum_height, out int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_get_preferred_height_for_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, int width, out int minimum_height, out int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_get_preferred_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, out int minimum_width, out int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_get_preferred_width_for_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, int height, out int minimum_width, out int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_push_preferred_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, int minimum_height, int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_push_preferred_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, int minimum_width, int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context);

}
