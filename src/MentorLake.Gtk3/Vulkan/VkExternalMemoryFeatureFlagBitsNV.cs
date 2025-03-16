namespace MentorLake.Vulkan;

public class VkExternalMemoryFeatureFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryFeatureFlagBitsNVExtensions
{

	public static VkExternalMemoryFeatureFlagBitsNV Dereference(this VkExternalMemoryFeatureFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryFeatureFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkExternalMemoryFeatureFlagBitsNVExterns
{
}

public struct VkExternalMemoryFeatureFlagBitsNV
{
}
