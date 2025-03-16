namespace MentorLake.Gtk;

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

public struct GtkIMContextInfo
{
	public string context_id;
	public string context_name;
	public string domain;
	public string domain_dirname;
	public string default_locales;
}
