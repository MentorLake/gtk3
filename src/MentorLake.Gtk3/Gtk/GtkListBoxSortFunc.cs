namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Compare two rows to determine which should be first.
/// </para>
/// </summary>

/// <param name="row1">
/// the first row
/// </param>
/// <param name="row2">
/// the second row
/// </param>
/// <param name="user_data">
/// user data
/// </param>
/// <return>
/// &amp;lt; 0 if @row1 should be before @row2, 0 if they are
///     equal and &amp;gt; 0 otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkListBoxSortFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row2, IntPtr user_data);
