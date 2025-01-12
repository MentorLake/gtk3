namespace MentorLake.Gtk3.GObject;

public class GTypeInterfaceHandle : BaseSafeHandle
{
}


public static class GTypeInterfaceHandleExtensions
{
	public static GTypeInterfaceHandle PeekParent(this GTypeInterfaceHandle g_iface)
	{
		return GTypeInterfaceExterns.g_type_interface_peek_parent(g_iface);
	}

	public static void AddPrerequisite(GType interface_type, GType prerequisite_type)
	{
		GTypeInterfaceExterns.g_type_interface_add_prerequisite(interface_type, prerequisite_type);
	}

	public static GTypePluginHandle GetPlugin(GType instance_type, GType interface_type)
	{
		return GTypeInterfaceExterns.g_type_interface_get_plugin(instance_type, interface_type);
	}

	public static GType InstantiatablePrerequisite(GType interface_type)
	{
		return GTypeInterfaceExterns.g_type_interface_instantiatable_prerequisite(interface_type);
	}

	public static GTypeInterfaceHandle Peek(GTypeClassHandle instance_class, GType iface_type)
	{
		return GTypeInterfaceExterns.g_type_interface_peek(instance_class, iface_type);
	}

	public static IntPtr Prerequisites(GType interface_type, out uint n_prerequisites)
	{
		return GTypeInterfaceExterns.g_type_interface_prerequisites(interface_type, out n_prerequisites);
	}

}
internal class GTypeInterfaceExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GTypeInterfaceHandle g_type_interface_peek_parent(GTypeInterfaceHandle g_iface);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_interface_add_prerequisite(GType interface_type, GType prerequisite_type);

	[DllImport(Libraries.GObject)]
	internal static extern GTypePluginHandle g_type_interface_get_plugin(GType instance_type, GType interface_type);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_interface_instantiatable_prerequisite(GType interface_type);

	[DllImport(Libraries.GObject)]
	internal static extern GTypeInterfaceHandle g_type_interface_peek(GTypeClassHandle instance_class, GType iface_type);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_type_interface_prerequisites(GType interface_type, out uint n_prerequisites);

}

public struct GTypeInterface
{
}
