namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Describes the role of an object
/// </para>
/// <para>
/// These are the built-in enumerated roles that UI components can have
/// in ATK.  Other roles may be added at runtime, so an AtkRole >=
/// %ATK_ROLE_LAST_DEFINED is not necessarily an error.
/// </para>
/// </summary>

[Flags]
public enum AtkRole
{
/// <summary>
/// <para>
/// Invalid role
/// </para>
/// </summary>

	ATK_ROLE_INVALID = 0,
/// <summary>
/// <para>
/// A label which represents an accelerator
/// </para>
/// </summary>

	ATK_ROLE_ACCEL_LABEL = 1,
/// <summary>
/// <para>
/// An object which is an alert to the user. Assistive Technologies typically respond to ATK_ROLE_ALERT by reading the entire onscreen contents of containers advertising this role.  Should be used for warning dialogs, etc.
/// </para>
/// </summary>

	ATK_ROLE_ALERT = 2,
/// <summary>
/// <para>
/// An object which is an animated image
/// </para>
/// </summary>

	ATK_ROLE_ANIMATION = 3,
/// <summary>
/// <para>
/// An arrow in one of the four cardinal directions
/// </para>
/// </summary>

	ATK_ROLE_ARROW = 4,
/// <summary>
/// <para>
/// An object that displays a calendar and allows the user to select a date
/// </para>
/// </summary>

	ATK_ROLE_CALENDAR = 5,
/// <summary>
/// <para>
/// An object that can be drawn into and is used to trap events
/// </para>
/// </summary>

	ATK_ROLE_CANVAS = 6,
/// <summary>
/// <para>
/// A choice that can be checked or unchecked and provides a separate indicator for the current state
/// </para>
/// </summary>

	ATK_ROLE_CHECK_BOX = 7,
/// <summary>
/// <para>
/// A menu item with a check box
/// </para>
/// </summary>

	ATK_ROLE_CHECK_MENU_ITEM = 8,
/// <summary>
/// <para>
/// A specialized dialog that lets the user choose a color
/// </para>
/// </summary>

	ATK_ROLE_COLOR_CHOOSER = 9,
/// <summary>
/// <para>
/// The header for a column of data
/// </para>
/// </summary>

	ATK_ROLE_COLUMN_HEADER = 10,
/// <summary>
/// <para>
/// A collapsible list of choices the user can select from
/// </para>
/// </summary>

	ATK_ROLE_COMBO_BOX = 11,
/// <summary>
/// <para>
/// An object whose purpose is to allow a user to edit a date
/// </para>
/// </summary>

	ATK_ROLE_DATE_EDITOR = 12,
/// <summary>
/// <para>
/// An inconifed internal frame within a DESKTOP_PANE
/// </para>
/// </summary>

	ATK_ROLE_DESKTOP_ICON = 13,
/// <summary>
/// <para>
/// A pane that supports internal frames and iconified versions of those internal frames
/// </para>
/// </summary>

	ATK_ROLE_DESKTOP_FRAME = 14,
/// <summary>
/// <para>
/// An object whose purpose is to allow a user to set a value
/// </para>
/// </summary>

	ATK_ROLE_DIAL = 15,
/// <summary>
/// <para>
/// A top level window with title bar and a border
/// </para>
/// </summary>

	ATK_ROLE_DIALOG = 16,
/// <summary>
/// <para>
/// A pane that allows the user to navigate through and select the contents of a directory
/// </para>
/// </summary>

	ATK_ROLE_DIRECTORY_PANE = 17,
/// <summary>
/// <para>
/// An object used for drawing custom user interface elements
/// </para>
/// </summary>

	ATK_ROLE_DRAWING_AREA = 18,
/// <summary>
/// <para>
/// A specialized dialog that lets the user choose a file
/// </para>
/// </summary>

	ATK_ROLE_FILE_CHOOSER = 19,
/// <summary>
/// <para>
/// A object that fills up space in a user interface
/// </para>
/// </summary>

	ATK_ROLE_FILLER = 20,
/// <summary>
/// <para>
/// A specialized dialog that lets the user choose a font
/// </para>
/// </summary>

	ATK_ROLE_FONT_CHOOSER = 21,
/// <summary>
/// <para>
/// A top level window with a title bar, border, menubar, etc.
/// </para>
/// </summary>

	ATK_ROLE_FRAME = 22,
/// <summary>
/// <para>
/// A pane that is guaranteed to be painted on top of all panes beneath it
/// </para>
/// </summary>

	ATK_ROLE_GLASS_PANE = 23,
/// <summary>
/// <para>
/// A document container for HTML, whose children represent the document content
/// </para>
/// </summary>

	ATK_ROLE_HTML_CONTAINER = 24,
/// <summary>
/// <para>
/// A small fixed size picture, typically used to decorate components
/// </para>
/// </summary>

	ATK_ROLE_ICON = 25,
/// <summary>
/// <para>
/// An object whose primary purpose is to display an image
/// </para>
/// </summary>

	ATK_ROLE_IMAGE = 26,
/// <summary>
/// <para>
/// A frame-like object that is clipped by a desktop pane
/// </para>
/// </summary>

	ATK_ROLE_INTERNAL_FRAME = 27,
/// <summary>
/// <para>
/// An object used to present an icon or short string in an interface
/// </para>
/// </summary>

	ATK_ROLE_LABEL = 28,
/// <summary>
/// <para>
/// A specialized pane that allows its children to be drawn in layers, providing a form of stacking order
/// </para>
/// </summary>

	ATK_ROLE_LAYERED_PANE = 29,
/// <summary>
/// <para>
/// An object that presents a list of objects to the user and allows the user to select one or more of them
/// </para>
/// </summary>

	ATK_ROLE_LIST = 30,
/// <summary>
/// <para>
/// An object that represents an element of a list
/// </para>
/// </summary>

	ATK_ROLE_LIST_ITEM = 31,
/// <summary>
/// <para>
/// An object usually found inside a menu bar that contains a list of actions the user can choose from
/// </para>
/// </summary>

	ATK_ROLE_MENU = 32,
/// <summary>
/// <para>
/// An object usually drawn at the top of the primary dialog box of an application that contains a list of menus the user can choose from
/// </para>
/// </summary>

	ATK_ROLE_MENU_BAR = 33,
/// <summary>
/// <para>
/// An object usually contained in a menu that presents an action the user can choose
/// </para>
/// </summary>

	ATK_ROLE_MENU_ITEM = 34,
/// <summary>
/// <para>
/// A specialized pane whose primary use is inside a DIALOG
/// </para>
/// </summary>

	ATK_ROLE_OPTION_PANE = 35,
/// <summary>
/// <para>
/// An object that is a child of a page tab list
/// </para>
/// </summary>

	ATK_ROLE_PAGE_TAB = 36,
/// <summary>
/// <para>
/// An object that presents a series of panels (or page tabs), one at a time, through some mechanism provided by the object
/// </para>
/// </summary>

	ATK_ROLE_PAGE_TAB_LIST = 37,
/// <summary>
/// <para>
/// A generic container that is often used to group objects
/// </para>
/// </summary>

	ATK_ROLE_PANEL = 38,
/// <summary>
/// <para>
/// A text object uses for passwords, or other places where the text content is not shown visibly to the user
/// </para>
/// </summary>

	ATK_ROLE_PASSWORD_TEXT = 39,
/// <summary>
/// <para>
/// A temporary window that is usually used to offer the user a list of choices, and then hides when the user selects one of those choices
/// </para>
/// </summary>

	ATK_ROLE_POPUP_MENU = 40,
/// <summary>
/// <para>
/// An object used to indicate how much of a task has been completed
/// </para>
/// </summary>

	ATK_ROLE_PROGRESS_BAR = 41,
/// <summary>
/// <para>
/// An object the user can manipulate to tell the application to do something
/// </para>
/// </summary>

	ATK_ROLE_BUTTON = 42,
/// <summary>
/// <para>
/// A specialized check box that will cause other radio buttons in the same group to become unchecked when this one is checked
/// </para>
/// </summary>

	ATK_ROLE_RADIO_BUTTON = 43,
/// <summary>
/// <para>
/// A check menu item which belongs to a group. At each instant exactly one of the radio menu items from a group is selected
/// </para>
/// </summary>

	ATK_ROLE_RADIO_MENU_ITEM = 44,
/// <summary>
/// <para>
/// A specialized pane that has a glass pane and a layered pane as its children
/// </para>
/// </summary>

	ATK_ROLE_ROOT_PANE = 45,
/// <summary>
/// <para>
/// The header for a row of data
/// </para>
/// </summary>

	ATK_ROLE_ROW_HEADER = 46,
/// <summary>
/// <para>
/// An object usually used to allow a user to incrementally view a large amount of data.
/// </para>
/// </summary>

	ATK_ROLE_SCROLL_BAR = 47,
/// <summary>
/// <para>
/// An object that allows a user to incrementally view a large amount of information
/// </para>
/// </summary>

	ATK_ROLE_SCROLL_PANE = 48,
/// <summary>
/// <para>
/// An object usually contained in a menu to provide a visible and logical separation of the contents in a menu
/// </para>
/// </summary>

	ATK_ROLE_SEPARATOR = 49,
/// <summary>
/// <para>
/// An object that allows the user to select from a bounded range
/// </para>
/// </summary>

	ATK_ROLE_SLIDER = 50,
/// <summary>
/// <para>
/// A specialized panel that presents two other panels at the same time
/// </para>
/// </summary>

	ATK_ROLE_SPLIT_PANE = 51,
/// <summary>
/// <para>
/// An object used to get an integer or floating point number from the user
/// </para>
/// </summary>

	ATK_ROLE_SPIN_BUTTON = 52,
/// <summary>
/// <para>
/// An object which reports messages of minor importance to the user
/// </para>
/// </summary>

	ATK_ROLE_STATUSBAR = 53,
/// <summary>
/// <para>
/// An object used to represent information in terms of rows and columns
/// </para>
/// </summary>

	ATK_ROLE_TABLE = 54,
/// <summary>
/// <para>
/// A cell in a table
/// </para>
/// </summary>

	ATK_ROLE_TABLE_CELL = 55,
/// <summary>
/// <para>
/// The header for a column of a table
/// </para>
/// </summary>

	ATK_ROLE_TABLE_COLUMN_HEADER = 56,
/// <summary>
/// <para>
/// The header for a row of a table
/// </para>
/// </summary>

	ATK_ROLE_TABLE_ROW_HEADER = 57,
/// <summary>
/// <para>
/// A menu item used to tear off and reattach its menu
/// </para>
/// </summary>

	ATK_ROLE_TEAR_OFF_MENU_ITEM = 58,
/// <summary>
/// <para>
/// An object that represents an accessible terminal.  (Since: 0.6)
/// </para>
/// </summary>

	ATK_ROLE_TERMINAL = 59,
/// <summary>
/// <para>
/// An interactive widget that supports multiple lines of text and
/// optionally accepts user input, but whose purpose is not to solicit user input.
/// Thus ATK_ROLE_TEXT is appropriate for the text view in a plain text editor
/// but inappropriate for an input field in a dialog box or web form. For widgets
/// whose purpose is to solicit input from the user, see ATK_ROLE_ENTRY and
/// ATK_ROLE_PASSWORD_TEXT. For generic objects which display a brief amount of
/// textual information, see ATK_ROLE_STATIC.
/// </para>
/// </summary>

	ATK_ROLE_TEXT = 60,
/// <summary>
/// <para>
/// A specialized push button that can be checked or unchecked, but does not provide a separate indicator for the current state
/// </para>
/// </summary>

	ATK_ROLE_TOGGLE_BUTTON = 61,
/// <summary>
/// <para>
/// A bar or palette usually composed of push buttons or toggle buttons
/// </para>
/// </summary>

	ATK_ROLE_TOOL_BAR = 62,
/// <summary>
/// <para>
/// An object that provides information about another object
/// </para>
/// </summary>

	ATK_ROLE_TOOL_TIP = 63,
/// <summary>
/// <para>
/// An object used to represent hierarchical information to the user
/// </para>
/// </summary>

	ATK_ROLE_TREE = 64,
/// <summary>
/// <para>
/// An object capable of expanding and collapsing rows as well as showing multiple columns of data.   (Since: 0.7)
/// </para>
/// </summary>

	ATK_ROLE_TREE_TABLE = 65,
/// <summary>
/// <para>
/// The object contains some Accessible information, but its role is not known
/// </para>
/// </summary>

	ATK_ROLE_UNKNOWN = 66,
/// <summary>
/// <para>
/// An object usually used in a scroll pane
/// </para>
/// </summary>

	ATK_ROLE_VIEWPORT = 67,
/// <summary>
/// <para>
/// A top level window with no title or border.
/// </para>
/// </summary>

	ATK_ROLE_WINDOW = 68,
/// <summary>
/// <para>
/// An object that serves as a document header. (Since: 1.1.1)
/// </para>
/// </summary>

	ATK_ROLE_HEADER = 69,
/// <summary>
/// <para>
/// An object that serves as a document footer.  (Since: 1.1.1)
/// </para>
/// </summary>

	ATK_ROLE_FOOTER = 70,
/// <summary>
/// <para>
/// An object which is contains a paragraph of text content.   (Since: 1.1.1)
/// </para>
/// </summary>

	ATK_ROLE_PARAGRAPH = 71,
/// <summary>
/// <para>
/// An object which describes margins and tab stops, etc. for text objects which it controls (should have CONTROLLER_FOR relation to such).   (Since: 1.1.1)
/// </para>
/// </summary>

	ATK_ROLE_RULER = 72,
/// <summary>
/// <para>
/// The object is an application object, which may contain @ATK_ROLE_FRAME objects or other types of accessibles.  The root accessible of any application's ATK hierarchy should have ATK_ROLE_APPLICATION.   (Since: 1.1.4)
/// </para>
/// </summary>

	ATK_ROLE_APPLICATION = 73,
/// <summary>
/// <para>
/// The object is a dialog or list containing items for insertion into an entry widget, for instance a list of words for completion of a text entry.   (Since: 1.3)
/// </para>
/// </summary>

	ATK_ROLE_AUTOCOMPLETE = 74,
/// <summary>
/// <para>
/// The object is an editable text object in a toolbar.  (Since: 1.5)
/// </para>
/// </summary>

	ATK_ROLE_EDITBAR = 75,
/// <summary>
/// <para>
/// The object is an embedded container within a document or panel.  This role is a grouping "hint" indicating that the contained objects share a context.  (Since: 1.7.2)
/// </para>
/// </summary>

	ATK_ROLE_EMBEDDED = 76,
/// <summary>
/// <para>
/// The object is a component whose textual content may be entered or modified by the user, provided @ATK_STATE_EDITABLE is present.   (Since: 1.11)
/// </para>
/// </summary>

	ATK_ROLE_ENTRY = 77,
/// <summary>
/// <para>
/// The object is a graphical depiction of quantitative data. It may contain multiple subelements whose attributes and/or description may be queried to obtain both the quantitative data and information about how the data is being presented. The LABELLED_BY relation is particularly important in interpreting objects of this type, as is the accessible-description property.  (Since: 1.11)
/// </para>
/// </summary>

	ATK_ROLE_CHART = 78,
/// <summary>
/// <para>
/// The object contains descriptive information, usually textual, about another user interface element such as a table, chart, or image.  (Since: 1.11)
/// </para>
/// </summary>

	ATK_ROLE_CAPTION = 79,
/// <summary>
/// <para>
/// The object is a visual frame or container which contains a view of document content. Document frames may occur within another Document instance, in which case the second document may be said to be embedded in the containing instance. HTML frames are often ROLE_DOCUMENT_FRAME. Either this object, or a singleton descendant, should implement the Document interface.  (Since: 1.11)
/// </para>
/// </summary>

	ATK_ROLE_DOCUMENT_FRAME = 80,
/// <summary>
/// <para>
/// The object serves as a heading for content which follows it in a document. The 'heading level' of the heading, if availabe, may be obtained by querying the object's attributes.
/// </para>
/// </summary>

	ATK_ROLE_HEADING = 81,
/// <summary>
/// <para>
/// The object is a containing instance which encapsulates a page of information. @ATK_ROLE_PAGE is used in documents and content which support a paginated navigation model.  (Since: 1.11)
/// </para>
/// </summary>

	ATK_ROLE_PAGE = 82,
/// <summary>
/// <para>
/// The object is a containing instance of document content which constitutes a particular 'logical' section of the document. The type of content within a section, and the nature of the section division itself, may be obtained by querying the object's attributes. Sections may be nested. (Since: 1.11)
/// </para>
/// </summary>

	ATK_ROLE_SECTION = 83,
/// <summary>
/// <para>
/// The object is redundant with another object in the hierarchy, and is exposed for purely technical reasons.  Objects of this role should normally be ignored by clients. (Since: 1.11)
/// </para>
/// </summary>

	ATK_ROLE_REDUNDANT_OBJECT = 84,
/// <summary>
/// <para>
/// The object is a container for form controls, for instance as part of a
/// web form or user-input form within a document.  This role is primarily a tag/convenience for
/// clients when navigating complex documents, it is not expected that ordinary GUI containers will
/// always have ATK_ROLE_FORM. (Since: 1.12.0)
/// </para>
/// </summary>

	ATK_ROLE_FORM = 85,
/// <summary>
/// <para>
/// The object is a hypertext anchor, i.e. a "link" in a
/// hypertext document.  Such objects are distinct from 'inline'
/// content which may also use the Hypertext/Hyperlink interfaces
/// to indicate the range/location within a text object where
/// an inline or embedded object lies.  (Since: 1.12.1)
/// </para>
/// </summary>

	ATK_ROLE_LINK = 86,
/// <summary>
/// <para>
/// The object is a window or similar viewport
/// which is used to allow composition or input of a 'complex character',
/// in other words it is an "input method window." (Since: 1.12.1)
/// </para>
/// </summary>

	ATK_ROLE_INPUT_METHOD_WINDOW = 87,
/// <summary>
/// <para>
/// A row in a table.  (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_TABLE_ROW = 88,
/// <summary>
/// <para>
/// An object that represents an element of a tree.  (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_TREE_ITEM = 89,
/// <summary>
/// <para>
/// A document frame which contains a spreadsheet.  (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_DOCUMENT_SPREADSHEET = 90,
/// <summary>
/// <para>
/// A document frame which contains a presentation or slide content.  (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_DOCUMENT_PRESENTATION = 91,
/// <summary>
/// <para>
/// A document frame which contains textual content, such as found in a word processing application.  (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_DOCUMENT_TEXT = 92,
/// <summary>
/// <para>
/// A document frame which contains HTML or other markup suitable for display in a web browser.  (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_DOCUMENT_WEB = 93,
/// <summary>
/// <para>
/// A document frame which contains email content to be displayed or composed either in plain text or HTML.  (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_DOCUMENT_EMAIL = 94,
/// <summary>
/// <para>
/// An object found within a document and designed to present a comment, note, or other annotation. In some cases, this object might not be visible until activated.  (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_COMMENT = 95,
/// <summary>
/// <para>
/// A non-collapsible list of choices the user can select from. (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_LIST_BOX = 96,
/// <summary>
/// <para>
/// A group of related widgets. This group typically has a label. (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_GROUPING = 97,
/// <summary>
/// <para>
/// An image map object. Usually a graphic with multiple hotspots, where each hotspot can be activated resulting in the loading of another document or section of a document. (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_IMAGE_MAP = 98,
/// <summary>
/// <para>
/// A transitory object designed to present a message to the user, typically at the desktop level rather than inside a particular application.  (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_NOTIFICATION = 99,
/// <summary>
/// <para>
/// An object designed to present a message to the user within an existing window. (Since: 2.1.0)
/// </para>
/// </summary>

	ATK_ROLE_INFO_BAR = 100,
/// <summary>
/// <para>
/// A bar that serves as a level indicator to, for instance, show the strength of a password or the state of a battery.  (Since: 2.7.3)
/// </para>
/// </summary>

	ATK_ROLE_LEVEL_BAR = 101,
/// <summary>
/// <para>
/// A bar that serves as the title of a window or a
/// dialog. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_TITLE_BAR = 102,
/// <summary>
/// <para>
/// An object which contains a text section
/// that is quoted from another source. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_BLOCK_QUOTE = 103,
/// <summary>
/// <para>
/// An object which represents an audio element. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_AUDIO = 104,
/// <summary>
/// <para>
/// An object which represents a video element. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_VIDEO = 105,
/// <summary>
/// <para>
/// A definition of a term or concept. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_DEFINITION = 106,
/// <summary>
/// <para>
/// A section of a page that consists of a
/// composition that forms an independent part of a document, page, or
/// site. Examples: A blog entry, a news story, a forum post. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_ARTICLE = 107,
/// <summary>
/// <para>
/// A region of a web page intended as a
/// navigational landmark. This is designed to allow Assistive
/// Technologies to provide quick navigation among key regions within a
/// document. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_LANDMARK = 108,
/// <summary>
/// <para>
/// A text widget or container holding log content, such
/// as chat history and error logs. In this role there is a
/// relationship between the arrival of new items in the log and the
/// reading order. The log contains a meaningful sequence and new
/// information is added only to the end of the log, not at arbitrary
/// points. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_LOG = 109,
/// <summary>
/// <para>
/// A container where non-essential information
/// changes frequently. Common usages of marquee include stock tickers
/// and ad banners. The primary difference between a marquee and a log
/// is that logs usually have a meaningful order or sequence of
/// important content changes. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_MARQUEE = 110,
/// <summary>
/// <para>
/// A text widget or container that holds a mathematical
/// expression. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_MATH = 111,
/// <summary>
/// <para>
/// A widget whose purpose is to display a rating,
/// such as the number of stars associated with a song in a media
/// player. Objects of this role should also implement
/// AtkValue. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_RATING = 112,
/// <summary>
/// <para>
/// An object containing a numerical counter which
/// indicates an amount of elapsed time from a start point, or the time
/// remaining until an end point. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_TIMER = 113,
/// <summary>
/// <para>
/// An object that represents a list of
/// term-value groups. A term-value group represents a individual
/// description and consist of one or more names
/// (ATK_ROLE_DESCRIPTION_TERM) followed by one or more values
/// (ATK_ROLE_DESCRIPTION_VALUE). For each list, there should not be
/// more than one group with the same term name. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_DESCRIPTION_LIST = 114,
/// <summary>
/// <para>
/// An object that represents a term or phrase
/// with a corresponding definition. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_DESCRIPTION_TERM = 115,
/// <summary>
/// <para>
/// An object that represents the
/// description, definition or value of a term. (Since: 2.12)
/// </para>
/// </summary>

	ATK_ROLE_DESCRIPTION_VALUE = 116,
/// <summary>
/// <para>
/// A generic non-container object whose purpose is to display a
/// brief amount of information to the user and whose role is known by the
/// implementor but lacks semantic value for the user. Examples in which
/// %ATK_ROLE_STATIC is appropriate include the message displayed in a message box
/// and an image used as an alternative means to display text. %ATK_ROLE_STATIC
/// should not be applied to widgets which are traditionally interactive, objects
/// which display a significant amount of content, or any object which has an
/// accessible relation pointing to another object. Implementors should expose the
/// displayed information through the accessible name of the object. If doing so seems
/// inappropriate, it may indicate that a different role should be used. For
/// labels which describe another widget, see %ATK_ROLE_LABEL. For text views, see
/// %ATK_ROLE_TEXT. For generic containers, see %ATK_ROLE_PANEL. For objects whose
/// role is not known by the implementor, see %ATK_ROLE_UNKNOWN. (Since: 2.16)
/// </para>
/// </summary>

	ATK_ROLE_STATIC = 117,
/// <summary>
/// <para>
/// An object that represents a mathematical fraction.
/// (Since: 2.16)
/// </para>
/// </summary>

	ATK_ROLE_MATH_FRACTION = 118,
/// <summary>
/// <para>
/// An object that represents a mathematical expression
/// displayed with a radical. (Since: 2.16)
/// </para>
/// </summary>

	ATK_ROLE_MATH_ROOT = 119,
/// <summary>
/// <para>
/// An object that contains text that is displayed as a
/// subscript. (Since: 2.16)
/// </para>
/// </summary>

	ATK_ROLE_SUBSCRIPT = 120,
/// <summary>
/// <para>
/// An object that contains text that is displayed as a
/// superscript. (Since: 2.16)
/// </para>
/// </summary>

	ATK_ROLE_SUPERSCRIPT = 121,
/// <summary>
/// <para>
/// An object that contains the text of a footnote. (Since: 2.26)
/// </para>
/// </summary>

	ATK_ROLE_FOOTNOTE = 122,
/// <summary>
/// <para>
/// Content previously deleted or proposed to be
/// deleted, e.g. in revision history or a content view providing suggestions
/// from reviewers. (Since: 2.34)
/// </para>
/// </summary>

	ATK_ROLE_CONTENT_DELETION = 123,
/// <summary>
/// <para>
/// Content previously inserted or proposed to be
/// inserted, e.g. in revision history or a content view providing suggestions
/// from reviewers. (Since: 2.34)
/// </para>
/// </summary>

	ATK_ROLE_CONTENT_INSERTION = 124,
/// <summary>
/// <para>
/// A run of content that is marked or highlighted, such as for
/// reference purposes, or to call it out as having a special purpose. If the
/// marked content has an associated section in the document elaborating on the
/// reason for the mark, then %ATK_RELATION_DETAILS should be used on the mark
/// to point to that associated section. In addition, the reciprocal relation
/// %ATK_RELATION_DETAILS_FOR should be used on the associated content section
/// to point back to the mark. (Since: 2.36)
/// </para>
/// </summary>

	ATK_ROLE_MARK = 125,
/// <summary>
/// <para>
/// A container for content that is called out as a proposed
/// change from the current version of the document, such as by a reviewer of the
/// content. This role should include either %ATK_ROLE_CONTENT_DELETION and/or
/// %ATK_ROLE_CONTENT_INSERTION children, in any order, to indicate what the
/// actual change is. (Since: 2.36)
/// </para>
/// </summary>

	ATK_ROLE_SUGGESTION = 126,
/// <summary>
/// <para>
/// A specialized push button to open a menu.
/// (Since: 2.46)
/// </para>
/// </summary>

	ATK_ROLE_PUSH_BUTTON_MENU = 127,
/// <summary>
/// <para>
/// not a valid role, used for finding end of the enumeration
/// </para>
/// </summary>

	ATK_ROLE_LAST_DEFINED = 128,

	ATK_ROLE_PUSH_BUTTON = 42
}
