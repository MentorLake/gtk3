namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GTlsPassword.
/// </para>
/// </summary>

public class GTlsPasswordClassHandle : BaseSafeHandle
{
}


public static class GTlsPasswordClassExtensions
{

	public static GTlsPasswordClass Dereference(this GTlsPasswordClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsPasswordClass>(x.DangerousGetHandle());
}
internal class GTlsPasswordClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GTlsPassword.
/// </para>
/// </summary>

public struct GTlsPasswordClass
{
	
public GObjectClass parent_class;
	/// <summary>
/// <para>
/// virtual method for g_tls_password_get_value()
/// </para>
/// </summary>

public IntPtr get_value;
	/// <summary>
/// <para>
/// virtual method for g_tls_password_set_value()
/// </para>
/// </summary>

public IntPtr set_value;
	/// <summary>
/// <para>
/// virtual method for g_tls_password_get_warning() if no
///  value has been set using g_tls_password_set_warning()
/// </para>
/// </summary>

public IntPtr get_default_warning;
}
