namespace MentorLake.Vulkan;

public class VkVideoEncodeUsageFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeUsageFlagsKHRExtensions
{

	public static VkVideoEncodeUsageFlagsKHR Dereference(this VkVideoEncodeUsageFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeUsageFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeUsageFlagsKHRExterns
{
}

public struct VkVideoEncodeUsageFlagsKHR
{
}
