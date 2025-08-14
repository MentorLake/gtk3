namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The GObjectConstructParam struct is an auxiliary structure used to hand
/// #GParamSpec/#GValue pairs to the @constructor of a #GObjectClass.
/// </para>
/// </summary>

public class GObjectConstructParamHandle : BaseSafeHandle
{
}


public static class GObjectConstructParamExtensions
{

	public static GObjectConstructParam Dereference(this GObjectConstructParamHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GObjectConstructParam>(x.DangerousGetHandle());
}
internal class GObjectConstructParamExterns
{
}

/// <summary>
/// <para>
/// The GObjectConstructParam struct is an auxiliary structure used to hand
/// #GParamSpec/#GValue pairs to the @constructor of a #GObjectClass.
/// </para>
/// </summary>

public struct GObjectConstructParam
{
	/// <summary>
/// <para>
/// the #GParamSpec of the construct parameter
/// </para>
/// </summary>

public IntPtr pspec;
	/// <summary>
/// <para>
/// the value to set the parameter to
/// </para>
/// </summary>

public IntPtr value;
}
