namespace MentorLake.Gtk;

public class GtkThemeEngineHandle : BaseSafeHandle
{
}


public static class GtkThemeEngineExtensions
{

	public static GtkThemeEngine Dereference(this GtkThemeEngineHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkThemeEngine>(x.DangerousGetHandle());
}
internal class GtkThemeEngineExterns
{
}

public struct GtkThemeEngine
{
}
