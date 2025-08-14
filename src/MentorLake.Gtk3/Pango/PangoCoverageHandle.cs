namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoCoverage` structure is a map from Unicode characters
/// to [enum@Pango.CoverageLevel] values.
/// </para>
/// <para>
/// It is often necessary in Pango to determine if a particular
/// font can represent a particular character, and also how well
/// it can represent that character. The `PangoCoverage` is a data
/// structure that is used to represent that information. It is an
/// opaque structure with no public fields.
/// </para>
/// </summary>

public class PangoCoverageHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new `PangoCoverage`
/// </para>
/// </summary>

/// <return>
/// the newly allocated `PangoCoverage`, initialized
///   to %PANGO_COVERAGE_NONE with a reference count of one, which
///   should be freed with [method@Pango.Coverage.unref].
/// </return>

	public static MentorLake.Pango.PangoCoverageHandle New()
	{
		return PangoCoverageHandleExterns.pango_coverage_new();
	}

/// <summary>
/// <para>
/// Convert data generated from [method@Pango.Coverage.to_bytes]
/// back to a `PangoCoverage`.
/// </para>
/// </summary>

/// <param name="bytes">
/// binary data
///   representing a `PangoCoverage`
/// </param>
/// <param name="n_bytes">
/// the size of @bytes in bytes
/// </param>
/// <return>
/// a newly allocated `PangoCoverage`
/// </return>

	public static MentorLake.Pango.PangoCoverageHandle FromBytes(byte[] bytes, int n_bytes)
	{
		return PangoCoverageHandleExterns.pango_coverage_from_bytes(bytes, n_bytes);
	}

}

public static class PangoCoverageHandleExtensions
{
/// <summary>
/// <para>
/// Copy an existing `PangoCoverage`.
/// </para>
/// </summary>

/// <param name="coverage">
/// a `PangoCoverage`
/// </param>
/// <return>
/// the newly allocated `PangoCoverage`,
///   with a reference count of one, which should be freed with
///   [method@Pango.Coverage.unref].
/// </return>

	public static MentorLake.Pango.PangoCoverageHandle Copy(this MentorLake.Pango.PangoCoverageHandle coverage)
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		return PangoCoverageHandleExterns.pango_coverage_copy(coverage);
	}

/// <summary>
/// <para>
/// Determine whether a particular index is covered by @coverage.
/// </para>
/// </summary>

/// <param name="coverage">
/// a `PangoCoverage`
/// </param>
/// <param name="index_">
/// the index to check
/// </param>
/// <return>
/// the coverage level of @coverage for character @index_.
/// </return>

	public static MentorLake.Pango.PangoCoverageLevel Get(this MentorLake.Pango.PangoCoverageHandle coverage, int index_)
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		return PangoCoverageHandleExterns.pango_coverage_get(coverage, index_);
	}

/// <summary>
/// <para>
/// Set the coverage for each index in @coverage to be the max (better)
/// value of the current coverage for the index and the coverage for
/// the corresponding index in @other.
/// </para>
/// </summary>

/// <param name="coverage">
/// a `PangoCoverage`
/// </param>
/// <param name="other">
/// another `PangoCoverage`
/// </param>

	public static T Max<T>(this T coverage, MentorLake.Pango.PangoCoverageHandle other) where T : PangoCoverageHandle
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		PangoCoverageHandleExterns.pango_coverage_max(coverage, other);
		return coverage;
	}

/// <summary>
/// <para>
/// Increase the reference count on the `PangoCoverage` by one.
/// </para>
/// </summary>

/// <param name="coverage">
/// a `PangoCoverage`
/// </param>
/// <return>
/// @coverage
/// </return>

	public static MentorLake.Pango.PangoCoverageHandle Ref(this MentorLake.Pango.PangoCoverageHandle coverage)
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		return PangoCoverageHandleExterns.pango_coverage_ref(coverage);
	}

/// <summary>
/// <para>
/// Modify a particular index within @coverage
/// </para>
/// </summary>

/// <param name="coverage">
/// a `PangoCoverage`
/// </param>
/// <param name="index_">
/// the index to modify
/// </param>
/// <param name="level">
/// the new level for @index_
/// </param>

	public static T Set<T>(this T coverage, int index_, MentorLake.Pango.PangoCoverageLevel level) where T : PangoCoverageHandle
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		PangoCoverageHandleExterns.pango_coverage_set(coverage, index_, level);
		return coverage;
	}

/// <summary>
/// <para>
/// Convert a `PangoCoverage` structure into a flat binary format.
/// </para>
/// </summary>

/// <param name="coverage">
/// a `PangoCoverage`
/// </param>
/// <param name="bytes">
/// 
///   location to store result (must be freed with g_free())
/// </param>
/// <param name="n_bytes">
/// location to store size of result
/// </param>

	public static T ToBytes<T>(this T coverage, out byte[] bytes, out int n_bytes) where T : PangoCoverageHandle
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		PangoCoverageHandleExterns.pango_coverage_to_bytes(coverage, out bytes, out n_bytes);
		return coverage;
	}

/// <summary>
/// <para>
/// Decrease the reference count on the `PangoCoverage` by one.
/// </para>
/// <para>
/// If the result is zero, free the coverage and all associated memory.
/// </para>
/// </summary>

/// <param name="coverage">
/// a `PangoCoverage`
/// </param>

	public static T Unref<T>(this T coverage) where T : PangoCoverageHandle
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		PangoCoverageHandleExterns.pango_coverage_unref(coverage);
		return coverage;
	}

}

internal class PangoCoverageHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))]
	internal static extern MentorLake.Pango.PangoCoverageHandle pango_coverage_new();

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))]
	internal static extern MentorLake.Pango.PangoCoverageHandle pango_coverage_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoCoverageLevel pango_coverage_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage, int index_);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_coverage_max([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle other);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))]
	internal static extern MentorLake.Pango.PangoCoverageHandle pango_coverage_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_coverage_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage, int index_, MentorLake.Pango.PangoCoverageLevel level);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_coverage_to_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] bytes, out int n_bytes);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_coverage_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))]
	internal static extern MentorLake.Pango.PangoCoverageHandle pango_coverage_from_bytes(byte[] bytes, int n_bytes);

}
