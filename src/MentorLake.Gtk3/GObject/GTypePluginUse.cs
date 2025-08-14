namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The type of the @use_plugin function of #GTypePluginClass, which gets called
/// to increase the use count of @plugin.
/// </para>
/// </summary>

/// <param name="plugin">
/// the #GTypePlugin whose use count should be increased
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypePluginUse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin);
