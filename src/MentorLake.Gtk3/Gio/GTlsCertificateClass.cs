namespace MentorLake.Gio;


public class GTlsCertificateClassHandle : BaseSafeHandle
{
}


public static class GTlsCertificateClassExtensions
{

	public static GTlsCertificateClass Dereference(this GTlsCertificateClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsCertificateClass>(x.DangerousGetHandle());
}
internal class GTlsCertificateClassExterns
{
}


public struct GTlsCertificateClass
{
	
public GObjectClass parent_class;
	
public IntPtr verify;
}
