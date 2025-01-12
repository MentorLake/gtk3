namespace MentorLake.Gtk3.Pango;

public class PangoCoverageHandle : GObjectHandle
{
	public static PangoCoverageHandle New()
	{
		return PangoCoverageExterns.pango_coverage_new();
	}

	public static PangoCoverageHandle FromBytes(string bytes, int n_bytes)
	{
		return PangoCoverageExterns.pango_coverage_from_bytes(bytes, n_bytes);
	}

}

public static class PangoCoverageHandleExtensions
{
	public static PangoCoverageHandle Copy(this PangoCoverageHandle coverage)
	{
		return PangoCoverageExterns.pango_coverage_copy(coverage);
	}

	public static PangoCoverageLevel Get(this PangoCoverageHandle coverage, int index_)
	{
		return PangoCoverageExterns.pango_coverage_get(coverage, index_);
	}

	public static T Max<T>(this T coverage, PangoCoverageHandle other) where T : PangoCoverageHandle
	{
		PangoCoverageExterns.pango_coverage_max(coverage, other);
		return coverage;
	}

	public static PangoCoverageHandle Ref(this PangoCoverageHandle coverage)
	{
		return PangoCoverageExterns.pango_coverage_ref(coverage);
	}

	public static T Set<T>(this T coverage, int index_, PangoCoverageLevel level) where T : PangoCoverageHandle
	{
		PangoCoverageExterns.pango_coverage_set(coverage, index_, level);
		return coverage;
	}

	public static T ToBytes<T>(this T coverage, out string bytes, out int n_bytes) where T : PangoCoverageHandle
	{
		PangoCoverageExterns.pango_coverage_to_bytes(coverage, out bytes, out n_bytes);
		return coverage;
	}

	public static T Unref<T>(this T coverage) where T : PangoCoverageHandle
	{
		PangoCoverageExterns.pango_coverage_unref(coverage);
		return coverage;
	}

}

internal class PangoCoverageExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoCoverageHandle pango_coverage_new();

	[DllImport(Libraries.Pango)]
	internal static extern PangoCoverageHandle pango_coverage_copy(PangoCoverageHandle coverage);

	[DllImport(Libraries.Pango)]
	internal static extern PangoCoverageLevel pango_coverage_get(PangoCoverageHandle coverage, int index_);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_coverage_max(PangoCoverageHandle coverage, PangoCoverageHandle other);

	[DllImport(Libraries.Pango)]
	internal static extern PangoCoverageHandle pango_coverage_ref(PangoCoverageHandle coverage);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_coverage_set(PangoCoverageHandle coverage, int index_, PangoCoverageLevel level);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_coverage_to_bytes(PangoCoverageHandle coverage, out string bytes, out int n_bytes);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_coverage_unref(PangoCoverageHandle coverage);

	[DllImport(Libraries.Pango)]
	internal static extern PangoCoverageHandle pango_coverage_from_bytes(string bytes, int n_bytes);

}
