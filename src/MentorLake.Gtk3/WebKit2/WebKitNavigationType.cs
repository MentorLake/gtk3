namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote the various navigation types.
/// </para>
/// </summary>

[Flags]
public enum WebKitNavigationType
{
/// <summary>
/// <para>
/// The navigation was triggered by clicking a link.
/// </para>
/// </summary>

	WEBKIT_NAVIGATION_TYPE_LINK_CLICKED = 0,
/// <summary>
/// <para>
/// The navigation was triggered by submitting a form.
/// </para>
/// </summary>

	WEBKIT_NAVIGATION_TYPE_FORM_SUBMITTED = 1,
/// <summary>
/// <para>
/// The navigation was triggered by navigating forward or backward.
/// </para>
/// </summary>

	WEBKIT_NAVIGATION_TYPE_BACK_FORWARD = 2,
/// <summary>
/// <para>
/// The navigation was triggered by reloading.
/// </para>
/// </summary>

	WEBKIT_NAVIGATION_TYPE_RELOAD = 3,
/// <summary>
/// <para>
/// The navigation was triggered by resubmitting a form.
/// </para>
/// </summary>

	WEBKIT_NAVIGATION_TYPE_FORM_RESUBMITTED = 4,
/// <summary>
/// <para>
/// The navigation was triggered by some other action.
/// </para>
/// </summary>

	WEBKIT_NAVIGATION_TYPE_OTHER = 5
}
