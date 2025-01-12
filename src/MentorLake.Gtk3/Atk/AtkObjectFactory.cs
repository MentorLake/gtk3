namespace MentorLake.Gtk3.Atk;

public class AtkObjectFactoryHandle : GObjectHandle
{
}

public static class AtkObjectFactoryHandleExtensions
{
	public static AtkObjectHandle CreateAccessible(this AtkObjectFactoryHandle factory, GObjectHandle obj)
	{
		return AtkObjectFactoryExterns.atk_object_factory_create_accessible(factory, obj);
	}

	public static GType GetAccessibleType(this AtkObjectFactoryHandle factory)
	{
		return AtkObjectFactoryExterns.atk_object_factory_get_accessible_type(factory);
	}

	public static T Invalidate<T>(this T factory) where T : AtkObjectFactoryHandle
	{
		AtkObjectFactoryExterns.atk_object_factory_invalidate(factory);
		return factory;
	}

}

internal class AtkObjectFactoryExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_object_factory_create_accessible(AtkObjectFactoryHandle factory, GObjectHandle obj);

	[DllImport(Libraries.Atk)]
	internal static extern GType atk_object_factory_get_accessible_type(AtkObjectFactoryHandle factory);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_object_factory_invalidate(AtkObjectFactoryHandle factory);

}
