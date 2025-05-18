namespace MentorLake.Atk;

public class AtkGObjectAccessibleHandle : AtkObjectHandle
{
	public static MentorLake.Atk.AtkObjectHandle ForObject(MentorLake.GObject.GObjectHandle obj)
	{
		return AtkGObjectAccessibleHandleExterns.atk_gobject_accessible_for_object(obj);
	}

}

public static class AtkGObjectAccessibleHandleExtensions
{
	public static MentorLake.GObject.GObjectHandle GetObject(this MentorLake.Atk.AtkGObjectAccessibleHandle obj)
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkGObjectAccessibleHandle)");
		return AtkGObjectAccessibleHandleExterns.atk_gobject_accessible_get_object(obj);
	}

}

internal class AtkGObjectAccessibleHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle atk_gobject_accessible_get_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkGObjectAccessibleHandle>))] MentorLake.Atk.AtkGObjectAccessibleHandle obj);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_gobject_accessible_for_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle obj);

}
