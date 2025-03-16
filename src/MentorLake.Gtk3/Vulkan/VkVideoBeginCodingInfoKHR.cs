namespace MentorLake.Vulkan;

public class VkVideoBeginCodingInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoBeginCodingInfoKHRExtensions
{

	public static VkVideoBeginCodingInfoKHR Dereference(this VkVideoBeginCodingInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoBeginCodingInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoBeginCodingInfoKHRExterns
{
}

public struct VkVideoBeginCodingInfoKHR
{
}
