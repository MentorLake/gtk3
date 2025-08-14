namespace MentorLake.Gtk;


public class GtkSettingsClassHandle : BaseSafeHandle
{
}


public static class GtkSettingsClassExtensions
{

	public static GtkSettingsClass Dereference(this GtkSettingsClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSettingsClass>(x.DangerousGetHandle());
}
internal class GtkSettingsClassExterns
{
}


public struct GtkSettingsClass
{
	
public GObjectClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
