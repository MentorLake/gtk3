namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAttrString` structure is used to represent attributes with
/// a string value.
/// </para>
/// </summary>

public class PangoAttrStringHandle : BaseSafeHandle
{
}


public static class PangoAttrStringExtensions
{

	public static PangoAttrString Dereference(this PangoAttrStringHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrString>(x.DangerousGetHandle());
}
internal class PangoAttrStringExterns
{
}

/// <summary>
/// <para>
/// The `PangoAttrString` structure is used to represent attributes with
/// a string value.
/// </para>
/// </summary>

public struct PangoAttrString
{
	/// <summary>
/// <para>
/// the common portion of the attribute
/// </para>
/// </summary>

public PangoAttribute attr;
	/// <summary>
/// <para>
/// the string which is the value of the attribute
/// </para>
/// </summary>

public string value;
}
