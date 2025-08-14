namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAnalysis` structure stores information about
/// the properties of a segment of text.
/// </para>
/// </summary>

public class PangoAnalysisHandle : BaseSafeHandle
{
}


public static class PangoAnalysisExtensions
{

	public static PangoAnalysis Dereference(this PangoAnalysisHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAnalysis>(x.DangerousGetHandle());
}
internal class PangoAnalysisExterns
{
}

/// <summary>
/// <para>
/// The `PangoAnalysis` structure stores information about
/// the properties of a segment of text.
/// </para>
/// </summary>

public struct PangoAnalysis
{
	/// <summary>
/// <para>
/// unused, reserved
/// </para>
/// </summary>

public IntPtr shape_engine;
	/// <summary>
/// <para>
/// unused, reserved
/// </para>
/// </summary>

public IntPtr lang_engine;
	/// <summary>
/// <para>
/// the font for this segment.
/// </para>
/// </summary>

public IntPtr font;
	/// <summary>
/// <para>
/// the bidirectional level for this segment.
/// </para>
/// </summary>

public byte level;
	/// <summary>
/// <para>
/// the glyph orientation for this segment (A `PangoGravity`).
/// </para>
/// </summary>

public byte gravity;
	/// <summary>
/// <para>
/// boolean flags for this segment (Since: 1.16).
/// </para>
/// </summary>

public byte flags;
	/// <summary>
/// <para>
/// the detected script for this segment (A `PangoScript`) (Since: 1.18).
/// </para>
/// </summary>

public byte script;
	/// <summary>
/// <para>
/// the detected language for this segment.
/// </para>
/// </summary>

public IntPtr language;
	/// <summary>
/// <para>
/// extra attributes for this segment.
/// </para>
/// </summary>

public IntPtr extra_attrs;
}
