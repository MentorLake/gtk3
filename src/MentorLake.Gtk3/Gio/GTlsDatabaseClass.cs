namespace MentorLake.Gio;

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

public struct GTlsDatabaseClass
{
	public GObjectClass parent_class;
	public IntPtr verify_chain;
	public IntPtr verify_chain_async;
	public IntPtr verify_chain_finish;
	public IntPtr create_certificate_handle;
	public IntPtr lookup_certificate_for_handle;
	public IntPtr lookup_certificate_for_handle_async;
	public IntPtr lookup_certificate_for_handle_finish;
	public IntPtr lookup_certificate_issuer;
	public IntPtr lookup_certificate_issuer_async;
	public IntPtr lookup_certificate_issuer_finish;
	public IntPtr lookup_certificates_issued_by;
	public IntPtr lookup_certificates_issued_by_async;
	public IntPtr lookup_certificates_issued_by_finish;
}
