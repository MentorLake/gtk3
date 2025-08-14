namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for holding variation data. Registered OpenType
/// variation-axis tags are listed in
/// [OpenType Axis Tag Registry](https://docs.microsoft.com/en-us/typography/opentype/spec/dvaraxisreg).
/// </para>
/// </summary>

public class hb_variation_tHandle : BaseSafeHandle
{
}


public static class hb_variation_tExtensions
{
/// <summary>
/// <para>
/// Converts an #hb_variation_t into a `NULL`-terminated string in the format
/// understood by hb_variation_from_string(). The client in responsible for
/// allocating big enough size for @buf, 128 bytes is more than enough.
/// </para>
/// </summary>

/// <param name="variation">
/// an #hb_variation_t to convert
/// </param>
/// <param name="buf">
/// output string
/// </param>
/// <param name="size">
/// the allocated size of @buf
/// </param>

	public static void String(this MentorLake.HarfBuzz.hb_variation_tHandle variation, out string[] buf, out uint size)
	{
		if (variation.IsInvalid) throw new Exception("Invalid handle (hb_variation_t)");
		hb_variation_tExterns.hb_variation_to_string(variation, out buf, out size);
	}


	public static hb_variation_t Dereference(this hb_variation_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_variation_t>(x.DangerousGetHandle());
}
internal class hb_variation_tExterns
{
	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_variation_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_variation_tHandle>))] MentorLake.HarfBuzz.hb_variation_tHandle variation, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out string[] buf, out uint size);

}

/// <summary>
/// <para>
/// Data type for holding variation data. Registered OpenType
/// variation-axis tags are listed in
/// [OpenType Axis Tag Registry](https://docs.microsoft.com/en-us/typography/opentype/spec/dvaraxisreg).
/// </para>
/// </summary>

public struct hb_variation_t
{
	/// <summary>
/// <para>
/// The #hb_tag_t tag of the variation-axis name
/// </para>
/// </summary>

public hb_tag_t tag;
	/// <summary>
/// <para>
/// The value of the variation axis
/// </para>
/// </summary>

public float value;
}
