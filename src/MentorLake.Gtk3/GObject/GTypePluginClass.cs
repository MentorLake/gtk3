namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The #GTypePlugin interface is used by the type system in order to handle
/// the lifecycle of dynamically loaded types.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The #GTypePlugin interface is used by the type system in order to handle
/// the lifecycle of dynamically loaded types.
/// </para>
/// </summary>

public struct GTypePluginClass
{
	/// <summary>
/// <para>
/// Increases the use count of the plugin.
/// </para>
/// </summary>

public GTypePluginUse use_plugin;
	/// <summary>
/// <para>
/// Decreases the use count of the plugin.
/// </para>
/// </summary>

public GTypePluginUnuse unuse_plugin;
	/// <summary>
/// <para>
/// Fills in the #GTypeInfo and
///  #GTypeValueTable structs for the type. The structs are initialized
///  with `memset(s, 0, sizeof (s))` before calling this function.
/// </para>
/// </summary>

public GTypePluginCompleteTypeInfo complete_type_info;
	/// <summary>
/// <para>
/// Fills in missing parts of the #GInterfaceInfo
///  for the interface. The structs is initialized with
///  `memset(s, 0, sizeof (s))` before calling this function.
/// </para>
/// </summary>

public GTypePluginCompleteInterfaceInfo complete_interface_info;
}
