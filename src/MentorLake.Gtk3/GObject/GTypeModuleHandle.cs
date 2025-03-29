namespace MentorLake.GObject;

public class GTypeModuleHandle : GObjectHandle, GTypePluginHandle
{
}

public static class GTypeModuleHandleExtensions
{
	public static T AddInterface<T>(this T module, MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, MentorLake.GObject.GInterfaceInfoHandle interface_info) where T : GTypeModuleHandle
	{
		if (module.IsInvalid || module.IsClosed) throw new Exception("Invalid or closed handle (GTypeModuleHandle)");
		GTypeModuleHandleExterns.g_type_module_add_interface(module, instance_type, interface_type, interface_info);
		return module;
	}

	public static MentorLake.GObject.GType RegisterEnum(this MentorLake.GObject.GTypeModuleHandle module, string name, MentorLake.GObject.GEnumValueHandle const_static_values)
	{
		if (module.IsInvalid || module.IsClosed) throw new Exception("Invalid or closed handle (GTypeModuleHandle)");
		return GTypeModuleHandleExterns.g_type_module_register_enum(module, name, const_static_values);
	}

	public static MentorLake.GObject.GType RegisterFlags(this MentorLake.GObject.GTypeModuleHandle module, string name, MentorLake.GObject.GFlagsValueHandle const_static_values)
	{
		if (module.IsInvalid || module.IsClosed) throw new Exception("Invalid or closed handle (GTypeModuleHandle)");
		return GTypeModuleHandleExterns.g_type_module_register_flags(module, name, const_static_values);
	}

	public static MentorLake.GObject.GType RegisterType(this MentorLake.GObject.GTypeModuleHandle module, MentorLake.GObject.GType parent_type, string type_name, MentorLake.GObject.GTypeInfoHandle type_info, MentorLake.GObject.GTypeFlags flags)
	{
		if (module.IsInvalid || module.IsClosed) throw new Exception("Invalid or closed handle (GTypeModuleHandle)");
		return GTypeModuleHandleExterns.g_type_module_register_type(module, parent_type, type_name, type_info, flags);
	}

	public static T SetName<T>(this T module, string name) where T : GTypeModuleHandle
	{
		if (module.IsInvalid || module.IsClosed) throw new Exception("Invalid or closed handle (GTypeModuleHandle)");
		GTypeModuleHandleExterns.g_type_module_set_name(module, name);
		return module;
	}

	public static T Unuse<T>(this T module) where T : GTypeModuleHandle
	{
		if (module.IsInvalid || module.IsClosed) throw new Exception("Invalid or closed handle (GTypeModuleHandle)");
		GTypeModuleHandleExterns.g_type_module_unuse(module);
		return module;
	}

	public static bool Use(this MentorLake.GObject.GTypeModuleHandle module)
	{
		if (module.IsInvalid || module.IsClosed) throw new Exception("Invalid or closed handle (GTypeModuleHandle)");
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
