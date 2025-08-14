namespace MentorLake.Vulkan;


public class VkExternalMemoryFeatureFlagBitsHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryFeatureFlagBitsExtensions
{

	public static VkExternalMemoryFeatureFlagBits Dereference(this VkExternalMemoryFeatureFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryFeatureFlagBits>(x.DangerousGetHandle());
}
internal class VkExternalMemoryFeatureFlagBitsExterns
{
}


public struct VkExternalMemoryFeatureFlagBits
{
}
