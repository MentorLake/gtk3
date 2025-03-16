namespace MentorLake.Gio;

public class GTlsInteractionClassHandle : BaseSafeHandle
{
}


public static class GTlsInteractionClassExtensions
{

	public static GTlsInteractionClass Dereference(this GTlsInteractionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsInteractionClass>(x.DangerousGetHandle());
}
internal class GTlsInteractionClassExterns
{
}

public struct GTlsInteractionClass
{
	public IntPtr ask_password;
	public IntPtr ask_password_async;
	public IntPtr ask_password_finish;
	public IntPtr request_certificate;
	public IntPtr request_certificate_async;
	public IntPtr request_certificate_finish;
}
