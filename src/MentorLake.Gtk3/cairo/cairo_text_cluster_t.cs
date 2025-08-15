namespace MentorLake.cairo;

/// <summary>
/// <para>
/// The #cairo_text_cluster_t structure holds information about a single
/// &amp;lt;firstterm&amp;gt;text cluster&amp;lt;/firstterm&amp;gt;.  A text cluster is a minimal
/// mapping of some glyphs corresponding to some UTF-8 text.
/// </para>
/// <para>
/// For a cluster to be valid, both @num_bytes and @num_glyphs should
/// be non-negative, and at least one should be non-zero.
/// Note that clusters with zero glyphs are not as well supported as
/// normal clusters.  For example, PDF rendering applications typically
/// ignore those clusters when PDF text is being selected.
/// </para>
/// <para>
/// See cairo_show_text_glyphs() for how clusters are used in advanced
/// text operations.
/// </para>
/// </summary>

public class cairo_text_cluster_tHandle : BaseSafeHandle
{
}


public static class cairo_text_cluster_tExtensions
{

	public static cairo_text_cluster_t Dereference(this cairo_text_cluster_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_text_cluster_t>(x.DangerousGetHandle());
}
internal class cairo_text_cluster_tExterns
{
}

/// <summary>
/// <para>
/// The #cairo_text_cluster_t structure holds information about a single
/// &amp;lt;firstterm&amp;gt;text cluster&amp;lt;/firstterm&amp;gt;.  A text cluster is a minimal
/// mapping of some glyphs corresponding to some UTF-8 text.
/// </para>
/// <para>
/// For a cluster to be valid, both @num_bytes and @num_glyphs should
/// be non-negative, and at least one should be non-zero.
/// Note that clusters with zero glyphs are not as well supported as
/// normal clusters.  For example, PDF rendering applications typically
/// ignore those clusters when PDF text is being selected.
/// </para>
/// <para>
/// See cairo_show_text_glyphs() for how clusters are used in advanced
/// text operations.
/// </para>
/// </summary>

public struct cairo_text_cluster_t
{
	/// <summary>
/// <para>
/// the number of bytes of UTF-8 text covered by cluster
/// </para>
/// </summary>

public int num_bytes;
	/// <summary>
/// <para>
/// the number of glyphs covered by cluster
/// </para>
/// </summary>

public int num_glyphs;
}
