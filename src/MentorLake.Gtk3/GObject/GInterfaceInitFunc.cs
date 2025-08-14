namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A callback function used by the type system to initialize a new
/// interface.
/// </para>
/// <para>
/// This function should initialize all internal data and* allocate any
/// resources required by the interface.
/// </para>
/// <para>
/// The members of @iface_data are guaranteed to have been filled with
/// zeros before this function is called.
/// </para>
/// </summary>

/// <param name="g_iface">
/// The interface structure to initialize
/// </param>
/// <param name="iface_data">
/// The @interface_data supplied via the #GInterfaceInfo structure
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GInterfaceInitFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface, IntPtr iface_data);
