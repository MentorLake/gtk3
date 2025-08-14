namespace MentorLake.Gio;


public class GTlsCertificatePrivateHandle : BaseSafeHandle
{
}


public static class GTlsCertificatePrivateExtensions
{

	public static GTlsCertificatePrivate Dereference(this GTlsCertificatePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsCertificatePrivate>(x.DangerousGetHandle());
}
internal class GTlsCertificatePrivateExterns
{
}


public struct GTlsCertificatePrivate
{
}
