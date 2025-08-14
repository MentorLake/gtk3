namespace MentorLake.Gtk;


public class GtkAccelLabelClassHandle : BaseSafeHandle
{
}


public static class GtkAccelLabelClassExtensions
{

	public static GtkAccelLabelClass Dereference(this GtkAccelLabelClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAccelLabelClass>(x.DangerousGetHandle());
}
internal class GtkAccelLabelClassExterns
{
}


public struct GtkAccelLabelClass
{
	
public GtkLabelClass parent_class;
	
public string signal_quote1;
	
public string signal_quote2;
	
public string mod_name_shift;
	
public string mod_name_control;
	
public string mod_name_alt;
	
public string mod_separator;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
