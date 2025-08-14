namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAttrSize` structure is used to represent attributes which
/// set font size.
/// </para>
/// </summary>

public class PangoAttrSizeHandle : BaseSafeHandle
{
}


public static class PangoAttrSizeExtensions
{

	public static PangoAttrSize Dereference(this PangoAttrSizeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrSize>(x.DangerousGetHandle());
}
internal class PangoAttrSizeExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_size_new(int size);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_size_new_absolute(int size);

}

/// <summary>
/// <para>
/// The `PangoAttrSize` structure is used to represent attributes which
/// set font size.
/// </para>
/// </summary>

public struct PangoAttrSize
{
	/// <summary>
/// <para>
/// the common portion of the attribute
/// </para>
/// </summary>

public PangoAttribute attr;
	/// <summary>
/// <para>
/// size of font, in units of 1/%PANGO_SCALE of a point (for
///   %PANGO_ATTR_SIZE) or of a device unit (for %PANGO_ATTR_ABSOLUTE_SIZE)
/// </para>
/// </summary>

public int size;
	/// <summary>
/// <para>
/// whether the font size is in device units or points.
///   This field is only present for compatibility with Pango-1.8.0
///   (%PANGO_ATTR_ABSOLUTE_SIZE was added in 1.8.1); and always will
///   be %FALSE for %PANGO_ATTR_SIZE and %TRUE for %PANGO_ATTR_ABSOLUTE_SIZE.
/// </para>
/// </summary>

public uint absolute;
/// <summary>
/// <para>
/// Create a new font-size attribute in fractional points.
/// </para>
/// </summary>

/// <param name="size">
/// the font size, in %PANGO_SCALE-ths of a point
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle New(int size)
	{
		return PangoAttrSizeExterns.pango_attr_size_new(size);
	}

/// <summary>
/// <para>
/// Create a new font-size attribute in device units.
/// </para>
/// </summary>

/// <param name="size">
/// the font size, in %PANGO_SCALE-ths of a device unit
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle NewAbsolute(int size)
	{
		return PangoAttrSizeExterns.pango_attr_size_new_absolute(size);
	}

}
