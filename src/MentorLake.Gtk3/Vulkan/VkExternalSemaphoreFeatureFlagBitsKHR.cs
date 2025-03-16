namespace MentorLake.Vulkan;

public class VkExternalSemaphoreFeatureFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkExternalSemaphoreFeatureFlagBitsKHRExtensions
{

	public static VkExternalSemaphoreFeatureFlagBitsKHR Dereference(this VkExternalSemaphoreFeatureFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalSemaphoreFeatureFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkExternalSemaphoreFeatureFlagBitsKHRExterns
{
}

public struct VkExternalSemaphoreFeatureFlagBitsKHR
{
}
