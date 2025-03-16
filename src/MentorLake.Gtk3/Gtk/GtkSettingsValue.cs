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
	public string origin;
	public GValue value;
}
