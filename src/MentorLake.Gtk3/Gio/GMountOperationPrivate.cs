namespace MentorLake.Gio;

public class GMountOperationPrivateHandle : BaseSafeHandle
{
}


public static class GMountOperationPrivateExtensions
{

	public static GMountOperationPrivate Dereference(this GMountOperationPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMountOperationPrivate>(x.DangerousGetHandle());
}
internal class GMountOperationPrivateExterns
{
}

public struct GMountOperationPrivate
{
}
