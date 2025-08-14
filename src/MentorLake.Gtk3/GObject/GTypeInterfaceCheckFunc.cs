namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A callback called after an interface vtable is initialized.
/// </para>
/// <para>
/// See g_type_add_interface_check().
/// </para>
/// </summary>

/// <param name="check_data">
/// data passed to g_type_add_interface_check()
/// </param>
/// <param name="g_iface">
/// the interface that has been
///    initialized
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypeInterfaceCheckFunc(IntPtr check_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface);
