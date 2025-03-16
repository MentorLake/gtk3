namespace MentorLake.Gtk;

public class GtkWindowGeometryInfoHandle : BaseSafeHandle
{
}


public static class GtkWindowGeometryInfoExtensions
{

	public static GtkWindowGeometryInfo Dereference(this GtkWindowGeometryInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWindowGeometryInfo>(x.DangerousGetHandle());
}
internal class GtkWindowGeometryInfoExterns
{
}

public struct GtkWindowGeometryInfo
{
}
