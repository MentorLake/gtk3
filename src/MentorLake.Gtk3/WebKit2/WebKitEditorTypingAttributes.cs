namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values with flags representing typing attributes.
/// </para>
/// </summary>

[Flags]
public enum WebKitEditorTypingAttributes : uint
{
/// <summary>
/// <para>
/// No typing attributes.
/// </para>
/// </summary>

	WEBKIT_EDITOR_TYPING_ATTRIBUTE_NONE = 2,
/// <summary>
/// <para>
/// Bold typing attribute.
/// </para>
/// </summary>

	WEBKIT_EDITOR_TYPING_ATTRIBUTE_BOLD = 4,
/// <summary>
/// <para>
/// Italic typing attribute.
/// </para>
/// </summary>

	WEBKIT_EDITOR_TYPING_ATTRIBUTE_ITALIC = 8,
/// <summary>
/// <para>
/// Underline typing attribute.
/// </para>
/// </summary>

	WEBKIT_EDITOR_TYPING_ATTRIBUTE_UNDERLINE = 16,
/// <summary>
/// <para>
/// Strikethrough typing attribute.
/// </para>
/// </summary>

	WEBKIT_EDITOR_TYPING_ATTRIBUTE_STRIKETHROUGH = 32
}
