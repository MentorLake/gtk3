namespace MentorLake.Vulkan;


public class VkExternalMemoryFeatureFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryFeatureFlagBitsKHRExtensions
{

	public static VkExternalMemoryFeatureFlagBitsKHR Dereference(this VkExternalMemoryFeatureFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryFeatureFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkExternalMemoryFeatureFlagBitsKHRExterns
{
}


public struct VkExternalMemoryFeatureFlagBitsKHR
{
}
