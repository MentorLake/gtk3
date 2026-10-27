namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to describe the primary purpose of the active editable element.
/// </para>
/// </summary>

[Flags]
public enum WebKitInputPurpose
{
/// <summary>
/// <para>
/// Editable element expects any characters
/// </para>
/// </summary>

	WEBKIT_INPUT_PURPOSE_FREE_FORM = 0,
/// <summary>
/// <para>
/// Editable element expects digits
/// </para>
/// </summary>

	WEBKIT_INPUT_PURPOSE_DIGITS = 1,
/// <summary>
/// <para>
/// Editable element expects a number
/// </para>
/// </summary>

	WEBKIT_INPUT_PURPOSE_NUMBER = 2,
/// <summary>
/// <para>
/// Editable element expects a telephone
/// </para>
/// </summary>

	WEBKIT_INPUT_PURPOSE_PHONE = 3,
/// <summary>
/// <para>
/// Editable element expects a URL
/// </para>
/// </summary>

	WEBKIT_INPUT_PURPOSE_URL = 4,
/// <summary>
/// <para>
/// Editable element expects an email
/// </para>
/// </summary>

	WEBKIT_INPUT_PURPOSE_EMAIL = 5,
/// <summary>
/// <para>
/// Editable element expects a password
/// </para>
/// </summary>

	WEBKIT_INPUT_PURPOSE_PASSWORD = 6
}
