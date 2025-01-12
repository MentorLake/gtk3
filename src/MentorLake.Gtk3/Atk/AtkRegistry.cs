namespace MentorLake.Gtk3.Atk;

public class AtkRegistryHandle : GObjectHandle
{
}

public static class AtkRegistryHandleExtensions
{
	public static AtkObjectFactoryHandle GetFactory(this AtkRegistryHandle registry, GType type)
	{
		return AtkRegistryExterns.atk_registry_get_factory(registry, type);
	}

	public static GType GetFactoryType(this AtkRegistryHandle registry, GType type)
	{
		return AtkRegistryExterns.atk_registry_get_factory_type(registry, type);
	}

	public static AtkRegistryHandle SetFactoryType(this AtkRegistryHandle registry, GType type, GType factory_type)
	{
		AtkRegistryExterns.atk_registry_set_factory_type(registry, type, factory_type);
		return registry;
	}

}

internal class AtkRegistryExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectFactoryHandle atk_registry_get_factory(AtkRegistryHandle registry, GType type);

	[DllImport(Libraries.Atk)]
	internal static extern GType atk_registry_get_factory_type(AtkRegistryHandle registry, GType type);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_registry_set_factory_type(AtkRegistryHandle registry, GType type, GType factory_type);

}
