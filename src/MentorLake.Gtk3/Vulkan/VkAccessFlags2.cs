namespace MentorLake.Vulkan;

public class VkAccessFlags2Handle : BaseSafeHandle
{
}


public static class VkAccessFlags2Extensions
{

	public static VkAccessFlags2 Dereference(this VkAccessFlags2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccessFlags2>(x.DangerousGetHandle());
}
internal class VkAccessFlags2Externs
{
}

public struct VkAccessFlags2
{
}
