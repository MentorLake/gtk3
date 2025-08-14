namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAttrColor` structure is used to represent attributes that
/// are colors.
/// </para>
/// </summary>

public class PangoAttrColorHandle : BaseSafeHandle
{
}


public static class PangoAttrColorExtensions
{

	public static PangoAttrColor Dereference(this PangoAttrColorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrColor>(x.DangerousGetHandle());
}
internal class PangoAttrColorExterns
{
}

/// <summary>
/// <para>
/// The `PangoAttrColor` structure is used to represent attributes that
/// are colors.
/// </para>
/// </summary>

public struct PangoAttrColor
{
	/// <summary>
/// <para>
/// the common portion of the attribute
/// </para>
/// </summary>

public PangoAttribute attr;
	/// <summary>
/// <para>
/// the `PangoColor` which is the value of the attribute
/// </para>
/// </summary>

public PangoColor color;
}
