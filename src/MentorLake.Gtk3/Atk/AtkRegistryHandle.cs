namespace MentorLake.Atk;

public class AtkRegistryHandle : GObjectHandle
{
}

public static class AtkRegistryHandleExtensions
{
	public static MentorLake.Atk.AtkObjectFactoryHandle GetFactory(this MentorLake.Atk.AtkRegistryHandle registry, MentorLake.GObject.GType type)
	{
		if (registry.IsInvalid) throw new Exception("Invalid handle (AtkRegistryHandle)");
		return AtkRegistryHandleExterns.atk_registry_get_factory(registry, type);
	}

	public static MentorLake.GObject.GType GetFactoryType(this MentorLake.Atk.AtkRegistryHandle registry, MentorLake.GObject.GType type)
	{
		if (registry.IsInvalid) throw new Exception("Invalid handle (AtkRegistryHandle)");
		return AtkRegistryHandleExterns.atk_registry_get_factory_type(registry, type);
	}

	public static T SetFactoryType<T>(this T registry, MentorLake.GObject.GType type, MentorLake.GObject.GType factory_type) where T : AtkRegistryHandle
	{
		if (registry.IsInvalid) throw new Exception("Invalid handle (AtkRegistryHandle)");
		AtkRegistryHandleExterns.atk_registry_set_factory_type(registry, type, factory_type);
		return registry;
	}

}

internal class AtkRegistryHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectFactoryHandle>))]
	internal static extern MentorLake.Atk.AtkObjectFactoryHandle atk_registry_get_factory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRegistryHandle>))] MentorLake.Atk.AtkRegistryHandle registry, MentorLake.GObject.GType type);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType atk_registry_get_factory_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRegistryHandle>))] MentorLake.Atk.AtkRegistryHandle registry, MentorLake.GObject.GType type);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_registry_set_factory_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRegistryHandle>))] MentorLake.Atk.AtkRegistryHandle registry, MentorLake.GObject.GType type, MentorLake.GObject.GType factory_type);

}
