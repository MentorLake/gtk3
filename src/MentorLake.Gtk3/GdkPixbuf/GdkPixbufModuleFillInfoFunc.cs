namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Defines the type of the function used to fill a
/// #GdkPixbufFormat structure with information about a module.
/// </para>
/// </summary>

/// <param name="info">
/// a #GdkPixbufFormat.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkPixbufModuleFillInfoFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle info);
