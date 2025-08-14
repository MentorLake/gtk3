namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Values corresponding to @errno codes returned from file operations
/// on UNIX. Unlike @errno codes, GFileError values are available on
/// all systems, even Windows. The exact meaning of each code depends
/// on what sort of file operation you were performing; the UNIX
/// documentation gives more details. The following error code descriptions
/// come from the GNU C Library manual, and are under the copyright
/// of that manual.
/// </para>
/// <para>
/// It's not very portable to make detailed assumptions about exactly
/// which errors will be returned from a given operation. Some errors
/// don't occur on some systems, etc., sometimes there are subtle
/// differences in when a system will report a given error, etc.
/// </para>
/// </summary>

[Flags]
public enum GFileError
{
/// <summary>
/// <para>
/// Operation not permitted; only the owner of
///     the file (or other resource) or processes with special privileges
///     can perform the operation.
/// </para>
/// </summary>

	G_FILE_ERROR_EXIST = 0,
/// <summary>
/// <para>
/// File is a directory; you cannot open a directory
///     for writing, or create or remove hard links to it.
/// </para>
/// </summary>

	G_FILE_ERROR_ISDIR = 1,
/// <summary>
/// <para>
/// Permission denied; the file permissions do not
///     allow the attempted operation.
/// </para>
/// </summary>

	G_FILE_ERROR_ACCES = 2,
/// <summary>
/// <para>
/// Filename too long.
/// </para>
/// </summary>

	G_FILE_ERROR_NAMETOOLONG = 3,
/// <summary>
/// <para>
/// No such file or directory. This is a "file
///     doesn't exist" error for ordinary files that are referenced in
///     contexts where they are expected to already exist.
/// </para>
/// </summary>

	G_FILE_ERROR_NOENT = 4,
/// <summary>
/// <para>
/// A file that isn't a directory was specified when
///     a directory is required.
/// </para>
/// </summary>

	G_FILE_ERROR_NOTDIR = 5,
/// <summary>
/// <para>
/// No such device or address. The system tried to
///     use the device represented by a file you specified, and it
///     couldn't find the device. This can mean that the device file was
///     installed incorrectly, or that the physical device is missing or
///     not correctly attached to the computer.
/// </para>
/// </summary>

	G_FILE_ERROR_NXIO = 6,
/// <summary>
/// <para>
/// The underlying file system of the specified file
///     does not support memory mapping.
/// </para>
/// </summary>

	G_FILE_ERROR_NODEV = 7,
/// <summary>
/// <para>
/// The directory containing the new link can't be
///     modified because it's on a read-only file system.
/// </para>
/// </summary>

	G_FILE_ERROR_ROFS = 8,
/// <summary>
/// <para>
/// Text file busy.
/// </para>
/// </summary>

	G_FILE_ERROR_TXTBSY = 9,
/// <summary>
/// <para>
/// You passed in a pointer to bad memory.
///     (GLib won't reliably return this, don't pass in pointers to bad
///     memory.)
/// </para>
/// </summary>

	G_FILE_ERROR_FAULT = 10,
/// <summary>
/// <para>
/// Too many levels of symbolic links were encountered
///     in looking up a file name. This often indicates a cycle of symbolic
///     links.
/// </para>
/// </summary>

	G_FILE_ERROR_LOOP = 11,
/// <summary>
/// <para>
/// No space left on device; write operation on a
///     file failed because the disk is full.
/// </para>
/// </summary>

	G_FILE_ERROR_NOSPC = 12,
/// <summary>
/// <para>
/// No memory available. The system cannot allocate
///     more virtual memory because its capacity is full.
/// </para>
/// </summary>

	G_FILE_ERROR_NOMEM = 13,
/// <summary>
/// <para>
/// The current process has too many files open and
///     can't open any more. Duplicate descriptors do count toward this
///     limit.
/// </para>
/// </summary>

	G_FILE_ERROR_MFILE = 14,
/// <summary>
/// <para>
/// There are too many distinct file openings in the
///     entire system.
/// </para>
/// </summary>

	G_FILE_ERROR_NFILE = 15,
/// <summary>
/// <para>
/// Bad file descriptor; for example, I/O on a
///     descriptor that has been closed or reading from a descriptor open
///     only for writing (or vice versa).
/// </para>
/// </summary>

	G_FILE_ERROR_BADF = 16,
/// <summary>
/// <para>
/// Invalid argument. This is used to indicate
///     various kinds of problems with passing the wrong argument to a
///     library function.
/// </para>
/// </summary>

	G_FILE_ERROR_INVAL = 17,
/// <summary>
/// <para>
/// Broken pipe; there is no process reading from the
///     other end of a pipe. Every library function that returns this
///     error code also generates a 'SIGPIPE' signal; this signal
///     terminates the program if not handled or blocked. Thus, your
///     program will never actually see this code unless it has handled
///     or blocked 'SIGPIPE'.
/// </para>
/// </summary>

	G_FILE_ERROR_PIPE = 18,
/// <summary>
/// <para>
/// Resource temporarily unavailable; the call might
///     work if you try again later.
/// </para>
/// </summary>

	G_FILE_ERROR_AGAIN = 19,
/// <summary>
/// <para>
/// Interrupted function call; an asynchronous signal
///     occurred and prevented completion of the call. When this
///     happens, you should try the call again.
/// </para>
/// </summary>

	G_FILE_ERROR_INTR = 20,
/// <summary>
/// <para>
/// Input/output error; usually used for physical read
///    or write errors. i.e. the disk or other physical device hardware
///    is returning errors.
/// </para>
/// </summary>

	G_FILE_ERROR_IO = 21,
/// <summary>
/// <para>
/// Operation not permitted; only the owner of the
///    file (or other resource) or processes with special privileges can
///    perform the operation.
/// </para>
/// </summary>

	G_FILE_ERROR_PERM = 22,
/// <summary>
/// <para>
/// Function not implemented; this indicates that
///    the system is missing some functionality.
/// </para>
/// </summary>

	G_FILE_ERROR_NOSYS = 23,
/// <summary>
/// <para>
/// Does not correspond to a UNIX error code; this
///    is the standard "failed for unspecified reason" error code present
///    in all #GError error code enumerations. Returned if no specific
///    code applies.
/// </para>
/// </summary>

	G_FILE_ERROR_FAILED = 24
}
