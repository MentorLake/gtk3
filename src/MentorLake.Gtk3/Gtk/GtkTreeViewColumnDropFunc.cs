namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Function type for determining whether @column can be dropped in a
/// particular spot (as determined by @prev_column and @next_column).  In
/// left to right locales, @prev_column is on the left of the potential drop
/// spot, and @next_column is on the right.  In right to left mode, this is
/// reversed.  This function should return %TRUE if the spot is a valid drop
/// spot.  Please note that returning %TRUE does not actually indicate that
/// the column drop was made, but is meant only to indicate a possible drop
/// spot to the user.
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="column">
/// The #GtkTreeViewColumn being dragged
/// </param>
/// <param name="prev_column">
/// A #GtkTreeViewColumn on one side of @column
/// </param>
/// <param name="next_column">
/// A #GtkTreeViewColumn on the other side of @column
/// </param>
/// <param name="data">
/// user data
/// </param>
/// <return>
/// %TRUE, if @column can be dropped in this spot
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkTreeViewColumnDropFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle prev_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle next_column, IntPtr data);
