namespace MentorLake.Atk;

public class AtkObjectFactoryHandle : GObjectHandle
{
}

public static class AtkObjectFactoryHandleExtensions
{
	public static MentorLake.Atk.AtkObjectHandle CreateAccessible(this MentorLake.Atk.AtkObjectFactoryHandle factory, MentorLake.GObject.GObjectHandle obj)
	{
		if (factory.IsInvalid) throw new Exception("Invalid handle (AtkObjectFactoryHandle)");
		return AtkObjectFactoryHandleExterns.atk_object_factory_create_accessible(factory, obj);
	}

	public static MentorLake.GObject.GType GetAccessibleType(this MentorLake.Atk.AtkObjectFactoryHandle factory)
	{
		if (factory.IsInvalid) throw new Exception("Invalid handle (AtkObjectFactoryHandle)");
		return AtkObjectFactoryHandleExterns.atk_object_factory_get_accessible_type(factory);
	}

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
