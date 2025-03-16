namespace MentorLake.Vulkan;

public class VkSubpassDependency2KHRHandle : BaseSafeHandle
{
}


public static class VkSubpassDependency2KHRExtensions
{

	public static VkSubpassDependency2KHR Dereference(this VkSubpassDependency2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassDependency2KHR>(x.DangerousGetHandle());
}
internal class VkSubpassDependency2KHRExterns
{
}

public struct VkSubpassDependency2KHR
{
}
