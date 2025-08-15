namespace MentorLake.Atk;

/// <summary>
/// <para>
/// An object used to store the GType of the
/// factories used to create an accessible object for an object of a
/// particular GType.
/// </para>
/// <para>
/// The AtkRegistry is normally used to create appropriate ATK &quot;peers&quot;
/// for user interface components.  Application developers usually need
/// only interact with the AtkRegistry by associating appropriate ATK
/// implementation classes with GObject classes via the
/// atk_registry_set_factory_type call, passing the appropriate GType
/// for application custom widget classes.
/// </para>
/// </summary>

public class AtkRegistryHandle : GObjectHandle
{
}

public static class AtkRegistryHandleExtensions
{
/// <summary>
/// <para>
/// Gets an #AtkObjectFactory appropriate for creating #AtkObjects
/// appropriate for @type.
/// </para>
/// </summary>

/// <param name="registry">
/// an #AtkRegistry
/// </param>
/// <param name="type">
/// a #GType with which to look up the associated #AtkObjectFactory
/// </param>
/// <return>
/// an #AtkObjectFactory appropriate for creating
/// #AtkObjects appropriate for @type.
/// </return>

	public static MentorLake.Atk.AtkObjectFactoryHandle GetFactory(this MentorLake.Atk.AtkRegistryHandle registry, MentorLake.GObject.GType type)
	{
		if (registry.IsInvalid) throw new Exception("Invalid handle (AtkRegistryHandle)");
		return AtkRegistryHandleExterns.atk_registry_get_factory(registry, type);
	}

/// <summary>
/// <para>
/// Provides a #GType indicating the #AtkObjectFactory subclass
/// associated with @type.
/// </para>
/// </summary>

/// <param name="registry">
/// an #AtkRegistry
/// </param>
/// <param name="type">
/// a #GType with which to look up the associated #AtkObjectFactory
/// subclass
/// </param>
/// <return>
/// a #GType associated with type @type
/// </return>

	public static MentorLake.GObject.GType GetFactoryType(this MentorLake.Atk.AtkRegistryHandle registry, MentorLake.GObject.GType type)
	{
		if (registry.IsInvalid) throw new Exception("Invalid handle (AtkRegistryHandle)");
		return AtkRegistryHandleExterns.atk_registry_get_factory_type(registry, type);
	}

/// <summary>
/// <para>
/// Associate an #AtkObjectFactory subclass with a #GType. Note:
/// The associated @factory_type will thereafter be responsible for
/// the creation of new #AtkObject implementations for instances
/// appropriate for @type.
/// </para>
/// </summary>

/// <param name="registry">
/// the #AtkRegistry in which to register the type association
/// </param>
/// <param name="type">
/// an #AtkObject type
/// </param>
/// <param name="factory_type">
/// an #AtkObjectFactory type to associate with @type.  Must
/// implement AtkObject appropriate for @type.
/// </param>

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
