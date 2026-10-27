namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote the stock actions for
/// #WebKitContextMenuItem&amp;lt;!-- --&amp;gt;s
/// </para>
/// </summary>

[Flags]
public enum WebKitContextMenuAction
{
/// <summary>
/// <para>
/// No action, used by separator menu items.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_NO_ACTION = 0,
/// <summary>
/// <para>
/// Open current link.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_OPEN_LINK = 1,
/// <summary>
/// <para>
/// Open current link in a new window.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_OPEN_LINK_IN_NEW_WINDOW = 2,
/// <summary>
/// <para>
/// Download link destination.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_DOWNLOAD_LINK_TO_DISK = 3,
/// <summary>
/// <para>
/// Copy link location to the clipboard.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_COPY_LINK_TO_CLIPBOARD = 4,
/// <summary>
/// <para>
/// Open current image in a new window.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_OPEN_IMAGE_IN_NEW_WINDOW = 5,
/// <summary>
/// <para>
/// Download current image.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_DOWNLOAD_IMAGE_TO_DISK = 6,
/// <summary>
/// <para>
/// Copy current image to the clipboard.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_COPY_IMAGE_TO_CLIPBOARD = 7,
/// <summary>
/// <para>
/// Copy current image location to the clipboard.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_COPY_IMAGE_URL_TO_CLIPBOARD = 8,
/// <summary>
/// <para>
/// Open current frame in a new window.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_OPEN_FRAME_IN_NEW_WINDOW = 9,
/// <summary>
/// <para>
/// Load the previous history item.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_GO_BACK = 10,
/// <summary>
/// <para>
/// Load the next history item.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_GO_FORWARD = 11,
/// <summary>
/// <para>
/// Stop any ongoing loading operation.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_STOP = 12,
/// <summary>
/// <para>
/// Reload the contents of current view.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_RELOAD = 13,
/// <summary>
/// <para>
/// Copy current selection the clipboard.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_COPY = 14,
/// <summary>
/// <para>
/// Cut current selection to the clipboard.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_CUT = 15,
/// <summary>
/// <para>
/// Paste clipboard contents.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_PASTE = 16,
/// <summary>
/// <para>
/// Delete current selection.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_DELETE = 17,
/// <summary>
/// <para>
/// Select all text.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_SELECT_ALL = 18,
/// <summary>
/// <para>
/// Input methods menu.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_INPUT_METHODS = 19,
/// <summary>
/// <para>
/// Unicode menu.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_UNICODE = 20,
/// <summary>
/// <para>
/// A proposed replacement for a misspelled word.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_SPELLING_GUESS = 21,
/// <summary>
/// <para>
/// An indicator that spellchecking found no proposed replacements.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_NO_GUESSES_FOUND = 22,
/// <summary>
/// <para>
/// Causes the spellchecker to ignore the word for this session.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_IGNORE_SPELLING = 23,
/// <summary>
/// <para>
/// Causes the spellchecker to add the word to the dictionary.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_LEARN_SPELLING = 24,
/// <summary>
/// <para>
/// Ignore grammar.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_IGNORE_GRAMMAR = 25,
/// <summary>
/// <para>
/// Font options menu.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_FONT_MENU = 26,
/// <summary>
/// <para>
/// Bold.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_BOLD = 27,
/// <summary>
/// <para>
/// Italic.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_ITALIC = 28,
/// <summary>
/// <para>
/// Underline.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_UNDERLINE = 29,
/// <summary>
/// <para>
/// Outline.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_OUTLINE = 30,
/// <summary>
/// <para>
/// Open current element in the inspector.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_INSPECT_ELEMENT = 31,
/// <summary>
/// <para>
/// Open current video element in a new window.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_OPEN_VIDEO_IN_NEW_WINDOW = 32,
/// <summary>
/// <para>
/// Open current audio element in a new window.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_OPEN_AUDIO_IN_NEW_WINDOW = 33,
/// <summary>
/// <para>
/// Copy video link location in to the clipboard.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_COPY_VIDEO_LINK_TO_CLIPBOARD = 34,
/// <summary>
/// <para>
/// Copy audio link location in to the clipboard.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_COPY_AUDIO_LINK_TO_CLIPBOARD = 35,
/// <summary>
/// <para>
/// Enable or disable media controls.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_TOGGLE_MEDIA_CONTROLS = 36,
/// <summary>
/// <para>
/// Enable or disable media loop.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_TOGGLE_MEDIA_LOOP = 37,
/// <summary>
/// <para>
/// Show current video element in fullscreen mode.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_ENTER_VIDEO_FULLSCREEN = 38,
/// <summary>
/// <para>
/// Play current media element.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_MEDIA_PLAY = 39,
/// <summary>
/// <para>
/// Pause current media element.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_MEDIA_PAUSE = 40,
/// <summary>
/// <para>
/// Mute current media element.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_MEDIA_MUTE = 41,
/// <summary>
/// <para>
/// Download video to disk. Since 2.2
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_DOWNLOAD_VIDEO_TO_DISK = 42,
/// <summary>
/// <para>
/// Download audio to disk. Since 2.2
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_DOWNLOAD_AUDIO_TO_DISK = 43,
/// <summary>
/// <para>
/// Insert an emoji. Since 2.26
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_INSERT_EMOJI = 44,
/// <summary>
/// <para>
/// Paste clipboard contents as plain text. Since 2.30
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_PASTE_AS_PLAIN_TEXT = 45,
/// <summary>
/// <para>
/// Custom action defined by applications.
/// </para>
/// </summary>

	WEBKIT_CONTEXT_MENU_ACTION_CUSTOM = 10000
}
