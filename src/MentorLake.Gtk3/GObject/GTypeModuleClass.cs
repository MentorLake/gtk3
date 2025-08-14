namespace MentorLake.GObject;

/// <summary>
/// <para>
/// In order to implement dynamic loading of types based on #GTypeModule,
/// the @load and @unload functions in #GTypeModuleClass must be implemented.
/// </para>
/// </summary>

public class GTypeModuleClassHandle : BaseSafeHandle
{
}


public static class GTypeModuleClassExtensions
{

	public static GTypeModuleClass Dereference(this GTypeModuleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeModuleClass>(x.DangerousGetHandle());
}
internal class GTypeModuleClassExterns
{
}

/// <summary>
/// <para>
/// In order to implement dynamic loading of types based on #GTypeModule,
/// the @load and @unload functions in #GTypeModuleClass must be implemented.
/// </para>
/// </summary>

public struct GTypeModuleClass
{
	/// <summary>
/// <para>
/// the parent class
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// loads the module and registers one or more types using
///  g_type_module_register_type().
/// </para>
/// </summary>

public IntPtr load;
	/// <summary>
/// <para>
/// unloads the module
/// </para>
/// </summary>

public IntPtr unload;
	
public IntPtr reserved1;
	
public IntPtr reserved2;
	
public IntPtr reserved3;
	
public IntPtr reserved4;
}
