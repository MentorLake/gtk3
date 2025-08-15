namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The base object class for a factory used to
///  create accessible objects for objects of a specific GType.
/// </para>
/// <para>
/// This class is the base object class for a factory used to create an
/// accessible object for a specific GType. The function
/// atk_registry_set_factory_type() is normally called to store in the
/// registry the factory type to be used to create an accessible of a
/// particular GType.
/// </para>
/// </summary>

public class AtkObjectFactoryHandle : GObjectHandle
{
}

public static class AtkObjectFactoryHandleExtensions
{
/// <summary>
/// <para>
/// Provides an #AtkObject that implements an accessibility interface
/// on behalf of @obj
/// </para>
/// </summary>

/// <param name="factory">
/// The #AtkObjectFactory associated with @obj&apos;s
/// object type
/// </param>
/// <param name="obj">
/// a #GObject
/// </param>
/// <return>
/// an #AtkObject that implements an accessibility
/// interface on behalf of @obj
/// </return>

	public static MentorLake.Atk.AtkObjectHandle CreateAccessible(this MentorLake.Atk.AtkObjectFactoryHandle factory, MentorLake.GObject.GObjectHandle obj)
	{
		if (factory.IsInvalid) throw new Exception("Invalid handle (AtkObjectFactoryHandle)");
		return AtkObjectFactoryHandleExterns.atk_object_factory_create_accessible(factory, obj);
	}

/// <summary>
/// <para>
/// Gets the GType of the accessible which is created by the factory.
/// </para>
/// </summary>

/// <param name="factory">
/// an #AtkObjectFactory
/// </param>
/// <return>
/// the type of the accessible which is created by the @factory.
/// The value G_TYPE_INVALID is returned if no type if found.
/// </return>

	public static MentorLake.GObject.GType GetAccessibleType(this MentorLake.Atk.AtkObjectFactoryHandle factory)
	{
		if (factory.IsInvalid) throw new Exception("Invalid handle (AtkObjectFactoryHandle)");
		return AtkObjectFactoryHandleExterns.atk_object_factory_get_accessible_type(factory);
	}

/// <summary>
/// <para>
/// Inform @factory that it is no longer being used to create
/// accessibles. When called, @factory may need to inform
/// #AtkObjects which it has created that they need to be re-instantiated.
/// Note: primarily used for runtime replacement of #AtkObjectFactorys
/// in object registries.
/// </para>
/// </summary>

/// <param name="factory">
/// an #AtkObjectFactory to invalidate
/// </param>

	public static T Invalidate<T>(this T factory) where T : AtkObjectFactoryHandle
	{
		if (factory.IsInvalid) throw new Exception("Invalid handle (AtkObjectFactoryHandle)");
		AtkObjectFactoryHandleExterns.atk_object_factory_invalidate(factory);
		return factory;
	}

}

internal class AtkObjectFactoryHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_object_factory_create_accessible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectFactoryHandle>))] MentorLake.Atk.AtkObjectFactoryHandle factory, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle obj);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType atk_object_factory_get_accessible_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectFactoryHandle>))] MentorLake.Atk.AtkObjectFactoryHandle factory);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_object_factory_invalidate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectFactoryHandle>))] MentorLake.Atk.AtkObjectFactoryHandle factory);

}
