namespace MentorLake.Gtk;

public class GtkAccelMapClassHandle : BaseSafeHandle
{
}


public static class GtkAccelMapClassExtensions
{

	public static GtkAccelMapClass Dereference(this GtkAccelMapClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAccelMapClass>(x.DangerousGetHandle());
}
internal class GtkAccelMapClassExterns
{
}

public struct GtkAccelMapClass
{
}
