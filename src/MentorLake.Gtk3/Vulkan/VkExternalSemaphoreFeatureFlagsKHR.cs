namespace MentorLake.Vulkan;

public class VkExternalSemaphoreFeatureFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkExternalSemaphoreFeatureFlagsKHRExtensions
{

	public static VkExternalSemaphoreFeatureFlagsKHR Dereference(this VkExternalSemaphoreFeatureFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalSemaphoreFeatureFlagsKHR>(x.DangerousGetHandle());
}
internal class VkExternalSemaphoreFeatureFlagsKHRExterns
{
}

public struct VkExternalSemaphoreFeatureFlagsKHR
{
}
