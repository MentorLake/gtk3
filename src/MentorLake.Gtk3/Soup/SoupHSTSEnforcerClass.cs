namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Class structure for [class@HSTSEnforcer].
/// </para>
/// </summary>

public class SoupHSTSEnforcerClassHandle : BaseSafeHandle
{
}


public static class SoupHSTSEnforcerClassExtensions
{

	public static SoupHSTSEnforcerClass Dereference(this SoupHSTSEnforcerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupHSTSEnforcerClass>(x.DangerousGetHandle());
}
internal class SoupHSTSEnforcerClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for [class@HSTSEnforcer].
/// </para>
/// </summary>

public struct SoupHSTSEnforcerClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// The @is_persistent function advertises whether the enforcer is persistent or
/// whether changes made to it will be lost when the underlying [class@Session] is finished.
/// </para>
/// </summary>

public IntPtr is_persistent;
	/// <summary>
/// <para>
/// The @has_valid_policy function is called to check whether there is a valid
/// policy for the given domain. This method should return %TRUE for [class@HSTSEnforcer] to
/// change the scheme of the #GUri in the [class@Message] to HTTPS. Implementations might want to
/// chain up to the @has_valid_policy in the parent class to check, for instance, for runtime
/// policies.
/// </para>
/// </summary>

public IntPtr has_valid_policy;
	/// <summary>
/// <para>
/// The class closure for the [signal@HSTSEnforcer::changed] signal.
/// </para>
/// </summary>

public IntPtr changed;
}
