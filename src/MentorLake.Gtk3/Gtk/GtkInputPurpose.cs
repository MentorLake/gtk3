namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes primary purpose of the input widget. This information is
/// useful for on-screen keyboards and similar input methods to decide
/// which keys should be presented to the user.
/// </para>
/// <para>
/// Note that the purpose is not meant to impose a totally strict rule
/// about allowed characters, and does not replace input validation.
/// It is fine for an on-screen keyboard to let the user override the
/// character set restriction that is expressed by the purpose. The
/// application is expected to validate the entry contents, even if
/// it specified a purpose.
/// </para>
/// <para>
/// The difference between @GTK_INPUT_PURPOSE_DIGITS and
/// @GTK_INPUT_PURPOSE_NUMBER is that the former accepts only digits
/// while the latter also some punctuation (like commas or points, plus,
/// minus) and “e” or “E” as in 3.14E+000.
/// </para>
/// <para>
/// This enumeration may be extended in the future; input methods should
/// interpret unknown values as “free form”.
/// </para>
/// </summary>

[Flags]
public enum GtkInputPurpose
{
/// <summary>
/// <para>
/// Allow any character
/// </para>
/// </summary>

	GTK_INPUT_PURPOSE_FREE_FORM = 0,
/// <summary>
/// <para>
/// Allow only alphabetic characters
/// </para>
/// </summary>

	GTK_INPUT_PURPOSE_ALPHA = 1,
/// <summary>
/// <para>
/// Allow only digits
/// </para>
/// </summary>

	GTK_INPUT_PURPOSE_DIGITS = 2,
/// <summary>
/// <para>
/// Edited field expects numbers
/// </para>
/// </summary>

	GTK_INPUT_PURPOSE_NUMBER = 3,
/// <summary>
/// <para>
/// Edited field expects phone number
/// </para>
/// </summary>

	GTK_INPUT_PURPOSE_PHONE = 4,
/// <summary>
/// <para>
/// Edited field expects URL
/// </para>
/// </summary>

	GTK_INPUT_PURPOSE_URL = 5,
/// <summary>
/// <para>
/// Edited field expects email address
/// </para>
/// </summary>

	GTK_INPUT_PURPOSE_EMAIL = 6,
/// <summary>
/// <para>
/// Edited field expects the name of a person
/// </para>
/// </summary>

	GTK_INPUT_PURPOSE_NAME = 7,
/// <summary>
/// <para>
/// Like @GTK_INPUT_PURPOSE_FREE_FORM, but characters are hidden
/// </para>
/// </summary>

	GTK_INPUT_PURPOSE_PASSWORD = 8,
/// <summary>
/// <para>
/// Like @GTK_INPUT_PURPOSE_DIGITS, but characters are hidden
/// </para>
/// </summary>

	GTK_INPUT_PURPOSE_PIN = 9,
/// <summary>
/// <para>
/// Allow any character, in addition to control codes
/// </para>
/// </summary>

	GTK_INPUT_PURPOSE_TERMINAL = 10
}
