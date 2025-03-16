namespace MentorLake.Vulkan;

public class VkExternalSemaphoreFeatureFlagBitsHandle : BaseSafeHandle
{
}


public static class VkExternalSemaphoreFeatureFlagBitsExtensions
{

	public static VkExternalSemaphoreFeatureFlagBits Dereference(this VkExternalSemaphoreFeatureFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalSemaphoreFeatureFlagBits>(x.DangerousGetHandle());
}
internal class VkExternalSemaphoreFeatureFlagBitsExterns
{
}

public struct VkExternalSemaphoreFeatureFlagBits
{
}
