namespace MentorLake.Vulkan;


public class VkSubpassDependency2Handle : BaseSafeHandle
{
}


public static class VkSubpassDependency2Extensions
{

	public static VkSubpassDependency2 Dereference(this VkSubpassDependency2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassDependency2>(x.DangerousGetHandle());
}
internal class VkSubpassDependency2Externs
{
}


public struct VkSubpassDependency2
{
}
