namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A callback function used by the type system to finalize an interface.
/// </para>
/// <para>
/// This function should destroy any internal data and release any resources
/// allocated by the corresponding GInterfaceInitFunc() function.
/// </para>
/// </summary>

/// <param name="g_iface">
/// The interface structure to finalize
/// </param>
/// <param name="iface_data">
/// The @interface_data supplied via the #GInterfaceInfo structure
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GInterfaceFinalizeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface, IntPtr iface_data);
