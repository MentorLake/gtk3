namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The type of the @complete_type_info function of #GTypePluginClass.
/// </para>
/// </summary>

/// <param name="plugin">
/// the #GTypePlugin
/// </param>
/// <param name="g_type">
/// the #GType whose info is completed
/// </param>
/// <param name="info">
/// the #GTypeInfo struct to fill in
/// </param>
/// <param name="value_table">
/// the #GTypeValueTable to fill in
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypePluginCompleteTypeInfo([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin, MentorLake.GObject.GType g_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInfoHandle>))] MentorLake.GObject.GTypeInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeValueTableHandle>))] MentorLake.GObject.GTypeValueTableHandle value_table);
