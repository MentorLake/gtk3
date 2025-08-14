namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GCredentials.
/// </para>
/// </summary>

public class GCredentialsClassHandle : BaseSafeHandle
{
}


public static class GCredentialsClassExtensions
{

	public static GCredentialsClass Dereference(this GCredentialsClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GCredentialsClass>(x.DangerousGetHandle());
}
internal class GCredentialsClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GCredentials.
/// </para>
/// </summary>

public struct GCredentialsClass
{
}
