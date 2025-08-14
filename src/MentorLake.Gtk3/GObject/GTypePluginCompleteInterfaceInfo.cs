namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The type of the @complete_interface_info function of #GTypePluginClass.
/// </para>
/// </summary>

/// <param name="plugin">
/// the #GTypePlugin
/// </param>
/// <param name="instance_type">
/// the #GType of an instantiatable type to which the interface
///  is added
/// </param>
/// <param name="interface_type">
/// the #GType of the interface whose info is completed
/// </param>
/// <param name="info">
/// the #GInterfaceInfo to fill in
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypePluginCompleteInterfaceInfo([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin, MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GInterfaceInfoHandle>))] MentorLake.GObject.GInterfaceInfoHandle info);
