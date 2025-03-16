namespace MentorLake.Vulkan;

public class VkCooperativeMatrixPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkCooperativeMatrixPropertiesKHRExtensions
{

	public static VkCooperativeMatrixPropertiesKHR Dereference(this VkCooperativeMatrixPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCooperativeMatrixPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkCooperativeMatrixPropertiesKHRExterns
{
}

public struct VkCooperativeMatrixPropertiesKHR
{
}
