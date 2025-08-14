namespace MentorLake.GObject;

/// <summary>
/// <para>
/// `GTypeModule` provides a simple implementation of the `GTypePlugin`
/// interface.
/// </para>
/// <para>
/// The model of `GTypeModule` is a dynamically loaded module which
/// implements some number of types and interface implementations.
/// </para>
/// <para>
/// When the module is loaded, it registers its types and interfaces
/// using [method@GObject.TypeModule.register_type] and
/// [method@GObject.TypeModule.add_interface].
/// As long as any instances of these types and interface implementations
/// are in use, the module is kept loaded. When the types and interfaces
/// are gone, the module may be unloaded. If the types and interfaces
/// become used again, the module will be reloaded. Note that the last
/// reference cannot be released from within the module code, since that
/// would lead to the caller's code being unloaded before `g_object_unref()`
/// returns to it.
/// </para>
/// <para>
/// Keeping track of whether the module should be loaded or not is done by
/// using a use count - it starts at zero, and whenever it is greater than
/// zero, the module is loaded. The use count is maintained internally by
/// the type system, but also can be explicitly controlled by
/// [method@GObject.TypeModule.use] and [method@GObject.TypeModule.unuse].
/// Typically, when loading a module for the first type, `g_type_module_use()`
/// will be used to load it so that it can initialize its types. At some later
/// point, when the module no longer needs to be loaded except for the type
/// implementations it contains, `g_type_module_unuse()` is called.
/// </para>
/// <para>
/// `GTypeModule` does not actually provide any implementation of module
/// loading and unloading. To create a particular module type you must
/// derive from `GTypeModule` and implement the load and unload functions
/// in `GTypeModuleClass`.
/// </para>
/// </summary>

public class GTypeModuleHandle : GObjectHandle, GTypePluginHandle
{
}

public static class GTypeModuleHandleExtensions
{
/// <summary>
/// <para>
/// Registers an additional interface for a type, whose interface lives
/// in the given type plugin. If the interface was already registered
/// for the type in this plugin, nothing will be done.
/// </para>
/// <para>
/// As long as any instances of the type exist, the type plugin will
/// not be unloaded.
/// </para>
/// <para>
/// Since 2.56 if @module is %NULL this will call g_type_add_interface_static()
/// instead. This can be used when making a static build of the module.
/// </para>
/// </summary>

/// <param name="module">
/// a #GTypeModule
/// </param>
/// <param name="instance_type">
/// type to which to add the interface.
/// </param>
/// <param name="interface_type">
/// interface type to add
/// </param>
/// <param name="interface_info">
/// type information structure
/// </param>

	public static T AddInterface<T>(this T module, MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, MentorLake.GObject.GInterfaceInfoHandle interface_info) where T : GTypeModuleHandle
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GTypeModuleHandle)");
		GTypeModuleHandleExterns.g_type_module_add_interface(module, instance_type, interface_type, interface_info);
		return module;
	}

/// <summary>
/// <para>
/// Looks up or registers an enumeration that is implemented with a particular
/// type plugin. If a type with name @type_name was previously registered,
/// the #GType identifier for the type is returned, otherwise the type
/// is newly registered, and the resulting #GType identifier returned.
/// </para>
/// <para>
/// As long as any instances of the type exist, the type plugin will
/// not be unloaded.
/// </para>
/// <para>
/// Since 2.56 if @module is %NULL this will call g_type_register_static()
/// instead. This can be used when making a static build of the module.
/// </para>
/// </summary>

/// <param name="module">
/// a #GTypeModule
/// </param>
/// <param name="name">
/// name for the type
/// </param>
/// <param name="const_static_values">
/// an array of #GEnumValue structs for the
///                       possible enumeration values. The array is
///                       terminated by a struct with all members being
///                       0.
/// </param>
/// <return>
/// the new or existing type ID
/// </return>

	public static MentorLake.GObject.GType RegisterEnum(this MentorLake.GObject.GTypeModuleHandle module, string name, MentorLake.GObject.GEnumValueHandle const_static_values)
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GTypeModuleHandle)");
		return GTypeModuleHandleExterns.g_type_module_register_enum(module, name, const_static_values);
	}

/// <summary>
/// <para>
/// Looks up or registers a flags type that is implemented with a particular
/// type plugin. If a type with name @type_name was previously registered,
/// the #GType identifier for the type is returned, otherwise the type
/// is newly registered, and the resulting #GType identifier returned.
/// </para>
/// <para>
/// As long as any instances of the type exist, the type plugin will
/// not be unloaded.
/// </para>
/// <para>
/// Since 2.56 if @module is %NULL this will call g_type_register_static()
/// instead. This can be used when making a static build of the module.
/// </para>
/// </summary>

/// <param name="module">
/// a #GTypeModule
/// </param>
/// <param name="name">
/// name for the type
/// </param>
/// <param name="const_static_values">
/// an array of #GFlagsValue structs for the
///                       possible flags values. The array is
///                       terminated by a struct with all members being
///                       0.
/// </param>
/// <return>
/// the new or existing type ID
/// </return>

	public static MentorLake.GObject.GType RegisterFlags(this MentorLake.GObject.GTypeModuleHandle module, string name, MentorLake.GObject.GFlagsValueHandle const_static_values)
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GTypeModuleHandle)");
		return GTypeModuleHandleExterns.g_type_module_register_flags(module, name, const_static_values);
	}

/// <summary>
/// <para>
/// Looks up or registers a type that is implemented with a particular
/// type plugin. If a type with name @type_name was previously registered,
/// the #GType identifier for the type is returned, otherwise the type
/// is newly registered, and the resulting #GType identifier returned.
/// </para>
/// <para>
/// When reregistering a type (typically because a module is unloaded
/// then reloaded, and reinitialized), @module and @parent_type must
/// be the same as they were previously.
/// </para>
/// <para>
/// As long as any instances of the type exist, the type plugin will
/// not be unloaded.
/// </para>
/// <para>
/// Since 2.56 if @module is %NULL this will call g_type_register_static()
/// instead. This can be used when making a static build of the module.
/// </para>
/// </summary>

/// <param name="module">
/// a #GTypeModule
/// </param>
/// <param name="parent_type">
/// the type for the parent class
/// </param>
/// <param name="type_name">
/// name for the type
/// </param>
/// <param name="type_info">
/// type information structure
/// </param>
/// <param name="flags">
/// flags field providing details about the type
/// </param>
/// <return>
/// the new or existing type ID
/// </return>

	public static MentorLake.GObject.GType RegisterType(this MentorLake.GObject.GTypeModuleHandle module, MentorLake.GObject.GType parent_type, string type_name, MentorLake.GObject.GTypeInfoHandle type_info, MentorLake.GObject.GTypeFlags flags)
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GTypeModuleHandle)");
		return GTypeModuleHandleExterns.g_type_module_register_type(module, parent_type, type_name, type_info, flags);
	}

/// <summary>
/// <para>
/// Sets the name for a #GTypeModule
/// </para>
/// </summary>

/// <param name="module">
/// a #GTypeModule.
/// </param>
/// <param name="name">
/// a human-readable name to use in error messages.
/// </param>

	public static T SetName<T>(this T module, string name) where T : GTypeModuleHandle
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GTypeModuleHandle)");
		GTypeModuleHandleExterns.g_type_module_set_name(module, name);
		return module;
	}

/// <summary>
/// <para>
/// Decreases the use count of a #GTypeModule by one. If the
/// result is zero, the module will be unloaded. (However, the
/// #GTypeModule will not be freed, and types associated with the
/// #GTypeModule are not unregistered. Once a #GTypeModule is
/// initialized, it must exist forever.)
/// </para>
/// </summary>

/// <param name="module">
/// a #GTypeModule
/// </param>

	public static T Unuse<T>(this T module) where T : GTypeModuleHandle
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GTypeModuleHandle)");
		GTypeModuleHandleExterns.g_type_module_unuse(module);
		return module;
	}

/// <summary>
/// <para>
/// Increases the use count of a #GTypeModule by one. If the
/// use count was zero before, the plugin will be loaded.
/// If loading the plugin fails, the use count is reset to
/// its prior value.
/// </para>
/// </summary>

/// <param name="module">
/// a #GTypeModule
/// </param>
/// <return>
/// %FALSE if the plugin needed to be loaded and
///  loading the plugin failed.
/// </return>

	public static bool Use(this MentorLake.GObject.GTypeModuleHandle module)
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GTypeModuleHandle)");
		return GTypeModuleHandleExterns.g_type_module_use(module);
	}

}

internal class GTypeModuleHandleExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_module_add_interface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeModuleHandle>))] MentorLake.GObject.GTypeModuleHandle module, MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GInterfaceInfoHandle>))] MentorLake.GObject.GInterfaceInfoHandle interface_info);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_module_register_enum([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeModuleHandle>))] MentorLake.GObject.GTypeModuleHandle module, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GEnumValueHandle>))] MentorLake.GObject.GEnumValueHandle const_static_values);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_module_register_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeModuleHandle>))] MentorLake.GObject.GTypeModuleHandle module, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GFlagsValueHandle>))] MentorLake.GObject.GFlagsValueHandle const_static_values);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_module_register_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeModuleHandle>))] MentorLake.GObject.GTypeModuleHandle module, MentorLake.GObject.GType parent_type, string type_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInfoHandle>))] MentorLake.GObject.GTypeInfoHandle type_info, MentorLake.GObject.GTypeFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_module_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeModuleHandle>))] MentorLake.GObject.GTypeModuleHandle module, string name);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_module_unuse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeModuleHandle>))] MentorLake.GObject.GTypeModuleHandle module);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_type_module_use([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeModuleHandle>))] MentorLake.GObject.GTypeModuleHandle module);

}
