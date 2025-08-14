namespace MentorLake.Gtk;


public class GtkSettingsValueHandle : BaseSafeHandle
{
}


public static class GtkSettingsValueExtensions
{

	public static GtkSettingsValue Dereference(this GtkSettingsValueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSettingsValue>(x.DangerousGetHandle());
}
internal class GtkSettingsValueExterns
{
}


public struct GtkSettingsValue
{
	/// <summary>
/// <para>
/// Origin should be something like “filename:linenumber” for
///    rc files, or e.g. “XProperty” for other sources.
/// </para>
/// </summary>

public string origin;
	/// <summary>
/// <para>
/// Valid types are LONG, DOUBLE and STRING corresponding to
///    the token parsed, or a GSTRING holding an unparsed statement
/// </para>
/// </summary>

public GValue value;
}
