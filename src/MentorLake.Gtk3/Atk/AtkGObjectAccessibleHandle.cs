namespace MentorLake.Atk;

/// <summary>
/// <para>
/// This object class is derived from AtkObject and can be used as a basis implementing accessible objects.
/// </para>
/// <para>
/// This object class is derived from AtkObject. It can be used as a
/// basis for implementing accessible objects for GObjects which are
/// not derived from GtkWidget. One example of its use is in providing
/// an accessible object for GnomeCanvasItem in the GAIL library.
/// </para>
/// </summary>

public class AtkGObjectAccessibleHandle : AtkObjectHandle
{
/// <summary>
/// <para>
/// Gets the accessible object for the specified @obj.
/// </para>
/// </summary>

/// <param name="obj">
/// a #GObject
/// </param>
/// <return>
/// a #AtkObject which is the accessible object for
/// the @obj
/// </return>

	public static MentorLake.Atk.AtkObjectHandle ForObject(MentorLake.GObject.GObjectHandle obj)
	{
		return AtkGObjectAccessibleHandleExterns.atk_gobject_accessible_for_object(obj);
	}

}

public static class AtkGObjectAccessibleHandleExtensions
{
/// <summary>
/// <para>
/// Gets the GObject for which @obj is the accessible object.
/// </para>
/// </summary>

/// <param name="obj">
/// a #AtkGObjectAccessible
/// </param>
/// <return>
/// a #GObject which is the object for which @obj is
/// the accessible object
/// </return>

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
