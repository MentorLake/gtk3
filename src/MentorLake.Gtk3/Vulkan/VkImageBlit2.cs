namespace MentorLake.Vulkan;

public class VkImageBlit2Handle : BaseSafeHandle
{
}


public static class VkImageBlit2Extensions
{

	public static VkImageBlit2 Dereference(this VkImageBlit2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageBlit2>(x.DangerousGetHandle());
}
internal class VkImageBlit2Externs
{
}

public struct VkImageBlit2
{
}
