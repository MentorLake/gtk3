namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Interface for miscellaneous [class@Session] features.
/// </para>
/// <para>
/// [iface@SessionFeature] is the interface used by classes that extend
/// the functionality of a [class@Session]. Some features like HTTP
/// authentication handling are implemented internally via
/// [iface@SessionFeature]s. Other features can be added to the session
/// by the application. (Eg, [class@Logger], [class@CookieJar].)
/// </para>
/// <para>
/// See [method@Session.add_feature], etc, to add a feature to a session.
/// </para>
/// </summary>

public interface SoupSessionFeatureHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class SoupSessionFeatureHandleImpl : BaseSafeHandle, SoupSessionFeatureHandle
{
}

public static class SoupSessionFeatureHandleExtensions
{
}

internal class SoupSessionFeatureHandleExterns
{
}
