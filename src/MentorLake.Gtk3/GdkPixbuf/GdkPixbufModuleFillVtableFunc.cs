namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Defines the type of the function used to set the vtable of a
/// #GdkPixbufModule when it is loaded.
/// </para>
/// </summary>

/// <param name="module">
/// a #GdkPixbufModule.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkPixbufModuleFillVtableFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufModuleHandle>))] MentorLake.GdkPixbuf.GdkPixbufModuleHandle module);
