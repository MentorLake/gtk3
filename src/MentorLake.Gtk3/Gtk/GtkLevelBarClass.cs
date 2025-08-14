namespace MentorLake.Gtk;


public class GtkLevelBarClassHandle : BaseSafeHandle
{
}


public static class GtkLevelBarClassExtensions
{

	public static GtkLevelBarClass Dereference(this GtkLevelBarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLevelBarClass>(x.DangerousGetHandle());
}
internal class GtkLevelBarClassExterns
{
}


public struct GtkLevelBarClass
{
	
public IntPtr offset_changed;
}
