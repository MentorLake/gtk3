namespace MentorLake.Gtk;


public class GtkEntryCompletionClassHandle : BaseSafeHandle
{
}


public static class GtkEntryCompletionClassExtensions
{

	public static GtkEntryCompletionClass Dereference(this GtkEntryCompletionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEntryCompletionClass>(x.DangerousGetHandle());
}
internal class GtkEntryCompletionClassExterns
{
}


public struct GtkEntryCompletionClass
{
	
public GObjectClass parent_class;
	
public IntPtr match_selected;
	
public IntPtr action_activated;
	
public IntPtr insert_prefix;
	
public IntPtr cursor_on_match;
	
public IntPtr no_matches;
	
public IntPtr _gtk_reserved0;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
}
