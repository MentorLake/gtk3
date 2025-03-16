namespace MentorLake.Vulkan;

public class VkExternalFenceFeatureFlagBitsHandle : BaseSafeHandle
{
}


public static class VkExternalFenceFeatureFlagBitsExtensions
{

	public static VkExternalFenceFeatureFlagBits Dereference(this VkExternalFenceFeatureFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalFenceFeatureFlagBits>(x.DangerousGetHandle());
}
internal class VkExternalFenceFeatureFlagBitsExterns
{
}

public struct VkExternalFenceFeatureFlagBits
{
}
