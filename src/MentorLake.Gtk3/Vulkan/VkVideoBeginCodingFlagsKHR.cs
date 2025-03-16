namespace MentorLake.Vulkan;

public class VkVideoBeginCodingFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoBeginCodingFlagsKHRExtensions
{

	public static VkVideoBeginCodingFlagsKHR Dereference(this VkVideoBeginCodingFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoBeginCodingFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoBeginCodingFlagsKHRExterns
{
}

public struct VkVideoBeginCodingFlagsKHR
{
}
