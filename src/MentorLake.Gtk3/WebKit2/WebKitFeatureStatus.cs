namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Describes the status of a [struct@WebKitFeature].
/// </para>
/// <para>
/// The status for a given feature can be obtained with
/// [id@webkit_feature_get_status].
/// </para>
/// </summary>

[Flags]
public enum WebKitFeatureStatus
{
/// <summary>
/// <para>
/// Feature that adjust behaviour for
///   specific application needs. The feature is not part of a Web platform
///   feature, not a mature feature intended to be always on.
/// </para>
/// </summary>

	WEBKIT_FEATURE_STATUS_EMBEDDER = 0,
/// <summary>
/// <para>
/// Feature in development. The feature
///   may be unfinished, and there are no guarantees about its safety and
///   stability.
/// </para>
/// </summary>

	WEBKIT_FEATURE_STATUS_UNSTABLE = 1,
/// <summary>
/// <para>
/// Feature for debugging the WebKit engine.
///   The feature is not generally useful for user or web developers, and
///   always disabled by default.
/// </para>
/// </summary>

	WEBKIT_FEATURE_STATUS_INTERNAL = 2,
/// <summary>
/// <para>
/// Feature for web developers. The feature
///   is not generally useful for end users, and always disabled by default.
/// </para>
/// </summary>

	WEBKIT_FEATURE_STATUS_DEVELOPER = 3,
/// <summary>
/// <para>
/// Feature in active development and
///   complete enough for testing. The feature may not be yet ready to
///   ship and is disabled by default.
/// </para>
/// </summary>

	WEBKIT_FEATURE_STATUS_TESTABLE = 4,
/// <summary>
/// <para>
/// Feature ready to be tested by users.
///   The feature is disabled by default, but may be enabled by applications
///   automatically e.g. in their “technology preview” or “beta” versions.
/// </para>
/// </summary>

	WEBKIT_FEATURE_STATUS_PREVIEW = 5,
/// <summary>
/// <para>
/// Feature ready for general use. The
///   feature is enabled by default, but it may still be toggled to support
///   debugging and testing.
/// </para>
/// </summary>

	WEBKIT_FEATURE_STATUS_STABLE = 6,
/// <summary>
/// <para>
/// Feature in general use. The feature is
///   always enabled and in general there should be no user-facing interface
///   to toggle it.
/// </para>
/// </summary>

	WEBKIT_FEATURE_STATUS_MATURE = 7
}
