namespace MentorLake.Vulkan;

public class VkInstanceHandle : BaseSafeHandle
{
}


public static class VkInstanceExtensions
{

	public static VkInstance Dereference(this VkInstanceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkInstance>(x.DangerousGetHandle());
}
internal class VkInstanceExterns
{
}

public struct VkInstance
{
}
