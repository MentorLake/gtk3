namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The type of the @unuse_plugin function of #GTypePluginClass.
/// </para>
/// </summary>

/// <param name="plugin">
/// the #GTypePlugin whose use count should be decreased
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypePluginUnuse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin);
