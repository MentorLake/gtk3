namespace MentorLake.Gtk;

public class GtkSettingsPrivateHandle : BaseSafeHandle
{
}


public static class GtkSettingsPrivateExtensions
{

	public static GtkSettingsPrivate Dereference(this GtkSettingsPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSettingsPrivate>(x.DangerousGetHandle());
}
internal class GtkSettingsPrivateExterns
{
}

public struct GtkSettingsPrivate
{
}
