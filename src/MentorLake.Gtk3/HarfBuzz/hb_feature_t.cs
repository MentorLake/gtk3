namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The #hb_feature_t is the structure that holds information about requested
/// feature application. The feature will be applied with the given value to all
/// glyphs which are in clusters between @start (inclusive) and @end (exclusive).
/// Setting start to #HB_FEATURE_GLOBAL_START and end to #HB_FEATURE_GLOBAL_END
/// specifies that the feature always applies to the entire buffer.
/// </para>
/// </summary>

public class hb_feature_tHandle : BaseSafeHandle
{
}


public static class hb_feature_tExtensions
{
/// <summary>
/// <para>
/// Converts a #hb_feature_t into a `NULL`-terminated string in the format
/// understood by hb_feature_from_string(). The client in responsible for
/// allocating big enough size for @buf, 128 bytes is more than enough.
/// </para>
/// </summary>

/// <param name="feature">
/// an #hb_feature_t to convert
/// </param>
/// <param name="buf">
/// output string
/// </param>
/// <param name="size">
/// the allocated size of @buf
/// </param>

	public static void String(this MentorLake.HarfBuzz.hb_feature_tHandle feature, out string[] buf, out uint size)
	{
		if (feature.IsInvalid) throw new Exception("Invalid handle (hb_feature_t)");
		hb_feature_tExterns.hb_feature_to_string(feature, out buf, out size);
	}


	public static hb_feature_t Dereference(this hb_feature_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_feature_t>(x.DangerousGetHandle());
}
internal class hb_feature_tExterns
{
	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_feature_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_feature_tHandle>))] MentorLake.HarfBuzz.hb_feature_tHandle feature, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out string[] buf, out uint size);

}

/// <summary>
/// <para>
/// The #hb_feature_t is the structure that holds information about requested
/// feature application. The feature will be applied with the given value to all
/// glyphs which are in clusters between @start (inclusive) and @end (exclusive).
/// Setting start to #HB_FEATURE_GLOBAL_START and end to #HB_FEATURE_GLOBAL_END
/// specifies that the feature always applies to the entire buffer.
/// </para>
/// </summary>

public struct hb_feature_t
{
	/// <summary>
/// <para>
/// The #hb_tag_t tag of the feature
/// </para>
/// </summary>

public hb_tag_t tag;
	/// <summary>
/// <para>
/// The value of the feature. 0 disables the feature, non-zero (usually
/// 1) enables the feature.  For features implemented as lookup type 3 (like
/// &apos;salt&apos;) the @value is a one based index into the alternates.
/// </para>
/// </summary>

public uint value;
	/// <summary>
/// <para>
/// the cluster to start applying this feature setting (inclusive).
/// </para>
/// </summary>

public uint start;
	/// <summary>
/// <para>
/// the cluster to end applying this feature setting (exclusive).
/// </para>
/// </summary>

public uint end;
}
