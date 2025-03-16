namespace MentorLake.GObject;

public class GTypePluginClassHandle : BaseSafeHandle
{
}


public static class GTypePluginClassExtensions
{

	public static GTypePluginClass Dereference(this GTypePluginClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypePluginClass>(x.DangerousGetHandle());
}
internal class GTypePluginClassExterns
{
}

public struct GTypePluginClass
{
	public GTypePluginUse use_plugin;
	public GTypePluginUnuse unuse_plugin;
	public GTypePluginCompleteTypeInfo complete_type_info;
	public GTypePluginCompleteInterfaceInfo complete_interface_info;
}
