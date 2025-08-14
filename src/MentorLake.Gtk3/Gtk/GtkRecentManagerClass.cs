namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkRecentManagerClass contains only private data.
/// </para>
/// </summary>

public class GtkRecentManagerClassHandle : BaseSafeHandle
{
}


public static class GtkRecentManagerClassExtensions
{

	public static GtkRecentManagerClass Dereference(this GtkRecentManagerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentManagerClass>(x.DangerousGetHandle());
}
internal class GtkRecentManagerClassExterns
{
}

/// <summary>
/// <para>
/// #GtkRecentManagerClass contains only private data.
/// </para>
/// </summary>

public struct GtkRecentManagerClass
{
	
public IntPtr changed;
	
public IntPtr _gtk_recent1;
	
public IntPtr _gtk_recent2;
	
public IntPtr _gtk_recent3;
	
public IntPtr _gtk_recent4;
}
