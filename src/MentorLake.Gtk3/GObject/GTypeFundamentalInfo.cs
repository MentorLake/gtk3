namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A structure that provides information to the type system which is
/// used specifically for managing fundamental types.
/// </para>
/// </summary>

public class GTypeFundamentalInfoHandle : BaseSafeHandle
{
}


public static class GTypeFundamentalInfoExtensions
{

	public static GTypeFundamentalInfo Dereference(this GTypeFundamentalInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeFundamentalInfo>(x.DangerousGetHandle());
}
internal class GTypeFundamentalInfoExterns
{
}

/// <summary>
/// <para>
/// A structure that provides information to the type system which is
/// used specifically for managing fundamental types.
/// </para>
/// </summary>

public struct GTypeFundamentalInfo
{
	/// <summary>
/// <para>
/// #GTypeFundamentalFlags describing the characteristics of the fundamental type
/// </para>
/// </summary>

public GTypeFundamentalFlags type_flags;
}
