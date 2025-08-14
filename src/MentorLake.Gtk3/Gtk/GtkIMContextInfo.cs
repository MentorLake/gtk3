namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Bookkeeping information about a loadable input method.
/// </para>
/// </summary>

public class GtkIMContextInfoHandle : BaseSafeHandle
{
}


public static class GtkIMContextInfoExtensions
{

	public static GtkIMContextInfo Dereference(this GtkIMContextInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIMContextInfo>(x.DangerousGetHandle());
}
internal class GtkIMContextInfoExterns
{
}

/// <summary>
/// <para>
/// Bookkeeping information about a loadable input method.
/// </para>
/// </summary>

public struct GtkIMContextInfo
{
	/// <summary>
/// <para>
/// The unique identification string of the input method.
/// </para>
/// </summary>

public string context_id;
	/// <summary>
/// <para>
/// The human-readable name of the input method.
/// </para>
/// </summary>

public string context_name;
	/// <summary>
/// <para>
/// Translation domain to be used with dgettext()
/// </para>
/// </summary>

public string domain;
	/// <summary>
/// <para>
/// Name of locale directory for use with bindtextdomain()
/// </para>
/// </summary>

public string domain_dirname;
	/// <summary>
/// <para>
/// A colon-separated list of locales where this input method
///   should be the default. The asterisk “*” sets the default for all locales.
/// </para>
/// </summary>

public string default_locales;
}
