namespace MentorLake.Pango;

public class PangoCoverageHandle : GObjectHandle
{
	public static MentorLake.Pango.PangoCoverageHandle New()
	{
		return PangoCoverageHandleExterns.pango_coverage_new();
	}

	public static MentorLake.Pango.PangoCoverageHandle FromBytes(byte[] bytes, int n_bytes)
	{
		return PangoCoverageHandleExterns.pango_coverage_from_bytes(bytes, n_bytes);
	}

}

public static class PangoCoverageHandleExtensions
{
	public static MentorLake.Pango.PangoCoverageHandle Copy(this MentorLake.Pango.PangoCoverageHandle coverage)
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		return PangoCoverageHandleExterns.pango_coverage_copy(coverage);
	}

	public static MentorLake.Pango.PangoCoverageLevel Get(this MentorLake.Pango.PangoCoverageHandle coverage, int index_)
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		return PangoCoverageHandleExterns.pango_coverage_get(coverage, index_);
	}

	public static T Max<T>(this T coverage, MentorLake.Pango.PangoCoverageHandle other) where T : PangoCoverageHandle
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		PangoCoverageHandleExterns.pango_coverage_max(coverage, other);
		return coverage;
	}

	public static MentorLake.Pango.PangoCoverageHandle Ref(this MentorLake.Pango.PangoCoverageHandle coverage)
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		return PangoCoverageHandleExterns.pango_coverage_ref(coverage);
	}

	public static T Set<T>(this T coverage, int index_, MentorLake.Pango.PangoCoverageLevel level) where T : PangoCoverageHandle
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		PangoCoverageHandleExterns.pango_coverage_set(coverage, index_, level);
		return coverage;
	}

	public static T ToBytes<T>(this T coverage, out byte[] bytes, out int n_bytes) where T : PangoCoverageHandle
	{
		if (coverage.IsInvalid) throw new Exception("Invalid handle (PangoCoverageHandle)");
		PangoCoverageHandleExterns.pango_coverage_to_bytes(coverage, out bytes, out n_bytes);
		return coverage;
	}

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))]
	internal static extern MentorLake.Pango.PangoCoverageHandle pango_coverage_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoCoverageLevel pango_coverage_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage, int index_);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_coverage_max([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle other);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))]
	internal static extern MentorLake.Pango.PangoCoverageHandle pango_coverage_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_coverage_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage, int index_, MentorLake.Pango.PangoCoverageLevel level);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_coverage_to_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage, out byte[] bytes, out int n_bytes);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_coverage_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))] MentorLake.Pango.PangoCoverageHandle coverage);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoCoverageHandle>))]
	internal static extern MentorLake.Pango.PangoCoverageHandle pango_coverage_from_bytes(byte[] bytes, int n_bytes);

}
