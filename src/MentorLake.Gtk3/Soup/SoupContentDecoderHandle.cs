namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Handles decoding of HTTP messages.
/// </para>
/// <para>
/// [class@ContentDecoder] handles adding the &quot;Accept-Encoding&quot; header on
/// outgoing messages, and processing the &quot;Content-Encoding&quot; header on
/// incoming ones. Currently it supports the &quot;gzip&quot;, &quot;deflate&quot;, and &quot;br&quot;
/// content codings.
/// </para>
/// <para>
/// A [class@ContentDecoder] will automatically be
/// added to the session by default. (You can use
/// [method@Session.remove_feature_by_type] if you don&apos;t
/// want this.)
/// </para>
/// <para>
/// If [class@ContentDecoder] successfully decodes the Content-Encoding,
/// the message body will contain the decoded data; however, the message headers
/// will be unchanged (and so &quot;Content-Encoding&quot; will still be present,
/// &quot;Content-Length&quot; will describe the original encoded length, etc).
/// </para>
/// <para>
/// If &quot;Content-Encoding&quot; contains any encoding types that
/// [class@ContentDecoder] doesn&apos;t recognize, then none of the encodings
/// will be decoded.
/// </para>
/// <para>
/// (Note that currently there is no way to (automatically) use
/// Content-Encoding when sending a request body, or to pick specific
/// encoding types to support.)
/// </para>
/// </summary>

public class SoupContentDecoderHandle : GObjectHandle, SoupSessionFeatureHandle
{
}

public static class SoupContentDecoderHandleExtensions
{
}

internal class SoupContentDecoderHandleExterns
{
}
