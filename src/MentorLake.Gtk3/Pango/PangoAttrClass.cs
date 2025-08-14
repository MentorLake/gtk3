namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAttrClass` structure stores the type and operations for
/// a particular type of attribute.
/// </para>
/// <para>
/// The functions in this structure should not be called directly. Instead,
/// one should use the wrapper functions provided for `PangoAttribute`.
/// </para>
/// </summary>

public class PangoAttrClassHandle : BaseSafeHandle
{
}


public static class PangoAttrClassExtensions
{

	public static PangoAttrClass Dereference(this PangoAttrClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrClass>(x.DangerousGetHandle());
}
internal class PangoAttrClassExterns
{
}

/// <summary>
/// <para>
/// The `PangoAttrClass` structure stores the type and operations for
/// a particular type of attribute.
/// </para>
/// <para>
/// The functions in this structure should not be called directly. Instead,
/// one should use the wrapper functions provided for `PangoAttribute`.
/// </para>
/// </summary>

public struct PangoAttrClass
{
	/// <summary>
/// <para>
/// the type ID for this attribute
/// </para>
/// </summary>

public PangoAttrType type;
	/// <summary>
/// <para>
/// function to duplicate an attribute of this type
///   (see [method@Pango.Attribute.copy])
/// </para>
/// </summary>

public IntPtr copy;
	/// <summary>
/// <para>
/// function to free an attribute of this type
///   (see [method@Pango.Attribute.destroy])
/// </para>
/// </summary>

public IntPtr destroy;
	/// <summary>
/// <para>
/// function to check two attributes of this type for equality
///   (see [method@Pango.Attribute.equal])
/// </para>
/// </summary>

public IntPtr equal;
}
