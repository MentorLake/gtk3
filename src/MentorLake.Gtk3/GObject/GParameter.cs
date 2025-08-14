namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The GParameter struct is an auxiliary structure used
/// to hand parameter name/value pairs to g_object_newv().
/// </para>
/// </summary>

public class GParameterHandle : BaseSafeHandle
{
}


public static class GParameterExtensions
{

	public static GParameter Dereference(this GParameterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GParameter>(x.DangerousGetHandle());
}
internal class GParameterExterns
{
}

/// <summary>
/// <para>
/// The GParameter struct is an auxiliary structure used
/// to hand parameter name/value pairs to g_object_newv().
/// </para>
/// </summary>

public struct GParameter
{
	/// <summary>
/// <para>
/// the parameter name
/// </para>
/// </summary>

public string name;
	/// <summary>
/// <para>
/// the parameter value
/// </para>
/// </summary>

public GValue value;
}
