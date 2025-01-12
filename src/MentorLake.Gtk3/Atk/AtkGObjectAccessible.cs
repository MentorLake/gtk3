namespace MentorLake.Gtk3.Atk;

public class AtkGObjectAccessibleHandle : AtkObjectHandle
{
	public static AtkObjectHandle AtkGobjectAccessibleForObject(GObjectHandle obj)
	{
		return AtkGObjectAccessibleExterns.atk_gobject_accessible_for_object(obj);
	}

}

public static class AtkGObjectAccessibleHandleExtensions
{
	public static GObjectHandle AtkGobjectAccessibleGetObject(this AtkGObjectAccessibleHandle obj)
	{
		return AtkGObjectAccessibleExterns.atk_gobject_accessible_get_object(obj);
	}

}

internal class AtkGObjectAccessibleExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern GObjectHandle atk_gobject_accessible_get_object(AtkGObjectAccessibleHandle obj);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_gobject_accessible_for_object(GObjectHandle obj);

}
