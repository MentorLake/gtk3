namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The class for #GTlsDatabase. Derived classes should implement the various
/// virtual methods. _async and _finish methods have a default
/// implementation that runs the corresponding sync method in a thread.
/// </para>
/// </summary>

public class GTlsDatabaseClassHandle : BaseSafeHandle
{
}


public static class GTlsDatabaseClassExtensions
{

	public static GTlsDatabaseClass Dereference(this GTlsDatabaseClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsDatabaseClass>(x.DangerousGetHandle());
}
internal class GTlsDatabaseClassExterns
{
}

/// <summary>
/// <para>
/// The class for #GTlsDatabase. Derived classes should implement the various
/// virtual methods. _async and _finish methods have a default
/// implementation that runs the corresponding sync method in a thread.
/// </para>
/// </summary>

public struct GTlsDatabaseClass
{
	
public GObjectClass parent_class;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_verify_chain().
/// </para>
/// </summary>

public IntPtr verify_chain;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_verify_chain_async().
/// </para>
/// </summary>

public IntPtr verify_chain_async;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_verify_chain_finish().
/// </para>
/// </summary>

public IntPtr verify_chain_finish;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_create_certificate_handle().
/// </para>
/// </summary>

public IntPtr create_certificate_handle;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_lookup_certificate_for_handle().
/// </para>
/// </summary>

public IntPtr lookup_certificate_for_handle;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_lookup_certificate_for_handle_async().
/// </para>
/// </summary>

public IntPtr lookup_certificate_for_handle_async;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_lookup_certificate_for_handle_finish().
/// </para>
/// </summary>

public IntPtr lookup_certificate_for_handle_finish;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_lookup_certificate_issuer().
/// </para>
/// </summary>

public IntPtr lookup_certificate_issuer;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_lookup_certificate_issuer_async().
/// </para>
/// </summary>

public IntPtr lookup_certificate_issuer_async;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_lookup_certificate_issuer_finish().
/// </para>
/// </summary>

public IntPtr lookup_certificate_issuer_finish;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_lookup_certificates_issued_by().
/// </para>
/// </summary>

public IntPtr lookup_certificates_issued_by;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_lookup_certificates_issued_by_async().
/// </para>
/// </summary>

public IntPtr lookup_certificates_issued_by_async;
	/// <summary>
/// <para>
/// Virtual method implementing
///  g_tls_database_lookup_certificates_issued_by_finish().
/// </para>
/// </summary>

public IntPtr lookup_certificates_issued_by_finish;
}
