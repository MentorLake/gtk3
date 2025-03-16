namespace MentorLake.Vulkan;

public class VkPipelineStageFlagBits2Handle : BaseSafeHandle
{
}


public static class VkPipelineStageFlagBits2Extensions
{

	public static VkPipelineStageFlagBits2 Dereference(this VkPipelineStageFlagBits2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineStageFlagBits2>(x.DangerousGetHandle());
}
internal class VkPipelineStageFlagBits2Externs
{
}

public struct VkPipelineStageFlagBits2
{
}
