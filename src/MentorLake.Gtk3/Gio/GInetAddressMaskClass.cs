namespace MentorLake.Gio;

public class GInetAddressMaskClassHandle : BaseSafeHandle
{
}


public static class GInetAddressMaskClassExtensions
{

	public static GInetAddressMaskClass Dereference(this GInetAddressMaskClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInetAddressMaskClass>(x.DangerousGetHandle());
}
internal class GInetAddressMaskClassExterns
{
}

public struct GInetAddressMaskClass
{
	public GObjectClass parent_class;
}
