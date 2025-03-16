namespace MentorLake.Vulkan;

public class VkLayeredDriverUnderlyingApiMSFTHandle : BaseSafeHandle
{
}


public static class VkLayeredDriverUnderlyingApiMSFTExtensions
{

	public static VkLayeredDriverUnderlyingApiMSFT Dereference(this VkLayeredDriverUnderlyingApiMSFTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLayeredDriverUnderlyingApiMSFT>(x.DangerousGetHandle());
}
internal class VkLayeredDriverUnderlyingApiMSFTExterns
{
}

public struct VkLayeredDriverUnderlyingApiMSFT
{
}
