namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Will be called whenever the row changes or is added and lets you control
/// if the row should be visible or not.
/// </para>
/// </summary>

/// <param name="row">
/// the row that may be filtered
/// </param>
/// <param name="user_data">
/// user data
/// </param>
/// <return>
/// %TRUE if the row should be visible, %FALSE otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkListBoxFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row, IntPtr user_data);
