using System.Security.Cryptography;
using System.Text;


namespace SalterNHasher.Services
{
    public class HasherNSalterServices : IHasherNSalterServices
    {
        public byte[] GenerateRandomPassword(int length)
        {
            string allowedCharacters =
                "!£$%^&*(){}[]@'#~¬`?+-/|ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            char[] chars = allowedCharacters.ToCharArray();
            var crypto = System.Security.Cryptography.RandomNumberGenerator.Create();
            byte[] data = new byte[length];
            crypto.GetBytes(data);
            return data;
        }

        public byte[] GenerateSalt(int saltLengthLimit)
        {
            var salt = new byte[saltLengthLimit];
            using (var random = new RNGCryptoServiceProvider())
            {
               random.GetNonZeroBytes(salt); 
            }

            return salt;
        }

        public string ByteArrayToString(byte[] byteArray)
        {
            string byteString = "";
            foreach (var thisByte in byteArray)
            {
                byteString = $"{byteString}{thisByte}";
            }
            return byteString;
        }

        public byte[] HashPassword(byte[] password, byte[] salt)
        {
            return password;
        }
    }
}