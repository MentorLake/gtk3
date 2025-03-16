namespace MentorLake.Vulkan;

public class VkVideoEndCodingFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEndCodingFlagsKHRExtensions
{

	public static VkVideoEndCodingFlagsKHR Dereference(this VkVideoEndCodingFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEndCodingFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEndCodingFlagsKHRExterns
{
}

public struct VkVideoEndCodingFlagsKHR
{
}
