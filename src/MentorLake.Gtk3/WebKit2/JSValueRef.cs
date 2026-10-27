namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Placeholder record for native JavaScriptCore JSValueRef pointer.
/// </para>
/// </summary>

public class JSValueRefHandle : BaseSafeHandle
{
}


public static class JSValueRefExtensions
{

	public static JSValueRef Dereference(this JSValueRefHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSValueRef>(x.DangerousGetHandle());
}
internal class JSValueRefExterns
{
}

/// <summary>
/// <para>
/// Placeholder record for native JavaScriptCore JSValueRef pointer.
/// </para>
/// </summary>

public struct JSValueRef
{
}
