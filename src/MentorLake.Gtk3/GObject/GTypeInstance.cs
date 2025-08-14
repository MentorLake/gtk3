namespace MentorLake.GObject;

/// <summary>
/// <para>
/// An opaque structure used as the base of all type instances.
/// </para>
/// </summary>

public class GTypeInstanceHandle : BaseSafeHandle
{
}


public static class GTypeInstanceExtensions
{

/// <param name="instance">
/// </param>
/// <param name="private_type">
/// </param>

	public static IntPtr GetPrivate(this MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType private_type)
	{
		if (instance.IsInvalid) throw new Exception("Invalid handle (GTypeInstance)");
		return GTypeInstanceExterns.g_type_instance_get_private(instance, private_type);
	}


	public static GTypeInstance Dereference(this GTypeInstanceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeInstance>(x.DangerousGetHandle());
}
internal class GTypeInstanceExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_type_instance_get_private([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType private_type);

}

/// <summary>
/// <para>
/// An opaque structure used as the base of all type instances.
/// </para>
/// </summary>

public struct GTypeInstance
{
}
