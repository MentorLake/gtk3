namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes hints that might be taken into account by input methods
/// or applications. Note that input methods may already tailor their
/// behaviour according to the #GtkInputPurpose of the entry.
/// </para>
/// <para>
/// Some common sense is expected when using these flags - mixing
/// @GTK_INPUT_HINT_LOWERCASE with any of the uppercase hints makes no sense.
/// </para>
/// <para>
/// This enumeration may be extended in the future; input methods should
/// ignore unknown values.
/// </para>
/// </summary>

[Flags]
public enum GtkInputHints : uint
{
/// <summary>
/// <para>
/// No special behaviour suggested
/// </para>
/// </summary>

	GTK_INPUT_HINT_NONE = 0,
/// <summary>
/// <para>
/// Suggest checking for typos
/// </para>
/// </summary>

	GTK_INPUT_HINT_SPELLCHECK = 1,
/// <summary>
/// <para>
/// Suggest not checking for typos
/// </para>
/// </summary>

	GTK_INPUT_HINT_NO_SPELLCHECK = 2,
/// <summary>
/// <para>
/// Suggest word completion
/// </para>
/// </summary>

	GTK_INPUT_HINT_WORD_COMPLETION = 4,
/// <summary>
/// <para>
/// Suggest to convert all text to lowercase
/// </para>
/// </summary>

	GTK_INPUT_HINT_LOWERCASE = 8,
/// <summary>
/// <para>
/// Suggest to capitalize all text
/// </para>
/// </summary>

	GTK_INPUT_HINT_UPPERCASE_CHARS = 16,
/// <summary>
/// <para>
/// Suggest to capitalize the first
///     character of each word
/// </para>
/// </summary>

	GTK_INPUT_HINT_UPPERCASE_WORDS = 32,
/// <summary>
/// <para>
/// Suggest to capitalize the
///     first word of each sentence
/// </para>
/// </summary>

	GTK_INPUT_HINT_UPPERCASE_SENTENCES = 64,
/// <summary>
/// <para>
/// Suggest to not show an onscreen keyboard
///     (e.g for a calculator that already has all the keys).
/// </para>
/// </summary>

	GTK_INPUT_HINT_INHIBIT_OSK = 128,
/// <summary>
/// <para>
/// The text is vertical. Since 3.18
/// </para>
/// </summary>

	GTK_INPUT_HINT_VERTICAL_WRITING = 256,
/// <summary>
/// <para>
/// Suggest offering Emoji support. Since 3.22.20
/// </para>
/// </summary>

	GTK_INPUT_HINT_EMOJI = 512,
/// <summary>
/// <para>
/// Suggest not offering Emoji support. Since 3.22.20
/// </para>
/// </summary>

	GTK_INPUT_HINT_NO_EMOJI = 1024
}
