namespace MentorLake.Vulkan;


public class VkVideoEncodeUsageFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeUsageFlagBitsKHRExtensions
{

	public static VkVideoEncodeUsageFlagBitsKHR Dereference(this VkVideoEncodeUsageFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeUsageFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeUsageFlagBitsKHRExterns
{
}


public struct VkVideoEncodeUsageFlagBitsKHR
{
}
