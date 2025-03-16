namespace MentorLake.Gtk;

public class GtkIconInfoClassHandle : BaseSafeHandle
{
}


public static class GtkIconInfoClassExtensions
{

	public static GtkIconInfoClass Dereference(this GtkIconInfoClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconInfoClass>(x.DangerousGetHandle());
}
internal class GtkIconInfoClassExterns
{
}

public struct GtkIconInfoClass
{
}
