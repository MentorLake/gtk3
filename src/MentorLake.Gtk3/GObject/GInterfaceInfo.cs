namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A structure that provides information to the type system which is
/// used specifically for managing interface types.
/// </para>
/// </summary>

public class GInterfaceInfoHandle : BaseSafeHandle
{
}


public static class GInterfaceInfoExtensions
{

	public static GInterfaceInfo Dereference(this GInterfaceInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInterfaceInfo>(x.DangerousGetHandle());
}
internal class GInterfaceInfoExterns
{
}

/// <summary>
/// <para>
/// A structure that provides information to the type system which is
/// used specifically for managing interface types.
/// </para>
/// </summary>

public struct GInterfaceInfo
{
	/// <summary>
/// <para>
/// location of the interface initialization function
/// </para>
/// </summary>

public GInterfaceInitFunc interface_init;
	/// <summary>
/// <para>
/// location of the interface finalization function
/// </para>
/// </summary>

public GInterfaceFinalizeFunc interface_finalize;
	/// <summary>
/// <para>
/// user-supplied data passed to the interface init/finalize functions
/// </para>
/// </summary>

public IntPtr interface_data;
}
