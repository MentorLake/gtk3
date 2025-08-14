namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAttrInt` structure is used to represent attributes with
/// an integer or enumeration value.
/// </para>
/// </summary>

public class PangoAttrIntHandle : BaseSafeHandle
{
}


public static class PangoAttrIntExtensions
{

	public static PangoAttrInt Dereference(this PangoAttrIntHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrInt>(x.DangerousGetHandle());
}
internal class PangoAttrIntExterns
{
}

/// <summary>
/// <para>
/// The `PangoAttrInt` structure is used to represent attributes with
/// an integer or enumeration value.
/// </para>
/// </summary>

public struct PangoAttrInt
{
	/// <summary>
/// <para>
/// the common portion of the attribute
/// </para>
/// </summary>

public PangoAttribute attr;
	/// <summary>
/// <para>
/// the value of the attribute
/// </para>
/// </summary>

public int value;
}
