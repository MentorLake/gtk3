namespace MentorLake.Vulkan;

public class VkExternalFenceFeatureFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkExternalFenceFeatureFlagBitsKHRExtensions
{

	public static VkExternalFenceFeatureFlagBitsKHR Dereference(this VkExternalFenceFeatureFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalFenceFeatureFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkExternalFenceFeatureFlagBitsKHRExterns
{
}

public struct VkExternalFenceFeatureFlagBitsKHR
{
}
