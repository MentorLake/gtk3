namespace MentorLake.Vulkan;


public class VkSubpassDescription2Handle : BaseSafeHandle
{
}


public static class VkSubpassDescription2Extensions
{

	public static VkSubpassDescription2 Dereference(this VkSubpassDescription2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassDescription2>(x.DangerousGetHandle());
}
internal class VkSubpassDescription2Externs
{
}


public struct VkSubpassDescription2
{
}
