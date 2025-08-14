namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function to compare two children to determine which
/// should come first.
/// </para>
/// </summary>

/// <param name="child1">
/// the first child
/// </param>
/// <param name="child2">
/// the second child
/// </param>
/// <param name="user_data">
/// user data
/// </param>
/// <return>
/// < 0 if @child1 should be before @child2, 0 if
///     the are equal, and > 0 otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkFlowBoxSortFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child2, IntPtr user_data);
