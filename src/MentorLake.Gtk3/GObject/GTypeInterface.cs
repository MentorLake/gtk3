namespace MentorLake.GObject;

public class GTypeInterfaceHandle : BaseSafeHandle
{
}


public static class GTypeInterfaceExtensions
{
	public static MentorLake.GObject.GTypeInterfaceHandle PeekParent(this MentorLake.GObject.GTypeInterfaceHandle g_iface)
	{
		if (g_iface.IsInvalid || g_iface.IsClosed) throw new Exception("Invalid or closed handle (GTypeInterface)");
		return GTypeInterfaceExterns.g_type_interface_peek_parent(g_iface);
	}


	public static GTypeInterface Dereference(this GTypeInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeInterface>(x.DangerousGetHandle());
}
internal class GTypeInterfaceExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GTypeInterfaceHandle g_type_interface_peek_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_interface_add_prerequisite(MentorLake.GObject.GType interface_type, MentorLake.GObject.GType prerequisite_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GTypePluginHandle g_type_interface_get_plugin(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_interface_instantiatable_prerequisite(MentorLake.GObject.GType interface_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GTypeInterfaceHandle g_type_interface_peek([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle instance_class, MentorLake.GObject.GType iface_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType[] g_type_interface_prerequisites(MentorLake.GObject.GType interface_type, out uint n_prerequisites);

}

public struct GTypeInterface
{
	public static void AddPrerequisite(MentorLake.GObject.GType interface_type, MentorLake.GObject.GType prerequisite_type)
	{
		GTypeInterfaceExterns.g_type_interface_add_prerequisite(interface_type, prerequisite_type);
	}

	public static MentorLake.GObject.GTypePluginHandle GetPlugin(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type)
	{
		return GTypeInterfaceExterns.g_type_interface_get_plugin(instance_type, interface_type);
	}

	public static MentorLake.GObject.GType InstantiatablePrerequisite(MentorLake.GObject.GType interface_type)
	{
		return GTypeInterfaceExterns.g_type_interface_instantiatable_prerequisite(interface_type);
	}

	public static MentorLake.GObject.GTypeInterfaceHandle Peek(MentorLake.GObject.GTypeClassHandle instance_class, MentorLake.GObject.GType iface_type)
	{
		return GTypeInterfaceExterns.g_type_interface_peek(instance_class, iface_type);
	}

	public static MentorLake.GObject.GType[] Prerequisites(MentorLake.GObject.GType interface_type, out uint n_prerequisites)
	{
		return GTypeInterfaceExterns.g_type_interface_prerequisites(interface_type, out n_prerequisites);
	}

}
