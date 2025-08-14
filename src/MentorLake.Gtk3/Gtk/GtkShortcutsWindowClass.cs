namespace MentorLake.Gtk;


public class GtkShortcutsWindowClassHandle : BaseSafeHandle
{
}


public static class GtkShortcutsWindowClassExtensions
{

	public static GtkShortcutsWindowClass Dereference(this GtkShortcutsWindowClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkShortcutsWindowClass>(x.DangerousGetHandle());
}
internal class GtkShortcutsWindowClassExterns
{
}


public struct GtkShortcutsWindowClass
{
	
public GtkWindowClass parent_class;
	
public IntPtr close;
	
public IntPtr search;
}
