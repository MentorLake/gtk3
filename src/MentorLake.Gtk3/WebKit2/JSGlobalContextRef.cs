namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Placeholder record for native JavaScriptCore JSGlobalContextRef pointer.
/// </para>
/// </summary>

public class JSGlobalContextRefHandle : BaseSafeHandle
{
}


public static class JSGlobalContextRefExtensions
{

	public static JSGlobalContextRef Dereference(this JSGlobalContextRefHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSGlobalContextRef>(x.DangerousGetHandle());
}
internal class JSGlobalContextRefExterns
{
}

/// <summary>
/// <para>
/// Placeholder record for native JavaScriptCore JSGlobalContextRef pointer.
/// </para>
/// </summary>

public struct JSGlobalContextRef
{
}
