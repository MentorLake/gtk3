namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkLinkButtonClass contains only
/// private data.
/// </para>
/// </summary>

public class GtkLinkButtonClassHandle : BaseSafeHandle
{
}


public static class GtkLinkButtonClassExtensions
{

	public static GtkLinkButtonClass Dereference(this GtkLinkButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLinkButtonClass>(x.DangerousGetHandle());
}
internal class GtkLinkButtonClassExterns
{
}

/// <summary>
/// <para>
/// The #GtkLinkButtonClass contains only
/// private data.
/// </para>
/// </summary>

public struct GtkLinkButtonClass
{
	/// <summary>
/// <para>
/// class handler for the #GtkLinkButton::activate-link signal
/// </para>
/// </summary>

public IntPtr activate_link;
	
public IntPtr _gtk_padding1;
	
public IntPtr _gtk_padding2;
	
public IntPtr _gtk_padding3;
	
public IntPtr _gtk_padding4;
}
