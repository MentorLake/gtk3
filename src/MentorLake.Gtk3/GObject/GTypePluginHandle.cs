namespace MentorLake.GObject;

/// <summary>
/// <para>
/// An interface that handles the lifecycle of dynamically loaded types.
/// </para>
/// <para>
/// The GObject type system supports dynamic loading of types.
/// It goes as follows:
/// </para>
/// <para>
/// 1. The type is initially introduced (usually upon loading the module
///    the first time, or by your main application that knows what modules
///    introduces what types), like this:
///    ```c
///    new_type_id = g_type_register_dynamic (parent_type_id,
///                                           "TypeName",
///                                           new_type_plugin,
///                                           type_flags);
///    ```
///    where `new_type_plugin` is an implementation of the
///    `GTypePlugin` interface.
/// </para>
/// <para>
/// 2. The type's implementation is referenced, e.g. through
///    [func@GObject.TypeClass.ref] or through [func@GObject.type_create_instance]
///    (this is being called by [ctor@GObject.Object.new]) or through one of the above
///    done on a type derived from `new_type_id`.
/// </para>
/// <para>
/// 3. This causes the type system to load the type's implementation by calling
///    [method@GObject.TypePlugin.use] and [method@GObject.TypePlugin.complete_type_info]
///    on `new_type_plugin`.
/// </para>
/// <para>
/// 4. At some point the type's implementation isn't required anymore, e.g. after
///    [method@GObject.TypeClass.unref] or [func@GObject.type_free_instance]
///    (called when the reference count of an instance drops to zero).
/// </para>
/// <para>
/// 5. This causes the type system to throw away the information retrieved
///    from [method@GObject.TypePlugin.complete_type_info] and then it calls
///    [method@GObject.TypePlugin.unuse] on `new_type_plugin`.
/// </para>
/// <para>
/// 6. Things may repeat from the second step.
/// </para>
/// <para>
/// So basically, you need to implement a `GTypePlugin` type that
/// carries a use_count, once use_count goes from zero to one, you need
/// to load the implementation to successfully handle the upcoming
/// [method@GObject.TypePlugin.complete_type_info] call. Later, maybe after
/// succeeding use/unuse calls, once use_count drops to zero, you can
/// unload the implementation again. The type system makes sure to call
/// [method@GObject.TypePlugin.use] and [method@GObject.TypePlugin.complete_type_info]
/// again when the type is needed again.
/// </para>
/// <para>
/// [class@GObject.TypeModule] is an implementation of `GTypePlugin` that
/// already implements most of this except for the actual module loading and
/// unloading. It even handles multiple registered types per module.
/// </para>
/// </summary>

public interface GTypePluginHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GTypePluginHandleImpl : BaseSafeHandle, GTypePluginHandle
{
}

public static class GTypePluginHandleExtensions
{
/// <summary>
/// <para>
/// Calls the @complete_interface_info function from the
/// #GTypePluginClass of @plugin. There should be no need to use this
/// function outside of the GObject type system itself.
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

	public static T CompleteInterfaceInfo<T>(this T plugin, MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, MentorLake.GObject.GInterfaceInfoHandle info) where T : GTypePluginHandle
	{
		if (plugin.IsInvalid) throw new Exception("Invalid handle (GTypePluginHandle)");
		GTypePluginHandleExterns.g_type_plugin_complete_interface_info(plugin, instance_type, interface_type, info);
		return plugin;
	}

/// <summary>
/// <para>
/// Calls the @complete_type_info function from the #GTypePluginClass of @plugin.
/// There should be no need to use this function outside of the GObject
/// type system itself.
/// </para>
/// </summary>

/// <param name="plugin">
/// a #GTypePlugin
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

	public static T CompleteTypeInfo<T>(this T plugin, MentorLake.GObject.GType g_type, MentorLake.GObject.GTypeInfoHandle info, MentorLake.GObject.GTypeValueTableHandle value_table) where T : GTypePluginHandle
	{
		if (plugin.IsInvalid) throw new Exception("Invalid handle (GTypePluginHandle)");
		GTypePluginHandleExterns.g_type_plugin_complete_type_info(plugin, g_type, info, value_table);
		return plugin;
	}

/// <summary>
/// <para>
/// Calls the @unuse_plugin function from the #GTypePluginClass of
/// @plugin.  There should be no need to use this function outside of
/// the GObject type system itself.
/// </para>
/// </summary>

/// <param name="plugin">
/// a #GTypePlugin
/// </param>

	public static T Unuse<T>(this T plugin) where T : GTypePluginHandle
	{
		if (plugin.IsInvalid) throw new Exception("Invalid handle (GTypePluginHandle)");
		GTypePluginHandleExterns.g_type_plugin_unuse(plugin);
		return plugin;
	}

/// <summary>
/// <para>
/// Calls the @use_plugin function from the #GTypePluginClass of
/// @plugin.  There should be no need to use this function outside of
/// the GObject type system itself.
/// </para>
/// </summary>

/// <param name="plugin">
/// a #GTypePlugin
/// </param>

	public static T Use<T>(this T plugin) where T : GTypePluginHandle
	{
		if (plugin.IsInvalid) throw new Exception("Invalid handle (GTypePluginHandle)");
		GTypePluginHandleExterns.g_type_plugin_use(plugin);
		return plugin;
	}

}

internal class GTypePluginHandleExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_plugin_complete_interface_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin, MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GInterfaceInfoHandle>))] MentorLake.GObject.GInterfaceInfoHandle info);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_plugin_complete_type_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin, MentorLake.GObject.GType g_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInfoHandle>))] MentorLake.GObject.GTypeInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeValueTableHandle>))] MentorLake.GObject.GTypeValueTableHandle value_table);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_plugin_unuse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_plugin_use([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin);

}
