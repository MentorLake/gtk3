namespace MentorLake.Gio;


public class GTlsInteractionPrivateHandle : BaseSafeHandle
{
}


public static class GTlsInteractionPrivateExtensions
{

	public static GTlsInteractionPrivate Dereference(this GTlsInteractionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsInteractionPrivate>(x.DangerousGetHandle());
}
internal class GTlsInteractionPrivateExterns
{
}


public struct GTlsInteractionPrivate
{
}
