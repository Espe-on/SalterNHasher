namespace SalterNHasher.Services
{
    public interface IHasherNSalterServices
    {
        byte[] GenerateRandomPassword(int length);
        byte[] GenerateSalt(int saltLengthLimit);

        string ByteArrayToString(byte[] byteArray);
        
        byte[] HashPassword(
            byte[] password,
            byte[] salt);
        
    }
}