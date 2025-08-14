namespace MentorLake.Gtk;


public class GtkRecentChooserMenuClassHandle : BaseSafeHandle
{
}


public static class GtkRecentChooserMenuClassExtensions
{

	public static GtkRecentChooserMenuClass Dereference(this GtkRecentChooserMenuClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentChooserMenuClass>(x.DangerousGetHandle());
}
internal class GtkRecentChooserMenuClassExterns
{
}


public struct GtkRecentChooserMenuClass
{
	
public GtkMenuClass parent_class;
	
public IntPtr gtk_recent1;
	
public IntPtr gtk_recent2;
	
public IntPtr gtk_recent3;
	
public IntPtr gtk_recent4;
}
