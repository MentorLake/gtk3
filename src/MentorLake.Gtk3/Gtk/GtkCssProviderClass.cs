namespace MentorLake.Gtk;


public class GtkCssProviderClassHandle : BaseSafeHandle
{
}


public static class GtkCssProviderClassExtensions
{

	public static GtkCssProviderClass Dereference(this GtkCssProviderClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCssProviderClass>(x.DangerousGetHandle());
}
internal class GtkCssProviderClassExterns
{
}


public struct GtkCssProviderClass
{
	
public GObjectClass parent_class;
	
public IntPtr parsing_error;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
