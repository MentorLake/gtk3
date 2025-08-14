namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAttrFloat` structure is used to represent attributes with
/// a float or double value.
/// </para>
/// </summary>

public class PangoAttrFloatHandle : BaseSafeHandle
{
}


public static class PangoAttrFloatExtensions
{

	public static PangoAttrFloat Dereference(this PangoAttrFloatHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrFloat>(x.DangerousGetHandle());
}
internal class PangoAttrFloatExterns
{
}

/// <summary>
/// <para>
/// The `PangoAttrFloat` structure is used to represent attributes with
/// a float or double value.
/// </para>
/// </summary>

public struct PangoAttrFloat
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

public double value;
}
