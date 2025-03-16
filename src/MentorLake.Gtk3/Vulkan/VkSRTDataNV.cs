namespace MentorLake.Vulkan;

public class VkSRTDataNVHandle : BaseSafeHandle
{
}


public static class VkSRTDataNVExtensions
{

	public static VkSRTDataNV Dereference(this VkSRTDataNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSRTDataNV>(x.DangerousGetHandle());
}
internal class VkSRTDataNVExterns
{
}

public struct VkSRTDataNV
{
}
