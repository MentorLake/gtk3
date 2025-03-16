namespace MentorLake.GObject;

public class GTypeInstanceHandle : BaseSafeHandle
{
}


public static class GTypeInstanceExtensions
{
	public static IntPtr GetPrivate(this MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType private_type)
	{
		return GTypeInstanceExterns.g_type_instance_get_private(instance, private_type);
	}


	public static GTypeInstance Dereference(this GTypeInstanceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeInstance>(x.DangerousGetHandle());
}
internal class GTypeInstanceExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_type_instance_get_private([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, MentorLake.GObject.GType private_type);

}

public struct GTypeInstance
{
}
