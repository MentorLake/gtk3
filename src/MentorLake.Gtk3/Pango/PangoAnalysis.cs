namespace MentorLake.Pango;

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

public struct PangoAnalysis
{
	public IntPtr shape_engine;
	public IntPtr lang_engine;
	public IntPtr font;
	public byte level;
	public byte gravity;
	public byte flags;
	public byte script;
	public IntPtr language;
	public IntPtr extra_attrs;
}
